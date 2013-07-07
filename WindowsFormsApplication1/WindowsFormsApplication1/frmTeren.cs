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
    public partial class frmTeren : Form
    {
        public frmTeren()
        {
            InitializeComponent();
        }

        private void frmTeren_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pIDataSet1.Tereni' table. You can move, or remove it, as needed.
            this.tereniTableAdapter.Fill(this.pIDataSet1.Tereni);

        }

        private void btnUsluga_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tereniBindingSource.EndEdit();
            this.tereniTableAdapter.Update(this.pIDataSet1.Tereni);

            dgvTereni.Refresh();
        }
    }
}
