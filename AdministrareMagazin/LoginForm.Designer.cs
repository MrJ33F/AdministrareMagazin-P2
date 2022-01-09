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
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginContainer = new CustomUI.Controls.CContainer();
            this.Animator = new AnimatorNS.Animator(this.components);
            this.SuspendLayout();
            // 
            // loginContainer
            // 
            this.loginContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.loginContainer, AnimatorNS.DecorationType.None);
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
            // Animator
            // 
            this.Animator.AnimationType = AnimatorNS.AnimationType.Custom;
            this.Animator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Animator.DefaultAnimation = animation2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.loginContainer);
            this.Animator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUI.Controls.CContainer loginContainer;
        private AnimatorNS.Animator Animator;
    }
}

