namespace desktop.view.organizador
{
    partial class NovoTipo
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
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.tileCadastrar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome do tipo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(240, 23);
            this.txtNome.TabIndex = 1;
            // 
            // tileCadastrar
            // 
            this.tileCadastrar.Location = new System.Drawing.Point(271, 19);
            this.tileCadastrar.Name = "tileCadastrar";
            this.tileCadastrar.Size = new System.Drawing.Size(112, 45);
            this.tileCadastrar.Style = MetroFramework.MetroColorStyle.Green;
            this.tileCadastrar.TabIndex = 2;
            this.tileCadastrar.TabStop = false;
            this.tileCadastrar.Text = "Cadastrar";
            this.tileCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCadastrar.Click += new System.EventHandler(this.tileCadastrar_Click);
            // 
            // NovoTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 99);
            this.Controls.Add(this.tileCadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NovoTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar novo tipo ";
            this.Load += new System.EventHandler(this.NovoTipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTile tileCadastrar;
    }
}