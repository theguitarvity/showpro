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
    public partial class CrudEventos : Form
    {
        public CrudEventos()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            NovoEvento novoEvento = new NovoEvento();
            novoEvento.Show();
        }
    }
}
