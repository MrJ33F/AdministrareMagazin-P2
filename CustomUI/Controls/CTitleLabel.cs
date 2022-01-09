using System.ComponentModel;
using System.Drawing.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CustomUI.Controls
{
    public class CTitleLabel : Label
    {
        #region Properties

        private PanelSide _Side;
        [Browsable(true)]
        [Description("Determina foreground color-ul labelului in concordanta cu partea in care aceasta a fost plasata.")]
        public PanelSide Side
        {
            get { return _Side; }
            set
            {
                _Side = value;
                switch (value)
                {
                    case PanelSide.LeftPanel:
                        ForeColor = ColorTranslator.FromHtml("#FAFAFA");
                        break;
                    case PanelSide.RightPanel:
                        ForeColor = ColorTranslator.FromHtml("#AAABB0");
                        break;
                }
                Invalidate();
            }
        }

        private TextRenderingHint _TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
        [Browsable(true)]
        [Description("Specifies the quality of text rendering.")]
        public TextRenderingHint TextRenderingHint
        {
            get { return _TextRenderingHint; }
            set
            {
                _TextRenderingHint = value;
                Invalidate();
            }
        }

        #endregion

        public enum PanelSide { LeftPanel, RightPanel };

        public CTitleLabel()
        {
            Cursor = Cursors.Arrow;
            Font = new Font("Microsoft Sans Serif", 22, FontStyle.Regular, GraphicsUnit.Point);
            TextAlign = ContentAlignment.MiddleCenter;
            ForeColor = ColorTranslator.FromHtml("#FAFAFA");
            BackColor = Color.Transparent;
            UseCompatibleTextRendering = true;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = _TextRenderingHint;
            base.OnPaint(e);
        }
    }
}