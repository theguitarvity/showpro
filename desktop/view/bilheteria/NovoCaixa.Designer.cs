namespace desktop.view.bilheteria
{
    partial class NovoCaixa
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
            this.tileAbrir = new MetroFramework.Controls.MetroTile();
            this.tileCancel = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Inicar caixa em ";
            // 
            // tileAbrir
            // 
            this.tileAbrir.Location = new System.Drawing.Point(35, 106);
            this.tileAbrir.Name = "tileAbrir";
            this.tileAbrir.Size = new System.Drawing.Size(119, 35);
            this.tileAbrir.Style = MetroFramework.MetroColorStyle.Green;
            this.tileAbrir.TabIndex = 1;
            this.tileAbrir.Text = "Abrir caixa";
            this.tileAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAbrir.Click += new System.EventHandler(this.tileAbrir_Click);
            // 
            // tileCancel
            // 
            this.tileCancel.Location = new System.Drawing.Point(181, 106);
            this.tileCancel.Name = "tileCancel";
            this.tileCancel.Size = new System.Drawing.Size(119, 35);
            this.tileCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.tileCancel.TabIndex = 2;
            this.tileCancel.Text = "Cancelar";
            this.tileCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NovoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 171);
            this.Controls.Add(this.tileCancel);
            this.Controls.Add(this.tileAbrir);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NovoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura de caixa";
            this.Load += new System.EventHandler(this.NovoCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile tileAbrir;
        private MetroFramework.Controls.MetroTile tileCancel;
    }
}