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

namespace AdministrareMagazin.Forms
{
    public partial class NewUser : Form
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

        public NewUser()
        {
            InitializeComponent();


            //Setari animator
            Animator.AnimationType = AnimatorNS.AnimationType.Transparent;
            Animator.Interval = 0;
            Animator.MaxAnimationTime = 1000;
            Animator.TimeStep = 0.02F;

            addUserButton.Enabled = false;
            usernameTextBox.TextChanged += ValidateInput;
            passwordTextBox.TextChanged += ValidateInput;
            emailTextBox.TextChanged += ValidateInput;
            numeTextBox.TextChanged += ValidateInput;
            prenumeTextBox.TextChanged += ValidateInput;
            adresaTextBox.TextChanged += ValidateInput;
            telefonTextBox.TextChanged += ValidateInput;


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

        private void ValidateInput(object sender, EventArgs e)
        {
            addUserButton.Enabled = !(usernameTextBox.Text == String.Empty && passwordTextBox.Text == String.Empty && emailTextBox.Text == String.Empty && numeTextBox.Text == String.Empty && prenumeTextBox.Text == String.Empty
                 && adresaTextBox.Text == String.Empty && telefonTextBox.Text == String.Empty);
        }
        #endregion

        private void addUserButton_Click(object sender, EventArgs e)
        {
            using(UtilizatorDbContext context = new UtilizatorDbContext())
            {
                if(context.Utilizatori.Any(item => item.Username == usernameTextBox.Text))
                {
                    MessageBox.Show("Eroare", "Username folosit!");
                    usernameTextBox.Text = "";
                    this.Close();
                }
                else
                {
                    Utilizator u = new Utilizator();
                    u.Username = usernameTextBox.Text;
                    u.Password = passwordTextBox.Text;
                    u.Email = emailTextBox.Text;
                    u.Nume = numeTextBox.Text;
                    u.Prenume = prenumeTextBox.Text;
                    u.Adresa = adresaTextBox.Text;
                    u.Telefon = telefonTextBox.Text;

                    context.Utilizatori.Add(u);
                    context.SaveChanges();
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void NewUser_Shown(object sender, EventArgs e)
        {
            // Animam controalele care au propietatea de visible = false dupa ce formul a fost incarcat si a devenit vizibil.
            foreach (Control item in cPanel1.Controls)
            {
                if (item.Visible != true) Animator.Show(item);
            }
        }

        private void NewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrFadeIn.Tick -= FadeIn_Tick;
            usernameTextBox.TextChanged -= ValidateInput;
            passwordTextBox.TextChanged -= ValidateInput;
            emailTextBox.TextChanged -= ValidateInput;
            numeTextBox.TextChanged -= ValidateInput;
            prenumeTextBox.TextChanged -= ValidateInput;
            adresaTextBox.TextChanged -= ValidateInput;
            telefonTextBox.TextChanged -= ValidateInput;
        }

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

                // WS_MINIMIZEBOX   : allows minimizing the software from the taskbar
                // WS_EX_COMPOSITED : paints bottom-to-top. Reduces flicker greatly

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
                    // Change the title bar text color according to whether the
                    // window is active or inactive
                    if (m.WParam == IntPtr.Zero)
                        newUserContainer.TitleBarColor = Color.DarkGray;
                    else
                        newUserContainer.TitleBarColor = Color.Gainsboro;
                    break;
            }
            base.WndProc(ref m);
        }
        #endregion        
    }
}
