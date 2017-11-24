using desktop.model;
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
    public partial class FinalizarVenda : MetroForm
    {
        private Pedido ped;
        private Evento ev;
        private Lote lot;
        public FinalizarVenda(Pedido pedido, Evento evento, Lote lote)
        {
            InitializeComponent();
            this.ped = pedido;
            this.ev = evento;
            this.lot = lote;
        }

        private void FinalizarVenda_Load(object sender, EventArgs e)
        {
            eventoNome.Text = ev.nomeEvento;
            clienteNome.Text +=" "+ ped.cliente.nomeCliente;
            lote.Text += " "+lot.numeroLote.ToString();
            total.Text += " R$"+ped.totalPedido.ToString();

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedItem.ToString().Substring(0, 3) == "001")
            {
                ativarPagamentoDinheiro(true);
            }
            else
                ativarPagamentoDinheiro(false);
        }

        private void ativarPagamentoDinheiro(bool v)
        {
            if (v==false)
            {
                txtTroco.Enabled = false;
                groupDinheiro.Enabled = false;
            }
            else
            {
                txtTroco.Enabled = true;
                groupDinheiro.Enabled = true;
            }

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTroco_Leave(object sender, EventArgs e)
        {
            decimal troco = Convert.ToDecimal(txtTroco.Text) - ped.totalPedido;
            lblTroco.Text += " " + troco + " R$";
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (txtTroco.Text == null)
            {
                MessageBox.Show("Valor em branco!");
            }
            else
            {
                MessageBox.Show("Venda finalizada com sucesso!");
                this.Close();
            }
        }
    }
}
