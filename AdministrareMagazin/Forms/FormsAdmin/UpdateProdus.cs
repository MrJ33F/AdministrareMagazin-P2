using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AdministrareMagazin.Classes.Natives;
using AdministrareMagazin.Classes.EF;
using System.Security.Permissions;

namespace AdministrareMagazin.Forms.FormsAdmin
{
    public partial class UpdateProdus : Form
    {
        #region Fields

        private readonly Timer tmrFadeIn;
        private bool aeroShadow;

        #endregion
        #region Constants

        //Permita ca taskbarul sa se micsoreze
        private const int WS_MINIMIZEBOX = 0x20000;

        //Deseneaza toti descententi dintr-un window de jos in sus folosing double buffering
        private const int WS_EX_COMPOSITED = 0x02000000;

        #endregion


        public UpdateProdus()
        {

            InitializeComponent();
            LoadData();
            //Setari animator
            Animator.AnimationType = AnimatorNS.AnimationType.Transparent;
            Animator.Interval = 0;
            Animator.MaxAnimationTime = 1000;
            Animator.TimeStep = 0.02F;

            //Setam opacitatea la form la 0 si dam drumul la timer, urmand ca acesta sa se incrementeze in momentul cand aplicatia se deschide
            Opacity = 0;

            tmrFadeIn = new Timer
            {
                Interval = 1,
                Enabled = true,
            };

            tmrFadeIn.Tick += FadeIn_Tick;
        }
        #region Metode

        private void FadeIn_Tick(object sender, EventArgs e)
        {
            //Crestem opacitatea pana la 100% si dupa oprim timerul
            Opacity += 0.05;
            if (Opacity == 1)
            {
                tmrFadeIn.Stop();
                tmrFadeIn.Enabled = false;
                tmrFadeIn.Tick -= FadeIn_Tick;
            }
        }
        private void LoadData()
        {
            using (MagazinDbContext db = new MagazinDbContext())
            {
                var res = from s in db.Produse
                          select new
                          {
                              s.Id,
                              s.Denumire,
                              s.DescriereProdus,
                              s.DataIntrare,
                              s.DataValabilitate,
                              s.Cantitate

                          };
                dataMagazin.DataSource = res.ToList();
            }
        }
        #endregion

        #region Security Related
        //Verifica daca Desktop Window manager este enabled.
        private static bool IsDwnCompositionEnabled()
        {
            if (Environment.OSVersion.Version.Major < 6) return false;

            bool isEnabled;
            NativeMethods.DwmIsCompositionEnabled(out isEnabled);

            return isEnabled;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
                aeroShadow = IsDwnCompositionEnabled();

                var cp = base.CreateParams;

                cp.Style |= WS_MINIMIZEBOX;
                cp.ExStyle |= WS_EX_COMPOSITED;

                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch ((NativeMethods.WindowsMessages)m.Msg)
            {
                case NativeMethods.WindowsMessages.WM_NCPAINT:
                    if (aeroShadow)
                    {
                        var ncAttr = NativeMethods.DWMWINDOWATTRIBUTE.DWMWA_NCRENDERING_POLICY;
                        var dwAttrPntr = 2;
                        NativeMethods.DwmSetWindowAttribute(Handle, ncAttr, ref dwAttrPntr, 4);

                        var margins = new NativeMethods.MARGINS()
                        {
                            cyBottomHeight = 1,
                            cxLeftWidth = 1,
                            cxRightWidth = 1,
                            cyTopHeight = 1
                        };

                        NativeMethods.DwmExtendFrameIntoClientArea(Handle, ref margins);
                    }
                    break;
                case NativeMethods.WindowsMessages.WM_NCACTIVATE:
                    if (m.WParam == IntPtr.Zero)
                        updateContainer.TitleBarColor = Color.DarkGray;
                    else
                        updateContainer.TitleBarColor = Color.Gainsboro;
                    break;
            }
            base.WndProc(ref m);
        }
        #endregion

        private void deleteCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(deleteCheck.Checked == true)
            {
                denumireText.Enabled = descriereText.Enabled = dataExp.Enabled = cantitateText.Enabled = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id_Context = int.Parse(idText.Text);
            using (var context = new MagazinDbContext())
            {
                if(deleteCheck.Checked == true)
                {
                    
                    var entity = context.Produse.SingleOrDefault(item => item.Id == id_Context);
                    if(entity != null)
                    {
                        context.Produse.Remove(entity);
                        context.SaveChanges();
                    }
                }
                else
                {
                    if(context.Produse.Any(item => item.Id == id_Context))
                    {
                        ModificaProdus();
                    }
                }
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void ModificaProdus()
        {
            int id_Context = int.Parse(idText.Text);
            using (var context = new MagazinDbContext())
            {
                var entity = context.Produse.FirstOrDefault(item => item.Id == id_Context);

                if(entity != null)
                {
                    entity.Denumire = this.denumireText.Text;
                    entity.DescriereProdus = this.descriereText.Text;
                    entity.DataIntrare = DateTime.Now;
                    entity.DataValabilitate = this.dataExp.Value;
                    entity.Cantitate = int.Parse(this.cantitateText.Text);

                    context.SaveChanges();
                }
            }
        }
    }
}
