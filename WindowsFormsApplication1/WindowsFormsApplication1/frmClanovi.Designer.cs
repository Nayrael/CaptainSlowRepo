namespace WindowsFormsApplication1
{
    partial class frmClanovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClanovi));
            this.clanoviBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pIDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIDataSet1 = new WindowsFormsApplication1.PIDataSet1();
            this.gbRegistracija = new System.Windows.Forms.GroupBox();
            this.chkclanarina = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dateClanarina = new System.Windows.Forms.DateTimePicker();
            this.btnRegistriraj = new System.Windows.Forms.Button();
            this.dateAktivan = new System.Windows.Forms.DateTimePicker();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblSpolR = new System.Windows.Forms.Label();
            this.lblDatumRodenjaR = new System.Windows.Forms.Label();
            this.lblKontaktR = new System.Windows.Forms.Label();
            this.lblPrezimeR = new System.Windows.Forms.Label();
            this.lblImeR = new System.Windows.Forms.Label();
            this.clanoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clanoviTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.ClanoviTableAdapter();
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
            this.clanoviBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.idclanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanarinaplacenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanarinaplacenadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRezervacija = new System.Windows.Forms.DataGridView();
            this.idrezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeprezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezerviranoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.trajanjeodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjedoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkRezervacijeClanovi1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijeTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.RezervacijeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet1)).BeginInit();
            this.gbRegistracija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkRezervacijeClanovi1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clanoviBindingSource1
            // 
            this.clanoviBindingSource1.DataMember = "Clanovi";
            this.clanoviBindingSource1.DataSource = this.pIDataSet1BindingSource;
            // 
            // pIDataSet1BindingSource
            // 
            this.pIDataSet1BindingSource.DataSource = this.pIDataSet1;
            this.pIDataSet1BindingSource.Position = 0;
            // 
            // pIDataSet1
            // 
            this.pIDataSet1.DataSetName = "PIDataSet1";
            this.pIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbRegistracija
            // 
            this.gbRegistracija.Controls.Add(this.chkclanarina);
            this.gbRegistracija.Controls.Add(this.label1);
            this.gbRegistracija.Controls.Add(this.txtID);
            this.gbRegistracija.Controls.Add(this.dateClanarina);
            this.gbRegistracija.Controls.Add(this.btnRegistriraj);
            this.gbRegistracija.Controls.Add(this.dateAktivan);
            this.gbRegistracija.Controls.Add(this.txtPrezime);
            this.gbRegistracija.Controls.Add(this.txtIme);
            this.gbRegistracija.Controls.Add(this.lblSpolR);
            this.gbRegistracija.Controls.Add(this.lblDatumRodenjaR);
            this.gbRegistracija.Controls.Add(this.lblKontaktR);
            this.gbRegistracija.Controls.Add(this.lblPrezimeR);
            this.gbRegistracija.Controls.Add(this.lblImeR);
            this.gbRegistracija.Location = new System.Drawing.Point(12, 31);
            this.gbRegistracija.Name = "gbRegistracija";
            this.gbRegistracija.Size = new System.Drawing.Size(305, 276);
            this.gbRegistracija.TabIndex = 9;
            this.gbRegistracija.TabStop = false;
            this.gbRegistracija.Text = "Podaci:";
            // 
            // chkclanarina
            // 
            this.chkclanarina.AutoSize = true;
            this.chkclanarina.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clanoviBindingSource1, "clanarina_placena", true));
            this.chkclanarina.Location = new System.Drawing.Point(107, 135);
            this.chkclanarina.Name = "chkclanarina";
            this.chkclanarina.Size = new System.Drawing.Size(40, 17);
            this.chkclanarina.TabIndex = 22;
            this.chkclanarina.Text = "Da";
            this.chkclanarina.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clanoviBindingSource1, "id_clan", true));
            this.txtID.Location = new System.Drawing.Point(105, 19);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 20;
            // 
            // dateClanarina
            // 
            this.dateClanarina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clanoviBindingSource1, "clanarina_placena_do", true));
            this.dateClanarina.Location = new System.Drawing.Point(45, 208);
            this.dateClanarina.Name = "dateClanarina";
            this.dateClanarina.Size = new System.Drawing.Size(200, 20);
            this.dateClanarina.TabIndex = 19;
            // 
            // btnRegistriraj
            // 
            this.btnRegistriraj.Location = new System.Drawing.Point(160, 234);
            this.btnRegistriraj.Name = "btnRegistriraj";
            this.btnRegistriraj.Size = new System.Drawing.Size(85, 31);
            this.btnRegistriraj.TabIndex = 18;
            this.btnRegistriraj.Text = "Registriraj";
            this.btnRegistriraj.UseVisualStyleBackColor = true;
            this.btnRegistriraj.Click += new System.EventHandler(this.btnRegistriraj_Click);
            // 
            // dateAktivan
            // 
            this.dateAktivan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clanoviBindingSource1, "aktivan_od", true));
            this.dateAktivan.Location = new System.Drawing.Point(105, 104);
            this.dateAktivan.Name = "dateAktivan";
            this.dateAktivan.Size = new System.Drawing.Size(130, 20);
            this.dateAktivan.TabIndex = 15;
            // 
            // txtPrezime
            // 
            this.txtPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clanoviBindingSource1, "prezime", true));
            this.txtPrezime.Location = new System.Drawing.Point(105, 75);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 14;
            // 
            // txtIme
            // 
            this.txtIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clanoviBindingSource1, "ime", true));
            this.txtIme.Location = new System.Drawing.Point(105, 49);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 9;
            // 
            // lblSpolR
            // 
            this.lblSpolR.AutoSize = true;
            this.lblSpolR.Location = new System.Drawing.Point(6, 135);
            this.lblSpolR.Name = "lblSpolR";
            this.lblSpolR.Size = new System.Drawing.Size(95, 13);
            this.lblSpolR.TabIndex = 5;
            this.lblSpolR.Text = "Članarina plaćena:";
            // 
            // lblDatumRodenjaR
            // 
            this.lblDatumRodenjaR.AutoSize = true;
            this.lblDatumRodenjaR.Location = new System.Drawing.Point(28, 104);
            this.lblDatumRodenjaR.Name = "lblDatumRodenjaR";
            this.lblDatumRodenjaR.Size = new System.Drawing.Size(61, 13);
            this.lblDatumRodenjaR.TabIndex = 4;
            this.lblDatumRodenjaR.Text = "Aktivan od:";
            // 
            // lblKontaktR
            // 
            this.lblKontaktR.AutoSize = true;
            this.lblKontaktR.Location = new System.Drawing.Point(6, 169);
            this.lblKontaktR.Name = "lblKontaktR";
            this.lblKontaktR.Size = new System.Drawing.Size(110, 13);
            this.lblKontaktR.TabIndex = 2;
            this.lblKontaktR.Text = "Članarina plaćena do:";
            // 
            // lblPrezimeR
            // 
            this.lblPrezimeR.AutoSize = true;
            this.lblPrezimeR.Location = new System.Drawing.Point(42, 78);
            this.lblPrezimeR.Name = "lblPrezimeR";
            this.lblPrezimeR.Size = new System.Drawing.Size(47, 13);
            this.lblPrezimeR.TabIndex = 1;
            this.lblPrezimeR.Text = "Prezime:";
            // 
            // lblImeR
            // 
            this.lblImeR.AutoSize = true;
            this.lblImeR.Location = new System.Drawing.Point(62, 56);
            this.lblImeR.Name = "lblImeR";
            this.lblImeR.Size = new System.Drawing.Size(27, 13);
            this.lblImeR.TabIndex = 0;
            this.lblImeR.Text = "Ime:";
            // 
            // clanoviBindingSource
            // 
            this.clanoviBindingSource.DataMember = "Clanovi";
            this.clanoviBindingSource.DataSource = this.pIDataSet1BindingSource;
            // 
            // clanoviTableAdapter
            // 
            this.clanoviTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.clanoviBindingSource1;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(991, 25);
            this.bindingNavigator1.TabIndex = 10;
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
            // clanoviBindingSource2
            // 
            this.clanoviBindingSource2.DataMember = "Clanovi";
            this.clanoviBindingSource2.DataSource = this.pIDataSet1;
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.AutoGenerateColumns = false;
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclanDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.aktivanodDataGridViewTextBoxColumn,
            this.clanarinaplacenaDataGridViewTextBoxColumn,
            this.clanarinaplacenadoDataGridViewTextBoxColumn});
            this.dgvClanovi.DataSource = this.clanoviBindingSource1;
            this.dgvClanovi.Location = new System.Drawing.Point(335, 40);
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.Size = new System.Drawing.Size(644, 256);
            this.dgvClanovi.TabIndex = 11;
            // 
            // idclanDataGridViewTextBoxColumn
            // 
            this.idclanDataGridViewTextBoxColumn.DataPropertyName = "id_clan";
            this.idclanDataGridViewTextBoxColumn.HeaderText = "id_clan";
            this.idclanDataGridViewTextBoxColumn.Name = "idclanDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // aktivanodDataGridViewTextBoxColumn
            // 
            this.aktivanodDataGridViewTextBoxColumn.DataPropertyName = "aktivan_od";
            this.aktivanodDataGridViewTextBoxColumn.HeaderText = "aktivan_od";
            this.aktivanodDataGridViewTextBoxColumn.Name = "aktivanodDataGridViewTextBoxColumn";
            // 
            // clanarinaplacenaDataGridViewTextBoxColumn
            // 
            this.clanarinaplacenaDataGridViewTextBoxColumn.DataPropertyName = "clanarina_placena";
            this.clanarinaplacenaDataGridViewTextBoxColumn.HeaderText = "clanarina_placena";
            this.clanarinaplacenaDataGridViewTextBoxColumn.Name = "clanarinaplacenaDataGridViewTextBoxColumn";
            // 
            // clanarinaplacenadoDataGridViewTextBoxColumn
            // 
            this.clanarinaplacenadoDataGridViewTextBoxColumn.DataPropertyName = "clanarina_placena_do";
            this.clanarinaplacenadoDataGridViewTextBoxColumn.HeaderText = "clanarina_placena_do";
            this.clanarinaplacenadoDataGridViewTextBoxColumn.Name = "clanarinaplacenadoDataGridViewTextBoxColumn";
            // 
            // dgvRezervacija
            // 
            this.dgvRezervacija.AutoGenerateColumns = false;
            this.dgvRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrezervacijaDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.clanDataGridViewTextBoxColumn,
            this.imeprezimeDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.rezerviranoDataGridViewCheckBoxColumn,
            this.trajanjeodDataGridViewTextBoxColumn,
            this.trajanjedoDataGridViewTextBoxColumn,
            this.terenDataGridViewTextBoxColumn});
            this.dgvRezervacija.DataSource = this.fkRezervacijeClanovi1BindingSource;
            this.dgvRezervacija.Location = new System.Drawing.Point(21, 313);
            this.dgvRezervacija.Name = "dgvRezervacija";
            this.dgvRezervacija.Size = new System.Drawing.Size(958, 167);
            this.dgvRezervacija.TabIndex = 12;
            // 
            // idrezervacijaDataGridViewTextBoxColumn
            // 
            this.idrezervacijaDataGridViewTextBoxColumn.DataPropertyName = "id_rezervacija";
            this.idrezervacijaDataGridViewTextBoxColumn.HeaderText = "id_rezervacija";
            this.idrezervacijaDataGridViewTextBoxColumn.Name = "idrezervacijaDataGridViewTextBoxColumn";
            // 
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            // 
            // clanDataGridViewTextBoxColumn
            // 
            this.clanDataGridViewTextBoxColumn.DataPropertyName = "clan";
            this.clanDataGridViewTextBoxColumn.HeaderText = "clan";
            this.clanDataGridViewTextBoxColumn.Name = "clanDataGridViewTextBoxColumn";
            // 
            // imeprezimeDataGridViewTextBoxColumn
            // 
            this.imeprezimeDataGridViewTextBoxColumn.DataPropertyName = "ime_prezime";
            this.imeprezimeDataGridViewTextBoxColumn.HeaderText = "ime_prezime";
            this.imeprezimeDataGridViewTextBoxColumn.Name = "imeprezimeDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // rezerviranoDataGridViewCheckBoxColumn
            // 
            this.rezerviranoDataGridViewCheckBoxColumn.DataPropertyName = "rezervirano";
            this.rezerviranoDataGridViewCheckBoxColumn.HeaderText = "rezervirano";
            this.rezerviranoDataGridViewCheckBoxColumn.Name = "rezerviranoDataGridViewCheckBoxColumn";
            // 
            // trajanjeodDataGridViewTextBoxColumn
            // 
            this.trajanjeodDataGridViewTextBoxColumn.DataPropertyName = "trajanje_od";
            this.trajanjeodDataGridViewTextBoxColumn.HeaderText = "trajanje_od";
            this.trajanjeodDataGridViewTextBoxColumn.Name = "trajanjeodDataGridViewTextBoxColumn";
            // 
            // trajanjedoDataGridViewTextBoxColumn
            // 
            this.trajanjedoDataGridViewTextBoxColumn.DataPropertyName = "trajanje_do";
            this.trajanjedoDataGridViewTextBoxColumn.HeaderText = "trajanje_do";
            this.trajanjedoDataGridViewTextBoxColumn.Name = "trajanjedoDataGridViewTextBoxColumn";
            // 
            // terenDataGridViewTextBoxColumn
            // 
            this.terenDataGridViewTextBoxColumn.DataPropertyName = "teren";
            this.terenDataGridViewTextBoxColumn.HeaderText = "teren";
            this.terenDataGridViewTextBoxColumn.Name = "terenDataGridViewTextBoxColumn";
            // 
            // fkRezervacijeClanovi1BindingSource
            // 
            this.fkRezervacijeClanovi1BindingSource.DataMember = "fk_Rezervacije_Clanovi1";
            this.fkRezervacijeClanovi1BindingSource.DataSource = this.clanoviBindingSource1;
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataMember = "Rezervacije";
            this.rezervacijeBindingSource.DataSource = this.pIDataSet1BindingSource;
            // 
            // rezervacijeTableAdapter
            // 
            this.rezervacijeTableAdapter.ClearBeforeFill = true;
            // 
            // frmClanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 490);
            this.Controls.Add(this.dgvRezervacija);
            this.Controls.Add(this.dgvClanovi);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.gbRegistracija);
            this.Name = "frmClanovi";
            this.Text = "Članovi";
            this.Load += new System.EventHandler(this.frmClanovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clanoviBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet1)).EndInit();
            this.gbRegistracija.ResumeLayout(false);
            this.gbRegistracija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkRezervacijeClanovi1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistracija;
        private System.Windows.Forms.Button btnRegistriraj;
        private System.Windows.Forms.DateTimePicker dateAktivan;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblSpolR;
        private System.Windows.Forms.Label lblDatumRodenjaR;
        private System.Windows.Forms.Label lblKontaktR;
        private System.Windows.Forms.Label lblPrezimeR;
        private System.Windows.Forms.Label lblImeR;
        private System.Windows.Forms.DateTimePicker dateClanarina;
        private System.Windows.Forms.BindingSource pIDataSet1BindingSource;
        private PIDataSet1 pIDataSet1;
        private System.Windows.Forms.BindingSource clanoviBindingSource;
        private PIDataSet1TableAdapters.ClanoviTableAdapter clanoviTableAdapter;
        private System.Windows.Forms.BindingSource clanoviBindingSource1;
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
        private System.Windows.Forms.BindingSource clanoviBindingSource2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivanodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanarinaplacenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanarinaplacenadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvRezervacija;
        private System.Windows.Forms.BindingSource rezervacijeBindingSource;
        private PIDataSet1TableAdapters.RezervacijeTableAdapter rezervacijeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrezervacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeprezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rezerviranoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjedoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fkRezervacijeClanovi1BindingSource;
        private System.Windows.Forms.CheckBox chkclanarina;
    }
}