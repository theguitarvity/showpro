using MetroFramework.Forms;
using showpro.model;
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
    public partial class CRUDUsers : MetroForm
    {
        public CRUDUsers()
        {
            InitializeComponent();
        }

        private void CRUDUsers_Load(object sender, EventArgs e)
        {
            List<Funcionario> lista = new List<Funcionario>();
            listBox1.Items.Add("Victor Lucas Lopes - 44465895801");
        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
