using desktop.model;
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

namespace desktop.view.admin
{
    public partial class NovoFuncionario : MetroForm
    {
        private FuncionarioDAO dao = new  FuncionarioDAO();
        long id;

        private Funcionario getForm() {
            Random random = new Random();
            id = random.Next(4);
            String conf = null;
            if (pwdConfSenha.Text == pwdSenha.Text)
                conf = pwdSenha.Text;
            Funcionario fun = new Funcionario(id,txtEmail.Text, conf, txtNome.Text, txtCpf.Text, dtpNasc.Value, System.DateTime.Now, txtCargo.Text  );
            return fun;

        }
        public NovoFuncionario()
        {
            InitializeComponent();
        }

        private void NovoFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario fun = getForm();
                dao.inserir(fun);
                MessageBox.Show("Funcionario cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
