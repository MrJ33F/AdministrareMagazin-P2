namespace AdministrareMagazin
{
    partial class LoginForm
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
            this.loginContainer = new CustomUI.Controls.CContainer();
            this.SuspendLayout();
            // 
            // loginContainer
            // 
            this.loginContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginContainer.DrawIcon = false;
            this.loginContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginContainer.Location = new System.Drawing.Point(0, 0);
            this.loginContainer.MinimumSize = new System.Drawing.Size(100, 42);
            this.loginContainer.Name = "loginContainer";
            this.loginContainer.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.loginContainer.Size = new System.Drawing.Size(1184, 661);
            this.loginContainer.TabIndex = 0;
            this.loginContainer.Text = "cContainer1";
            this.loginContainer.TextAlignment = CustomUI.Controls.CContainer.Alignment.Left;
            this.loginContainer.TitleBarColor = System.Drawing.Color.Gainsboro;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.loginContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUI.Controls.CContainer loginContainer;
    }
}

