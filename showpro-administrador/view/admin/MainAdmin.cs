using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using showpro.model.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace showpro
{
    public partial class MainAdmin : MetroForm
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void tileMonitorar_Click(object sender, EventArgs e)
        {
            try {
                MySqlConnection conn;
                conn = new ConnectionFactory().getConnection();
                MessageBox.Show("Connectado");
                conn.Close();
            }
            catch (NullReferenceException erro) {
                MessageBox.Show(erro.Message, "erro");
            }
        }

        private void metroTile2_Click(object sender, EventArgs e) { 
            CRUDUsers userspage = new CRUDUsers();
            userspage.ShowDialog();

        }
}
}
