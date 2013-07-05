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
            // TODO: This line of code loads data into the 'PIDataSet1.Usluge' table. You can move, or remove it, as needed.
            this.UslugeTableAdapter.Fill(this.PIDataSet1.Usluge);
            // TODO: This line of code loads data into the 'PIDataSet1.Tereni' table. You can move, or remove it, as needed.
            this.TereniTableAdapter.Fill(this.PIDataSet1.Tereni);
            // TODO: This line of code loads data into the 'PIDataSet1.Rezervacije' table. You can move, or remove it, as needed.
            this.RezervacijeTableAdapter.Fill(this.PIDataSet1.Rezervacije);
            // TODO: This line of code loads data into the 'PIDataSet1.Zaposlenici' table. You can move, or remove it, as needed.
            this.ZaposleniciTableAdapter.Fill(this.PIDataSet1.Zaposlenici);
            // TODO: This line of code loads data into the 'PIDataSet1.Clanovi' table. You can move, or remove it, as needed.
            this.ClanoviTableAdapter.Fill(this.PIDataSet1.Clanovi);

            this.reportViewer1.RefreshReport();

            this.reportViewer2.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
        }

    }
}
