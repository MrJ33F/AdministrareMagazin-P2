using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AdministrareMagazin.Forms.FormsAdmin;
using AdministrareMagazin.Classes.Natives;
using AdministrareMagazin.Classes.EF;
using System.Security.Permissions;

namespace AdministrareMagazin.Forms
{
    public partial class Administrator : Form
    {
        #region Fields

        private readonly Timer tmrFadeIn;
        private bool aeroShadow;
        private bool cautareProduse = true;
        private bool cautareUtilizatori = true;
        private bool cautareIstoric = true;

        #endregion
        #region Constants

        //Permita ca taskbarul sa se micsoreze
        private const int WS_MINIMIZEBOX = 0x20000;

        //Deseneaza toti descententi dintr-un window de jos in sus folosing double buffering
        private const int WS_EX_COMPOSITED = 0x02000000;

        #endregion

        public Administrator()
        {
            InitializeComponent();
            LoadData();


            //Setari animator
            Animator.AnimationType = AnimatorNS.AnimationType.Transparent;
            Animator.Interval = 0;
            Animator.MaxAnimationTime = 1000;
            Animator.TimeStep = 0.02F;

            descriereTextBox.Enabled = false;

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
        private void LoadUtilizatori()
        {
            using (UtilizatorDbContext db = new UtilizatorDbContext())
            {
                var res = from s in db.Utilizatori
                          select new
                          {
                              s.Id,
                              s.Username,
                              s.Password,
                              s.Email,
                              s.Nume,
                              s.Prenume,
                              s.Adresa,
                              s.Telefon
                          };
                dataMagazin.DataSource = res.ToList();
            }
        }
        private void LoadPurchaseHistory()
        {
            using(IstoricVanzariDbContext db = new IstoricVanzariDbContext())
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
                        adminContainer.TitleBarColor = Color.DarkGray;
                    else
                        adminContainer.TitleBarColor = Color.Gainsboro;
                    break;
            }
            base.WndProc(ref m);
        }
        #endregion

        private void iesireAplicatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inapoiLaMeniulDeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProdus ap = new AddProdus();
            if (ap.ShowDialog() == DialogResult.OK) LoadData();
        }

        private void adaugareTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produs produs = new Produs();
            AddProdusTask addFrm = new AddProdusTask(produs);

            addFrm.ShowDialog();

            var result = Task.Run(() => AddProdusT(produs));

            Console.WriteLine("Waiting for the add process to finish.");
            result.Wait();
            Console.WriteLine("Done");
        }

        private async Task AddProdusT(Produs produs)
        {
            using (var db = new MagazinDbContext())
            {
               

                if(db.Produse.Any(r => r.Denumire == produs.Denumire))
                {
                    var entity = db.Produse.FirstOrDefault(item => item.Denumire == produs.Denumire);
                    if(entity != null)
                    {
                        entity.Cantitate += produs.Cantitate;
                    }
                    await (db.SaveChangesAsync());
                    this.BeginInvoke(new MyDelegate(LoadData));
                }
                else
                {
                    db.Entry(produs).State = System.Data.Entity.EntityState.Added;

                    await (db.SaveChangesAsync());

                    this.BeginInvoke(new MyDelegate(LoadData));
                }
            }
        }

        public delegate void MyDelegate();
        public void LoadDataDgv(DataGridView dgv){
            using (MagazinDbContext db = new MagazinDbContext())
            {
                var res = from s in db.Produse
                          select new
                          {
                              s.Id,
                              s.Denumire,
                              s.Cantitate

                          };
                dgv.DataSource = res.ToList();
            }
        }

        private void actualizareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProdus up = new UpdateProdus();
            up.ShowDialog();
            if (up.DialogResult == DialogResult.OK) LoadData();
        }

        private void stergeUtilizatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser du = new DeleteUser();
            du.Show();
        }

        private void dataMagazin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataMagazin.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            using (var db = new MagazinDbContext())
            {
                var res = db.Produse.SingleOrDefault(item => item.Id == id);

                if(res != null)
                {
                    descriereTextBox.Text = String.Format("{0}\n----------------\n{1}\n----------------\nCantitate: {2} bucati" +
                        "\nData Expirare:{3}\n" + "Data Intrare: {4}\n"+
                        "Id[{5}] in DataBase.\n", res.Denumire, res.DescriereProdus, res.Cantitate, res.DataValabilitate.ToString(), res.DataIntrare.ToString(), res.Id); ;
                }
            }
        }

        private void arataProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cautareIstoric = false;
            cautareUtilizatori = false;
            cautareProduse = true;
            LoadData();
        }

        private void arataUtilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cautareIstoric = false;
            cautareUtilizatori = true;
            cautareProduse = false;
            LoadUtilizatori();
        }
        private void arataIstoricVanzariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cautareIstoric = true;
            cautareUtilizatori = false;
            cautareProduse = false;
            LoadPurchaseHistory();
        }
        private void cautareButton_Click(object sender, EventArgs e)
        {
            if(cautareProduse == true)
            {
                using(var db = new MagazinDbContext())
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
            else if(cautareUtilizatori == true)
            {
                using(var db = new UtilizatorDbContext())
                {
                    var entity = from s in db.Utilizatori
                                 where s.Username.Contains(this.cautareTextBox.Text)
                                 select new
                                 {
                                     s.Id,
                                     s.Username,
                                     s.Password,
                                     s.Email,
                                     s.Nume,
                                     s.Prenume,
                                     s.Adresa,
                                     s.Telefon
                                 };
                    dataMagazin.DataSource = entity.ToList();
                }
            }
            else if(cautareIstoric == true)
            {
                using(var db = new IstoricVanzariDbContext())
                {
                    var entity = from s in db.IstoricVanzari
                                 where s.DenumireProdus.Contains(this.cautareTextBox.Text)
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
        }

        
    }
}
