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


namespace showpro_administrador
{
    public partial class MainAdmin : MetroForm
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {
            Funcionario fun = new Funcionario();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e) { 
            CRUDUsers userspage = new CRUDUsers();
            userspage.ShowDialog();

        }
}
}
