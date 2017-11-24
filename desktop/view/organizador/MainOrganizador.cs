using desktop.view.portaria;
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
    public partial class MainOrganizador : MetroForm
    {
        public MainOrganizador()
        {
            InitializeComponent();
        }

        private void MainOrganizador_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrudEventos eventos = new CrudEventos();
            eventos.Show();

        }

        private void tileNovoEvento_Click(object sender, EventArgs e)
        {
            CrudEventos crud = new CrudEventos();
            crud.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            PortariaMain port = new PortariaMain();
            port.Show();
            this.Hide(); 
        }
    }
}
