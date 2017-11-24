using desktop.model;
using desktop.model.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop.view.bilheteria
{
    public partial class NovaVenda : Form
    {
        private EventoDAO eventoDAO = new EventoDAO();
        private Cliente cliente;
        private IngressoDAO ingressoDAO = new IngressoDAO();
        private LoteDAO loteDao = new LoteDAO();
        private List<Ingresso> ingressosASeremVendidos = new List<Ingresso>();
        private ClienteDAO clienteDao = new ClienteDAO();
        private PedidoDAO pedidoDao = new PedidoDAO();
        private Pedido_Ingresso pedido_ingressoDAO = new Pedido_Ingresso();
        
        private int qtdIngressos = 0;
        public NovaVenda()
        {
            InitializeComponent();
        }
        public void atribuirCliente(Cliente cliente)
        {
            this.cliente = cliente;

        }
        private void NovaVenda_Load(object sender, EventArgs e)
        {
            foreach (Evento evento in eventoDAO.listar() )
            {
                cmbEventos.Items.Add(evento.codEvento +" - "+evento.nomeEvento);
            }
            cmbIngresso.Items.Clear();
            try
            {

                foreach (Lote lote in loteDao.listarPorEvento(eventoDAO.buscarPorID(retornaCodEvento())))
                {
                    cmbIngresso.Items.Add(lote.numeroLote + "º lote" + " - R$ " + lote.valor);
                }
            }
            catch (Exception erro)
            {
                cmbIngresso.Items.Add(" Evento sem ingressos disponiveis no momento!");
            }
            txtQtd.Text = qtdIngressos.ToString();
            
        }
        private long retornaCodEvento()
        {
            long cod;
            cod = long.Parse(cmbEventos.SelectedItem.ToString().Substring(0,7));
            return cod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(retornaCodEvento().ToString());
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            qtdIngressos += 1;
            txtQtd.Text = qtdIngressos.ToString();
            down.Enabled = true;

            Ingresso ingresso = criarIngresso();
            ingressosASeremVendidos.Add(ingresso);
            
        }

        private Ingresso criarIngresso()
        {
            Ingresso ingresso = new Ingresso();
            Random random = new Random();
            Lote codLote = loteDao.listarPorEvento(eventoDAO.buscarPorID(retornaCodEvento())).Find(x=>x.codLote==Convert.ToInt64(cmbIngresso.SelectedItem.ToString().Substring(0,7)));
            long cod = random.Next(1111111,9999999);
            ingresso.codIngresso = cod;
            ingresso.evento = eventoDAO.buscarPorID(retornaCodEvento());
            ingresso.lote = codLote;
            ingresso.gerarCodigoBarras();
            return ingresso;

        }
        public Pedido criarPedido(Cliente cli)
        {
            Random random = new Random();
            Pedido pedido = new Pedido();
            pedido.codPedido = random.Next(1111111,9999999);
            pedido.cliente = cli;
            pedido.totalPedido = calcularValorTotal(ingressosASeremVendidos);
            return pedido;
        }
        private decimal calcularValorTotal(List<Ingresso> ingresso)
        {
            decimal total = 0.0m;
            foreach (Ingresso ing in ingressosASeremVendidos)
            {
                total += loteDao.listarPorEvento(eventoDAO.buscarPorID(retornaCodEvento())).Find(x => x.codLote == Convert.ToInt64(cmbIngresso.SelectedItem.ToString().Substring(0,7))).valor;
            }
            return total;
        }

        private void down_Click(object sender, EventArgs e)
        {
            if (qtdIngressos != 0)
                qtdIngressos -= 1;
            else
                down.Enabled = false;
            txtQtd.Text = qtdIngressos.ToString();
        }
        public void setarCpf(Cliente cli)
        {
            this.txtCpf.Text = cli.cpfCliente;
        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
            NovoCliente novo = new NovoCliente(this);
            novo.Show();
        }

        private void cmbEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIngresso.Items.Clear();
            try
            {
                foreach (Lote lote in loteDao.listarPorEvento(eventoDAO.buscarPorID(retornaCodEvento())))
                {
                    cmbIngresso.Items.Add(lote.codLote+" - " +lote.numeroLote + "º lote" + " - R$ " + lote.valor);
                }
            }
            catch (Exception erro)
            {
                cmbIngresso.Items.Add(" - ");
            }
            txtQtd.Text = qtdIngressos.ToString();
        }

        private void tileRealizarVenda_Click(object sender, EventArgs e)
        {
            cliente = clienteDao.buscarPorCpf(txtCpf.Text);
            Pedido pedido = criarPedido(cliente);
            try
            {
                pedidoDao.inserir(pedido);
                //ingressoDAO.inserir(ingressosASeremVendidos);
                pedido_ingressoDAO.realizarVenda(ingressosASeremVendidos,pedido);
                FinalizarVenda finalizar = new FinalizarVenda(pedido, eventoDAO.buscarPorID(retornaCodEvento()), loteDao.listarPorEvento(eventoDAO.buscarPorID(retornaCodEvento())).Find(x=>x.codLote == Convert.ToInt64(cmbIngresso.SelectedItem.ToString().Substring(0,7))));
                finalizar.Show();
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message+erro.Source);
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = clienteDao.buscarPorCpf(txtCpf.Text);
                txtNome.Text = cliente.nomeCliente;
                
            }
            catch (Exception erro)
            {
                NovoCliente cli = new NovoCliente(this);
                cli.Show();
            }
        }
    }
}
