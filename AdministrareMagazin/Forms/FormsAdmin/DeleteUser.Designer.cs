namespace AdministrareMagazin.Forms.FormsAdmin
{
    partial class DeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            this.deleteContainer = new CustomUI.Controls.CContainer();
            this.cPanel1 = new CustomUI.Controls.CPanel();
            this.dataUtilizatori = new System.Windows.Forms.DataGridView();
            this.idTextBox = new CustomUI.CTextBox();
            this.idLabel = new CustomUI.Controls.CLabel();
            this.deleteButton = new CustomUI.Controls.CButton();
            this.cancelButton = new CustomUI.Controls.CButton();
            this.Animator = new AnimatorNS.Animator(this.components);
            this.deleteContainer.SuspendLayout();
            this.cPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUtilizatori)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteContainer
            // 
            this.deleteContainer.Controls.Add(this.cPanel1);
            this.deleteContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.deleteContainer, AnimatorNS.DecorationType.None);
            this.deleteContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteContainer.DrawIcon = false;
            this.deleteContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteContainer.Location = new System.Drawing.Point(0, 0);
            this.deleteContainer.MinimumSize = new System.Drawing.Size(100, 42);
            this.deleteContainer.Name = "deleteContainer";
            this.deleteContainer.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.deleteContainer.Size = new System.Drawing.Size(618, 369);
            this.deleteContainer.TabIndex = 0;
            this.deleteContainer.Text = "Sterge Utilizator";
            this.deleteContainer.TextAlignment = CustomUI.Controls.CContainer.Alignment.Left;
            this.deleteContainer.TitleBarColor = System.Drawing.Color.Gainsboro;
            // 
            // cPanel1
            // 
            this.cPanel1.Controls.Add(this.cancelButton);
            this.cPanel1.Controls.Add(this.deleteButton);
            this.cPanel1.Controls.Add(this.idLabel);
            this.cPanel1.Controls.Add(this.idTextBox);
            this.cPanel1.Controls.Add(this.dataUtilizatori);
            this.cPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.cPanel1, AnimatorNS.DecorationType.None);
            this.cPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cPanel1.Location = new System.Drawing.Point(0, 31);
            this.cPanel1.Name = "cPanel1";
            this.cPanel1.Side = CustomUI.Controls.CPanel.PanelSide.Right;
            this.cPanel1.Size = new System.Drawing.Size(618, 338);
            this.cPanel1.TabIndex = 0;
            // 
            // dataUtilizatori
            // 
            this.dataUtilizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Animator.SetDecoration(this.dataUtilizatori, AnimatorNS.DecorationType.None);
            this.dataUtilizatori.Location = new System.Drawing.Point(12, 93);
            this.dataUtilizatori.Name = "dataUtilizatori";
            this.dataUtilizatori.Size = new System.Drawing.Size(594, 242);
            this.dataUtilizatori.TabIndex = 0;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.idTextBox.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.idTextBox, AnimatorNS.DecorationType.None);
            this.idTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.idTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.idTextBox.Image = null;
            this.idTextBox.Location = new System.Drawing.Point(59, 37);
            this.idTextBox.MaxLength = 32767;
            this.idTextBox.Multiline = false;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = false;
            this.idTextBox.ShortcutsEnabled = true;
            this.idTextBox.ShowBottomBorder = true;
            this.idTextBox.ShowTopBorder = true;
            this.idTextBox.Size = new System.Drawing.Size(145, 50);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.idTextBox.UseSystemPasswordChar = false;
            this.idTextBox.Watermark = "Id utilizator";
            this.idTextBox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.idLabel, AnimatorNS.DecorationType.None);
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.idLabel.Location = new System.Drawing.Point(9, 37);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(44, 33);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.deleteButton, AnimatorNS.DecorationType.None);
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteButton.Location = new System.Drawing.Point(210, 37);
            this.deleteButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Radius = 20;
            this.deleteButton.Size = new System.Drawing.Size(144, 47);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Sterge";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.cancelButton, AnimatorNS.DecorationType.None);
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cancelButton.Location = new System.Drawing.Point(462, 37);
            this.cancelButton.MinimumSize = new System.Drawing.Size(144, 47);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Radius = 1;
            this.cancelButton.Size = new System.Drawing.Size(144, 47);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 369);
            this.Controls.Add(this.deleteContainer);
            this.Animator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.deleteContainer.ResumeLayout(false);
            this.cPanel1.ResumeLayout(false);
            this.cPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUtilizatori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUI.Controls.CContainer deleteContainer;
        private CustomUI.Controls.CPanel cPanel1;
        private System.Windows.Forms.DataGridView dataUtilizatori;
        private CustomUI.CTextBox idTextBox;
        private CustomUI.Controls.CLabel idLabel;
        private CustomUI.Controls.CButton deleteButton;
        private CustomUI.Controls.CButton cancelButton;
        private AnimatorNS.Animator Animator;
    }
}