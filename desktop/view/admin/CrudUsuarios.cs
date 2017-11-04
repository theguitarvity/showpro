using desktop.model;
using desktop.model.dao;
using desktop.Properties;
using MetroFramework.Controls;
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
        private FuncionarioDAO daoFun= new FuncionarioDAO();
        public CrudUsuarios()
        {
            InitializeComponent();
        }

        private void CrudUsuarios_Load(object sender, EventArgs e)
        {

            atualizaGrid();
            if (toggleEdit.Checked == true)
            {
                desabilitarBotoes();
            }
        }
        private void setForm(Funcionario fun)
        {
            txtNome.Text = fun.nomeFuncionario;
            txtCpf.Text = fun.cpfFuncionario;
            txtEmail.Text = fun.emailUsuario;
        }
        public void atualizaGrid()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CrudUsuarios));
            //dgvFuncionarios.DataSource = daoFun.listar();
            foreach (var item in daoFun.listar())
            {
                MetroPanel panel = new MetroPanel();
                PictureBox pct = new PictureBox();
                MetroLabel matricula = new MetroLabel();

                MetroLabel nome = new MetroLabel();

                //adicionar picture box

                pct.Dock = System.Windows.Forms.DockStyle.Left;
                pct.Image = ((Image)(resources.GetObject("pct.Image")));
                pct.Location = new System.Drawing.Point(0, 0);
                pct.Name = "pct"+item.codUsuario;
                pct.Size = new System.Drawing.Size(55, 47);
                pct.TabIndex = 2;
                pct.TabStop = false;


                //adicionar label do nome

                nome.AutoSize = true;
                nome.Location = new System.Drawing.Point(62, 4);
                nome.Name = "nome"+item.codUsuario;
                nome.Size = new System.Drawing.Size(53, 19);
                nome.TabIndex = 3;
                nome.Text = "Nome: " + item.nomeFuncionario;


                //adicionar label da matricula

                matricula.AutoSize = true;
                matricula.Location = new System.Drawing.Point(61, 23);
                matricula.Name = "matricula"+item.codUsuario;
                matricula.Size = new System.Drawing.Size(66, 19);
                matricula.TabIndex = 4;
                matricula.Text = "Matricula: "+ item.codUsuario;


                //adicionar panel que agrupa todos os itens acima
                panel.Controls.Add(matricula);
                panel.Controls.Add(nome);
                panel.Controls.Add(pct);
                panel.Dock = System.Windows.Forms.DockStyle.Top;
                panel.HorizontalScrollbarBarColor = true;
                panel.HorizontalScrollbarHighlightOnWheel = false;
                panel.HorizontalScrollbarSize = 10;
                panel.Location = new System.Drawing.Point(0, 0);
                panel.Name = "panel"+item.codUsuario;
                panel.Size = new System.Drawing.Size(256, 47);
                panel.TabIndex = 2;
                panel.VerticalScrollbarBarColor = true;
                panel.VerticalScrollbarHighlightOnWheel = false;
                panel.VerticalScrollbarSize = 10;
                
                this.panelLista.Controls.Add(panel);

            }

            


        }
        private void tileNewFuncionario_Click(object sender, EventArgs e)
        {
            NovoFuncionario novo = new NovoFuncionario(this);
            novo.ShowDialog();

        }
        private void panel_Click(object sender, EventArgs e)
        {
            setForm((Funcionario) sender);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {
            
            
        }
        private void habilitarBotoes()
        {
            this.btnAtualizar.Enabled = true;
            this.btnBloquear.Enabled = true;
            this.btnDeletar.Enabled = true;
        }
        private void desabilitarBotoes()
        {
            this.btnAtualizar.Enabled = false;
            this.btnBloquear.Enabled = false;
            this.btnDeletar.Enabled = false;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
