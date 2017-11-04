namespace desktop.view
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.btnEntrar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Email";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(24, 97);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(317, 23);
            this.metroTextBox1.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 135);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Senha";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(24, 157);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(317, 23);
            this.metroTextBox2.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(23, 208);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(113, 37);
            this.btnEntrar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 285);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "LoginPage";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Showpro  - Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.LoginPage_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroButton btnEntrar;
    }
}