namespace desktop.view.bilheteria
{
    partial class NovaVenda
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbEventos = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCpf = new MetroFramework.Controls.MetroTextBox();
            this.tileCliente = new MetroFramework.Controls.MetroTile();
            this.cmbIngresso = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.up = new MetroFramework.Controls.MetroTile();
            this.down = new MetroFramework.Controls.MetroTile();
            this.txtQtd = new MetroFramework.Controls.MetroTextBox();
            this.tileRealizarVenda = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEventos);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do evento";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Evento";
            // 
            // cmbEventos
            // 
            this.cmbEventos.FormattingEnabled = true;
            this.cmbEventos.ItemHeight = 23;
            this.cmbEventos.Location = new System.Drawing.Point(7, 43);
            this.cmbEventos.Name = "cmbEventos";
            this.cmbEventos.Size = new System.Drawing.Size(342, 29);
            this.cmbEventos.TabIndex = 1;
            this.cmbEventos.SelectedIndexChanged += new System.EventHandler(this.cmbEventos_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQtd);
            this.groupBox2.Controls.Add(this.down);
            this.groupBox2.Controls.Add(this.up);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.cmbIngresso);
            this.groupBox2.Location = new System.Drawing.Point(13, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Ingresso";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tileCliente);
            this.groupBox3.Controls.Add(this.txtCpf);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Location = new System.Drawing.Point(13, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do cliente";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "CPF do cliente";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(7, 43);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(154, 23);
            this.txtCpf.TabIndex = 1;
            // 
            // tileCliente
            // 
            this.tileCliente.Location = new System.Drawing.Point(187, 43);
            this.tileCliente.Name = "tileCliente";
            this.tileCliente.Size = new System.Drawing.Size(140, 23);
            this.tileCliente.Style = MetroFramework.MetroColorStyle.Green;
            this.tileCliente.TabIndex = 2;
            this.tileCliente.Text = "Novo cliente";
            this.tileCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCliente.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // cmbIngresso
            // 
            this.cmbIngresso.FormattingEnabled = true;
            this.cmbIngresso.ItemHeight = 23;
            this.cmbIngresso.Location = new System.Drawing.Point(6, 37);
            this.cmbIngresso.Name = "cmbIngresso";
            this.cmbIngresso.Size = new System.Drawing.Size(121, 29);
            this.cmbIngresso.TabIndex = 0;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(0, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Tipo do ingresso";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(167, 15);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Quantidade";
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(177, 43);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(29, 23);
            this.up.Style = MetroFramework.MetroColorStyle.Green;
            this.up.TabIndex = 3;
            this.up.Text = "+";
            this.up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.up.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(253, 43);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(29, 23);
            this.down.Style = MetroFramework.MetroColorStyle.Red;
            this.down.TabIndex = 4;
            this.down.Text = "-";
            this.down.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.CustomBackground = true;
            this.txtQtd.Location = new System.Drawing.Point(212, 43);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(35, 23);
            this.txtQtd.TabIndex = 5;
            // 
            // tileRealizarVenda
            // 
            this.tileRealizarVenda.Location = new System.Drawing.Point(13, 336);
            this.tileRealizarVenda.Name = "tileRealizarVenda";
            this.tileRealizarVenda.Size = new System.Drawing.Size(137, 40);
            this.tileRealizarVenda.Style = MetroFramework.MetroColorStyle.Green;
            this.tileRealizarVenda.TabIndex = 3;
            this.tileRealizarVenda.Text = "Realizar venda";
            this.tileRealizarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileRealizarVenda.Click += new System.EventHandler(this.tileRealizarVenda_Click);
            // 
            // NovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 388);
            this.Controls.Add(this.tileRealizarVenda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Venda";
            this.Load += new System.EventHandler(this.NovaVenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cmbEventos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile tileCliente;
        private MetroFramework.Controls.MetroTextBox txtCpf;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile down;
        private MetroFramework.Controls.MetroTile up;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbIngresso;
        private MetroFramework.Controls.MetroTextBox txtQtd;
        private MetroFramework.Controls.MetroTile tileRealizarVenda;
    }
}