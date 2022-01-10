namespace AdministrareMagazin.Forms
{
    partial class NewUser
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
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation3 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.newUserContainer = new CustomUI.Controls.CContainer();
            this.cControlBox1 = new CustomUI.Controls.CControlBox();
            this.cPanel1 = new CustomUI.Controls.CPanel();
            this.addUserButton = new CustomUI.Controls.CButton();
            this.telefonTextBox = new CustomUI.CTextBox();
            this.adresaTextBox = new CustomUI.CTextBox();
            this.prenumeTextBox = new CustomUI.CTextBox();
            this.numeTextBox = new CustomUI.CTextBox();
            this.emailTextBox = new CustomUI.CTextBox();
            this.passwordTextBox = new CustomUI.CTextBox();
            this.usernameTextBox = new CustomUI.CTextBox();
            this.Animator = new AnimatorNS.Animator(this.components);
            this.newUserContainer.SuspendLayout();
            this.cPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newUserContainer
            // 
            this.newUserContainer.Controls.Add(this.cPanel1);
            this.newUserContainer.Controls.Add(this.cControlBox1);
            this.newUserContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.newUserContainer, AnimatorNS.DecorationType.None);
            this.newUserContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newUserContainer.DrawIcon = false;
            this.newUserContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newUserContainer.Location = new System.Drawing.Point(0, 0);
            this.newUserContainer.MinimumSize = new System.Drawing.Size(100, 42);
            this.newUserContainer.Name = "newUserContainer";
            this.newUserContainer.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.newUserContainer.Size = new System.Drawing.Size(289, 490);
            this.newUserContainer.TabIndex = 0;
            this.newUserContainer.Text = "Utilizator Nou";
            this.newUserContainer.TextAlignment = CustomUI.Controls.CContainer.Alignment.Left;
            this.newUserContainer.TitleBarColor = System.Drawing.Color.Gainsboro;
            // 
            // cControlBox1
            // 
            this.cControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.cControlBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.cControlBox1, AnimatorNS.DecorationType.None);
            this.cControlBox1.EnableMaximizeButton = false;
            this.cControlBox1.EnableMinimizeButton = true;
            this.cControlBox1.Location = new System.Drawing.Point(150, 0);
            this.cControlBox1.Name = "cControlBox1";
            this.cControlBox1.Size = new System.Drawing.Size(139, 31);
            this.cControlBox1.TabIndex = 0;
            // 
            // cPanel1
            // 
            this.cPanel1.Controls.Add(this.addUserButton);
            this.cPanel1.Controls.Add(this.telefonTextBox);
            this.cPanel1.Controls.Add(this.adresaTextBox);
            this.cPanel1.Controls.Add(this.prenumeTextBox);
            this.cPanel1.Controls.Add(this.numeTextBox);
            this.cPanel1.Controls.Add(this.emailTextBox);
            this.cPanel1.Controls.Add(this.passwordTextBox);
            this.cPanel1.Controls.Add(this.usernameTextBox);
            this.cPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.cPanel1, AnimatorNS.DecorationType.None);
            this.cPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cPanel1.Location = new System.Drawing.Point(0, 31);
            this.cPanel1.Name = "cPanel1";
            this.cPanel1.Side = CustomUI.Controls.CPanel.PanelSide.Right;
            this.cPanel1.Size = new System.Drawing.Size(289, 459);
            this.cPanel1.TabIndex = 1;
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.addUserButton, AnimatorNS.DecorationType.None);
            this.addUserButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addUserButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addUserButton.Location = new System.Drawing.Point(69, 407);
            this.addUserButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Radius = 1;
            this.addUserButton.Size = new System.Drawing.Size(144, 47);
            this.addUserButton.TabIndex = 7;
            this.addUserButton.Text = "Inregistrare";
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.telefonTextBox.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.telefonTextBox, AnimatorNS.DecorationType.None);
            this.telefonTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.telefonTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.telefonTextBox.Image = global::AdministrareMagazin.Properties.Resources.phone;
            this.telefonTextBox.Location = new System.Drawing.Point(3, 351);
            this.telefonTextBox.MaxLength = 32767;
            this.telefonTextBox.Multiline = false;
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.ReadOnly = false;
            this.telefonTextBox.ShortcutsEnabled = true;
            this.telefonTextBox.ShowBottomBorder = true;
            this.telefonTextBox.ShowTopBorder = true;
            this.telefonTextBox.Size = new System.Drawing.Size(284, 50);
            this.telefonTextBox.TabIndex = 6;
            this.telefonTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.telefonTextBox.UseSystemPasswordChar = false;
            this.telefonTextBox.Watermark = "Telefon";
            this.telefonTextBox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.adresaTextBox.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.adresaTextBox, AnimatorNS.DecorationType.None);
            this.adresaTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.adresaTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.adresaTextBox.Image = global::AdministrareMagazin.Properties.Resources.home;
            this.adresaTextBox.Location = new System.Drawing.Point(3, 295);
            this.adresaTextBox.MaxLength = 32767;
            this.adresaTextBox.Multiline = false;
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.ReadOnly = false;
            this.adresaTextBox.ShortcutsEnabled = true;
            this.adresaTextBox.ShowBottomBorder = true;
            this.adresaTextBox.ShowTopBorder = true;
            this.adresaTextBox.Size = new System.Drawing.Size(284, 50);
            this.adresaTextBox.TabIndex = 5;
            this.adresaTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.adresaTextBox.UseSystemPasswordChar = false;
            this.adresaTextBox.Watermark = "Adresa";
            this.adresaTextBox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.prenumeTextBox.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.prenumeTextBox, AnimatorNS.DecorationType.None);
            this.prenumeTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.prenumeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.prenumeTextBox.Image = ((System.Drawing.Image)(resources.GetObject("prenumeTextBox.Image")));
            this.prenumeTextBox.Location = new System.Drawing.Point(2, 239);
            this.prenumeTextBox.MaxLength = 32767;
            this.prenumeTextBox.Multiline = false;
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.ReadOnly = false;
            this.prenumeTextBox.ShortcutsEnabled = true;
            this.prenumeTextBox.ShowBottomBorder = true;
            this.prenumeTextBox.ShowTopBorder = true;
            this.prenumeTextBox.Size = new System.Drawing.Size(284, 50);
            this.prenumeTextBox.TabIndex = 4;
            this.prenumeTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.prenumeTextBox.UseSystemPasswordChar = false;
            this.prenumeTextBox.Watermark = "Prenume";
            this.prenumeTextBox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // numeTextBox
            // 
            this.numeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.numeTextBox.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.numeTextBox, AnimatorNS.DecorationType.None);
            this.numeTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.numeTextBox.Image = ((System.Drawing.Image)(resources.GetObject("numeTextBox.Image")));
            this.numeTextBox.Location = new System.Drawing.Point(2, 183);
            this.numeTextBox.MaxLength = 32767;
            this.numeTextBox.Multiline = false;
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.ReadOnly = false;
            this.numeTextBox.ShortcutsEnabled = true;
            this.numeTextBox.ShowBottomBorder = true;
            this.numeTextBox.ShowTopBorder = true;
            this.numeTextBox.Size = new System.Drawing.Size(284, 50);
            this.numeTextBox.TabIndex = 3;
            this.numeTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.numeTextBox.UseSystemPasswordChar = false;
            this.numeTextBox.Watermark = "Nume";
            this.numeTextBox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.emailTextBox.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.emailTextBox, AnimatorNS.DecorationType.None);
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.emailTextBox.Image = global::AdministrareMagazin.Properties.Resources.email;
            this.emailTextBox.Location = new System.Drawing.Point(2, 127);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Multiline = false;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = false;
            this.emailTextBox.ShortcutsEnabled = true;
            this.emailTextBox.ShowBottomBorder = true;
            this.emailTextBox.ShowTopBorder = true;
            this.emailTextBox.Size = new System.Drawing.Size(284, 50);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTextBox.UseSystemPasswordChar = false;
            this.emailTextBox.Watermark = "Email";
            this.emailTextBox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.passwordTextBox.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.passwordTextBox, AnimatorNS.DecorationType.None);
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.passwordTextBox.Image = global::AdministrareMagazin.Properties.Resources.password;
            this.passwordTextBox.Location = new System.Drawing.Point(0, 71);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.ShowBottomBorder = true;
            this.passwordTextBox.ShowTopBorder = true;
            this.passwordTextBox.Size = new System.Drawing.Size(284, 50);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Watermark = "Password";
            this.passwordTextBox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.usernameTextBox.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.usernameTextBox, AnimatorNS.DecorationType.None);
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.usernameTextBox.Image = global::AdministrareMagazin.Properties.Resources.user;
            this.usernameTextBox.Location = new System.Drawing.Point(0, 15);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = false;
            this.usernameTextBox.ShortcutsEnabled = true;
            this.usernameTextBox.ShowBottomBorder = true;
            this.usernameTextBox.ShowTopBorder = true;
            this.usernameTextBox.Size = new System.Drawing.Size(284, 50);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameTextBox.UseSystemPasswordChar = false;
            this.usernameTextBox.Watermark = "Username";
            this.usernameTextBox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // Animator
            // 
            this.Animator.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.Animator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.Animator.DefaultAnimation = animation3;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 490);
            this.Controls.Add(this.newUserContainer);
            this.Animator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewUser_FormClosing);
            this.Shown += new System.EventHandler(this.NewUser_Shown);
            this.newUserContainer.ResumeLayout(false);
            this.cPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUI.Controls.CContainer newUserContainer;
        private CustomUI.Controls.CControlBox cControlBox1;
        private CustomUI.Controls.CPanel cPanel1;
        private CustomUI.CTextBox usernameTextBox;
        private CustomUI.CTextBox passwordTextBox;
        private CustomUI.CTextBox emailTextBox;
        private CustomUI.CTextBox prenumeTextBox;
        private CustomUI.CTextBox numeTextBox;
        private CustomUI.CTextBox adresaTextBox;
        private CustomUI.CTextBox telefonTextBox;
        private CustomUI.Controls.CButton addUserButton;
        private AnimatorNS.Animator Animator;
    }
}