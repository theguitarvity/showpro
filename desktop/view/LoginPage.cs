using desktop.view.admin;
using desktop.view.organizador;
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

namespace desktop.view
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
           
            switch (txtEmal.Text)
            {

                case "admin":
                    MainAdmin admin = new MainAdmin();
                    admin.Show();
                    this.Hide();
                    break;
                case "orga":
                    MainOrganizador org = new MainOrganizador();
                    org.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Falha na inicialização");
                    break;

            }

            
            
        }

        private void LoginPage_Load_1(object sender, EventArgs e)
        {

        }

        private void LoginPage_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
        }

        private void btnEntrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (txtEmal.Text)
                {

                    case "admin":
                        MainAdmin admin = new MainAdmin();
                        admin.Show();
                        this.Hide();
                        break;
                    case "orga":
                        MainOrganizador org = new MainOrganizador();
                        org.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Falha na inicialização");
                        break;

                }
            }
        }
    }
}
