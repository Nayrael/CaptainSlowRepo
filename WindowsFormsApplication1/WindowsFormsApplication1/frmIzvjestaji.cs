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
    public partial class frmIzvjestaji : Form
    {
        public frmIzvjestaji()

        {

            
                InitializeComponent();
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
       
            
            this.ClanoviTableAdapter.Fill(this.PIDataSet1.Clanovi);
            this.reportViewer1.RefreshReport();

            
        }

        private void byrez()
        {
            this.RezervacijeTableAdapter.FillByDatumRez(this.PIDataSet1.Rezervacije, this.dtNOW.Value.Date);
            this.reportViewer7.RefreshReport();
        }

        private void dtNOW_ValueChanged(object sender, EventArgs e)
        {
            byrez();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 1) {
                this.ZaposleniciTableAdapter.Fill(this.PIDataSet1.Zaposlenici);
                this.reportViewer2.RefreshReport();
            }
            if (this.tabControl1.SelectedIndex == 2)
            {
                this.TereniTableAdapter.Fill(this.PIDataSet1.Tereni);
                this.reportViewer4.RefreshReport();
            }
            if (this.tabControl1.SelectedIndex == 3)
            {
                this.Tip_terenaTableAdapter.Fill(this.PIDataSet1.Tip_terena);
                this.reportViewer5.RefreshReport();
            }
            if (this.tabControl1.SelectedIndex == 4)
            {
                this.UslugeTableAdapter.Fill(this.PIDataSet1.Usluge);
                this.reportViewer6.RefreshReport();
            }
            if (this.tabControl1.SelectedIndex == 5)
            {
                byrez();
            }
            
        }

    }
}
