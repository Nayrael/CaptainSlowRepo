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
    public partial class frmtipTerena : Form
    {
        public frmtipTerena()
        {
            InitializeComponent();
        }

        private void frmtipTerena_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pIDataSet1.Tip_terena' table. You can move, or remove it, as needed.
            this.tip_terenaTableAdapter.Fill(this.pIDataSet1.Tip_terena);

        }

        private void btnUsluga_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipterenaBindingSource.EndEdit();
            this.tip_terenaTableAdapter.Update(this.pIDataSet1.Tip_terena);

            dgvtipTereni.Refresh();
        }
    }
}
