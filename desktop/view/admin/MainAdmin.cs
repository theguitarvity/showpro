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
    public partial class MainAdmin : MetroForm
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {

        }

        private void tileUsuarios_Click(object sender, EventArgs e)
        {
            CrudUsuarios crud = new CrudUsuarios();
            crud.ShowDialog();
        }

        private void tileMonitorar_Click(object sender, EventArgs e)
        {
            Monitoramento monit = new Monitoramento();
            monit.ShowDialog();
        }
    }
}
