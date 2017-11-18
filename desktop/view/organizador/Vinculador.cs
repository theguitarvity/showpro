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
    public partial class Vinculador : MetroForm
    {
        private Evento evento;
        private EventoDAO eventoDAO = new EventoDAO();
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

        private void Vinculador_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            NovoEvento novo = new NovoEvento(evento.codEvento);
            novo.Show();
        }
    }
}
