namespace desktop.view.admin
{
    partial class NovoFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCargo = new MetroFramework.Controls.MetroTextBox();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtCpf = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbBilheteria = new MetroFramework.Controls.MetroRadioButton();
            this.rdbOrg = new MetroFramework.Controls.MetroRadioButton();
            this.rdbAdm = new MetroFramework.Controls.MetroRadioButton();
            this.pwdConfSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.pwdSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtCargo);
            this.groupBox1.Controls.Add(this.dtpNasc);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Pessoais";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(187, 69);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(187, 91);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(152, 23);
            this.txtCargo.TabIndex = 5;
            this.txtCargo.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // dtpNasc
            // 
            this.dtpNasc.CustomFormat = "dd/mm/yyy";
            this.dtpNasc.Location = new System.Drawing.Point(187, 43);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(209, 20);
            this.dtpNasc.TabIndex = 7;
            this.dtpNasc.Value = new System.DateTime(2017, 11, 30, 0, 0, 0, 0);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(187, 20);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(125, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Data de nascimento";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(7, 91);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(152, 23);
            this.txtCpf.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(152, 23);
            this.txtNome.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.pwdConfSenha);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.pwdSenha);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(20, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações de acesso ao sistema";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbBilheteria);
            this.groupBox3.Controls.Add(this.rdbOrg);
            this.groupBox3.Controls.Add(this.rdbAdm);
            this.groupBox3.Location = new System.Drawing.Point(190, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 89);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo";
            // 
            // rdbBilheteria
            // 
            this.rdbBilheteria.AutoSize = true;
            this.rdbBilheteria.Location = new System.Drawing.Point(6, 44);
            this.rdbBilheteria.Name = "rdbBilheteria";
            this.rdbBilheteria.Size = new System.Drawing.Size(72, 15);
            this.rdbBilheteria.TabIndex = 8;
            this.rdbBilheteria.TabStop = true;
            this.rdbBilheteria.Text = "Bilheteria";
            this.rdbBilheteria.UseVisualStyleBackColor = true;
            // 
            // rdbOrg
            // 
            this.rdbOrg.AutoSize = true;
            this.rdbOrg.Location = new System.Drawing.Point(107, 18);
            this.rdbOrg.Name = "rdbOrg";
            this.rdbOrg.Size = new System.Drawing.Size(88, 15);
            this.rdbOrg.TabIndex = 1;
            this.rdbOrg.TabStop = true;
            this.rdbOrg.Text = "Organizador";
            this.rdbOrg.UseVisualStyleBackColor = true;
            // 
            // rdbAdm
            // 
            this.rdbAdm.AutoSize = true;
            this.rdbAdm.Location = new System.Drawing.Point(7, 18);
            this.rdbAdm.Name = "rdbAdm";
            this.rdbAdm.Size = new System.Drawing.Size(99, 15);
            this.rdbAdm.TabIndex = 0;
            this.rdbAdm.TabStop = true;
            this.rdbAdm.Text = "Administrador";
            this.rdbAdm.UseVisualStyleBackColor = true;
            // 
            // pwdConfSenha
            // 
            this.pwdConfSenha.Location = new System.Drawing.Point(9, 134);
            this.pwdConfSenha.Name = "pwdConfSenha";
            this.pwdConfSenha.PasswordChar = '●';
            this.pwdConfSenha.Size = new System.Drawing.Size(152, 23);
            this.pwdConfSenha.TabIndex = 6;
            this.pwdConfSenha.UseSystemPasswordChar = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 112);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(112, 19);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Confirme a senha";
            // 
            // pwdSenha
            // 
            this.pwdSenha.Location = new System.Drawing.Point(6, 86);
            this.pwdSenha.Name = "pwdSenha";
            this.pwdSenha.PasswordChar = '●';
            this.pwdSenha.Size = new System.Drawing.Size(152, 23);
            this.pwdSenha.TabIndex = 4;
            this.pwdSenha.UseSystemPasswordChar = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(7, 64);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(44, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(7, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(7, 16);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "E-mail";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.metroTile1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 62);
            this.panel1.TabIndex = 2;
            // 
            // metroTile1
            // 
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(121, 62);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Confirmar";
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NovoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NovoFuncionario";
            this.Text = "Novo Funcionario";
            this.Load += new System.EventHandler(this.NovoFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtCpf;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCargo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroRadioButton rdbBilheteria;
        private MetroFramework.Controls.MetroRadioButton rdbOrg;
        private MetroFramework.Controls.MetroRadioButton rdbAdm;
        private MetroFramework.Controls.MetroTextBox pwdConfSenha;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox pwdSenha;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Button button1;
    }
}