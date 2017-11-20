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
    public partial class BilheteriaMain : MetroForm
    {
        private CaixaDAO caixaDAO = new CaixaDAO();
        public BilheteriaMain()
        {
            InitializeComponent();
        }

        private void BilheteriaMain_Load(object sender, EventArgs e)
        {
           // verificarCaixa();
        }
        public void verificarCaixa()
        {
            if (caixaDAO.verificarCaixaDiario() == false)
            {
                tileVenda.Enabled = false;
            }
            else
                tileVenda.Enabled = true;
        }

        private void caixarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoCaixa caixa = new NovoCaixa(this);
            caixa.Show();
        }

        private void tileVenda_Click(object sender, EventArgs e)
        {
            CrudVendas crud = new CrudVendas();
            crud.Show();
        }
    }
}
