namespace WindowsFormsApplication1
{
    partial class frmRezervacija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tereniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.članoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slobodniTerminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idstavkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduslugaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKStavkerezervacijeRezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIDataSet1 = new WindowsFormsApplication1.PIDataSet1();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblClan = new System.Windows.Forms.Label();
            this.lblUkupanIznos = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtClan = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.dateTimeRezervacija = new System.Windows.Forms.DateTimePicker();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.lblZaposlenik = new System.Windows.Forms.Label(); 
            this.rezervacijeTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.RezervacijeTableAdapter();
            this.stavke_rezervacijeTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.Stavke_rezervacijeTableAdapter();
            this.rezervacijeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timeTrajanjeOd = new System.Windows.Forms.DateTimePicker();
            this.lblTrajanjeOd = new System.Windows.Forms.Label();
            this.timeTrajanjeDo = new System.Windows.Forms.DateTimePicker();
            this.lblTrajanjeDo = new System.Windows.Forms.Label();
            this.lblTeren = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tereniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tereniTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.TereniTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStavkerezervacijeRezervacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tereniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tereniToolStripMenuItem,
            this.članoviToolStripMenuItem,
            this.slobodniTerminiToolStripMenuItem,
            this.pregledRezervacijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tereniToolStripMenuItem
            // 
            this.tereniToolStripMenuItem.Name = "tereniToolStripMenuItem";
            this.tereniToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tereniToolStripMenuItem.Text = "Tereni";
            // 
            // članoviToolStripMenuItem
            // 
            this.članoviToolStripMenuItem.Name = "članoviToolStripMenuItem";
            this.članoviToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.članoviToolStripMenuItem.Text = "Članovi";
            // 
            // slobodniTerminiToolStripMenuItem
            // 
            this.slobodniTerminiToolStripMenuItem.Name = "slobodniTerminiToolStripMenuItem";
            this.slobodniTerminiToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.slobodniTerminiToolStripMenuItem.Text = "Slobodni termini";
            // 
            // pregledRezervacijaToolStripMenuItem
            // 
            this.pregledRezervacijaToolStripMenuItem.Name = "pregledRezervacijaToolStripMenuItem";
            this.pregledRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.pregledRezervacijaToolStripMenuItem.Text = "Pregled rezervacija";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstavkeDataGridViewTextBoxColumn,
            this.idrezervacijeDataGridViewTextBoxColumn,
            this.iduslugaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.jedinicnacijenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKStavkerezervacijeRezervacijeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 171);
            this.dataGridView1.TabIndex = 1;
            // 
            // idstavkeDataGridViewTextBoxColumn
            // 
            this.idstavkeDataGridViewTextBoxColumn.DataPropertyName = "id_stavke";
            this.idstavkeDataGridViewTextBoxColumn.HeaderText = "id_stavke";
            this.idstavkeDataGridViewTextBoxColumn.Name = "idstavkeDataGridViewTextBoxColumn";
            // 
            // idrezervacijeDataGridViewTextBoxColumn
            // 
            this.idrezervacijeDataGridViewTextBoxColumn.DataPropertyName = "id_rezervacije";
            this.idrezervacijeDataGridViewTextBoxColumn.HeaderText = "id_rezervacije";
            this.idrezervacijeDataGridViewTextBoxColumn.Name = "idrezervacijeDataGridViewTextBoxColumn";
            // 
            // iduslugaDataGridViewTextBoxColumn
            // 
            this.iduslugaDataGridViewTextBoxColumn.DataPropertyName = "id_usluga";
            this.iduslugaDataGridViewTextBoxColumn.HeaderText = "id_usluga";
            this.iduslugaDataGridViewTextBoxColumn.Name = "iduslugaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // jedinicnacijenaDataGridViewTextBoxColumn
            // 
            this.jedinicnacijenaDataGridViewTextBoxColumn.DataPropertyName = "jedinicna_cijena";
            this.jedinicnacijenaDataGridViewTextBoxColumn.HeaderText = "jedinicna_cijena";
            this.jedinicnacijenaDataGridViewTextBoxColumn.Name = "jedinicnacijenaDataGridViewTextBoxColumn";
            // 
            // fKStavkerezervacijeRezervacijeBindingSource
            // 
            this.fKStavkerezervacijeRezervacijeBindingSource.DataMember = "FK_Stavke_rezervacije_Rezervacije";
            this.fKStavkerezervacijeRezervacijeBindingSource.DataSource = this.rezervacijeBindingSource;
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataMember = "Rezervacije";
            this.rezervacijeBindingSource.DataSource = this.pIDataSet1;
            // 
            // pIDataSet1
            // 
            this.pIDataSet1.DataSetName = "PIDataSet1";
            this.pIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(53, 102);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(39, 124);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "Datum:";
            // 
            // lblClan
            // 
            this.lblClan.AutoSize = true;
            this.lblClan.Location = new System.Drawing.Point(49, 76);
            this.lblClan.Name = "lblClan";
            this.lblClan.Size = new System.Drawing.Size(31, 13);
            this.lblClan.TabIndex = 4;
            this.lblClan.Text = "Član:";
            // 
            // lblUkupanIznos
            // 
            this.lblUkupanIznos.AutoSize = true;
            this.lblUkupanIznos.Location = new System.Drawing.Point(15, 357);
            this.lblUkupanIznos.Name = "lblUkupanIznos";
            this.lblUkupanIznos.Size = new System.Drawing.Size(71, 13);
            this.lblUkupanIznos.TabIndex = 6;
            this.lblUkupanIznos.Text = "Ukupni iznos:";
            // 
            // txtIme
            // 
            this.txtIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijeBindingSource, "ime_prezime", true));
            this.txtIme.Location = new System.Drawing.Point(92, 95);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(130, 20);
            this.txtIme.TabIndex = 7;
            // 
            // txtClan
            // 
            this.txtClan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijeBindingSource, "clan", true));
            this.txtClan.Location = new System.Drawing.Point(92, 69);
            this.txtClan.Name = "txtClan";
            this.txtClan.Size = new System.Drawing.Size(130, 20);
            this.txtClan.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(92, 354);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(81, 20);
            this.textBox6.TabIndex = 13;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(587, 397);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(75, 23);
            this.btnRezerviraj.TabIndex = 23;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRezerviraj_MouseUp);
            // 
            // dateTimeRezervacija
            // 
            this.dateTimeRezervacija.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rezervacijeBindingSource, "datum", true));
            this.dateTimeRezervacija.Location = new System.Drawing.Point(92, 124);
            this.dateTimeRezervacija.Name = "dateTimeRezervacija";
            this.dateTimeRezervacija.Size = new System.Drawing.Size(130, 20);
            this.dateTimeRezervacija.TabIndex = 25;
            this.dateTimeRezervacija.ValueChanged += new System.EventHandler(this.dateTimeRezervacija_ValueChanged);
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijeBindingSource, "zaposlenik", true));
            this.txtZaposlenik.Location = new System.Drawing.Point(92, 43);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.Size = new System.Drawing.Size(130, 20);
            this.txtZaposlenik.TabIndex = 27;
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(21, 47);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(62, 13);
            this.lblZaposlenik.TabIndex = 26;
            this.lblZaposlenik.Text = "Zaposlenik:";
            // 
            // clanoviTableAdapter
            //  
            // 
            // rezervacijeTableAdapter
            // 
            this.rezervacijeTableAdapter.ClearBeforeFill = true;
            // 
            // stavke_rezervacijeTableAdapter
            // 
            this.stavke_rezervacijeTableAdapter.ClearBeforeFill = true;
            // 
            // rezervacijeBindingSource1
            // 
            this.rezervacijeBindingSource1.DataMember = "Rezervacije";
            this.rezervacijeBindingSource1.DataSource = this.pIDataSet1;
            // 
            // timeTrajanjeOd
            // 
            this.timeTrajanjeOd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rezervacijeBindingSource, "trajanje_od", true));
            this.timeTrajanjeOd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeTrajanjeOd.Location = new System.Drawing.Point(340, 65);
            this.timeTrajanjeOd.Name = "timeTrajanjeOd";
            this.timeTrajanjeOd.Size = new System.Drawing.Size(130, 20);
            this.timeTrajanjeOd.TabIndex = 29;
            // 
            // lblTrajanjeOd
            // 
            this.lblTrajanjeOd.AutoSize = true;
            this.lblTrajanjeOd.Location = new System.Drawing.Point(259, 65);
            this.lblTrajanjeOd.Name = "lblTrajanjeOd";
            this.lblTrajanjeOd.Size = new System.Drawing.Size(65, 13);
            this.lblTrajanjeOd.TabIndex = 28;
            this.lblTrajanjeOd.Text = "Trajanje Od:";
            // 
            // timeTrajanjeDo
            // 
            this.timeTrajanjeDo.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rezervacijeBindingSource, "trajanje_do", true));
            this.timeTrajanjeDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeTrajanjeDo.Location = new System.Drawing.Point(340, 91);
            this.timeTrajanjeDo.Name = "timeTrajanjeDo";
            this.timeTrajanjeDo.Size = new System.Drawing.Size(130, 20);
            this.timeTrajanjeDo.TabIndex = 31;
            // 
            // lblTrajanjeDo
            // 
            this.lblTrajanjeDo.AutoSize = true;
            this.lblTrajanjeDo.Location = new System.Drawing.Point(259, 91);
            this.lblTrajanjeDo.Name = "lblTrajanjeDo";
            this.lblTrajanjeDo.Size = new System.Drawing.Size(65, 13);
            this.lblTrajanjeDo.TabIndex = 30;
            this.lblTrajanjeDo.Text = "Trajanje Do:";
            // 
            // lblTeren
            // 
            this.lblTeren.AutoSize = true;
            this.lblTeren.Location = new System.Drawing.Point(287, 45);
            this.lblTeren.Name = "lblTeren";
            this.lblTeren.Size = new System.Drawing.Size(38, 13);
            this.lblTeren.TabIndex = 32;
            this.lblTeren.Text = "Teren:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rezervacijeBindingSource, "teren", true));
            this.comboBox1.DataSource = this.tereniBindingSource;
            this.comboBox1.DisplayMember = "Opis";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(340, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "id_teren";
            // 
            // tereniBindingSource
            // 
            this.tereniBindingSource.DataMember = "Tereni";
            this.tereniBindingSource.DataSource = this.pIDataSet1;
            // 
            // tereniTableAdapter
            // 
            this.tereniTableAdapter.ClearBeforeFill = true;
            // 
            // frmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 432);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTeren);
            this.Controls.Add(this.timeTrajanjeDo);
            this.Controls.Add(this.lblTrajanjeDo);
            this.Controls.Add(this.timeTrajanjeOd);
            this.Controls.Add(this.lblTrajanjeOd);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.dateTimeRezervacija);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtClan);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblUkupanIznos);
            this.Controls.Add(this.lblClan);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRezervacija";
            this.Text = "Rezervacija";
            this.Load += new System.EventHandler(this.frmRezervacija_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStavkerezervacijeRezervacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tereniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tereniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem članoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slobodniTerminiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblClan;
        private System.Windows.Forms.Label lblUkupanIznos;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtClan;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.ToolStripMenuItem pregledRezervacijaToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimeRezervacija;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.Label lblZaposlenik; 
        private System.Windows.Forms.BindingSource ZaposleniciBindingSource;
        private PIDataSet1 pIDataSet1;
        private System.Windows.Forms.BindingSource rezervacijeBindingSource;
        private PIDataSet1TableAdapters.RezervacijeTableAdapter rezervacijeTableAdapter;
        private System.Windows.Forms.BindingSource fKStavkerezervacijeRezervacijeBindingSource;
        private PIDataSet1TableAdapters.Stavke_rezervacijeTableAdapter stavke_rezervacijeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstavkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduslugaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rezervacijeBindingSource1;
        private System.Windows.Forms.Label lblTrajanjeOd;
        private System.Windows.Forms.DateTimePicker timeTrajanjeDo;
        private System.Windows.Forms.Label lblTrajanjeDo;
        private System.Windows.Forms.Label lblTeren;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tereniBindingSource;
        private PIDataSet1TableAdapters.TereniTableAdapter tereniTableAdapter;
        private System.Windows.Forms.DateTimePicker timeTrajanjeOd;
    }
}