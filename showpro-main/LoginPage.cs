using MetroFramework.Forms;
using showpro_administrador;
using showpro_organizador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace showpro_main
{
    public partial class LoginPage : MetroForm
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testado");
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MainAdmin form = new MainAdmin();
            form.Show();
            this.Hide();
        }
    }
}
