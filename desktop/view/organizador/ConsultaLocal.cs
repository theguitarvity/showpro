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
    public partial class ConsultaLocal : Form
    {
        public ConsultaLocal()
        {
            InitializeComponent();
        }

        private void ConsultaLocal_Load(object sender, EventArgs e)
        {

        }

        private void tileCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
