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

namespace desktop.view.portaria
{
    public partial class PortariaMain : MetroForm
    {
        private EventoDAO eventoDAO = new EventoDAO();
        private IngressoDAO ingressoDAO = new IngressoDAO();
        public PortariaMain()
        {
            InitializeComponent();
        }

        private void PortariaMain_Load(object sender, EventArgs e)
        {
            foreach (Evento evento in eventoDAO.listar())
            {
                cmbEventos.Items.Add(evento.codEvento + " - " + evento.nomeEvento);
            }
        }
        public long retornaCodEvento()
        {
            return Convert.ToInt64(cmbEventos.SelectedItem.ToString().Substring(0,7));
        }

        private void txtCodigoBarras_Leave(object sender, EventArgs e)
        {
            if(ingressoDAO.validar(eventoDAO.buscarPorID(retornaCodEvento()), txtCodigoBarras.Text))
            {
                lblResultado.Text = "Liberado";
                lblResultado.ForeColor = Color.Green;
            }
            else
            {
                lblResultado.Text = "Rejeitado";
                lblResultado.ForeColor = Color.Red;
            }
        }
    }
}
