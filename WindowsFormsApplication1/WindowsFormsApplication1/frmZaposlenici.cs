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
    public partial class frmZaposlenici : Form
    {
        public frmZaposlenici()
        {
            InitializeComponent();
        }

        private void frmZaposlenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pIDataSet11.Rezervacije' table. You can move, or remove it, as needed.
            this.rezervacijeTableAdapter.Fill(this.pIDataSet1.Rezervacije);
            // TODO: This line of code loads data into the 'pIDataSet1.Zaposlenici' table. You can move, or remove it, as needed.
            this.zaposleniciTableAdapter.Fill(this.pIDataSet1.Zaposlenici);

        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zaposleniciBindingSource.EndEdit();
            this.zaposleniciTableAdapter.Update(this.pIDataSet1.Zaposlenici);
            dgvZaposlenici.Refresh();
            dgvRezervacije.Refresh();
        }
    }
}
