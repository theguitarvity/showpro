using desktop.model.dao;
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

namespace desktop.view.bilheteria
{
    public partial class CrudVendas : MetroForm
    {
        private PedidoDAO dao = new PedidoDAO();
        public CrudVendas()
        {
            InitializeComponent();
        }

        private void tileNova_Click(object sender, EventArgs e)
        {
            NovaVenda nova = new NovaVenda();
            nova.Show();
        }

        private void CrudVendas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.listar();
            dataGridView1.Columns[0].HeaderText = "Cod";
            dataGridView1.Columns[2].HeaderText = "Total";
            dataGridView1.Columns[1].Visible = false;
        }
    }
}
