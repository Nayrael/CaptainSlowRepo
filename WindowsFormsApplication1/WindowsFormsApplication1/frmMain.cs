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
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            openLogin();
        }

        private void openLogin()
        {
            frmPrijava FrmPrijava = new frmPrijava();
            FrmPrijava.MdiParent = this;
            FrmPrijava.Show();
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
            FrmRezervacija.ShowDialog();
            
            
        }
   }
}
