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

namespace desktop.view.admin
{
    public partial class Monitoramento : MetroForm
    {
        private EventoDAO eventoDAO = new EventoDAO();
        private FuncionarioDAO funDAO = new FuncionarioDAO();
        public Monitoramento()
        {
            InitializeComponent();
        }

        private void Monitoramento_Load(object sender, EventArgs e)
        {
            metroLabel1.Text += " "+eventoDAO.listar().Count+" eventos cadastrados";
            metroLabel2.Text += " " + funDAO.listar().Count + " funcionários cadastrados";
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
