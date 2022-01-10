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
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Animator = new AnimatorNS.Animator(this.components);
            this.loginContainer = new CustomUI.Controls.CContainer();
            this.cControlBox = new CustomUI.Controls.CControlBox();
            this.cRightPanel = new CustomUI.Controls.CPanel();
            this.cLinkLabel1 = new CustomUI.Controls.CLinkLabel();
            this.loginButton = new CustomUI.Controls.CButton();
            this.cLabel3 = new CustomUI.Controls.CLabel();
            this.linkNewAccount = new CustomUI.Controls.CLinkLabel();
            this.linkForgotPass = new CustomUI.Controls.CLinkLabel();
            this.loginToLabel = new CustomUI.Controls.CLabel();
            this.cLeftPanel = new CustomUI.Controls.CPanel();
            this.cLabel4 = new CustomUI.Controls.CLabel();
            this.welcomeLabel = new CustomUI.Controls.CLabel();
            this.loginData = new System.Windows.Forms.DataGridView();
            this.labelLogginIn = new CustomUI.Controls.CLabel();
            this.passwordTextBox = new CustomUI.CTextBox();
            this.usernameTextBox = new CustomUI.CTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginContainer.SuspendLayout();
            this.cRightPanel.SuspendLayout();
            this.cLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginData)).BeginInit();
            this.SuspendLayout();
            // 
            // Animator
            // 
            this.Animator.AnimationType = AnimatorNS.AnimationType.Custom;
            this.Animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Animator.DefaultAnimation = animation1;
            // 
            // loginContainer
            // 
            this.loginContainer.Controls.Add(this.loginData);
            this.loginContainer.Controls.Add(this.cControlBox);
            this.loginContainer.Controls.Add(this.cRightPanel);
            this.loginContainer.Controls.Add(this.cLeftPanel);
            this.loginContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.loginContainer, AnimatorNS.DecorationType.None);
            this.loginContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginContainer.DrawIcon = false;
            this.loginContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginContainer.Location = new System.Drawing.Point(0, 0);
            this.loginContainer.MinimumSize = new System.Drawing.Size(100, 42);
            this.loginContainer.Name = "loginContainer";
            this.loginContainer.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.loginContainer.Size = new System.Drawing.Size(1184, 467);
            this.loginContainer.TabIndex = 0;
            this.loginContainer.Text = "Magazin Login";
            this.loginContainer.TextAlignment = CustomUI.Controls.CContainer.Alignment.Left;
            this.loginContainer.TitleBarColor = System.Drawing.Color.Gainsboro;
            // 
            // cControlBox
            // 
            this.cControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cControlBox.BackColor = System.Drawing.Color.Transparent;
            this.cControlBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.cControlBox, AnimatorNS.DecorationType.None);
            this.cControlBox.EnableMaximizeButton = false;
            this.cControlBox.EnableMinimizeButton = true;
            this.cControlBox.Location = new System.Drawing.Point(1045, 0);
            this.cControlBox.Name = "cControlBox";
            this.cControlBox.Size = new System.Drawing.Size(139, 31);
            this.cControlBox.TabIndex = 2;
            // 
            // cRightPanel
            // 
            this.cRightPanel.Controls.Add(this.cLinkLabel1);
            this.cRightPanel.Controls.Add(this.loginButton);
            this.cRightPanel.Controls.Add(this.labelLogginIn);
            this.cRightPanel.Controls.Add(this.cLabel3);
            this.cRightPanel.Controls.Add(this.linkNewAccount);
            this.cRightPanel.Controls.Add(this.linkForgotPass);
            this.cRightPanel.Controls.Add(this.passwordTextBox);
            this.cRightPanel.Controls.Add(this.usernameTextBox);
            this.cRightPanel.Controls.Add(this.loginToLabel);
            this.cRightPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.cRightPanel, AnimatorNS.DecorationType.None);
            this.cRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.cRightPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRightPanel.Location = new System.Drawing.Point(402, 31);
            this.cRightPanel.Name = "cRightPanel";
            this.cRightPanel.Side = CustomUI.Controls.CPanel.PanelSide.Right;
            this.cRightPanel.Size = new System.Drawing.Size(782, 436);
            this.cRightPanel.TabIndex = 1;
            // 
            // cLinkLabel1
            // 
            this.cLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.cLinkLabel1.AutoSize = true;
            this.cLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLinkLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.cLinkLabel1, AnimatorNS.DecorationType.None);
            this.cLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.cLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.cLinkLabel1.Location = new System.Drawing.Point(541, 406);
            this.cLinkLabel1.Name = "cLinkLabel1";
            this.cLinkLabel1.Size = new System.Drawing.Size(210, 15);
            this.cLinkLabel1.TabIndex = 10;
            this.cLinkLabel1.TabStop = true;
            this.cLinkLabel1.Text = "magazinonlinesupport@exemplu.com";
            this.cLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.loginButton, AnimatorNS.DecorationType.None);
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loginButton.Location = new System.Drawing.Point(0, 165);
            this.loginButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.loginButton.Name = "loginButton";
            this.loginButton.Radius = 20;
            this.loginButton.Size = new System.Drawing.Size(144, 47);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "LOGIN";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cLabel3, AnimatorNS.DecorationType.None);
            this.cLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.cLabel3.Location = new System.Drawing.Point(187, 361);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Size = new System.Drawing.Size(524, 75);
            this.cLabel3.TabIndex = 8;
            this.cLabel3.Text = "Support\r\n\r\nPentru ajutor in legatura cu functionalitatea aplicatiei, probleme int" +
    "alnite in timpul rulari aplicatiei,\r\ncustomer support si alte intrebari de admin" +
    "istratie contatctatine la \r\n\r\n";
            // 
            // linkNewAccount
            // 
            this.linkNewAccount.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.linkNewAccount.AutoSize = true;
            this.linkNewAccount.BackColor = System.Drawing.Color.Transparent;
            this.linkNewAccount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.linkNewAccount, AnimatorNS.DecorationType.None);
            this.linkNewAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkNewAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkNewAccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.linkNewAccount.Location = new System.Drawing.Point(150, 192);
            this.linkNewAccount.Name = "linkNewAccount";
            this.linkNewAccount.Size = new System.Drawing.Size(309, 15);
            this.linkNewAccount.TabIndex = 7;
            this.linkNewAccount.TabStop = true;
            this.linkNewAccount.Text = "Utilizator nou? Apasa-ti aici pentru a va crea un cont nou!";
            this.linkNewAccount.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.linkNewAccount.Click += new System.EventHandler(this.linkNewAccount_Click);
            // 
            // linkForgotPass
            // 
            this.linkForgotPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.linkForgotPass.AutoSize = true;
            this.linkForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.linkForgotPass.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.linkForgotPass, AnimatorNS.DecorationType.None);
            this.linkForgotPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkForgotPass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkForgotPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.linkForgotPass.Location = new System.Drawing.Point(150, 177);
            this.linkForgotPass.Name = "linkForgotPass";
            this.linkForgotPass.Size = new System.Drawing.Size(95, 15);
            this.linkForgotPass.TabIndex = 6;
            this.linkForgotPass.TabStop = true;
            this.linkForgotPass.Text = "A-ti uitat parola?";
            this.linkForgotPass.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            // 
            // loginToLabel
            // 
            this.loginToLabel.AutoSize = true;
            this.loginToLabel.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.loginToLabel, AnimatorNS.DecorationType.None);
            this.loginToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.loginToLabel.Location = new System.Drawing.Point(253, 12);
            this.loginToLabel.Name = "loginToLabel";
            this.loginToLabel.Size = new System.Drawing.Size(281, 33);
            this.loginToLabel.TabIndex = 2;
            this.loginToLabel.Text = "Contectati-va la cont";
            // 
            // cLeftPanel
            // 
            this.cLeftPanel.Controls.Add(this.cLabel4);
            this.cLeftPanel.Controls.Add(this.panel1);
            this.cLeftPanel.Controls.Add(this.welcomeLabel);
            this.cLeftPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.cLeftPanel, AnimatorNS.DecorationType.None);
            this.cLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cLeftPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLeftPanel.Location = new System.Drawing.Point(0, 31);
            this.cLeftPanel.Name = "cLeftPanel";
            this.cLeftPanel.Side = CustomUI.Controls.CPanel.PanelSide.Left;
            this.cLeftPanel.Size = new System.Drawing.Size(402, 436);
            this.cLeftPanel.TabIndex = 0;
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cLabel4, AnimatorNS.DecorationType.None);
            this.cLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.cLabel4.Location = new System.Drawing.Point(15, 412);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Size = new System.Drawing.Size(343, 15);
            this.cLabel4.TabIndex = 2;
            this.cLabel4.Text = "Groza Cosmin-Gabriel - Anul II - Proiect Administrare Magazin";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.welcomeLabel, AnimatorNS.DecorationType.None);
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 254);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(384, 33);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Bine ati venit la cumparaturi!";
            // 
            // loginData
            // 
            this.loginData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Animator.SetDecoration(this.loginData, AnimatorNS.DecorationType.None);
            this.loginData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginData.Location = new System.Drawing.Point(402, 31);
            this.loginData.Name = "loginData";
            this.loginData.Size = new System.Drawing.Size(0, 436);
            this.loginData.TabIndex = 11;
            // 
            // labelLogginIn
            // 
            this.labelLogginIn.AutoSize = true;
            this.labelLogginIn.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.labelLogginIn, AnimatorNS.DecorationType.None);
            this.labelLogginIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelLogginIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.labelLogginIn.Image = global::AdministrareMagazin.Properties.Resources.spinner;
            this.labelLogginIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLogginIn.Location = new System.Drawing.Point(21, 190);
            this.labelLogginIn.Name = "labelLogginIn";
            this.labelLogginIn.Size = new System.Drawing.Size(93, 15);
            this.labelLogginIn.TabIndex = 9;
            this.labelLogginIn.Text = "         Loggin In...";
            this.labelLogginIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.passwordTextBox.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.passwordTextBox, AnimatorNS.DecorationType.None);
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.passwordTextBox.Image = global::AdministrareMagazin.Properties.Resources.password;
            this.passwordTextBox.Location = new System.Drawing.Point(0, 109);
            this.passwordTextBox.MaxLength = 30;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.ShowBottomBorder = true;
            this.passwordTextBox.ShowTopBorder = true;
            this.passwordTextBox.Size = new System.Drawing.Size(782, 50);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Watermark = "Parola";
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
            this.usernameTextBox.Location = new System.Drawing.Point(0, 59);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = false;
            this.usernameTextBox.ShortcutsEnabled = true;
            this.usernameTextBox.ShowBottomBorder = true;
            this.usernameTextBox.ShowTopBorder = true;
            this.usernameTextBox.Size = new System.Drawing.Size(782, 50);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameTextBox.UseSystemPasswordChar = false;
            this.usernameTextBox.Watermark = "Username sau Email";
            this.usernameTextBox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AdministrareMagazin.Properties.Resources.logo1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Animator.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(79, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 165);
            this.panel1.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 467);
            this.Controls.Add(this.loginContainer);
            this.Animator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.loginContainer.ResumeLayout(false);
            this.cRightPanel.ResumeLayout(false);
            this.cRightPanel.PerformLayout();
            this.cLeftPanel.ResumeLayout(false);
            this.cLeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUI.Controls.CContainer loginContainer;
        private AnimatorNS.Animator Animator;
        private CustomUI.Controls.CPanel cLeftPanel;
        private CustomUI.Controls.CPanel cRightPanel;
        private CustomUI.Controls.CControlBox cControlBox;
        private System.Windows.Forms.Panel panel1;
        private CustomUI.Controls.CLabel loginToLabel;
        private CustomUI.CTextBox usernameTextBox;
        private CustomUI.CTextBox passwordTextBox;
        private CustomUI.Controls.CButton loginButton;
        private CustomUI.Controls.CLinkLabel linkForgotPass;
        private CustomUI.Controls.CLinkLabel linkNewAccount;
        private CustomUI.Controls.CLabel cLabel3;
        private CustomUI.Controls.CLabel cLabel4;
        private CustomUI.Controls.CLabel welcomeLabel;
        private CustomUI.Controls.CLabel labelLogginIn;
        private CustomUI.Controls.CLinkLabel cLinkLabel1;
        private System.Windows.Forms.DataGridView loginData;
    }
}

