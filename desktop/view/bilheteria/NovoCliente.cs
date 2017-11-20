using desktop.model;
using desktop.model.dao;
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
    public partial class NovoCliente : Form
    {
        private ClienteDAO dao = new ClienteDAO();
        private NovaVenda novaVenda;
        long cod;

        private Cliente getForm()
        {
            Cliente cliente = new Cliente();
            Random rd = new Random();
            cod = rd.Next(1111111,9999999);
            cliente.codCliente = cod;
            cliente.nomeCliente = txtNome.Text;
            cliente.emailCliente = txtEmail.Text;
            cliente.cpfCliente = mxtCpf.Text.Replace(".", "").Replace("-","");
            cliente.dataNascCliente = Convert.ToDateTime(mxtData.Text);
            return cliente;
        }
        public NovoCliente(NovaVenda venda)
        {
            InitializeComponent();
            novaVenda = venda;
        }

        private void tileCancelar_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void mxtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void NovoCliente_Load(object sender, EventArgs e)
        {

        }

        private void tileCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = getForm();
                dao.inserir(cli);
                MessageBox.Show("Cliente cadastrado com sucesso!");
                novaVenda.atribuirCliente(cli);
                novaVenda.setarCpf(cli);

                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
