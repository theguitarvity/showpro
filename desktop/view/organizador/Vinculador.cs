using desktop.model;
using desktop.model.dao;
using MetroFramework.Controls;
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
    public partial class Vinculador : MetroForm
    {
        private Evento evento;
        
        private EventoDAO eventoDAO = new EventoDAO();
        private LoteDAO loteDao = new LoteDAO();
        long codLote;

        private Lote getFormLote()
        {
            Random random = new Random();
            Lote lote = new Lote();
            codLote = random.Next(1111111,9999999);
            lote.codLote = codLote;
            lote.numeroLote = Convert.ToInt32(nmLote.Value);
            lote.valor = Convert.ToDecimal(mxtPreco.Text.Replace(",", "."));
            lote.maximo = Convert.ToInt32(nmMax.Value);
            lote.evento = evento;
            return lote;
        }
        public Vinculador(long Codevento)
        {
            InitializeComponent();
            evento = eventoDAO.buscarPorID(Codevento);
            this.Text = evento.nomeEvento;
            this.lblCod.Text =this.lblCod.Text+" "+ evento.codEvento;
            this.lblNome.Text = this.lblNome.Text + "" + evento.nomeEvento;
            this.lblData.Text = this.lblData.Text + " " + evento.dtEvento.Date.ToString("dd/mm/yyyy");
            this.rtxtDetalhes.Text = evento.detalhesEvento; 
            
        }
        private void construirCardAtracao(Atracao atracao, int index, int init)
        {

            this.tileEvento = new MetroFramework.Controls.MetroTile();
            this.tileEvento.Location = new System.Drawing.Point(init, 4);
            this.tileEvento.Name = Convert.ToString(evento.codEvento);
            this.tileEvento.Size = new System.Drawing.Size(126, 152);
            this.tileEvento.TabIndex = 0;
            this.tileEvento.Text = atracao.nomeAtracao;
            //this.tileEvento.Dock = DockStyle.Left;
            this.tileEvento.Margin = new Padding(10);
            this.tileEvento.TabIndex = index;
            this.tileEvento.Click += new System.EventHandler(this.tile_Click);
        }
        private void listarEventos()
        {
            this.panelAtracoes.Controls.Clear();
            int init = 9, index = 0;
            this.panelEventos = new Panel();
            this.panelEventos.Dock = DockStyle.Top;
            this.panelEventos.Name = "panelEventos";
            this.panelEventos.Height = 152;
            this.panelAtracoes.Controls.Add(panelEventos);
            //this.panelEventos.TabIndex = 2;
            //this.pageEventos.Controls.Add(panelEventos);

            foreach (Atracao atracao in eventoDAO.listarAtracoes(evento.codEvento))
            {

                if (index % 4 != 0)
                {
                    construirCardAtracao(atracao, index, init);
                    this.panelEventos.Controls.Add(this.tileEvento);
                }
                else
                {
                    init = 9;
                    construirCardAtracao(atracao, index, init);
                    this.panelEventos = new Panel();
                    this.panelEventos.Dock = DockStyle.Top;

                    this.panelEventos.Name = "panelEventos" + index;
                    this.panelEventos.Size = new System.Drawing.Size(this.panelAtracoes.Width, 159);
                    //this.panelEventos.TabIndex = 2;
                    this.panelEventos.Controls.Add(tileEvento);
                    this.panelAtracoes.Controls.Add(panelEventos);

                }

                index++;
                init += 132;

            }
        }
        private void tile_Click(object sender, EventArgs e)
        {
            long codEvento = ObterCodigoAtracao(sender);

            Vinculador vinc = new Vinculador(codEvento);
            vinc.Show();
        }

        private long ObterCodigoAtracao(object sender)
        {
            long cod = 0;
            MetroTile tile;
            if (sender is MetroTile)
            {
                tile = (MetroTile)sender;
                cod = long.Parse(tile.Name);

            }
            return cod;
        }
        private void Vinculador_Load(object sender, EventArgs e)
        {
            listarEventos();
            AtualizaGridLotes();
        }

        private void AtualizaGridLotes()
        {
            dataGridView1.DataSource = loteDao.listarPorEvento(evento);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Nº do Lote";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Maximo de ingressos";
            dataGridView1.Columns[4].Visible = false;

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            NovoEvento novo = new NovoEvento(evento.codEvento);
            novo.Show();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tileNova_Click(object sender, EventArgs e)
        {
            NovaAtracao nova = new NovaAtracao(evento.codEvento);
            nova.Show();
        }

        private void tileFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tileSalvar_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                Lote lote = getFormLote();
                loteDao.inserir(lote);
                MessageBox.Show("Lote adicionado!");
                AtualizaGridLotes();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
