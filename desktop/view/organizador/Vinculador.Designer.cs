namespace desktop.view.organizador
{
    partial class Vinculador
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.rtxtDetalhes = new System.Windows.Forms.RichTextBox();
            this.lblDetalhes = new MetroFramework.Controls.MetroLabel();
            this.lblData = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.lblCod = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tileFechar = new MetroFramework.Controls.MetroTile();
            this.tileNova = new MetroFramework.Controls.MetroTile();
            this.panelAtracoes = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.tileSalvar = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.nmMax = new System.Windows.Forms.NumericUpDown();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.nmLote = new System.Windows.Forms.NumericUpDown();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.mxtPreco = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelPreview.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(539, 345);
            this.metroTabControl1.TabIndex = 2;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.Controls.Add(this.rtxtDetalhes);
            this.metroTabPage1.Controls.Add(this.lblDetalhes);
            this.metroTabPage1.Controls.Add(this.lblData);
            this.metroTabPage1.Controls.Add(this.lblNome);
            this.metroTabPage1.Controls.Add(this.lblCod);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(531, 306);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Detalhes do evento";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTile1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 55);
            this.panel1.TabIndex = 7;
            // 
            // metroTile1
            // 
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(146, 55);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Editar";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // rtxtDetalhes
            // 
            this.rtxtDetalhes.Location = new System.Drawing.Point(1, 130);
            this.rtxtDetalhes.Name = "rtxtDetalhes";
            this.rtxtDetalhes.Size = new System.Drawing.Size(531, 89);
            this.rtxtDetalhes.TabIndex = 6;
            this.rtxtDetalhes.Text = "";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Location = new System.Drawing.Point(3, 108);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(124, 19);
            this.lblDetalhes.TabIndex = 5;
            this.lblDetalhes.Text = "Datalhes do Evento:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(3, 80);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(102, 19);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data do Evento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(112, 19);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome do Evento:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(3, 18);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(119, 19);
            this.lblCod.TabIndex = 2;
            this.lblCod.Text = "Codigo do Evento:";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel2);
            this.metroTabPage2.Controls.Add(this.panelAtracoes);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(531, 306);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Atrações";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tileFechar);
            this.panel2.Controls.Add(this.tileNova);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 43);
            this.panel2.TabIndex = 4;
            // 
            // tileFechar
            // 
            this.tileFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tileFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileFechar.Location = new System.Drawing.Point(263, 0);
            this.tileFechar.Name = "tileFechar";
            this.tileFechar.Size = new System.Drawing.Size(268, 43);
            this.tileFechar.Style = MetroFramework.MetroColorStyle.Red;
            this.tileFechar.TabIndex = 1;
            this.tileFechar.Text = "Fechar";
            this.tileFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileFechar.Click += new System.EventHandler(this.tileFechar_Click);
            // 
            // tileNova
            // 
            this.tileNova.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileNova.Location = new System.Drawing.Point(0, 0);
            this.tileNova.Name = "tileNova";
            this.tileNova.Size = new System.Drawing.Size(246, 43);
            this.tileNova.Style = MetroFramework.MetroColorStyle.Green;
            this.tileNova.TabIndex = 0;
            this.tileNova.Text = "Adicionar nova";
            this.tileNova.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNova.Click += new System.EventHandler(this.tileNova_Click);
            // 
            // panelAtracoes
            // 
            this.panelAtracoes.AutoScroll = true;
            this.panelAtracoes.Location = new System.Drawing.Point(0, 36);
            this.panelAtracoes.Name = "panelAtracoes";
            this.panelAtracoes.Size = new System.Drawing.Size(528, 195);
            this.panelAtracoes.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Lista de Atrações";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroLabel2);
            this.metroTabPage3.Controls.Add(this.tileSalvar);
            this.metroTabPage3.Controls.Add(this.panelPreview);
            this.metroTabPage3.Controls.Add(this.groupBox2);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(531, 306);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Ingressos e financeiro";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.metroTile2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.mxtPreco);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.nmLote);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.nmMax);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Location = new System.Drawing.Point(3, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 245);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lotes e preços";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panelPreview
            // 
            this.panelPreview.BackColor = System.Drawing.Color.Transparent;
            this.panelPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPreview.Controls.Add(this.metroPanel1);
            this.panelPreview.Controls.Add(this.metroLabel6);
            this.panelPreview.Controls.Add(this.metroLabel5);
            this.panelPreview.Controls.Add(this.metroLabel4);
            this.panelPreview.Controls.Add(this.metroLabel3);
            this.panelPreview.Location = new System.Drawing.Point(266, 38);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(262, 199);
            this.panelPreview.TabIndex = 4;
            // 
            // tileSalvar
            // 
            this.tileSalvar.AccessibleName = "";
            this.tileSalvar.Location = new System.Drawing.Point(3, 270);
            this.tileSalvar.Name = "tileSalvar";
            this.tileSalvar.Size = new System.Drawing.Size(138, 33);
            this.tileSalvar.Style = MetroFramework.MetroColorStyle.Green;
            this.tileSalvar.TabIndex = 5;
            this.tileSalvar.Text = "Salvar alterações";
            this.tileSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSalvar.Click += new System.EventHandler(this.tileSalvar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(266, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(175, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Pré-visualização do ingresso";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(69, 18);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(137, 25);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "nome do evento";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(11, 66);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Data do evento";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(11, 91);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Lote:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(11, 110);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Preço";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(45, 132);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 42);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(24, 13);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(110, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "codigo de barras";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 45);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(156, 19);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Nº maximo de ingressos:";
            // 
            // nmMax
            // 
            this.nmMax.Location = new System.Drawing.Point(158, 45);
            this.nmMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMax.Name = "nmMax";
            this.nmMax.Size = new System.Drawing.Size(54, 20);
            this.nmMax.TabIndex = 0;
            this.nmMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(6, 16);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(110, 19);
            this.metroLabel9.TabIndex = 3;
            this.metroLabel9.Text = "Numero do Lote:";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // nmLote
            // 
            this.nmLote.Location = new System.Drawing.Point(119, 16);
            this.nmLote.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmLote.Name = "nmLote";
            this.nmLote.Size = new System.Drawing.Size(54, 20);
            this.nmLote.TabIndex = 4;
            this.nmLote.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(6, 76);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(89, 19);
            this.metroLabel10.TabIndex = 5;
            this.metroLabel10.Text = "Preço do lote";
            // 
            // mxtPreco
            // 
            this.mxtPreco.Location = new System.Drawing.Point(6, 98);
            this.mxtPreco.Name = "mxtPreco";
            this.mxtPreco.Size = new System.Drawing.Size(100, 20);
            this.mxtPreco.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 81);
            this.dataGridView1.TabIndex = 7;
            // 
            // metroTile2
            // 
            this.metroTile2.AccessibleName = "";
            this.metroTile2.Location = new System.Drawing.Point(6, 212);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(54, 27);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 8;
            this.metroTile2.Text = "Salvar";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // Vinculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.tileFechar;
            this.ClientSize = new System.Drawing.Size(579, 425);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Vinculador";
            this.Text = "Nome do evento";
            this.Load += new System.EventHandler(this.Vinculador_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelPreview.ResumeLayout(false);
            this.panelPreview.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel lblCod;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.RichTextBox rtxtDetalhes;
        private MetroFramework.Controls.MetroLabel lblDetalhes;
        private MetroFramework.Controls.MetroLabel lblData;
        private MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTile tileFechar;
        private MetroFramework.Controls.MetroTile tileNova;
        private System.Windows.Forms.Panel panelAtracoes;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile tileEvento;
        private System.Windows.Forms.Panel panelEventos;
        private System.Windows.Forms.Panel panelCenter;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile tileSalvar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.NumericUpDown nmLote;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.NumericUpDown nmMax;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.MaskedTextBox mxtPreco;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}