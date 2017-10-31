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
    public partial class CrudUsuarios : MetroForm
    {
        public CrudUsuarios()
        {
            InitializeComponent();
        }

        private void CrudUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void tileNewFuncionario_Click(object sender, EventArgs e)
        {
            NovoFuncionario novo = new NovoFuncionario();
            novo.ShowDialog();
        }
    }
}
