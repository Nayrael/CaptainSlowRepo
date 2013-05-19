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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tereniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.članoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slobodniTerminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.lblUkupanIznos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblPopust = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPocetnoVrijeme = new System.Windows.Forms.Label();
            this.lblZavrsnoVrijeme = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.lblTipTerena = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblOprema = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.gbCijenik = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pregledRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbCijenik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 171);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(81, 262);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(61, 288);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Location = new System.Drawing.Point(61, 317);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(47, 13);
            this.lblKontakt.TabIndex = 4;
            this.lblKontakt.Text = "Kontakt:";
            // 
            // lblUkupanIznos
            // 
            this.lblUkupanIznos.AutoSize = true;
            this.lblUkupanIznos.Location = new System.Drawing.Point(37, 475);
            this.lblUkupanIznos.Name = "lblUkupanIznos";
            this.lblUkupanIznos.Size = new System.Drawing.Size(71, 13);
            this.lblUkupanIznos.TabIndex = 6;
            this.lblUkupanIznos.Text = "Ukupni iznos:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 259);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 311);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 285);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(114, 446);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(81, 20);
            this.textBox5.TabIndex = 11;
            // 
            // lblPopust
            // 
            this.lblPopust.AutoSize = true;
            this.lblPopust.Location = new System.Drawing.Point(65, 449);
            this.lblPopust.Name = "lblPopust";
            this.lblPopust.Size = new System.Drawing.Size(43, 13);
            this.lblPopust.TabIndex = 12;
            this.lblPopust.Text = "Popust:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(114, 472);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(81, 20);
            this.textBox6.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 340);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // lblPocetnoVrijeme
            // 
            this.lblPocetnoVrijeme.AutoSize = true;
            this.lblPocetnoVrijeme.Location = new System.Drawing.Point(22, 346);
            this.lblPocetnoVrijeme.Name = "lblPocetnoVrijeme";
            this.lblPocetnoVrijeme.Size = new System.Drawing.Size(86, 13);
            this.lblPocetnoVrijeme.TabIndex = 16;
            this.lblPocetnoVrijeme.Text = "Početno vrijeme:";
            // 
            // lblZavrsnoVrijeme
            // 
            this.lblZavrsnoVrijeme.AutoSize = true;
            this.lblZavrsnoVrijeme.Location = new System.Drawing.Point(23, 370);
            this.lblZavrsnoVrijeme.Name = "lblZavrsnoVrijeme";
            this.lblZavrsnoVrijeme.Size = new System.Drawing.Size(85, 13);
            this.lblZavrsnoVrijeme.TabIndex = 17;
            this.lblZavrsnoVrijeme.Text = "Završno vrijeme:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(114, 366);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 18;
            // 
            // lblTipTerena
            // 
            this.lblTipTerena.AutoSize = true;
            this.lblTipTerena.Location = new System.Drawing.Point(50, 395);
            this.lblTipTerena.Name = "lblTipTerena";
            this.lblTipTerena.Size = new System.Drawing.Size(58, 13);
            this.lblTipTerena.TabIndex = 19;
            this.lblTipTerena.Text = "Tip terena:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 392);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // lblOprema
            // 
            this.lblOprema.AutoSize = true;
            this.lblOprema.Location = new System.Drawing.Point(61, 419);
            this.lblOprema.Name = "lblOprema";
            this.lblOprema.Size = new System.Drawing.Size(47, 13);
            this.lblOprema.TabIndex = 21;
            this.lblOprema.Text = "Oprema:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(114, 419);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(84, 509);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(75, 23);
            this.btnRezerviraj.TabIndex = 23;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            // 
            // gbCijenik
            // 
            this.gbCijenik.Controls.Add(this.dataGridView2);
            this.gbCijenik.Location = new System.Drawing.Point(390, 231);
            this.gbCijenik.Name = "gbCijenik";
            this.gbCijenik.Size = new System.Drawing.Size(313, 301);
            this.gbCijenik.TabIndex = 24;
            this.gbCijenik.TabStop = false;
            this.gbCijenik.Text = "Cijenik";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(301, 260);
            this.dataGridView2.TabIndex = 0;
            // 
            // pregledRezervacijaToolStripMenuItem
            // 
            this.pregledRezervacijaToolStripMenuItem.Name = "pregledRezervacijaToolStripMenuItem";
            this.pregledRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.pregledRezervacijaToolStripMenuItem.Text = "Pregled rezervacija";
            // 
            // frmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 558);
            this.Controls.Add(this.gbCijenik);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblOprema);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTipTerena);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.lblZavrsnoVrijeme);
            this.Controls.Add(this.lblPocetnoVrijeme);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lblPopust);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUkupanIznos);
            this.Controls.Add(this.lblKontakt);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRezervacija";
            this.Text = "Rezervacija";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbCijenik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.Label lblUkupanIznos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblPopust;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPocetnoVrijeme;
        private System.Windows.Forms.Label lblZavrsnoVrijeme;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label lblTipTerena;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblOprema;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.GroupBox gbCijenik;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem pregledRezervacijaToolStripMenuItem;
    }
}