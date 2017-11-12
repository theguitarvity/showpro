namespace desktop.view.organizador
{
    partial class NovoEvento
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
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mxtCep = new MetroFramework.Controls.MetroTextBox();
            this.txtNomeLocal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.tilePesquisar = new MetroFramework.Controls.MetroTile();
            this.txtCidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtBairro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtRua = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.rtxtDetalhes = new System.Windows.Forms.RichTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tileAddTipo = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new MetroFramework.Controls.MetroTile();
            this.btnCancelar = new MetroFramework.Controls.MetroTile();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.nupNu = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpHora);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.rtxtDetalhes);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.tileAddTipo);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Evento";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(233, 87);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(200, 20);
            this.dtpHora.TabIndex = 12;
            this.dtpHora.Value = new System.DateTime(2017, 11, 12, 16, 9, 0, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nupNu);
            this.groupBox3.Controls.Add(this.metroLabel12);
            this.groupBox3.Controls.Add(this.mxtCep);
            this.groupBox3.Controls.Add(this.txtNomeLocal);
            this.groupBox3.Controls.Add(this.metroLabel11);
            this.groupBox3.Controls.Add(this.tilePesquisar);
            this.groupBox3.Controls.Add(this.txtCidade);
            this.groupBox3.Controls.Add(this.metroLabel10);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.txtBairro);
            this.groupBox3.Controls.Add(this.metroLabel9);
            this.groupBox3.Controls.Add(this.cmbEstado);
            this.groupBox3.Controls.Add(this.txtRua);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Location = new System.Drawing.Point(7, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 119);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Localidade";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // mxtCep
            // 
            this.mxtCep.Location = new System.Drawing.Point(9, 38);
            this.mxtCep.Name = "mxtCep";
            this.mxtCep.Size = new System.Drawing.Size(68, 20);
            this.mxtCep.TabIndex = 18;
            this.mxtCep.Leave += new System.EventHandler(this.mxtCep_Leave);
            // 
            // txtNomeLocal
            // 
            this.txtNomeLocal.Location = new System.Drawing.Point(112, 83);
            this.txtNomeLocal.Name = "txtNomeLocal";
            this.txtNomeLocal.Size = new System.Drawing.Size(126, 20);
            this.txtNomeLocal.TabIndex = 17;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(110, 61);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(100, 19);
            this.metroLabel11.TabIndex = 16;
            this.metroLabel11.Text = "Nome do Local";
            // 
            // tilePesquisar
            // 
            this.tilePesquisar.Location = new System.Drawing.Point(244, 71);
            this.tilePesquisar.Name = "tilePesquisar";
            this.tilePesquisar.Size = new System.Drawing.Size(183, 32);
            this.tilePesquisar.Style = MetroFramework.MetroColorStyle.Green;
            this.tilePesquisar.TabIndex = 15;
            this.tilePesquisar.Text = "Pesquisar locais";
            this.tilePesquisar.Click += new System.EventHandler(this.tilePesquisar_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(347, 38);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(80, 20);
            this.txtCidade.TabIndex = 14;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(343, 16);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(51, 19);
            this.metroLabel10.TabIndex = 13;
            this.metroLabel10.Text = "Cidade";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(261, 16);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(45, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Bairro";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(261, 38);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(80, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(6, 61);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(48, 19);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "AC \t ",
            "AL \t ",
            "AP \t ",
            "AM \t ",
            "BA \t ",
            "CE \t ",
            "DF \t ",
            "ES \t ",
            "GO \t ",
            "MA \t ",
            "MT \t ",
            "MS \t ",
            "MG \t ",
            "PA \t ",
            "PB \t ",
            "PR \t ",
            "PE \t ",
            "PI \t ",
            "RJ \t ",
            "RN \t ",
            "RS \t ",
            "RO \t ",
            "RR \t ",
            "SC \t ",
            "SP \t ",
            "SE \t ",
            "TO"});
            this.cmbEstado.Location = new System.Drawing.Point(6, 83);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(100, 21);
            this.cmbEstado.TabIndex = 9;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(84, 38);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(126, 20);
            this.txtRua.TabIndex = 6;
            this.txtRua.Click += new System.EventHandler(this.txtRua_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(84, 16);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(31, 19);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Rua";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 16);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(33, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "CEP";
            // 
            // rtxtDetalhes
            // 
            this.rtxtDetalhes.Location = new System.Drawing.Point(7, 135);
            this.rtxtDetalhes.Name = "rtxtDetalhes";
            this.rtxtDetalhes.Size = new System.Drawing.Size(447, 144);
            this.rtxtDetalhes.TabIndex = 10;
            this.rtxtDetalhes.Text = "";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 111);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(121, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Detalhes do Evento";
            // 
            // tileAddTipo
            // 
            this.tileAddTipo.Location = new System.Drawing.Point(417, 41);
            this.tileAddTipo.Name = "tileAddTipo";
            this.tileAddTipo.Size = new System.Drawing.Size(37, 23);
            this.tileAddTipo.Style = MetroFramework.MetroColorStyle.Green;
            this.tileAddTipo.TabIndex = 8;
            this.tileAddTipo.Text = "+";
            this.tileAddTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAddTipo.Click += new System.EventHandler(this.tileAddTipo_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(232, 65);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Hora";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(233, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Tipo do Evento";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(233, 41);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(177, 21);
            this.cmbTipo.TabIndex = 4;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(7, 88);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(219, 20);
            this.dtpData.TabIndex = 3;
            this.dtpData.Value = new System.DateTime(2017, 11, 12, 0, 0, 0, 0);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Data";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 20);
            this.txtNome.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome do Evento";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 48);
            this.panel1.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(230, 48);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(237, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(225, 48);
            this.btnCancelar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(207, 16);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(25, 19);
            this.metroLabel12.TabIndex = 19;
            this.metroLabel12.Text = "Nº";
            // 
            // nupNu
            // 
            this.nupNu.Location = new System.Drawing.Point(214, 38);
            this.nupNu.Name = "nupNu";
            this.nupNu.Size = new System.Drawing.Size(41, 20);
            this.nupNu.TabIndex = 20;
            // 
            // NovoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnCadastrar;
            this.ClientSize = new System.Drawing.Size(502, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "NovoEvento";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Adicionar novo Evento";
            this.Load += new System.EventHandler(this.NovoEvento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupNu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile btnCadastrar;
        private MetroFramework.Controls.MetroTile btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile tileAddTipo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtxtDetalhes;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtBairro;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.ComboBox cmbEstado;
        private MetroFramework.Controls.MetroTextBox txtRua;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtNomeLocal;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTile tilePesquisar;
        private MetroFramework.Controls.MetroTextBox txtCidade;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox mxtCep;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.NumericUpDown nupNu;
    }
}