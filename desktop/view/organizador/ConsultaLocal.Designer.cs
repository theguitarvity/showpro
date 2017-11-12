namespace desktop.view.organizador
{
    partial class ConsultaLocal
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mxtCep = new System.Windows.Forms.MaskedTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnUsar = new MetroFramework.Controls.MetroTile();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.tileCancelar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Pesquisar por cep";
            // 
            // mxtCep
            // 
            this.mxtCep.Location = new System.Drawing.Point(13, 48);
            this.mxtCep.Name = "mxtCep";
            this.mxtCep.Size = new System.Drawing.Size(144, 20);
            this.mxtCep.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 95);
            this.listBox1.TabIndex = 2;
            // 
            // btnUsar
            // 
            this.btnUsar.Location = new System.Drawing.Point(13, 175);
            this.btnUsar.Name = "btnUsar";
            this.btnUsar.Size = new System.Drawing.Size(92, 49);
            this.btnUsar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnUsar.TabIndex = 3;
            this.btnUsar.Text = "Usar";
            this.btnUsar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(160, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 19);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "ok";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileCancelar
            // 
            this.tileCancelar.Location = new System.Drawing.Point(111, 175);
            this.tileCancelar.Name = "tileCancelar";
            this.tileCancelar.Size = new System.Drawing.Size(92, 49);
            this.tileCancelar.Style = MetroFramework.MetroColorStyle.Red;
            this.tileCancelar.TabIndex = 5;
            this.tileCancelar.Text = "Fechar";
            this.tileCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCancelar.Click += new System.EventHandler(this.tileCancelar_Click);
            // 
            // ConsultaLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 236);
            this.Controls.Add(this.tileCancelar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUsar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mxtCep);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConsultaLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaLocal";
            this.Load += new System.EventHandler(this.ConsultaLocal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.MaskedTextBox mxtCep;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTile btnUsar;
        private MetroFramework.Controls.MetroTile btnSearch;
        private MetroFramework.Controls.MetroTile tileCancelar;
    }
}