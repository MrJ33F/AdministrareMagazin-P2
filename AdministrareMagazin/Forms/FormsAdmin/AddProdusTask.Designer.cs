namespace AdministrareMagazin.Forms.FormsAdmin
{
    partial class AddProdusTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProdusTask));
            this.addButton = new CustomUI.Controls.CButton();
            this.addContainer = new CustomUI.Controls.CContainer();
            this.cPanel1 = new CustomUI.Controls.CPanel();
            this.cancelButton = new CustomUI.Controls.CButton();
            this.cantitateText = new CustomUI.CTextBox();
            this.cLabel4 = new CustomUI.Controls.CLabel();
            this.dataExp = new System.Windows.Forms.DateTimePicker();
            this.cLabel3 = new CustomUI.Controls.CLabel();
            this.descriereText = new CustomUI.CTextBox();
            this.denumireText = new CustomUI.CTextBox();
            this.cLabel2 = new CustomUI.Controls.CLabel();
            this.cLabel1 = new CustomUI.Controls.CLabel();
            this.cControlBox1 = new CustomUI.Controls.CControlBox();
            this.Animator = new AnimatorNS.Animator(this.components);
            this.addContainer.SuspendLayout();
            this.cPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.addButton, AnimatorNS.DecorationType.None);
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addButton.Location = new System.Drawing.Point(633, 360);
            this.addButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.addButton.Name = "addButton";
            this.addButton.Radius = 1;
            this.addButton.Size = new System.Drawing.Size(144, 47);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addContainer
            // 
            this.addContainer.Controls.Add(this.cPanel1);
            this.addContainer.Controls.Add(this.cControlBox1);
            this.addContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.addContainer, AnimatorNS.DecorationType.None);
            this.addContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addContainer.DrawIcon = false;
            this.addContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addContainer.Location = new System.Drawing.Point(0, 0);
            this.addContainer.MinimumSize = new System.Drawing.Size(100, 42);
            this.addContainer.Name = "addContainer";
            this.addContainer.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.addContainer.Size = new System.Drawing.Size(800, 450);
            this.addContainer.TabIndex = 1;
            this.addContainer.Text = "Adaugare produs";
            this.addContainer.TextAlignment = CustomUI.Controls.CContainer.Alignment.Left;
            this.addContainer.TitleBarColor = System.Drawing.Color.Gainsboro;
            // 
            // cPanel1
            // 
            this.cPanel1.Controls.Add(this.cancelButton);
            this.cPanel1.Controls.Add(this.addButton);
            this.cPanel1.Controls.Add(this.cantitateText);
            this.cPanel1.Controls.Add(this.cLabel4);
            this.cPanel1.Controls.Add(this.dataExp);
            this.cPanel1.Controls.Add(this.cLabel3);
            this.cPanel1.Controls.Add(this.descriereText);
            this.cPanel1.Controls.Add(this.denumireText);
            this.cPanel1.Controls.Add(this.cLabel2);
            this.cPanel1.Controls.Add(this.cLabel1);
            this.cPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.cPanel1, AnimatorNS.DecorationType.None);
            this.cPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cPanel1.Location = new System.Drawing.Point(0, 31);
            this.cPanel1.Name = "cPanel1";
            this.cPanel1.Side = CustomUI.Controls.CPanel.PanelSide.Right;
            this.cPanel1.Size = new System.Drawing.Size(800, 419);
            this.cPanel1.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cancelButton, AnimatorNS.DecorationType.None);
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cancelButton.Location = new System.Drawing.Point(483, 360);
            this.cancelButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Radius = 1;
            this.cancelButton.Size = new System.Drawing.Size(144, 47);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // cantitateText
            // 
            this.cantitateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.cantitateText.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.cantitateText, AnimatorNS.DecorationType.None);
            this.cantitateText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cantitateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.cantitateText.Image = null;
            this.cantitateText.Location = new System.Drawing.Point(148, 300);
            this.cantitateText.MaxLength = 7;
            this.cantitateText.Multiline = false;
            this.cantitateText.Name = "cantitateText";
            this.cantitateText.ReadOnly = false;
            this.cantitateText.ShortcutsEnabled = true;
            this.cantitateText.ShowBottomBorder = true;
            this.cantitateText.ShowTopBorder = true;
            this.cantitateText.Size = new System.Drawing.Size(145, 50);
            this.cantitateText.TabIndex = 7;
            this.cantitateText.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.cantitateText.UseSystemPasswordChar = false;
            this.cantitateText.Watermark = "Max 7 cifre.";
            this.cantitateText.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cLabel4, AnimatorNS.DecorationType.None);
            this.cLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.cLabel4.Location = new System.Drawing.Point(12, 300);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Size = new System.Drawing.Size(72, 21);
            this.cLabel4.TabIndex = 6;
            this.cLabel4.Text = "Cantitate";
            // 
            // dataExp
            // 
            this.Animator.SetDecoration(this.dataExp, AnimatorNS.DecorationType.None);
            this.dataExp.Location = new System.Drawing.Point(148, 255);
            this.dataExp.Name = "dataExp";
            this.dataExp.Size = new System.Drawing.Size(296, 23);
            this.dataExp.TabIndex = 5;
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cLabel3, AnimatorNS.DecorationType.None);
            this.cLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.cLabel3.Location = new System.Drawing.Point(12, 255);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Size = new System.Drawing.Size(121, 21);
            this.cLabel3.TabIndex = 4;
            this.cLabel3.Text = "Data valabilitate";
            // 
            // descriereText
            // 
            this.descriereText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.descriereText.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.descriereText, AnimatorNS.DecorationType.None);
            this.descriereText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.descriereText.ForeColor = System.Drawing.Color.White;
            this.descriereText.Image = null;
            this.descriereText.Location = new System.Drawing.Point(148, 80);
            this.descriereText.MaxLength = 500;
            this.descriereText.Multiline = true;
            this.descriereText.Name = "descriereText";
            this.descriereText.ReadOnly = false;
            this.descriereText.ShortcutsEnabled = true;
            this.descriereText.ShowBottomBorder = true;
            this.descriereText.ShowTopBorder = true;
            this.descriereText.Size = new System.Drawing.Size(614, 151);
            this.descriereText.TabIndex = 3;
            this.descriereText.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.descriereText.UseSystemPasswordChar = false;
            this.descriereText.Watermark = "Max 500 caractere.";
            this.descriereText.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // denumireText
            // 
            this.denumireText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.denumireText.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.denumireText, AnimatorNS.DecorationType.None);
            this.denumireText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.denumireText.ForeColor = System.Drawing.Color.White;
            this.denumireText.Image = null;
            this.denumireText.Location = new System.Drawing.Point(148, 18);
            this.denumireText.MaxLength = 30;
            this.denumireText.Multiline = false;
            this.denumireText.Name = "denumireText";
            this.denumireText.ReadOnly = false;
            this.denumireText.ShortcutsEnabled = true;
            this.denumireText.ShowBottomBorder = true;
            this.denumireText.ShowTopBorder = true;
            this.denumireText.Size = new System.Drawing.Size(614, 50);
            this.denumireText.TabIndex = 2;
            this.denumireText.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.denumireText.UseSystemPasswordChar = false;
            this.denumireText.Watermark = "Max 30 caractere.";
            this.denumireText.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cLabel2, AnimatorNS.DecorationType.None);
            this.cLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.cLabel2.Location = new System.Drawing.Point(12, 80);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Size = new System.Drawing.Size(75, 21);
            this.cLabel2.TabIndex = 1;
            this.cLabel2.Text = "Descriere";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cLabel1, AnimatorNS.DecorationType.None);
            this.cLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.cLabel1.Location = new System.Drawing.Point(12, 34);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Size = new System.Drawing.Size(79, 21);
            this.cLabel1.TabIndex = 0;
            this.cLabel1.Text = "Denumire";
            // 
            // cControlBox1
            // 
            this.cControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.cControlBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.cControlBox1, AnimatorNS.DecorationType.None);
            this.cControlBox1.EnableMaximizeButton = false;
            this.cControlBox1.EnableMinimizeButton = true;
            this.cControlBox1.Location = new System.Drawing.Point(661, 0);
            this.cControlBox1.Name = "cControlBox1";
            this.cControlBox1.Size = new System.Drawing.Size(139, 31);
            this.cControlBox1.TabIndex = 0;
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
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.Animator.DefaultAnimation = animation3;
            // 
            // AddProdusTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addContainer);
            this.Animator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "AddProdusTask";
            this.Text = "AddProdusTask";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.addContainer.ResumeLayout(false);
            this.cPanel1.ResumeLayout(false);
            this.cPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUI.Controls.CButton addButton;
        private AnimatorNS.Animator Animator;
        private CustomUI.Controls.CContainer addContainer;
        private CustomUI.Controls.CPanel cPanel1;
        private CustomUI.Controls.CButton cancelButton;
        private CustomUI.CTextBox cantitateText;
        private CustomUI.Controls.CLabel cLabel4;
        private System.Windows.Forms.DateTimePicker dataExp;
        private CustomUI.Controls.CLabel cLabel3;
        private CustomUI.CTextBox descriereText;
        private CustomUI.CTextBox denumireText;
        private CustomUI.Controls.CLabel cLabel2;
        private CustomUI.Controls.CLabel cLabel1;
        private CustomUI.Controls.CControlBox cControlBox1;
    }
}