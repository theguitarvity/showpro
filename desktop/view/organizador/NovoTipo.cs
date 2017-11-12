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

namespace desktop.view.organizador
{
    public partial class NovoTipo : Form
    {
        private TipoEventoDAO dao = new TipoEventoDAO();
        long id;
        private TipoEvento getForm()
        {
            Random random = new Random();
            id = random.Next(1111, 9999);
            TipoEvento tipo = new TipoEvento(id, txtNome.Text);
            return tipo;
        }

        public NovoTipo()
        {
            InitializeComponent();
        }

        private void NovoTipo_Load(object sender, EventArgs e)
        {

        }

        private void tileCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoEvento tipo = getForm();
                dao.inserir(tipo);
                MessageBox.Show("Tipo de evento cadastrado");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
