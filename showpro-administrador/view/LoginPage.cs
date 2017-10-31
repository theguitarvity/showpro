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

namespace showpro.view
{
    public partial class LoginPage : MetroForm
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (this.txtEmail.Text == "admin" && this.pwdSenha.Text == "admin") {
                MainAdmin main = new MainAdmin();
                main.Show();
                this.Hide();
            }

        }
    }
}
