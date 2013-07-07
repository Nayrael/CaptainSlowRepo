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
    public partial class frmUsluge : Form
    {
        public frmUsluge()
        {
            InitializeComponent();
        }

        private void frmUsluge_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pIDataSet1.Usluge' table. You can move, or remove it, as needed.
            this.uslugeTableAdapter.Fill(this.pIDataSet1.Usluge);

        }

        private void btnUsluga_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uslugeBindingSource.EndEdit();
            this.uslugeTableAdapter.Update(this.pIDataSet1.Usluge);
            
            dgvUsluge.Refresh();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.uslugeTableAdapter.brisiUslugu(int.Parse(txtID.Text));

            dgvUsluge.Refresh();
        }
    }
}
