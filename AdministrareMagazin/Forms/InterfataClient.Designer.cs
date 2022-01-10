namespace AdministrareMagazin.Forms
{
    partial class InterfataClient
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
            this.cContainer1 = new CustomUI.Controls.CContainer();
            this.cControlBox1 = new CustomUI.Controls.CControlBox();
            this.cPanel2 = new CustomUI.Controls.CPanel();
            this.cPanel1 = new CustomUI.Controls.CPanel();
            this.buyButton = new CustomUI.Controls.CButton();
            this.historyButton = new CustomUI.Controls.CButton();
            this.basketButton = new CustomUI.Controls.CButton();
            this.logoffButton = new CustomUI.Controls.CButton();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.cLabel1 = new CustomUI.Controls.CLabel();
            this.cautareTextBox = new CustomUI.CTextBox();
            this.cautareButton = new CustomUI.Controls.CButton();
            this.refreshButton = new CustomUI.Controls.CButton();
            this.magazinDataGrid = new System.Windows.Forms.DataGridView();
            this.cContainer1.SuspendLayout();
            this.cPanel2.SuspendLayout();
            this.cPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cContainer1
            // 
            this.cContainer1.Controls.Add(this.cControlBox1);
            this.cContainer1.Controls.Add(this.cPanel2);
            this.cContainer1.Controls.Add(this.cPanel1);
            this.cContainer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cContainer1.DrawIcon = false;
            this.cContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cContainer1.Location = new System.Drawing.Point(0, 0);
            this.cContainer1.MinimumSize = new System.Drawing.Size(100, 42);
            this.cContainer1.Name = "cContainer1";
            this.cContainer1.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.cContainer1.Size = new System.Drawing.Size(1003, 605);
            this.cContainer1.TabIndex = 0;
            this.cContainer1.Text = "Magazin";
            this.cContainer1.TextAlignment = CustomUI.Controls.CContainer.Alignment.Left;
            this.cContainer1.TitleBarColor = System.Drawing.Color.Gainsboro;
            // 
            // cControlBox1
            // 
            this.cControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.cControlBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cControlBox1.EnableMaximizeButton = false;
            this.cControlBox1.EnableMinimizeButton = true;
            this.cControlBox1.Location = new System.Drawing.Point(864, 0);
            this.cControlBox1.Name = "cControlBox1";
            this.cControlBox1.Size = new System.Drawing.Size(139, 31);
            this.cControlBox1.TabIndex = 2;
            // 
            // cPanel2
            // 
            this.cPanel2.Controls.Add(this.magazinDataGrid);
            this.cPanel2.Controls.Add(this.refreshButton);
            this.cPanel2.Controls.Add(this.cautareButton);
            this.cPanel2.Controls.Add(this.cautareTextBox);
            this.cPanel2.Controls.Add(this.cLabel1);
            this.cPanel2.Controls.Add(this.descriptionBox);
            this.cPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cPanel2.Location = new System.Drawing.Point(200, 31);
            this.cPanel2.Name = "cPanel2";
            this.cPanel2.Side = CustomUI.Controls.CPanel.PanelSide.Left;
            this.cPanel2.Size = new System.Drawing.Size(803, 574);
            this.cPanel2.TabIndex = 1;
            // 
            // cPanel1
            // 
            this.cPanel1.Controls.Add(this.logoffButton);
            this.cPanel1.Controls.Add(this.basketButton);
            this.cPanel1.Controls.Add(this.historyButton);
            this.cPanel1.Controls.Add(this.buyButton);
            this.cPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.cPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cPanel1.Location = new System.Drawing.Point(0, 31);
            this.cPanel1.Name = "cPanel1";
            this.cPanel1.Side = CustomUI.Controls.CPanel.PanelSide.Right;
            this.cPanel1.Size = new System.Drawing.Size(200, 574);
            this.cPanel1.TabIndex = 0;
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.Transparent;
            this.buyButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buyButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buyButton.Location = new System.Drawing.Point(0, 57);
            this.buyButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.buyButton.Name = "buyButton";
            this.buyButton.Radius = 1;
            this.buyButton.Size = new System.Drawing.Size(200, 47);
            this.buyButton.TabIndex = 0;
            this.buyButton.Text = "Cumpara";
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.Transparent;
            this.historyButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.historyButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.historyButton.Location = new System.Drawing.Point(0, 110);
            this.historyButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.historyButton.Name = "historyButton";
            this.historyButton.Radius = 1;
            this.historyButton.Size = new System.Drawing.Size(200, 47);
            this.historyButton.TabIndex = 1;
            this.historyButton.Text = "Istoric Cumparaturi";
            // 
            // basketButton
            // 
            this.basketButton.BackColor = System.Drawing.Color.Transparent;
            this.basketButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.basketButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.basketButton.Location = new System.Drawing.Point(0, 163);
            this.basketButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.basketButton.Name = "basketButton";
            this.basketButton.Radius = 1;
            this.basketButton.Size = new System.Drawing.Size(200, 47);
            this.basketButton.TabIndex = 2;
            this.basketButton.Text = "Cos de cumparaturi";
            // 
            // logoffButton
            // 
            this.logoffButton.BackColor = System.Drawing.Color.Transparent;
            this.logoffButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.logoffButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.logoffButton.Location = new System.Drawing.Point(0, 515);
            this.logoffButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.logoffButton.Name = "logoffButton";
            this.logoffButton.Radius = 1;
            this.logoffButton.Size = new System.Drawing.Size(200, 47);
            this.logoffButton.TabIndex = 3;
            this.logoffButton.Text = "Inapoi la login";
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(72)))), ((int)(((byte)(70)))));
            this.descriptionBox.ForeColor = System.Drawing.Color.White;
            this.descriptionBox.Location = new System.Drawing.Point(36, 41);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(742, 116);
            this.descriptionBox.TabIndex = 0;
            this.descriptionBox.Text = "";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel1.ForeColor = System.Drawing.Color.White;
            this.cLabel1.Location = new System.Drawing.Point(313, 6);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Size = new System.Drawing.Size(194, 32);
            this.cLabel1.TabIndex = 2;
            this.cLabel1.Text = "Descriere produs";
            // 
            // cautareTextBox
            // 
            this.cautareTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.cautareTextBox.ColorBordersOnEnter = true;
            this.cautareTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cautareTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.cautareTextBox.Image = null;
            this.cautareTextBox.Location = new System.Drawing.Point(36, 163);
            this.cautareTextBox.MaxLength = 32767;
            this.cautareTextBox.Multiline = false;
            this.cautareTextBox.Name = "cautareTextBox";
            this.cautareTextBox.ReadOnly = false;
            this.cautareTextBox.ShortcutsEnabled = true;
            this.cautareTextBox.ShowBottomBorder = true;
            this.cautareTextBox.ShowTopBorder = true;
            this.cautareTextBox.Size = new System.Drawing.Size(234, 50);
            this.cautareTextBox.TabIndex = 3;
            this.cautareTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.cautareTextBox.UseSystemPasswordChar = false;
            this.cautareTextBox.Watermark = "";
            this.cautareTextBox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // cautareButton
            // 
            this.cautareButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.cautareButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cautareButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cautareButton.Location = new System.Drawing.Point(288, 166);
            this.cautareButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.cautareButton.Name = "cautareButton";
            this.cautareButton.Radius = 1;
            this.cautareButton.Size = new System.Drawing.Size(144, 47);
            this.cautareButton.TabIndex = 4;
            this.cautareButton.Text = "Cautare";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.refreshButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.refreshButton.Location = new System.Drawing.Point(634, 166);
            this.refreshButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Radius = 1;
            this.refreshButton.Size = new System.Drawing.Size(144, 47);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh";
            // 
            // magazinDataGrid
            // 
            this.magazinDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.magazinDataGrid.Location = new System.Drawing.Point(36, 236);
            this.magazinDataGrid.Name = "magazinDataGrid";
            this.magazinDataGrid.Size = new System.Drawing.Size(742, 326);
            this.magazinDataGrid.TabIndex = 6;
            // 
            // InterfataClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 605);
            this.Controls.Add(this.cContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "InterfataClient";
            this.Text = "InterfaraClient";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.cContainer1.ResumeLayout(false);
            this.cPanel2.ResumeLayout(false);
            this.cPanel2.PerformLayout();
            this.cPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUI.Controls.CContainer cContainer1;
        private CustomUI.Controls.CPanel cPanel1;
        private CustomUI.Controls.CPanel cPanel2;
        private CustomUI.Controls.CControlBox cControlBox1;
        private CustomUI.Controls.CButton buyButton;
        private CustomUI.Controls.CButton logoffButton;
        private CustomUI.Controls.CButton basketButton;
        private CustomUI.Controls.CButton historyButton;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private CustomUI.Controls.CLabel cLabel1;
        private CustomUI.CTextBox cautareTextBox;
        private CustomUI.Controls.CButton cautareButton;
        private CustomUI.Controls.CButton refreshButton;
        private System.Windows.Forms.DataGridView magazinDataGrid;
    }
}