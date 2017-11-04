using desktop.view.admin;
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
            MainAdmin admin = new MainAdmin();
            admin.Show();
            this.Hide();
        }

        private void LoginPage_Load_1(object sender, EventArgs e)
        {

        }
    }
}
