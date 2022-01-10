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
            this.adminContainer = new CustomUI.Controls.CContainer();
            this.cControlBox1 = new CustomUI.Controls.CControlBox();
            this.adminMenuStrip = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arataProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arataUtilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeUtilizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireAplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiLaMeniulDeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPanel1 = new CustomUI.Controls.CPanel();
            this.cPanel2 = new CustomUI.Controls.CPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cLabel1 = new CustomUI.Controls.CLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cautaProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautareTextBox = new CustomUI.CTextBox();
            this.cautareButton = new CustomUI.Controls.CButton();
            this.refreshButton = new CustomUI.Controls.CButton();
            this.adminContainer.SuspendLayout();
            this.adminMenuStrip.SuspendLayout();
            this.cPanel1.SuspendLayout();
            this.cPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminContainer
            // 
            this.adminContainer.Controls.Add(this.cPanel2);
            this.adminContainer.Controls.Add(this.cPanel1);
            this.adminContainer.Controls.Add(this.cControlBox1);
            this.adminContainer.Controls.Add(this.adminMenuStrip);
            this.adminContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
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
            // cControlBox1
            // 
            this.cControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.cControlBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cControlBox1.EnableMaximizeButton = false;
            this.cControlBox1.EnableMinimizeButton = true;
            this.cControlBox1.Location = new System.Drawing.Point(872, 0);
            this.cControlBox1.Name = "cControlBox1";
            this.cControlBox1.Size = new System.Drawing.Size(139, 31);
            this.cControlBox1.TabIndex = 0;
            // 
            // adminMenuStrip
            // 
            this.adminMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
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
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produseToolStripMenuItem.Text = "Produse";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            // 
            // adaugareTaskToolStripMenuItem
            // 
            this.adaugareTaskToolStripMenuItem.Name = "adaugareTaskToolStripMenuItem";
            this.adaugareTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugareTaskToolStripMenuItem.Text = "Adaugare (Task)";
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizareProduseToolStripMenuItem,
            this.stergereProduseToolStripMenuItem,
            this.stergeUtilizatorToolStripMenuItem});
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificareToolStripMenuItem.Text = "Modificare";
            // 
            // actualizareProduseToolStripMenuItem
            // 
            this.actualizareProduseToolStripMenuItem.Name = "actualizareProduseToolStripMenuItem";
            this.actualizareProduseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizareProduseToolStripMenuItem.Text = "Actualizare produse";
            // 
            // stergereProduseToolStripMenuItem
            // 
            this.stergereProduseToolStripMenuItem.Name = "stergereProduseToolStripMenuItem";
            this.stergereProduseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergereProduseToolStripMenuItem.Text = "Stergere produse";
            // 
            // vizualizareToolStripMenuItem
            // 
            this.vizualizareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arataProduseToolStripMenuItem,
            this.arataUtilizatoriToolStripMenuItem,
            this.cautaProduseToolStripMenuItem});
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
            // 
            // arataUtilizatoriToolStripMenuItem
            // 
            this.arataUtilizatoriToolStripMenuItem.Name = "arataUtilizatoriToolStripMenuItem";
            this.arataUtilizatoriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arataUtilizatoriToolStripMenuItem.Text = "Arata utilizatori";
            // 
            // stergeUtilizatorToolStripMenuItem
            // 
            this.stergeUtilizatorToolStripMenuItem.Name = "stergeUtilizatorToolStripMenuItem";
            this.stergeUtilizatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergeUtilizatorToolStripMenuItem.Text = "Sterge utilizator";
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
            // 
            // inapoiLaMeniulDeLoginToolStripMenuItem
            // 
            this.inapoiLaMeniulDeLoginToolStripMenuItem.Name = "inapoiLaMeniulDeLoginToolStripMenuItem";
            this.inapoiLaMeniulDeLoginToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.inapoiLaMeniulDeLoginToolStripMenuItem.Text = "Inapoi la meniul de login";
            // 
            // cPanel1
            // 
            this.cPanel1.Controls.Add(this.cLabel1);
            this.cPanel1.Controls.Add(this.richTextBox1);
            this.cPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.cPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cPanel1.Location = new System.Drawing.Point(702, 55);
            this.cPanel1.Name = "cPanel1";
            this.cPanel1.Side = CustomUI.Controls.CPanel.PanelSide.Left;
            this.cPanel1.Size = new System.Drawing.Size(309, 515);
            this.cPanel1.TabIndex = 2;
            // 
            // cPanel2
            // 
            this.cPanel2.Controls.Add(this.refreshButton);
            this.cPanel2.Controls.Add(this.cautareButton);
            this.cPanel2.Controls.Add(this.cautareTextBox);
            this.cPanel2.Controls.Add(this.dataGridView1);
            this.cPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cPanel2.Location = new System.Drawing.Point(0, 55);
            this.cPanel2.Name = "cPanel2";
            this.cPanel2.Side = CustomUI.Controls.CPanel.PanelSide.Right;
            this.cPanel2.Size = new System.Drawing.Size(702, 515);
            this.cPanel2.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(72)))), ((int)(((byte)(70)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(19, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 441);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel1.ForeColor = System.Drawing.Color.White;
            this.cLabel1.Location = new System.Drawing.Point(64, 17);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Size = new System.Drawing.Size(194, 32);
            this.cLabel1.TabIndex = 1;
            this.cLabel1.Text = "Descriere produs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // cautaProduseToolStripMenuItem
            // 
            this.cautaProduseToolStripMenuItem.Name = "cautaProduseToolStripMenuItem";
            this.cautaProduseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cautaProduseToolStripMenuItem.Text = "Cauta produse";
            // 
            // cautareTextBox
            // 
            this.cautareTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.cautareTextBox.ColorBordersOnEnter = true;
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
            // cautareButton
            // 
            this.cautareButton.BackColor = System.Drawing.Color.Transparent;
            this.cautareButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cautareButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cautareButton.Location = new System.Drawing.Point(252, 17);
            this.cautareButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.cautareButton.Name = "cautareButton";
            this.cautareButton.Radius = 20;
            this.cautareButton.Size = new System.Drawing.Size(144, 47);
            this.cautareButton.TabIndex = 2;
            this.cautareButton.Text = "Cautare";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
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
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 570);
            this.Controls.Add(this.adminContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.adminMenuStrip;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.adminContainer.ResumeLayout(false);
            this.adminContainer.PerformLayout();
            this.adminMenuStrip.ResumeLayout(false);
            this.adminMenuStrip.PerformLayout();
            this.cPanel1.ResumeLayout(false);
            this.cPanel1.PerformLayout();
            this.cPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUI.Controls.CContainer adminContainer;
        private CustomUI.Controls.CControlBox cControlBox1;
        private System.Windows.Forms.MenuStrip adminMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizareProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeUtilizatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arataProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arataUtilizatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireAplicatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiLaMeniulDeLoginToolStripMenuItem;
        private CustomUI.Controls.CPanel cPanel1;
        private CustomUI.Controls.CPanel cPanel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private CustomUI.Controls.CLabel cLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem cautaProduseToolStripMenuItem;
        private CustomUI.CTextBox cautareTextBox;
        private CustomUI.Controls.CButton cautareButton;
        private CustomUI.Controls.CButton refreshButton;
    }
}