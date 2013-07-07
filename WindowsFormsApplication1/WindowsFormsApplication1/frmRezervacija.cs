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
        int pregled = 0;
        List<int> LclanID = new List<int>();

        public frmRezervacija()
        {
            InitializeComponent();
                       
        }

        private void frmRezervacija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pIDataSet11.Clanovi' table. You can move, or remove it, as needed.
            this.clanoviTableAdapter.Fill(this.pIDataSet11.Clanovi);
            // TODO: This line of code loads data into the 'pIDataSet11.Usluge' table. You can move, or remove it, as needed.
            this.uslugeTableAdapter.Fill(this.pIDataSet11.Usluge);
            // TODO: This line of code loads data into the 'pIDataSet1.Tereni' table. You can move, or remove it, as needed.
            this.tereniTableAdapter.Fill(this.pIDataSet1.Tereni);
            // TODO: This line of code loads data into the 'pIDataSet1.Stavke_rezervacije' table. You can move, or remove it, as needed.
            this.stavke_rezervacijeTableAdapter.Fill(this.pIDataSet1.Stavke_rezervacije);
            // TODO: This line of code loads data into the 'pIDataSet1.Rezervacije' table. You can move, or remove it, as needed.
            //this.rezervacijeTableAdapter.Fill(this.pIDataSet1.Rezervacije);

                     

            List<string> Lclanovi = new List<string>();              
            DataTable Tclanovi = new DataTable();
            Tclanovi = this.clanoviTableAdapter.GetData();
            foreach (DataRow redak in Tclanovi.Rows)
            {
                LclanID.Add(redak.Field<int>("id_clan"));
                Lclanovi.Add(redak.Field<string>("ime") +" "+ redak.Field<string>("prezime"));                              
               
            }           

            this.cmbClan.Items.AddRange(Lclanovi.ToArray<string>());
            this.cmbClan.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cmbClan.AutoCompleteSource = AutoCompleteSource.ListItems;
            
            if (pregled == 1)            
                PopuniRezervirano();

            else
            {
                this.rezervacijeTableAdapter.Fill(this.pIDataSet1.Rezervacije);
                this.rezervacijeBindingSource.Filter = "rezervirano=0";


            }

            SumaIznosa();

        }

        private void SumaIznosa()
        {
            decimal suma = 0;
            decimal temp = 0;
            suma += decimal.Parse(this.txtCijenaTerena.Text);
            for (int i = 0; i < this.dataGridStavkeRezervacije.Rows.Count; ++i)
            {
                if ((this.dataGridStavkeRezervacije.Rows[i].Cells[2].Value != null))
                {
                    temp = decimal.Parse(this.dataGridStavkeRezervacije.Rows[i].Cells[1].Value.ToString());
                    suma += decimal.Parse(this.dataGridStavkeRezervacije.Rows[i].Cells[2].Value.ToString())*temp;
                    
                }
                
            }
            this.txtUkupno.Text = suma.ToString();
        }

        public void Parametri()
        {
            pregled = 1;
        }
        

        private void PopuniRezervirano()
        {
            this.rezervacijeTableAdapter.FillByRezervirano(this.pIDataSet1.Rezervacije);
            
            TrajanjePopuni();
            CijenaTerena();

            this.btnRezerviraj.Visible = false;
            this.bindingNavigator1.AddNewItem.Enabled = false;
            this.txtClan.ReadOnly = true;                        
            this.dateTimeRezervacija.Enabled = false;           
            this.dataGridStavkeRezervacije.ReadOnly = true;
            this.cmbOd.Enabled = false;
            this.cmbDo.Enabled = false;
            this.cmbTeren.Enabled= false;
            this.cmbClan.Enabled = false;
        }

        private void TrajanjePopuni()
        {
            DataRow[] redTrajanje =
            this.pIDataSet1.Tables["Rezervacije"].Select("id_rezervacija = " + int.Parse(this.txtIdRezervacije.Text));
            //this.cmbOd.ResetText();
            //this.cmbDo.ResetText();
            this.cmbDo.SelectedItem = null;
            this.cmbOd.SelectedItem = null;
            this.cmbOd.SelectedItem = redTrajanje[0]["trajanje_od"].ToString();
            this.cmbDo.SelectedItem = redTrajanje[0]["trajanje_do"].ToString();
            
  
            
        }

 
  
 
        private void btnRezerviraj_MouseClick(object sender, MouseEventArgs e)
        {
            this.Validate();
            //this.rezervacijeBindingSource.EndEdit();          
            string tempid = this.txtIdRezervacije.Text;
            int tempod = int.Parse(this.cmbOd.SelectedItem.ToString());
            int tempdo = int.Parse(this.cmbDo.SelectedItem.ToString());
            this.rezervacijeBindingSource.EndEdit();
            this.fKStavkerezervacijeRezervacijeBindingSource.EndEdit();
            this.rezervacijeTableAdapter.Update(this.pIDataSet1.Rezervacije);
            this.stavke_rezervacijeTableAdapter.Update(this.pIDataSet1.Stavke_rezervacije);
            DataRow[] trenutniRed =
            this.pIDataSet1.Tables["Rezervacije"].Select("id_rezervacija = " + tempid);
            trenutniRed[0]["rezervirano"] = 1;
            trenutniRed[0]["trajanje_od"] = tempod;
            trenutniRed[0]["trajanje_do"] = tempdo;
            this.rezervacijeTableAdapter.Update(this.pIDataSet1.Rezervacije);
            this.txtCijenaTerena.Text = "0";
            this.txtClan.ResetText();
            this.cmbClan.ResetText();
            this.cmbOd.ResetText();
            this.cmbDo.ResetText();
            
            

        }

        private void fKStavkerezervacijeRezervacijeBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            SumaIznosa();
            
        }

        private void dataGridStavkeRezervacije_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            SumaIznosa();
        }

        private void dataGridStavkeRezervacije_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tablicaUsluga = new DataTable();
            for (int i = 0; i < this.dataGridStavkeRezervacije.Rows.Count; ++i)
            {
                if ((this.dataGridStavkeRezervacije.Rows[i].Cells[0].Value != null))
                {
                    int UslugaID=int.Parse(this.dataGridStavkeRezervacije.Rows[i].Cells[0].Value.ToString());
                    tablicaUsluga = this.uslugeTableAdapter.GetDataByUsluga(UslugaID);
                    decimal uslugaCijena = decimal.Parse(tablicaUsluga.Rows[0]["CijenaUsluge"].ToString());
                    this.dataGridStavkeRezervacije.Rows[i].Cells[2].Value = uslugaCijena;                    
                }
            }
        }

        private void cmbTeren_Validated(object sender, EventArgs e)
        {
            //CijenaTerena();
        }

        private void CijenaTerena()
        {
            
            if (this.cmbTeren.SelectedValue != null && cmbOd.SelectedItem!=null && cmbDo.SelectedItem!=null)
            {
                decimal decOD = decimal.Parse(this.cmbOd.SelectedItem.ToString());
                decimal decDO = decimal.Parse(this.cmbDo.SelectedItem.ToString());
                if (decDO - decOD > 0)
                {
                    DataTable tTeren = new DataTable();
                    DataTable tTip = new DataTable();
                    tTeren = this.tereniTableAdapter.GetDataByTerenID(int.Parse(this.cmbTeren.SelectedValue.ToString()));
                    int idTip = int.Parse(tTeren.Rows[0]["Tip_terena"].ToString());
                    PIDataSet1TableAdapters.Tip_terenaTableAdapter tipAdapter = new PIDataSet1TableAdapters.Tip_terenaTableAdapter();
                    tTip = tipAdapter.GetDataByTipTerena(idTip);
                    decimal cijeneTeren = decimal.Parse(tTip.Rows[0]["jedinicna_cijena"].ToString());
                    cijeneTeren = cijeneTeren * (decDO - decOD);
                    this.txtCijenaTerena.Text = cijeneTeren.ToString();
                }
                else MessageBox.Show("Termin nije pravilno unesen!");
            }
        }

        private void rezervacijeBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {

            if (this.txtIdRezervacije.Text != "" && pregled == 1)
            {
                TrajanjePopuni();
                CijenaTerena();
            }

        }

        private void cmbOd_TextChanged(object sender, EventArgs e)
        {
            if(pregled==0)
            CijenaTerena();
        }

        private void cmbDo_TextChanged(object sender, EventArgs e)
        {
            if (pregled == 0)
            CijenaTerena();
        }

        private void cmbClan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indeksClan=this.cmbClan.SelectedIndex;
            this.txtClan.Text=LclanID[indeksClan].ToString();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataTable TaktivanZaposlenik = new DataTable();
            PIDataSet1TableAdapters.ZaposleniciTableAdapter Adapterzaposlenik = new PIDataSet1TableAdapters.ZaposleniciTableAdapter();
            TaktivanZaposlenik = Adapterzaposlenik.GetDataByAktivanZaposlenik();
            string idAktivan = TaktivanZaposlenik.Rows[0]["id_zaposlenik"].ToString();
            this.txtZaposlenik.Text = idAktivan;
            this.dateTimeRezervacija.ResetText();
            this.txtCijenaTerena.Text = "0";
            this.txtClan.ResetText();
            this.cmbClan.ResetText();
            this.cmbOd.ResetText();
            this.cmbDo.ResetText();

        }

        private void txtCijenaTerena_TextChanged(object sender, EventArgs e)
        {
            SumaIznosa();
        }

 
        
             

        

 

       
    }
}
