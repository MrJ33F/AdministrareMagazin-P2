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
    public partial class InterfataClient : Form
    {
        #region Fields

        private readonly Timer tmrFadeIn;
        private bool aeroShadow;
        private int indexCumparare = 0;
        private bool modes = true;
        private Utilizator usr = null;

        #endregion
        #region Constants

        //Permita ca taskbarul sa se micsoreze
        private const int WS_MINIMIZEBOX = 0x20000;

        //Deseneaza toti descententi dintr-un window de jos in sus folosing double buffering
        private const int WS_EX_COMPOSITED = 0x02000000;

        #endregion

        public InterfataClient(Utilizator user)
        {
            InitializeComponent();
            usr = user;
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
                var entity = from s in db.Produse
                             select new
                             {
                                 s.Id,
                                 s.Denumire,
                                 s.DescriereProdus,
                                 s.DataIntrare,
                                 s.DataValabilitate,
                                 s.Cantitate
                             };
                dataMagazin.DataSource = entity.ToList();
            }
        }
        private void LoadPurchaseHistory()
        {
            using (IstoricVanzariDbContext db = new IstoricVanzariDbContext())
            {
                var entity = from s in db.IstoricVanzari
                             select new
                             {
                                 s.Id,
                                 s.Id_User,
                                 s.DenumireProdus,
                                 s.CantitateProduse
                             };
                dataMagazin.DataSource = entity.ToList();
            }
        }
        private void LoadCosCumparaturi()
        {
            using (CosDbContext db = new CosDbContext())
            {
                var entity = from s in db.CosCumparaturi
                             select new
                             {
                                 s.Id,
                                 s.Id_Produs,
                                 s.NumeProdus,
                                 s.Cantitate
                             };
                dataMagazin.DataSource = entity.ToList();
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
                        uiContainer.TitleBarColor = Color.DarkGray;
                    else
                        uiContainer.TitleBarColor = Color.Gainsboro;
                    break;
            }
            base.WndProc(ref m);
        }
        #endregion

        private void logoffButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            dataMagazin.Location = new Point(36, 6);
            dataMagazin.Size = new Size(742, 457);
            LoadPurchaseHistory();
        }

        private void basketButton_Click(object sender, EventArgs e)
        {
            modes = false;
            cautareButton.Location = new Point(36, 163);
            cautareTextBox.Visible = false;
            dataMagazin.Size = new Size(742, 326);
            dataMagazin.Location = new Point(36, 236);
            cautareButton.Text = "Cumpara.";
            LoadCosCumparaturi();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            modes = true;
            cautareButton.Text = "Cautare";
            cautareTextBox.Visible = true;
            cautareButton.Location = new Point(288, 166);
            dataMagazin.Size = new Size(742, 326);
            dataMagazin.Location = new Point(36, 236);
            LoadData();
        }

        private void dataMagazin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataMagazin.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            using (var db = new MagazinDbContext())
            {
                var res = db.Produse.SingleOrDefault(item => item.Id == id);

                if (res != null)
                {
                    descriptionBox.Text = String.Format("{0}\n----------------\n{1}\n----------------\nCantitate: {2} bucati" +
                        "\nData Expirare:{3}\n" +
                        "Id[{4}] in DataBase.\n", res.Denumire, res.DescriereProdus, res.Cantitate, res.DataValabilitate.ToString(), res.Id); ;
                }
            }
        }

        private void dataMagazin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataMagazin.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            using (var db = new MagazinDbContext())
            {
                var entity = db.Produse.FirstOrDefault(item => item.Id == id);
                if (entity != null)
                {
                    indexCumparare += 1;
                    basketButton.Text = String.Format("Cos de cumparaturi. ({0} Obiecte in cos.)", indexCumparare);
                    entity.Cantitate--;
                    SendToHistory(indexCumparare, entity.Denumire);
                    db.SaveChanges();
                    LoadData();
                }
            }
        }
        private void SendToHistory(int cantitate, string denumire)
        {
            using(var db = new IstoricVanzariDbContext())
            {

                if (db.IstoricVanzari.Any(item => item.DenumireProdus == denumire)){

                    var entity = db.IstoricVanzari.FirstOrDefault(item => item.DenumireProdus == denumire);

                    if(entity != null)
                    {
                        entity.CantitateProduse += cantitate;
                        db.SaveChanges();
                    }

                }
                else {
                    Istoric history = new Istoric();

                    history.Id_User = usr.Id;
                    history.DenumireProdus = denumire;
                    history.CantitateProduse = cantitate;

                    db.IstoricVanzari.Add(history);
                    db.SaveChanges();
                }
            }
        }
        private void cautareButton_Click(object sender, EventArgs e)
        {
            if (modes == true)
            {
                using (var db = new MagazinDbContext())
                {
                    var entity = from s in db.Produse
                                 where s.Denumire.Contains(this.cautareTextBox.Text)
                                 select new
                                 {
                                     s.Id,
                                     s.Denumire,
                                     s.DescriereProdus,
                                     s.DataIntrare,
                                     s.DataValabilitate,
                                     s.Cantitate
                                 };
                    dataMagazin.DataSource = entity.ToList();
                }
            }
            else if (modes == false)
            {
                BuySelected();
            }
        }

        private void BuySelected()
        {
            using(var db = new CosDbContext())
            {
                var entity = db.CosCumparaturi.SingleOrDefault(item => item.Id == 1);
                if(entity != null)
                {
                    db.CosCumparaturi.Remove(entity);
                    db.SaveChanges();
                }

            }
            basketButton.Text = "Cos de cumparaturi";
        }
    }
}
