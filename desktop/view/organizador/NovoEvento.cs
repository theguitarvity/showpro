using Correios.Net;
using desktop.model;
using desktop.model.dao;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop.view.organizador
{
    public partial class NovoEvento : MetroForm
    {
        private EventoDAO eventoDao = new EventoDAO();
        private LocalDAO localDao = new LocalDAO();
        private EnderecoDAO enderecoDao = new EnderecoDAO();
        long codEvento;
        long codLocal;
        long codEndereco;
        string acao = null;
        TipoEvento tipo;
        Local local;
        private Evento eventoUpdate;

        private Evento getFormEvento()
        {
            Random id = new Random();
            codEvento = id.Next(1111111, 9999999);
            tipo = tipoDAO.retornaCod(cmbTipo.SelectedItem.ToString());
            DateTime data = dtpData.Value;
            DateTime hora = dtpHora.Value;
            Evento evento = new Evento();
            evento.codEvento = codEvento;
            evento.nomeEvento = txtNome.Text;
            evento.dtEvento = data;
            evento.horaEvento = hora;
            evento.detalhesEvento = rtxtDetalhes.Text;
            evento.tipoEvento = tipo;
            evento.localEvento = getFormLocal();
            return evento;


            

        }
        private Local getFormLocal()
        {
            Random cod = new Random();
            codLocal = cod.Next(1111111,9999999);
            Local local = new Local();
            local.codLocal = codLocal;
            local.nomeLocal = txtNomeLocal.Text;
            local.enderecoLocal = getFormEndereco();
            return local;
        }
        private Endereco getFormEndereco()
        {
            Random cod = new Random();
            codEndereco = cod.Next(1111111,9999999);
            Endereco endereco = new Endereco();
            endereco.codEndereco = codEndereco;
            endereco.logradoureEndereco = txtRua.Text;
            endereco.numeroEndereco = Convert.ToInt32(nupNu.Value);
            endereco.bairroEndereco = txtBairro.Text;
            endereco.cidadeEndereco = txtCidade.Text;
            endereco.estadoEndereco = cmbEstado.SelectedItem.ToString();
            endereco.cepEndereco = mxtCep.Text;
            return endereco;
        }

        public NovoEvento()
        {
            InitializeComponent();
            acao = "insert";
        }
        public NovoEvento(long cod)
        {
            InitializeComponent();
            this.eventoUpdate = eventoDao.buscarPorID(cod);
            AtivarUpdate(eventoUpdate);
            acao = "update";

        }

        private void AtivarUpdate(Evento eventoUpdate)
        {
            this.txtNome.Text = eventoUpdate.nomeEvento;


        }

        private TipoEventoDAO tipoDAO = new TipoEventoDAO();
        

        private void NovoEvento_Load(object sender, EventArgs e)
        {

            foreach (TipoEvento tipo in tipoDAO.listar())
            {
                cmbTipo.Items.Add(tipo.nomeTipo);
            }
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void tileAddTipo_Click(object sender, EventArgs e)
        {
            NovoTipo novoTipo = new NovoTipo();
            novoTipo.Show();
        }

        private void tilePesquisar_Click(object sender, EventArgs e)
        {
            ConsultaLocal clocal = new ConsultaLocal();
            clocal.Show();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(tipoDAO.retornaCod(cmbTipo.SelectedItem.ToString())));
            //MessageBox.Show(mxtCep.Text.Replace("-", ""));
            try
            {
                enderecoDao.inserir(getFormEndereco());
                localDao.inserir(getFormLocal());
                eventoDao.inserir(getFormEvento());
                MessageBox.Show("Evento cadastrado!");

            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void txtRua_Click(object sender, EventArgs e)
        {
           
        }
        /*private void localizaCep() 
        {
            if (!string.IsNullOrWhiteSpace(mxtCep.Text))
            {
               
                if (endereco.Zip != null)
                {
                    txtRua.Text = endereco.Street;
                    txtBairro.Text = endereco.District;
                    txtCidade.Text = endereco.City;
                }
                else
                {
                    MessageBox.Show("Cep não localizado");
                }
            }
            else
            {
                MessageBox.Show("Informe um cep válido");
            }
        }*/

        private void mxtCep_Leave(object sender, EventArgs e)
        {
            //localizaCep();
        }
    }
}
