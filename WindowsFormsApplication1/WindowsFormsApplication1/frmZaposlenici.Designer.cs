namespace WindowsFormsApplication1
{
    partial class frmZaposlenici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZaposlenici));
            this.gbRegistracija = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIDataSet1 = new WindowsFormsApplication1.PIDataSet1();
            this.lblAktivan = new System.Windows.Forms.Label();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblprezime = new System.Windows.Forms.Label();
            this.lblime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnRegistriraj = new System.Windows.Forms.Button();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPrezimeR = new System.Windows.Forms.Label();
            this.lblImeR = new System.Windows.Forms.Label();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.idzaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.zaposleniciTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.ZaposleniciTableAdapter();
            this.clanoviTableAdapter1 = new WindowsFormsApplication1.PIDataSet1TableAdapters.ClanoviTableAdapter();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.idrezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeprezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezerviranoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.trajanjeodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjedoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkRezervacijeZaposlenici1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIDataSet11 = new WindowsFormsApplication1.PIDataSet1();
            this.rezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijeTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.RezervacijeTableAdapter();
            this.zaposleniciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gbRegistracija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkRezervacijeZaposlenici1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRegistracija
            // 
            this.gbRegistracija.Controls.Add(this.checkBox1);
            this.gbRegistracija.Controls.Add(this.lblAktivan);
            this.gbRegistracija.Controls.Add(this.txtOib);
            this.gbRegistracija.Controls.Add(this.label2);
            this.gbRegistracija.Controls.Add(this.txtPass);
            this.gbRegistracija.Controls.Add(this.txtUsername);
            this.gbRegistracija.Controls.Add(this.lblprezime);
            this.gbRegistracija.Controls.Add(this.lblime);
            this.gbRegistracija.Controls.Add(this.label1);
            this.gbRegistracija.Controls.Add(this.txtID);
            this.gbRegistracija.Controls.Add(this.btnRegistriraj);
            this.gbRegistracija.Controls.Add(this.txtPrezime);
            this.gbRegistracija.Controls.Add(this.txtIme);
            this.gbRegistracija.Controls.Add(this.lblPrezimeR);
            this.gbRegistracija.Controls.Add(this.lblImeR);
            this.gbRegistracija.Location = new System.Drawing.Point(12, 41);
            this.gbRegistracija.Name = "gbRegistracija";
            this.gbRegistracija.Size = new System.Drawing.Size(253, 284);
            this.gbRegistracija.TabIndex = 10;
            this.gbRegistracija.TabStop = false;
            this.gbRegistracija.Text = "Podaci:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.zaposleniciBindingSource, "aktivan", true));
            this.checkBox1.Location = new System.Drawing.Point(103, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(40, 17);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Da";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataMember = "Zaposlenici";
            this.zaposleniciBindingSource.DataSource = this.pIDataSet1;
            // 
            // pIDataSet1
            // 
            this.pIDataSet1.DataSetName = "PIDataSet1";
            this.pIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblAktivan
            // 
            this.lblAktivan.AutoSize = true;
            this.lblAktivan.Location = new System.Drawing.Point(35, 164);
            this.lblAktivan.Name = "lblAktivan";
            this.lblAktivan.Size = new System.Drawing.Size(46, 13);
            this.lblAktivan.TabIndex = 28;
            this.lblAktivan.Text = "Aktivan:";
            // 
            // txtOib
            // 
            this.txtOib.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtOib.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposleniciBindingSource, "OIB", true));
            this.txtOib.Location = new System.Drawing.Point(103, 187);
            this.txtOib.MaxLength = 11;
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(134, 20);
            this.txtOib.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "OIB:";
            // 
            // txtPass
            // 
            this.txtPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposleniciBindingSource, "password", true));
            this.txtPass.Location = new System.Drawing.Point(103, 132);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(134, 20);
            this.txtPass.TabIndex = 25;
            // 
            // txtUsername
            // 
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposleniciBindingSource, "username", true));
            this.txtUsername.Location = new System.Drawing.Point(103, 104);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(134, 20);
            this.txtUsername.TabIndex = 24;
            // 
            // lblprezime
            // 
            this.lblprezime.AutoSize = true;
            this.lblprezime.Location = new System.Drawing.Point(35, 139);
            this.lblprezime.Name = "lblprezime";
            this.lblprezime.Size = new System.Drawing.Size(47, 13);
            this.lblprezime.TabIndex = 23;
            this.lblprezime.Text = "Lozinka:";
            // 
            // lblime
            // 
            this.lblime.AutoSize = true;
            this.lblime.Location = new System.Drawing.Point(13, 108);
            this.lblime.Name = "lblime";
            this.lblime.Size = new System.Drawing.Size(78, 13);
            this.lblime.TabIndex = 22;
            this.lblime.Text = "Korisničko ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposleniciBindingSource, "id_zaposlenik", true));
            this.txtID.Location = new System.Drawing.Point(103, 17);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 20;
            // 
            // btnRegistriraj
            // 
            this.btnRegistriraj.Location = new System.Drawing.Point(82, 246);
            this.btnRegistriraj.Name = "btnRegistriraj";
            this.btnRegistriraj.Size = new System.Drawing.Size(85, 31);
            this.btnRegistriraj.TabIndex = 18;
            this.btnRegistriraj.Text = "Registriraj";
            this.btnRegistriraj.UseVisualStyleBackColor = true;
            this.btnRegistriraj.Click += new System.EventHandler(this.btnRegistriraj_Click);
            // 
            // txtPrezime
            // 
            this.txtPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposleniciBindingSource, "prezime", true));
            this.txtPrezime.Location = new System.Drawing.Point(103, 77);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(134, 20);
            this.txtPrezime.TabIndex = 14;
            // 
            // txtIme
            // 
            this.txtIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposleniciBindingSource, "ime", true));
            this.txtIme.Location = new System.Drawing.Point(103, 48);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(134, 20);
            this.txtIme.TabIndex = 9;
            // 
            // lblPrezimeR
            // 
            this.lblPrezimeR.AutoSize = true;
            this.lblPrezimeR.Location = new System.Drawing.Point(44, 81);
            this.lblPrezimeR.Name = "lblPrezimeR";
            this.lblPrezimeR.Size = new System.Drawing.Size(47, 13);
            this.lblPrezimeR.TabIndex = 1;
            this.lblPrezimeR.Text = "Prezime:";
            // 
            // lblImeR
            // 
            this.lblImeR.AutoSize = true;
            this.lblImeR.Location = new System.Drawing.Point(64, 55);
            this.lblImeR.Name = "lblImeR";
            this.lblImeR.Size = new System.Drawing.Size(27, 13);
            this.lblImeR.TabIndex = 0;
            this.lblImeR.Text = "Ime:";
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AutoGenerateColumns = false;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzaposlenikDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.aktivanDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn});
            this.dgvZaposlenici.DataSource = this.zaposleniciBindingSource;
            this.dgvZaposlenici.Location = new System.Drawing.Point(271, 41);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.Size = new System.Drawing.Size(765, 284);
            this.dgvZaposlenici.TabIndex = 11;
            // 
            // idzaposlenikDataGridViewTextBoxColumn
            // 
            this.idzaposlenikDataGridViewTextBoxColumn.DataPropertyName = "id_zaposlenik";
            this.idzaposlenikDataGridViewTextBoxColumn.HeaderText = "id_zaposlenik";
            this.idzaposlenikDataGridViewTextBoxColumn.Name = "idzaposlenikDataGridViewTextBoxColumn";
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
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // aktivanDataGridViewTextBoxColumn
            // 
            this.aktivanDataGridViewTextBoxColumn.DataPropertyName = "aktivan";
            this.aktivanDataGridViewTextBoxColumn.HeaderText = "aktivan";
            this.aktivanDataGridViewTextBoxColumn.Name = "aktivanDataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.zaposleniciBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1046, 25);
            this.bindingNavigator1.TabIndex = 12;
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
            // zaposleniciTableAdapter
            // 
            this.zaposleniciTableAdapter.ClearBeforeFill = true;
            // 
            // clanoviTableAdapter1
            // 
            this.clanoviTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AutoGenerateColumns = false;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrezervacijaDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.clanDataGridViewTextBoxColumn,
            this.imeprezimeDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.rezerviranoDataGridViewCheckBoxColumn,
            this.trajanjeodDataGridViewTextBoxColumn,
            this.trajanjedoDataGridViewTextBoxColumn,
            this.terenDataGridViewTextBoxColumn});
            this.dgvRezervacije.DataSource = this.fkRezervacijeZaposlenici1BindingSource;
            this.dgvRezervacije.Location = new System.Drawing.Point(12, 331);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.Size = new System.Drawing.Size(1024, 224);
            this.dgvRezervacije.TabIndex = 13;
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
            // fkRezervacijeZaposlenici1BindingSource
            // 
            this.fkRezervacijeZaposlenici1BindingSource.DataMember = "fk_Rezervacije_Zaposlenici1";
            this.fkRezervacijeZaposlenici1BindingSource.DataSource = this.zaposleniciBindingSource;
            // 
            // pIDataSet11
            // 
            this.pIDataSet11.DataSetName = "PIDataSet1";
            this.pIDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataMember = "Rezervacije";
            this.rezervacijeBindingSource.DataSource = this.pIDataSet11;
            // 
            // rezervacijeTableAdapter
            // 
            this.rezervacijeTableAdapter.ClearBeforeFill = true;
            // 
            // zaposleniciBindingSource1
            // 
            this.zaposleniciBindingSource1.DataMember = "Zaposlenici";
            this.zaposleniciBindingSource1.DataSource = this.pIDataSet1;
            // 
            // frmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 564);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.gbRegistracija);
            this.Name = "frmZaposlenici";
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.frmZaposlenici_Load);
            this.gbRegistracija.ResumeLayout(false);
            this.gbRegistracija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkRezervacijeZaposlenici1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistracija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnRegistriraj;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezimeR;
        private System.Windows.Forms.Label lblImeR;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private PIDataSet1 pIDataSet1;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private PIDataSet1TableAdapters.ZaposleniciTableAdapter zaposleniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblprezime;
        private System.Windows.Forms.Label lblime;
        private PIDataSet1TableAdapters.ClanoviTableAdapter clanoviTableAdapter1;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAktivan;
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
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private PIDataSet1 pIDataSet11;
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
        private System.Windows.Forms.BindingSource fkRezervacijeZaposlenici1BindingSource;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource1;

    }
}