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
    public partial class frmClanovi : Form
    {
        public frmClanovi()
        {
            InitializeComponent();
        }

        private void frmClanovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pIDataSet1.Rezervacije' table. You can move, or remove it, as needed.
            this.rezervacijeTableAdapter.Fill(this.pIDataSet1.Rezervacije);
            // TODO: This line of code loads data into the 'pIDataSet1.Clanovi' table. You can move, or remove it, as needed.
            this.clanoviTableAdapter.Fill(this.pIDataSet1.Clanovi);

        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clanoviBindingSource1.EndEdit();
            this.clanoviTableAdapter.Update(this.pIDataSet1.Clanovi);
            dgvClanovi.Refresh();
            dgvRezervacija.Refresh();
            
        }

       
    }
}
