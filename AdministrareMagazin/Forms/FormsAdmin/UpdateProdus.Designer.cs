namespace AdministrareMagazin.Forms.FormsAdmin
{
    partial class UpdateProdus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProdus));
            this.updateContainer = new CustomUI.Controls.CContainer();
            this.updatePanel = new CustomUI.Controls.CPanel();
            this.deleteCheck = new System.Windows.Forms.CheckBox();
            this.dataMagazin = new System.Windows.Forms.DataGridView();
            this.idText = new CustomUI.CTextBox();
            this.cLabel5 = new CustomUI.Controls.CLabel();
            this.cancelButton = new CustomUI.Controls.CButton();
            this.addButton = new CustomUI.Controls.CButton();
            this.cantitateText = new CustomUI.CTextBox();
            this.cLabel4 = new CustomUI.Controls.CLabel();
            this.dataExp = new System.Windows.Forms.DateTimePicker();
            this.cLabel3 = new CustomUI.Controls.CLabel();
            this.descriereText = new CustomUI.CTextBox();
            this.denumireText = new CustomUI.CTextBox();
            this.cLabel2 = new CustomUI.Controls.CLabel();
            this.cLabel1 = new CustomUI.Controls.CLabel();
            this.Animator = new AnimatorNS.Animator(this.components);
            this.updateContainer.SuspendLayout();
            this.updatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMagazin)).BeginInit();
            this.SuspendLayout();
            // 
            // updateContainer
            // 
            this.updateContainer.Controls.Add(this.updatePanel);
            this.updateContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.updateContainer, AnimatorNS.DecorationType.None);
            this.updateContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateContainer.DrawIcon = false;
            this.updateContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateContainer.Location = new System.Drawing.Point(0, 0);
            this.updateContainer.MinimumSize = new System.Drawing.Size(100, 42);
            this.updateContainer.Name = "updateContainer";
            this.updateContainer.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.updateContainer.Size = new System.Drawing.Size(795, 740);
            this.updateContainer.TabIndex = 0;
            this.updateContainer.Text = "Modifica produsele";
            this.updateContainer.TextAlignment = CustomUI.Controls.CContainer.Alignment.Left;
            this.updateContainer.TitleBarColor = System.Drawing.Color.Gainsboro;
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.deleteCheck);
            this.updatePanel.Controls.Add(this.dataMagazin);
            this.updatePanel.Controls.Add(this.idText);
            this.updatePanel.Controls.Add(this.cLabel5);
            this.updatePanel.Controls.Add(this.cancelButton);
            this.updatePanel.Controls.Add(this.addButton);
            this.updatePanel.Controls.Add(this.cantitateText);
            this.updatePanel.Controls.Add(this.cLabel4);
            this.updatePanel.Controls.Add(this.dataExp);
            this.updatePanel.Controls.Add(this.cLabel3);
            this.updatePanel.Controls.Add(this.descriereText);
            this.updatePanel.Controls.Add(this.denumireText);
            this.updatePanel.Controls.Add(this.cLabel2);
            this.updatePanel.Controls.Add(this.cLabel1);
            this.updatePanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.updatePanel, AnimatorNS.DecorationType.None);
            this.updatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updatePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.updatePanel.Location = new System.Drawing.Point(0, 31);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Side = CustomUI.Controls.CPanel.PanelSide.Right;
            this.updatePanel.Size = new System.Drawing.Size(795, 709);
            this.updatePanel.TabIndex = 0;
            // 
            // deleteCheck
            // 
            this.deleteCheck.AutoSize = true;
            this.Animator.SetDecoration(this.deleteCheck, AnimatorNS.DecorationType.None);
            this.deleteCheck.Location = new System.Drawing.Point(644, 626);
            this.deleteCheck.Name = "deleteCheck";
            this.deleteCheck.Size = new System.Drawing.Size(64, 19);
            this.deleteCheck.TabIndex = 23;
            this.deleteCheck.Text = "Sterge?";
            this.deleteCheck.UseVisualStyleBackColor = true;
            this.deleteCheck.CheckedChanged += new System.EventHandler(this.deleteCheck_CheckedChanged);
            // 
            // dataMagazin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataMagazin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMagazin.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataMagazin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Animator.SetDecoration(this.dataMagazin, AnimatorNS.DecorationType.None);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataMagazin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataMagazin.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataMagazin.Location = new System.Drawing.Point(12, 17);
            this.dataMagazin.Name = "dataMagazin";
            this.dataMagazin.Size = new System.Drawing.Size(761, 198);
            this.dataMagazin.TabIndex = 22;
            // 
            // idText
            // 
            this.idText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.idText.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.idText, AnimatorNS.DecorationType.None);
            this.idText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.idText.ForeColor = System.Drawing.Color.White;
            this.idText.Image = null;
            this.idText.Location = new System.Drawing.Point(159, 236);
            this.idText.MaxLength = 1000;
            this.idText.Multiline = false;
            this.idText.Name = "idText";
            this.idText.ReadOnly = false;
            this.idText.ShortcutsEnabled = true;
            this.idText.ShowBottomBorder = true;
            this.idText.ShowTopBorder = true;
            this.idText.Size = new System.Drawing.Size(614, 50);
            this.idText.TabIndex = 21;
            this.idText.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.idText.UseSystemPasswordChar = false;
            this.idText.Watermark = "Introduce-ti id-ul produsului care trebuie modificat.";
            this.idText.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // cLabel5
            // 
            this.cLabel5.AutoSize = true;
            this.cLabel5.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cLabel5, AnimatorNS.DecorationType.None);
            this.cLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.cLabel5.Location = new System.Drawing.Point(23, 236);
            this.cLabel5.Name = "cLabel5";
            this.cLabel5.Size = new System.Drawing.Size(23, 21);
            this.cLabel5.TabIndex = 20;
            this.cLabel5.Text = "Id";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cancelButton, AnimatorNS.DecorationType.None);
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cancelButton.Location = new System.Drawing.Point(494, 655);
            this.cancelButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Radius = 1;
            this.cancelButton.Size = new System.Drawing.Size(144, 47);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.addButton, AnimatorNS.DecorationType.None);
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addButton.Location = new System.Drawing.Point(644, 655);
            this.addButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.addButton.Name = "addButton";
            this.addButton.Radius = 1;
            this.addButton.Size = new System.Drawing.Size(144, 47);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Modifica";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cantitateText
            // 
            this.cantitateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.cantitateText.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.cantitateText, AnimatorNS.DecorationType.None);
            this.cantitateText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cantitateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.cantitateText.Image = null;
            this.cantitateText.Location = new System.Drawing.Point(159, 595);
            this.cantitateText.MaxLength = 7;
            this.cantitateText.Multiline = false;
            this.cantitateText.Name = "cantitateText";
            this.cantitateText.ReadOnly = false;
            this.cantitateText.ShortcutsEnabled = true;
            this.cantitateText.ShowBottomBorder = true;
            this.cantitateText.ShowTopBorder = true;
            this.cantitateText.Size = new System.Drawing.Size(145, 50);
            this.cantitateText.TabIndex = 17;
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
            this.cLabel4.Location = new System.Drawing.Point(23, 595);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Size = new System.Drawing.Size(72, 21);
            this.cLabel4.TabIndex = 16;
            this.cLabel4.Text = "Cantitate";
            // 
            // dataExp
            // 
            this.Animator.SetDecoration(this.dataExp, AnimatorNS.DecorationType.None);
            this.dataExp.Location = new System.Drawing.Point(159, 550);
            this.dataExp.Name = "dataExp";
            this.dataExp.Size = new System.Drawing.Size(296, 23);
            this.dataExp.TabIndex = 15;
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cLabel3, AnimatorNS.DecorationType.None);
            this.cLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.cLabel3.Location = new System.Drawing.Point(23, 550);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Size = new System.Drawing.Size(121, 21);
            this.cLabel3.TabIndex = 14;
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
            this.descriereText.Location = new System.Drawing.Point(159, 375);
            this.descriereText.MaxLength = 500;
            this.descriereText.Multiline = true;
            this.descriereText.Name = "descriereText";
            this.descriereText.ReadOnly = false;
            this.descriereText.ShortcutsEnabled = true;
            this.descriereText.ShowBottomBorder = true;
            this.descriereText.ShowTopBorder = true;
            this.descriereText.Size = new System.Drawing.Size(614, 151);
            this.descriereText.TabIndex = 13;
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
            this.denumireText.Location = new System.Drawing.Point(159, 313);
            this.denumireText.MaxLength = 30;
            this.denumireText.Multiline = false;
            this.denumireText.Name = "denumireText";
            this.denumireText.ReadOnly = false;
            this.denumireText.ShortcutsEnabled = true;
            this.denumireText.ShowBottomBorder = true;
            this.denumireText.ShowTopBorder = true;
            this.denumireText.Size = new System.Drawing.Size(614, 50);
            this.denumireText.TabIndex = 12;
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
            this.cLabel2.Location = new System.Drawing.Point(23, 375);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Size = new System.Drawing.Size(75, 21);
            this.cLabel2.TabIndex = 11;
            this.cLabel2.Text = "Descriere";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cLabel1, AnimatorNS.DecorationType.None);
            this.cLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.cLabel1.Location = new System.Drawing.Point(23, 329);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Size = new System.Drawing.Size(79, 21);
            this.cLabel1.TabIndex = 10;
            this.cLabel1.Text = "Denumire";
            // 
            // Animator
            // 
            this.Animator.AnimationType = AnimatorNS.AnimationType.VertSlide;
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
            // UpdateProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 740);
            this.Controls.Add(this.updateContainer);
            this.Animator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "UpdateProdus";
            this.Text = "UpdateProdus";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.updateContainer.ResumeLayout(false);
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMagazin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUI.Controls.CContainer updateContainer;
        private CustomUI.Controls.CPanel updatePanel;
        private CustomUI.Controls.CButton cancelButton;
        private CustomUI.Controls.CButton addButton;
        private CustomUI.CTextBox cantitateText;
        private CustomUI.Controls.CLabel cLabel4;
        private System.Windows.Forms.DateTimePicker dataExp;
        private CustomUI.Controls.CLabel cLabel3;
        private CustomUI.CTextBox descriereText;
        private CustomUI.CTextBox denumireText;
        private CustomUI.Controls.CLabel cLabel2;
        private CustomUI.Controls.CLabel cLabel1;
        private CustomUI.Controls.CLabel cLabel5;
        private CustomUI.CTextBox idText;
        private System.Windows.Forms.DataGridView dataMagazin;
        private System.Windows.Forms.CheckBox deleteCheck;
        private AnimatorNS.Animator Animator;
    }
}