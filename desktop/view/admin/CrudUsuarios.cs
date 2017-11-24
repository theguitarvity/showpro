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
        private long codAtual;
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
            this.panelLista.Controls.Clear();
            int initTam = 12;
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CrudUsuarios));
            //dgvFuncionarios.DataSource = daoFun.listar();
            foreach (var item in daoFun.listar())
            {
                this.panel = new MetroPanel();
                this.pct = new PictureBox();
                this.labelMatricula = new MetroLabel();

                this.labelNome= new MetroLabel();

                //adicionar picture box

                pct.Dock = System.Windows.Forms.DockStyle.Left;
                pct.Image = ((Image)(resources.GetObject("pct.Image")));
                pct.Location = new System.Drawing.Point(0, 0);
                pct.Name = "pct"+item.codUsuario;
                pct.Size = new System.Drawing.Size(55, 47);
                pct.TabIndex = 2;
                pct.TabStop = false;


                //adicionar label do nome

                labelNome.AutoSize = true;
                labelNome.Location = new System.Drawing.Point(62, 4);
                labelNome.Name = "nome"+item.codUsuario;
                labelNome.Size = new System.Drawing.Size(53, 19);
                labelNome.TabIndex = 3;
                labelNome.Text = "Nome: " + item.nomeFuncionario;


                //adicionar label da matricula

                this.labelMatricula.AutoSize = true;
                this.labelMatricula.Location = new System.Drawing.Point(61, 23);
                this.labelMatricula.Name = "matricula"+item.codUsuario;
                this.labelMatricula.Size = new System.Drawing.Size(66, 19);
                this.labelMatricula.TabIndex = 4;
                this.labelMatricula.Text = "Matricula: "+ item.codUsuario;


                //adicionar panel que agrupa todos os itens acima
                panel.Controls.Add(this.labelMatricula);
                panel.Controls.Add(this.labelNome);
                panel.Controls.Add(pct);
                //panel.Dock = System.Windows.Forms.DockStyle.Top;
                panel.HorizontalScrollbarBarColor = true;
                panel.HorizontalScrollbarHighlightOnWheel = false;
                panel.HorizontalScrollbarSize = 10;
                panel.Location = new System.Drawing.Point(12, initTam);
                panel.Name = item.codUsuario.ToString();
                panel.Size = new System.Drawing.Size(256, 47);
                panel.TabIndex = 2;
                panel.VerticalScrollbarBarColor = true;
                panel.VerticalScrollbarHighlightOnWheel = false;
                panel.VerticalScrollbarSize = 10;
                panel.Click += new  System.EventHandler(this.Evento_Click);
                //panel.Margin = new Padding(10, 10, 10, 100);
                
                this.panelLista.Controls.Add(panel);
                initTam += 41;

            }

            


        }
        private void Evento_Click(object sender, EventArgs e)
        {
            long cod = obterCodigoUsuario(sender);
            Funcionario fun = daoFun.listar().Find(x=>x.codUsuario==cod);
            txtNome.Text = fun.nomeFuncionario;
            txtCpf.Text = fun.cpfFuncionario;
            txtEmail.Text = fun.emailUsuario;
            this.codAtual = fun.codUsuario;
            
        }

        private long obterCodigoUsuario(object sender)
        {
            long cod = 0;
            Panel panel;
            if (sender is Panel)
            {
                panel = (Panel)sender;
                cod = Convert.ToInt64(panel.Name);
            }
            return cod;
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

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }
    }
}
