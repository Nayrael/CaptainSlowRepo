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
    public partial class frmMain : Form
    {
        public static PIDataSet1.ZaposleniciRow LogiraniKorisnik;
        public static ToolStripStatusLabel statusna_traka;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            statusna_traka = toolStripStatusLabel3;
            openLogin();
        }

        private void openLogin()
        {
            frmPrijava FrmPrijava = new frmPrijava();
            FrmPrijava.ShowDialog(this);
    
        }

        private void prijavaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openLogin();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void novaRezervacijaToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            frmRezervacija FrmRezervacija = new frmRezervacija();
            FrmRezervacija.MdiParent = this;
            FrmRezervacija.Show();
            
            
        }

        private void članoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClanovi clanovi = new frmClanovi();
            clanovi.MdiParent = this;
            clanovi.Show();
        }

        private void zaposleniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZaposlenici zaposlenici = new frmZaposlenici();
            zaposlenici.MdiParent = this;
            zaposlenici.Show();
        }
        public static void status(string text, int duration, int priority)
        {
            statusna_traka.Text = text;
        }

        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzvjestaji izvjestaji = new frmIzvjestaji();
            izvjestaji.MdiParent = this;
            izvjestaji.Show();
        }
   }
}
