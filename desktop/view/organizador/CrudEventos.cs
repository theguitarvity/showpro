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
    public partial class CrudEventos : MetroForm
    {
        public CrudEventos()
        {
            InitializeComponent();
        }

        private void CrudEventos_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            NovoEvento novo = new NovoEvento();
            novo.Show();
        }
    }
}
