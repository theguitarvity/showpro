namespace desktop.view.organizador
{
    partial class NovaAtracao
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
            this.tileAdd = new MetroFramework.Controls.MetroTile();
            this.tileLimpar = new MetroFramework.Controls.MetroTile();
            this.tileCancelar = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTipo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.rtxtDetalhes = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtDetalhes);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da atração";
            // 
            // tileAdd
            // 
            this.tileAdd.Location = new System.Drawing.Point(24, 218);
            this.tileAdd.Name = "tileAdd";
            this.tileAdd.Size = new System.Drawing.Size(96, 33);
            this.tileAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.tileAdd.TabIndex = 1;
            this.tileAdd.Text = "Adicionar";
            this.tileAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAdd.Click += new System.EventHandler(this.tileAdd_Click);
            // 
            // tileLimpar
            // 
            this.tileLimpar.Location = new System.Drawing.Point(165, 218);
            this.tileLimpar.Name = "tileLimpar";
            this.tileLimpar.Size = new System.Drawing.Size(96, 33);
            this.tileLimpar.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileLimpar.TabIndex = 2;
            this.tileLimpar.Text = "Limpar";
            this.tileLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileLimpar.Click += new System.EventHandler(this.tileLimpar_Click);
            // 
            // tileCancelar
            // 
            this.tileCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tileCancelar.Location = new System.Drawing.Point(316, 218);
            this.tileCancelar.Name = "tileCancelar";
            this.tileCancelar.Size = new System.Drawing.Size(96, 33);
            this.tileCancelar.Style = MetroFramework.MetroColorStyle.Red;
            this.tileCancelar.TabIndex = 3;
            this.tileCancelar.Text = "Cancelar";
            this.tileCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome da atração";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(134, 23);
            this.txtNome.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(5, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Tipo da atração";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(7, 103);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(134, 23);
            this.txtTipo.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(167, 20);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(125, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Detalhes da atração";
            // 
            // rtxtDetalhes
            // 
            this.rtxtDetalhes.Location = new System.Drawing.Point(167, 43);
            this.rtxtDetalhes.Name = "rtxtDetalhes";
            this.rtxtDetalhes.Size = new System.Drawing.Size(215, 83);
            this.rtxtDetalhes.TabIndex = 5;
            this.rtxtDetalhes.Text = "";
            // 
            // NovaAtracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.CancelButton = this.tileCancelar;
            this.ClientSize = new System.Drawing.Size(436, 274);
            this.Controls.Add(this.tileCancelar);
            this.Controls.Add(this.tileLimpar);
            this.Controls.Add(this.tileAdd);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Movable = false;
            this.Name = "NovaAtracao";
            this.Resizable = false;
            this.Text = "Adicionar uma nova atracao";
            this.Load += new System.EventHandler(this.NovaAtracao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile tileAdd;
        private MetroFramework.Controls.MetroTile tileLimpar;
        private MetroFramework.Controls.MetroTile tileCancelar;
        private System.Windows.Forms.RichTextBox rtxtDetalhes;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtTipo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}