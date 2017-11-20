namespace desktop.view.bilheteria
{
    partial class NovoCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tileCadastrar = new MetroFramework.Controls.MetroTile();
            this.tileCancelar = new MetroFramework.Controls.MetroTile();
            this.tileLimpar = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.mxtData = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mxtData);
            this.groupBox1.Controls.Add(this.mxtCpf);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tileLimpar);
            this.panel1.Controls.Add(this.tileCancelar);
            this.panel1.Controls.Add(this.tileCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 37);
            this.panel1.TabIndex = 1;
            // 
            // tileCadastrar
            // 
            this.tileCadastrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileCadastrar.Location = new System.Drawing.Point(0, 0);
            this.tileCadastrar.Name = "tileCadastrar";
            this.tileCadastrar.Size = new System.Drawing.Size(137, 37);
            this.tileCadastrar.Style = MetroFramework.MetroColorStyle.Green;
            this.tileCadastrar.TabIndex = 0;
            this.tileCadastrar.Text = "Cadastrar";
            this.tileCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCadastrar.Click += new System.EventHandler(this.tileCadastrar_Click);
            // 
            // tileCancelar
            // 
            this.tileCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileCancelar.Location = new System.Drawing.Point(325, 0);
            this.tileCancelar.Name = "tileCancelar";
            this.tileCancelar.Size = new System.Drawing.Size(92, 37);
            this.tileCancelar.Style = MetroFramework.MetroColorStyle.Red;
            this.tileCancelar.TabIndex = 1;
            this.tileCancelar.Text = "Cancelar";
            this.tileCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCancelar.Click += new System.EventHandler(this.tileCancelar_Click);
            // 
            // tileLimpar
            // 
            this.tileLimpar.Location = new System.Drawing.Point(143, 0);
            this.tileLimpar.Name = "tileLimpar";
            this.tileLimpar.Size = new System.Drawing.Size(176, 37);
            this.tileLimpar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tileLimpar.TabIndex = 2;
            this.tileLimpar.Text = "Limpar";
            this.tileLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome do cliente";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 23);
            this.txtNome.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(214, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "CPF do Cliente";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(108, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "E-mail do cliente";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(214, 82);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(129, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Data de nascimento ";
            // 
            // mxtCpf
            // 
            this.mxtCpf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mxtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mxtCpf.Location = new System.Drawing.Point(214, 43);
            this.mxtCpf.Mask = "000.000.000-00";
            this.mxtCpf.MinimumSize = new System.Drawing.Size(0, 23);
            this.mxtCpf.Name = "mxtCpf";
            this.mxtCpf.Size = new System.Drawing.Size(100, 23);
            this.mxtCpf.TabIndex = 8;
            this.mxtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mxtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mxtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mxtCpf_MaskInputRejected);
            // 
            // mxtData
            // 
            this.mxtData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mxtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mxtData.Location = new System.Drawing.Point(214, 104);
            this.mxtData.Mask = "00/00/0000";
            this.mxtData.MinimumSize = new System.Drawing.Size(0, 23);
            this.mxtData.Name = "mxtData";
            this.mxtData.Size = new System.Drawing.Size(100, 23);
            this.mxtData.TabIndex = 9;
            this.mxtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mxtData.ValidatingType = typeof(System.DateTime);
            // 
            // NovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 209);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NovoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adionar novo cliente";
            this.Load += new System.EventHandler(this.NovoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile tileCancelar;
        private MetroFramework.Controls.MetroTile tileCadastrar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile tileLimpar;
        private System.Windows.Forms.MaskedTextBox mxtCpf;
        private System.Windows.Forms.MaskedTextBox mxtData;
    }
}