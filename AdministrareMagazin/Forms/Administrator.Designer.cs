namespace AdministrareMagazin.Forms
{
    partial class Administrator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            AnimatorNS.Animation animation4 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.adminContainer = new CustomUI.Controls.CContainer();
            this.cPanel2 = new CustomUI.Controls.CPanel();
            this.dataMagazin = new System.Windows.Forms.DataGridView();
            this.refreshButton = new CustomUI.Controls.CButton();
            this.cautareButton = new CustomUI.Controls.CButton();
            this.cautareTextBox = new CustomUI.CTextBox();
            this.cPanel1 = new CustomUI.Controls.CPanel();
            this.cLabel1 = new CustomUI.Controls.CLabel();
            this.descriereTextBox = new System.Windows.Forms.RichTextBox();
            this.adminMenuStrip = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeUtilizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arataProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arataUtilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireAplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiLaMeniulDeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Animator = new AnimatorNS.Animator(this.components);
            this.arataIstoricVanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminContainer.SuspendLayout();
            this.cPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMagazin)).BeginInit();
            this.cPanel1.SuspendLayout();
            this.adminMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminContainer
            // 
            this.adminContainer.Controls.Add(this.cPanel2);
            this.adminContainer.Controls.Add(this.cPanel1);
            this.adminContainer.Controls.Add(this.adminMenuStrip);
            this.adminContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.adminContainer, AnimatorNS.DecorationType.None);
            this.adminContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminContainer.DrawIcon = false;
            this.adminContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adminContainer.Location = new System.Drawing.Point(0, 0);
            this.adminContainer.MinimumSize = new System.Drawing.Size(100, 42);
            this.adminContainer.Name = "adminContainer";
            this.adminContainer.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.adminContainer.Size = new System.Drawing.Size(1011, 570);
            this.adminContainer.TabIndex = 0;
            this.adminContainer.Text = "Administrare Magazin";
            this.adminContainer.TextAlignment = CustomUI.Controls.CContainer.Alignment.Left;
            this.adminContainer.TitleBarColor = System.Drawing.Color.Gainsboro;
            // 
            // cPanel2
            // 
            this.cPanel2.Controls.Add(this.dataMagazin);
            this.cPanel2.Controls.Add(this.refreshButton);
            this.cPanel2.Controls.Add(this.cautareButton);
            this.cPanel2.Controls.Add(this.cautareTextBox);
            this.cPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.cPanel2, AnimatorNS.DecorationType.None);
            this.cPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cPanel2.Location = new System.Drawing.Point(0, 55);
            this.cPanel2.Name = "cPanel2";
            this.cPanel2.Side = CustomUI.Controls.CPanel.PanelSide.Right;
            this.cPanel2.Size = new System.Drawing.Size(702, 515);
            this.cPanel2.TabIndex = 3;
            // 
            // dataMagazin
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataMagazin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataMagazin.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataMagazin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Animator.SetDecoration(this.dataMagazin, AnimatorNS.DecorationType.None);
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataMagazin.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataMagazin.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataMagazin.Location = new System.Drawing.Point(12, 82);
            this.dataMagazin.Name = "dataMagazin";
            this.dataMagazin.Size = new System.Drawing.Size(660, 411);
            this.dataMagazin.TabIndex = 0;
            this.dataMagazin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMagazin_CellClick);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.refreshButton, AnimatorNS.DecorationType.None);
            this.refreshButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.refreshButton.Location = new System.Drawing.Point(528, 17);
            this.refreshButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Radius = 1;
            this.refreshButton.Size = new System.Drawing.Size(144, 47);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            // 
            // cautareButton
            // 
            this.cautareButton.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cautareButton, AnimatorNS.DecorationType.None);
            this.cautareButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cautareButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cautareButton.Location = new System.Drawing.Point(252, 17);
            this.cautareButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.cautareButton.Name = "cautareButton";
            this.cautareButton.Radius = 20;
            this.cautareButton.Size = new System.Drawing.Size(144, 47);
            this.cautareButton.TabIndex = 2;
            this.cautareButton.Text = "Cautare";
            this.cautareButton.Click += new System.EventHandler(this.cautareButton_Click);
            // 
            // cautareTextBox
            // 
            this.cautareTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.cautareTextBox.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.cautareTextBox, AnimatorNS.DecorationType.None);
            this.cautareTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cautareTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.cautareTextBox.Image = null;
            this.cautareTextBox.Location = new System.Drawing.Point(12, 17);
            this.cautareTextBox.MaxLength = 32767;
            this.cautareTextBox.Multiline = false;
            this.cautareTextBox.Name = "cautareTextBox";
            this.cautareTextBox.ReadOnly = false;
            this.cautareTextBox.ShortcutsEnabled = true;
            this.cautareTextBox.ShowBottomBorder = true;
            this.cautareTextBox.ShowTopBorder = true;
            this.cautareTextBox.Size = new System.Drawing.Size(234, 50);
            this.cautareTextBox.TabIndex = 1;
            this.cautareTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.cautareTextBox.UseSystemPasswordChar = false;
            this.cautareTextBox.Watermark = "";
            this.cautareTextBox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // cPanel1
            // 
            this.cPanel1.Controls.Add(this.cLabel1);
            this.cPanel1.Controls.Add(this.descriereTextBox);
            this.cPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.cPanel1, AnimatorNS.DecorationType.None);
            this.cPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.cPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cPanel1.Location = new System.Drawing.Point(702, 55);
            this.cPanel1.Name = "cPanel1";
            this.cPanel1.Side = CustomUI.Controls.CPanel.PanelSide.Left;
            this.cPanel1.Size = new System.Drawing.Size(309, 515);
            this.cPanel1.TabIndex = 2;
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cLabel1, AnimatorNS.DecorationType.None);
            this.cLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel1.ForeColor = System.Drawing.Color.White;
            this.cLabel1.Location = new System.Drawing.Point(64, 17);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Size = new System.Drawing.Size(194, 32);
            this.cLabel1.TabIndex = 1;
            this.cLabel1.Text = "Descriere produs";
            // 
            // descriereTextBox
            // 
            this.descriereTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(72)))), ((int)(((byte)(70)))));
            this.Animator.SetDecoration(this.descriereTextBox, AnimatorNS.DecorationType.None);
            this.descriereTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriereTextBox.ForeColor = System.Drawing.Color.Black;
            this.descriereTextBox.Location = new System.Drawing.Point(19, 52);
            this.descriereTextBox.Name = "descriereTextBox";
            this.descriereTextBox.Size = new System.Drawing.Size(278, 441);
            this.descriereTextBox.TabIndex = 0;
            this.descriereTextBox.Text = "";
            // 
            // adminMenuStrip
            // 
            this.adminMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            this.Animator.SetDecoration(this.adminMenuStrip, AnimatorNS.DecorationType.None);
            this.adminMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem,
            this.vizualizareToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.adminMenuStrip.Location = new System.Drawing.Point(0, 31);
            this.adminMenuStrip.Name = "adminMenuStrip";
            this.adminMenuStrip.Size = new System.Drawing.Size(1011, 24);
            this.adminMenuStrip.TabIndex = 1;
            this.adminMenuStrip.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem,
            this.modificareToolStripMenuItem});
            this.meniuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.meniuToolStripMenuItem.Text = "Meniu";
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.adaugareTaskToolStripMenuItem});
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.produseToolStripMenuItem.Text = "Produse";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // adaugareTaskToolStripMenuItem
            // 
            this.adaugareTaskToolStripMenuItem.Name = "adaugareTaskToolStripMenuItem";
            this.adaugareTaskToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.adaugareTaskToolStripMenuItem.Text = "Adaugare (Task)";
            this.adaugareTaskToolStripMenuItem.Click += new System.EventHandler(this.adaugareTaskToolStripMenuItem_Click);
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizareProduseToolStripMenuItem,
            this.stergeUtilizatorToolStripMenuItem});
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.modificareToolStripMenuItem.Text = "Modificare";
            // 
            // actualizareProduseToolStripMenuItem
            // 
            this.actualizareProduseToolStripMenuItem.Name = "actualizareProduseToolStripMenuItem";
            this.actualizareProduseToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.actualizareProduseToolStripMenuItem.Text = "Actualizare produse";
            this.actualizareProduseToolStripMenuItem.Click += new System.EventHandler(this.actualizareProduseToolStripMenuItem_Click);
            // 
            // stergeUtilizatorToolStripMenuItem
            // 
            this.stergeUtilizatorToolStripMenuItem.Name = "stergeUtilizatorToolStripMenuItem";
            this.stergeUtilizatorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.stergeUtilizatorToolStripMenuItem.Text = "Sterge utilizator";
            this.stergeUtilizatorToolStripMenuItem.Click += new System.EventHandler(this.stergeUtilizatorToolStripMenuItem_Click);
            // 
            // vizualizareToolStripMenuItem
            // 
            this.vizualizareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arataProduseToolStripMenuItem,
            this.arataUtilizatoriToolStripMenuItem,
            this.arataIstoricVanzariToolStripMenuItem});
            this.vizualizareToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.vizualizareToolStripMenuItem.Name = "vizualizareToolStripMenuItem";
            this.vizualizareToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.vizualizareToolStripMenuItem.Text = "Vizualizare";
            // 
            // arataProduseToolStripMenuItem
            // 
            this.arataProduseToolStripMenuItem.Name = "arataProduseToolStripMenuItem";
            this.arataProduseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arataProduseToolStripMenuItem.Text = "Arata produse";
            this.arataProduseToolStripMenuItem.Click += new System.EventHandler(this.arataProduseToolStripMenuItem_Click);
            // 
            // arataUtilizatoriToolStripMenuItem
            // 
            this.arataUtilizatoriToolStripMenuItem.Name = "arataUtilizatoriToolStripMenuItem";
            this.arataUtilizatoriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arataUtilizatoriToolStripMenuItem.Text = "Arata utilizatori";
            this.arataUtilizatoriToolStripMenuItem.Click += new System.EventHandler(this.arataUtilizatoriToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireAplicatieToolStripMenuItem,
            this.inapoiLaMeniulDeLoginToolStripMenuItem});
            this.iesireToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.iesireToolStripMenuItem.Text = "Iesire";
            // 
            // iesireAplicatieToolStripMenuItem
            // 
            this.iesireAplicatieToolStripMenuItem.Name = "iesireAplicatieToolStripMenuItem";
            this.iesireAplicatieToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.iesireAplicatieToolStripMenuItem.Text = "Iesire aplicatie";
            this.iesireAplicatieToolStripMenuItem.Click += new System.EventHandler(this.iesireAplicatieToolStripMenuItem_Click);
            // 
            // inapoiLaMeniulDeLoginToolStripMenuItem
            // 
            this.inapoiLaMeniulDeLoginToolStripMenuItem.Name = "inapoiLaMeniulDeLoginToolStripMenuItem";
            this.inapoiLaMeniulDeLoginToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.inapoiLaMeniulDeLoginToolStripMenuItem.Text = "Inapoi la meniul de login";
            this.inapoiLaMeniulDeLoginToolStripMenuItem.Click += new System.EventHandler(this.inapoiLaMeniulDeLoginToolStripMenuItem_Click);
            // 
            // Animator
            // 
            this.Animator.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.Animator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.Animator.DefaultAnimation = animation4;
            // 
            // arataIstoricVanzariToolStripMenuItem
            // 
            this.arataIstoricVanzariToolStripMenuItem.Name = "arataIstoricVanzariToolStripMenuItem";
            this.arataIstoricVanzariToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arataIstoricVanzariToolStripMenuItem.Text = "Arata istoric vanzari";
            this.arataIstoricVanzariToolStripMenuItem.Click += new System.EventHandler(this.arataIstoricVanzariToolStripMenuItem_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 570);
            this.Controls.Add(this.adminContainer);
            this.Animator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.adminMenuStrip;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.adminContainer.ResumeLayout(false);
            this.adminContainer.PerformLayout();
            this.cPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMagazin)).EndInit();
            this.cPanel1.ResumeLayout(false);
            this.cPanel1.PerformLayout();
            this.adminMenuStrip.ResumeLayout(false);
            this.adminMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUI.Controls.CContainer adminContainer;
        private System.Windows.Forms.MenuStrip adminMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizareProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeUtilizatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arataProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arataUtilizatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireAplicatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiLaMeniulDeLoginToolStripMenuItem;
        private CustomUI.Controls.CPanel cPanel1;
        private CustomUI.Controls.CPanel cPanel2;
        private System.Windows.Forms.RichTextBox descriereTextBox;
        private CustomUI.Controls.CLabel cLabel1;
        private System.Windows.Forms.DataGridView dataMagazin;
        private CustomUI.CTextBox cautareTextBox;
        private CustomUI.Controls.CButton cautareButton;
        private CustomUI.Controls.CButton refreshButton;
        private AnimatorNS.Animator Animator;
        private System.Windows.Forms.ToolStripMenuItem arataIstoricVanzariToolStripMenuItem;
    }
}