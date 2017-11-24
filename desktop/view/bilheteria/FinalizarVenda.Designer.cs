namespace desktop.view.bilheteria
{
    partial class FinalizarVenda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupDinheiro = new System.Windows.Forms.GroupBox();
            this.lblTroco = new MetroFramework.Controls.MetroLabel();
            this.txtTroco = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.lote = new MetroFramework.Controls.MetroLabel();
            this.total = new MetroFramework.Controls.MetroLabel();
            this.clienteNome = new MetroFramework.Controls.MetroLabel();
            this.eventoNome = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupDinheiro.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lote);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.clienteNome);
            this.panel1.Controls.Add(this.eventoNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 221);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupDinheiro);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroComboBox1);
            this.groupBox1.Location = new System.Drawing.Point(315, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 199);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamento";
            // 
            // groupDinheiro
            // 
            this.groupDinheiro.Controls.Add(this.lblTroco);
            this.groupDinheiro.Controls.Add(this.txtTroco);
            this.groupDinheiro.Controls.Add(this.metroLabel2);
            this.groupDinheiro.Location = new System.Drawing.Point(22, 84);
            this.groupDinheiro.Name = "groupDinheiro";
            this.groupDinheiro.Size = new System.Drawing.Size(200, 100);
            this.groupDinheiro.TabIndex = 3;
            this.groupDinheiro.TabStop = false;
            this.groupDinheiro.Text = "Dinheiro";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Location = new System.Drawing.Point(7, 69);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(44, 19);
            this.lblTroco.TabIndex = 2;
            this.lblTroco.Text = "Troco:";
            this.lblTroco.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(7, 43);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(135, 23);
            this.txtTroco.TabIndex = 1;
            this.txtTroco.Leave += new System.EventHandler(this.txtTroco_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Valor pago";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Tipo de pagamento";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "001 - DInheiro ",
            "002 - Cartão débito",
            "003 - Cartão Crédito",
            "004 - Bitcoin(Beta)"});
            this.metroComboBox1.Location = new System.Drawing.Point(22, 48);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(216, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // lote
            // 
            this.lote.AutoSize = true;
            this.lote.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lote.Location = new System.Drawing.Point(27, 94);
            this.lote.Name = "lote";
            this.lote.Size = new System.Drawing.Size(48, 25);
            this.lote.TabIndex = 3;
            this.lote.Text = "Lote:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.CustomForeColor = true;
            this.total.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.total.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.total.ForeColor = System.Drawing.Color.Red;
            this.total.Location = new System.Drawing.Point(27, 127);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(59, 25);
            this.total.TabIndex = 2;
            this.total.Text = "Total:";
            // 
            // clienteNome
            // 
            this.clienteNome.AutoSize = true;
            this.clienteNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.clienteNome.Location = new System.Drawing.Point(27, 58);
            this.clienteNome.Name = "clienteNome";
            this.clienteNome.Size = new System.Drawing.Size(145, 25);
            this.clienteNome.TabIndex = 1;
            this.clienteNome.Text = "Nome do Cliente:";
            // 
            // eventoNome
            // 
            this.eventoNome.AutoSize = true;
            this.eventoNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.eventoNome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.eventoNome.Location = new System.Drawing.Point(18, 19);
            this.eventoNome.Name = "eventoNome";
            this.eventoNome.Size = new System.Drawing.Size(159, 25);
            this.eventoNome.TabIndex = 0;
            this.eventoNome.Text = "Nome do Evento ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroTile2);
            this.panel2.Controls.Add(this.metroTile1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 43);
            this.panel2.TabIndex = 1;
            // 
            // metroTile2
            // 
            this.metroTile2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroTile2.Location = new System.Drawing.Point(371, 0);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(241, 43);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Cancelar venda";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile1
            // 
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(247, 43);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Finalizar venda";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // FinalizarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 356);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FinalizarVenda";
            this.Text = "Finalização de venda";
            this.Load += new System.EventHandler(this.FinalizarVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupDinheiro.ResumeLayout(false);
            this.groupDinheiro.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel eventoNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupDinheiro;
        private MetroFramework.Controls.MetroLabel lblTroco;
        private MetroFramework.Controls.MetroTextBox txtTroco;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel lote;
        private MetroFramework.Controls.MetroLabel total;
        private MetroFramework.Controls.MetroLabel clienteNome;
    }
}