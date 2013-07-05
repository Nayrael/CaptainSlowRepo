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
    public partial class frmRezervacija : Form
    {
        public frmRezervacija()
        {
            InitializeComponent();
                       
        }

        private void frmRezervacija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pIDataSet1.Tereni' table. You can move, or remove it, as needed.
            this.tereniTableAdapter.Fill(this.pIDataSet1.Tereni);
            // TODO: This line of code loads data into the 'pIDataSet1.Stavke_rezervacije' table. You can move, or remove it, as needed.
            this.stavke_rezervacijeTableAdapter.Fill(this.pIDataSet1.Stavke_rezervacije);
            // TODO: This line of code loads data into the 'pIDataSet1.Rezervacije' table. You can move, or remove it, as needed.
            this.rezervacijeTableAdapter.Fill(this.pIDataSet1.Rezervacije);
            

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //this.rezervacijeTableAdapter.Update(this.pIDataSet.Rezervacije);
        }

        private void dateTimeRezervacija_ValueChanged(object sender, EventArgs e)
        {
            this.timeTrajanjeOd.MinDate =  this.dateTimeRezervacija.Value;
            this.timeTrajanjeOd.MaxDate = this.dateTimeRezervacija.Value;

        }

        private void btnRezerviraj_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void članoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClanovi clanovi = new frmClanovi();
            clanovi.Show();
        }

 

       
    }
}
