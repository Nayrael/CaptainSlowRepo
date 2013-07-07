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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervacija));
            this.dataGridStavkeRezervacije = new System.Windows.Forms.DataGridView();
            this.iduslugaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uslugeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIDataSet11 = new WindowsFormsApplication1.PIDataSet1();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKStavkerezervacijeRezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIDataSet1 = new WindowsFormsApplication1.PIDataSet1();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblClan = new System.Windows.Forms.Label();
            this.lblUkupanIznos = new System.Windows.Forms.Label();
            this.txtClan = new System.Windows.Forms.TextBox();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.dateTimeRezervacija = new System.Windows.Forms.DateTimePicker();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.rezervacijeTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.RezervacijeTableAdapter();
            this.stavke_rezervacijeTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.Stavke_rezervacijeTableAdapter();
            this.lblTeren = new System.Windows.Forms.Label();
            this.cmbTeren = new System.Windows.Forms.ComboBox();
            this.tereniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tereniTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.TereniTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtIdRezervacije = new System.Windows.Forms.TextBox();
            this.lblIdRezervacije = new System.Windows.Forms.Label();
            this.uslugeTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.UslugeTableAdapter();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblCrta = new System.Windows.Forms.Label();
            this.txtCijenaTerena = new System.Windows.Forms.TextBox();
            this.lblCijenaTerena = new System.Windows.Forms.Label();
            this.cmbOd = new System.Windows.Forms.ComboBox();
            this.cmbDo = new System.Windows.Forms.ComboBox();
            this.cmbClan = new System.Windows.Forms.ComboBox();
            this.clanoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clanoviTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.ClanoviTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStavkeRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStavkerezervacijeRezervacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tereniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStavkeRezervacije
            // 
            this.dataGridStavkeRezervacije.AutoGenerateColumns = false;
            this.dataGridStavkeRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStavkeRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iduslugaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.jedinicnacijenaDataGridViewTextBoxColumn});
            this.dataGridStavkeRezervacije.DataSource = this.fKStavkerezervacijeRezervacijeBindingSource;
            this.dataGridStavkeRezervacije.Location = new System.Drawing.Point(18, 177);
            this.dataGridStavkeRezervacije.Name = "dataGridStavkeRezervacije";
            this.dataGridStavkeRezervacije.Size = new System.Drawing.Size(481, 171);
            this.dataGridStavkeRezervacije.TabIndex = 1;
            this.dataGridStavkeRezervacije.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStavkeRezervacije_CellValueChanged);
            this.dataGridStavkeRezervacije.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStavkeRezervacije_RowValidated);
            // 
            // iduslugaDataGridViewTextBoxColumn
            // 
            this.iduslugaDataGridViewTextBoxColumn.DataPropertyName = "id_usluga";
            this.iduslugaDataGridViewTextBoxColumn.DataSource = this.uslugeBindingSource;
            this.iduslugaDataGridViewTextBoxColumn.DisplayMember = "imeUsluge";
            this.iduslugaDataGridViewTextBoxColumn.HeaderText = "Usluga";
            this.iduslugaDataGridViewTextBoxColumn.Name = "iduslugaDataGridViewTextBoxColumn";
            this.iduslugaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iduslugaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iduslugaDataGridViewTextBoxColumn.ValueMember = "id_usluga";
            // 
            // uslugeBindingSource
            // 
            this.uslugeBindingSource.DataMember = "Usluge";
            this.uslugeBindingSource.DataSource = this.pIDataSet11;
            // 
            // pIDataSet11
            // 
            this.pIDataSet11.DataSetName = "PIDataSet1";
            this.pIDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // jedinicnacijenaDataGridViewTextBoxColumn
            // 
            this.jedinicnacijenaDataGridViewTextBoxColumn.DataPropertyName = "jedinicna_cijena";
            this.jedinicnacijenaDataGridViewTextBoxColumn.HeaderText = "Jedinična Cijena";
            this.jedinicnacijenaDataGridViewTextBoxColumn.Name = "jedinicnacijenaDataGridViewTextBoxColumn";
            // 
            // fKStavkerezervacijeRezervacijeBindingSource
            // 
            this.fKStavkerezervacijeRezervacijeBindingSource.DataMember = "FK_Stavke_rezervacije_Rezervacije";
            this.fKStavkerezervacijeRezervacijeBindingSource.DataSource = this.rezervacijeBindingSource;
            this.fKStavkerezervacijeRezervacijeBindingSource.Filter = "";
            this.fKStavkerezervacijeRezervacijeBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.fKStavkerezervacijeRezervacijeBindingSource_ListChanged);
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataMember = "Rezervacije";
            this.rezervacijeBindingSource.DataSource = this.pIDataSet1;
            this.rezervacijeBindingSource.CurrentItemChanged += new System.EventHandler(this.rezervacijeBindingSource_CurrentItemChanged);
            // 
            // pIDataSet1
            // 
            this.pIDataSet1.DataSetName = "PIDataSet1";
            this.pIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(20, 118);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(72, 13);
            this.lblImePrezime.TabIndex = 2;
            this.lblImePrezime.Text = "Ime i Prezime:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(51, 140);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "Datum:";
            // 
            // lblClan
            // 
            this.lblClan.AutoSize = true;
            this.lblClan.Location = new System.Drawing.Point(61, 92);
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
            // txtClan
            // 
            this.txtClan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijeBindingSource, "clan", true));
            this.txtClan.Location = new System.Drawing.Point(108, 85);
            this.txtClan.Name = "txtClan";
            this.txtClan.ReadOnly = true;
            this.txtClan.Size = new System.Drawing.Size(130, 20);
            this.txtClan.TabIndex = 9;
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(92, 354);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(81, 20);
            this.txtUkupno.TabIndex = 13;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(424, 380);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(75, 23);
            this.btnRezerviraj.TabIndex = 23;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRezerviraj_MouseClick);
            // 
            // dateTimeRezervacija
            // 
            this.dateTimeRezervacija.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijeBindingSource, "datum", true));
            this.dateTimeRezervacija.Location = new System.Drawing.Point(108, 140);
            this.dateTimeRezervacija.Name = "dateTimeRezervacija";
            this.dateTimeRezervacija.Size = new System.Drawing.Size(130, 20);
            this.dateTimeRezervacija.TabIndex = 25;
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijeBindingSource, "zaposlenik", true));
            this.txtZaposlenik.Location = new System.Drawing.Point(356, 140);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.ReadOnly = true;
            this.txtZaposlenik.Size = new System.Drawing.Size(130, 20);
            this.txtZaposlenik.TabIndex = 27;
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(278, 143);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(62, 13);
            this.lblZaposlenik.TabIndex = 26;
            this.lblZaposlenik.Text = "Zaposlenik:";
            // 
            // rezervacijeTableAdapter
            // 
            this.rezervacijeTableAdapter.ClearBeforeFill = true;
            // 
            // stavke_rezervacijeTableAdapter
            // 
            this.stavke_rezervacijeTableAdapter.ClearBeforeFill = true;
            // 
            // lblTeren
            // 
            this.lblTeren.AutoSize = true;
            this.lblTeren.Location = new System.Drawing.Point(303, 61);
            this.lblTeren.Name = "lblTeren";
            this.lblTeren.Size = new System.Drawing.Size(38, 13);
            this.lblTeren.TabIndex = 32;
            this.lblTeren.Text = "Teren:";
            // 
            // cmbTeren
            // 
            this.cmbTeren.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rezervacijeBindingSource, "teren", true));
            this.cmbTeren.DataSource = this.tereniBindingSource;
            this.cmbTeren.DisplayMember = "Opis";
            this.cmbTeren.FormattingEnabled = true;
            this.cmbTeren.Location = new System.Drawing.Point(356, 54);
            this.cmbTeren.Name = "cmbTeren";
            this.cmbTeren.Size = new System.Drawing.Size(130, 21);
            this.cmbTeren.TabIndex = 33;
            this.cmbTeren.ValueMember = "id_teren";
            this.cmbTeren.Validated += new System.EventHandler(this.cmbTeren_Validated);
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
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.rezervacijeBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(518, 25);
            this.bindingNavigator1.TabIndex = 34;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txtIdRezervacije
            // 
            this.txtIdRezervacije.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijeBindingSource, "id_rezervacija", true));
            this.txtIdRezervacije.Location = new System.Drawing.Point(108, 54);
            this.txtIdRezervacije.Name = "txtIdRezervacije";
            this.txtIdRezervacije.ReadOnly = true;
            this.txtIdRezervacije.Size = new System.Drawing.Size(130, 20);
            this.txtIdRezervacije.TabIndex = 36;
            // 
            // lblIdRezervacije
            // 
            this.lblIdRezervacije.AutoSize = true;
            this.lblIdRezervacije.Location = new System.Drawing.Point(13, 62);
            this.lblIdRezervacije.Name = "lblIdRezervacije";
            this.lblIdRezervacije.Size = new System.Drawing.Size(82, 13);
            this.lblIdRezervacije.TabIndex = 35;
            this.lblIdRezervacije.Text = "Br. Rezervacije:";
            // 
            // uslugeTableAdapter
            // 
            this.uslugeTableAdapter.ClearBeforeFill = true;
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Location = new System.Drawing.Point(259, 88);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(82, 13);
            this.lblTrajanje.TabIndex = 37;
            this.lblTrajanje.Text = "Trajanje(Od-Do)";
            // 
            // lblCrta
            // 
            this.lblCrta.AutoSize = true;
            this.lblCrta.Location = new System.Drawing.Point(417, 86);
            this.lblCrta.Name = "lblCrta";
            this.lblCrta.Size = new System.Drawing.Size(10, 13);
            this.lblCrta.TabIndex = 39;
            this.lblCrta.Text = "-";
            // 
            // txtCijenaTerena
            // 
            this.txtCijenaTerena.Location = new System.Drawing.Point(356, 114);
            this.txtCijenaTerena.Name = "txtCijenaTerena";
            this.txtCijenaTerena.ReadOnly = true;
            this.txtCijenaTerena.Size = new System.Drawing.Size(130, 20);
            this.txtCijenaTerena.TabIndex = 42;
            this.txtCijenaTerena.Text = "0";
            this.txtCijenaTerena.TextChanged += new System.EventHandler(this.txtCijenaTerena_TextChanged);
            // 
            // lblCijenaTerena
            // 
            this.lblCijenaTerena.AutoSize = true;
            this.lblCijenaTerena.Location = new System.Drawing.Point(301, 118);
            this.lblCijenaTerena.Name = "lblCijenaTerena";
            this.lblCijenaTerena.Size = new System.Drawing.Size(39, 13);
            this.lblCijenaTerena.TabIndex = 41;
            this.lblCijenaTerena.Text = "Cijena:";
            // 
            // cmbOd
            // 
            this.cmbOd.FormattingEnabled = true;
            this.cmbOd.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbOd.Location = new System.Drawing.Point(375, 85);
            this.cmbOd.Name = "cmbOd";
            this.cmbOd.Size = new System.Drawing.Size(36, 21);
            this.cmbOd.TabIndex = 43;
            this.cmbOd.TextChanged += new System.EventHandler(this.cmbOd_TextChanged);
            // 
            // cmbDo
            // 
            this.cmbDo.FormattingEnabled = true;
            this.cmbDo.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbDo.Location = new System.Drawing.Point(433, 85);
            this.cmbDo.Name = "cmbDo";
            this.cmbDo.Size = new System.Drawing.Size(36, 21);
            this.cmbDo.TabIndex = 44;
            this.cmbDo.TextChanged += new System.EventHandler(this.cmbDo_TextChanged);
            // 
            // cmbClan
            // 
            this.cmbClan.FormattingEnabled = true;
            this.cmbClan.Location = new System.Drawing.Point(108, 113);
            this.cmbClan.Name = "cmbClan";
            this.cmbClan.Size = new System.Drawing.Size(130, 21);
            this.cmbClan.TabIndex = 45;
            this.cmbClan.SelectedIndexChanged += new System.EventHandler(this.cmbClan_SelectedIndexChanged);
            // 
            // clanoviBindingSource
            // 
            this.clanoviBindingSource.DataMember = "Clanovi";
            this.clanoviBindingSource.DataSource = this.pIDataSet11;
            // 
            // clanoviTableAdapter
            // 
            this.clanoviTableAdapter.ClearBeforeFill = true;
            // 
            // frmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 432);
            this.Controls.Add(this.cmbClan);
            this.Controls.Add(this.cmbDo);
            this.Controls.Add(this.cmbOd);
            this.Controls.Add(this.txtCijenaTerena);
            this.Controls.Add(this.lblCijenaTerena);
            this.Controls.Add(this.lblCrta);
            this.Controls.Add(this.lblTrajanje);
            this.Controls.Add(this.txtIdRezervacije);
            this.Controls.Add(this.lblIdRezervacije);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.cmbTeren);
            this.Controls.Add(this.lblTeren);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.dateTimeRezervacija);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.txtClan);
            this.Controls.Add(this.lblUkupanIznos);
            this.Controls.Add(this.lblClan);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.dataGridStavkeRezervacije);
            this.Name = "frmRezervacija";
            this.Text = "Rezervacija";
            this.Load += new System.EventHandler(this.frmRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStavkeRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStavkerezervacijeRezervacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tereniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStavkeRezervacije;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblClan;
        private System.Windows.Forms.Label lblUkupanIznos;
        private System.Windows.Forms.TextBox txtClan;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.DateTimePicker dateTimeRezervacija;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.Label lblZaposlenik; 
        private System.Windows.Forms.BindingSource ZaposleniciBindingSource;
        private PIDataSet1 pIDataSet1;
        private System.Windows.Forms.BindingSource rezervacijeBindingSource;
        private PIDataSet1TableAdapters.RezervacijeTableAdapter rezervacijeTableAdapter;
        private System.Windows.Forms.BindingSource fKStavkerezervacijeRezervacijeBindingSource;
        private PIDataSet1TableAdapters.Stavke_rezervacijeTableAdapter stavke_rezervacijeTableAdapter;
        private System.Windows.Forms.Label lblTeren;
        private System.Windows.Forms.ComboBox cmbTeren;
        private System.Windows.Forms.BindingSource tereniBindingSource;
        private PIDataSet1TableAdapters.TereniTableAdapter tereniTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox txtIdRezervacije;
        private System.Windows.Forms.Label lblIdRezervacije;
        private PIDataSet1 pIDataSet11;
        private System.Windows.Forms.BindingSource uslugeBindingSource;
        private PIDataSet1TableAdapters.UslugeTableAdapter uslugeTableAdapter;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label lblCrta;
        private System.Windows.Forms.TextBox txtCijenaTerena;
        private System.Windows.Forms.Label lblCijenaTerena;
        private System.Windows.Forms.ComboBox cmbOd;
        private System.Windows.Forms.ComboBox cmbDo;
        private System.Windows.Forms.ComboBox cmbClan;
        private System.Windows.Forms.BindingSource clanoviBindingSource;
        private PIDataSet1TableAdapters.ClanoviTableAdapter clanoviTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn iduslugaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnacijenaDataGridViewTextBoxColumn;
    }
}