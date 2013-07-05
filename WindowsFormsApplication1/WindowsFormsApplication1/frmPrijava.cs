using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            this.zaposleniciTableAdapter.FillByLogin(pIDataSet1.Zaposlenici, txtKorisnickoIme.Text, txtLozinka.Text);
            if (pIDataSet1.Zaposlenici.Count() != 1)
            {
                frmMain.status("Prijava neuspješna!", 0, 0);
                txtKorisnickoIme.Text = "";
                txtLozinka.Text = "";
                txtKorisnickoIme.Focus();
            }
            else
            {
                frmMain.LogiraniKorisnik = pIDataSet1.Zaposlenici.First();
                frmMain.statusna_traka.Text = "Uspješna prijava za korisnika: " + frmMain.LogiraniKorisnik.username.ToString();
                this.Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
