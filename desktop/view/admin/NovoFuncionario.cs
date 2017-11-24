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
        private CrudUsuarios baseForm;

        private Funcionario getForm() {
            Random random = new Random();
            id = random.Next(9999, 99999);
            String conf = null;
            if (pwdConfSenha.Text == pwdSenha.Text)
                conf = pwdSenha.Text;
            Funcionario fun = new Funcionario(id,txtEmail.Text, conf, txtNome.Text, txtCpf.Text, dtpNasc.Value, System.DateTime.Now, txtCargo.Text  );
            return fun;

        }
        private Administrador getFormAdm()
        {
            Random random = new Random();
            id = random.Next(9999, 99999);
            String conf = null;
            if (pwdConfSenha.Text == pwdSenha.Text)
                conf = pwdSenha.Text;
            Administrador adm = new Administrador(id, txtEmail.Text, conf, txtNome.Text, txtCpf.Text, dtpNasc.Value, System.DateTime.Now, txtCargo.Text, "Administrativo");
            return adm;

        }
        private Organizador getFormOrga()
        {
            Random random = new Random();
            id = random.Next(9999, 99999);
            String conf = null;
            if (pwdConfSenha.Text == pwdSenha.Text)
                conf = pwdSenha.Text;
            Organizador orga = new Organizador(id, txtEmail.Text, conf, txtNome.Text, txtCpf.Text, dtpNasc.Value, System.DateTime.Now, txtCargo.Text, "Organização");

            return orga;

        }


        public NovoFuncionario(CrudUsuarios baseForm)
        {
            InitializeComponent();
            this.baseForm = baseForm;
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
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbBilheteria.Checked)
                {
                    Funcionario fun = getForm();
                    dao.inserir(fun);
                    MessageBox.Show("Funcionario cadastrado!");
                    baseForm.atualizaGrid();
                }
                else if (rdbAdm.Checked)
                {
                    Administrador fun = getFormAdm();
                    dao.inserir(fun);
                    MessageBox.Show("Administrador cadastrado!");
                    baseForm.atualizaGrid();
                }
                else if (rdbOrg.Checked)
                {
                    Organizador fun = getFormOrga();
                    dao.inserir(fun);
                    MessageBox.Show("Organizador cadastrado!");
                    baseForm.atualizaGrid();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
