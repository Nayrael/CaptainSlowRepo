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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbClanovi = new System.Windows.Forms.GroupBox();
            this.lblImeC = new System.Windows.Forms.Label();
            this.lblPrezimeC = new System.Windows.Forms.Label();
            this.lblPrikaz = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gbTrazilica = new System.Windows.Forms.GroupBox();
            this.lblPrikazAN = new System.Windows.Forms.Label();
            this.rBAktivni = new System.Windows.Forms.RadioButton();
            this.rBAN = new System.Windows.Forms.RadioButton();
            this.gbRegistracija = new System.Windows.Forms.GroupBox();
            this.lblImeR = new System.Windows.Forms.Label();
            this.lblPrezimeR = new System.Windows.Forms.Label();
            this.lblKontaktR = new System.Windows.Forms.Label();
            this.lblAdresaR = new System.Windows.Forms.Label();
            this.lblDatumRodenjaR = new System.Windows.Forms.Label();
            this.lblSpolR = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbMuskoR = new System.Windows.Forms.RadioButton();
            this.rbZenskoR = new System.Windows.Forms.RadioButton();
            this.btnRegistriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbClanovi.SuspendLayout();
            this.gbTrazilica.SuspendLayout();
            this.gbRegistracija.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 455);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbClanovi
            // 
            this.gbClanovi.Controls.Add(this.dataGridView1);
            this.gbClanovi.Location = new System.Drawing.Point(336, 12);
            this.gbClanovi.Name = "gbClanovi";
            this.gbClanovi.Size = new System.Drawing.Size(442, 480);
            this.gbClanovi.TabIndex = 1;
            this.gbClanovi.TabStop = false;
            this.gbClanovi.Text = "Popis članova";
            // 
            // lblImeC
            // 
            this.lblImeC.AutoSize = true;
            this.lblImeC.Location = new System.Drawing.Point(56, 26);
            this.lblImeC.Name = "lblImeC";
            this.lblImeC.Size = new System.Drawing.Size(27, 13);
            this.lblImeC.TabIndex = 2;
            this.lblImeC.Text = "Ime:";
            // 
            // lblPrezimeC
            // 
            this.lblPrezimeC.AutoSize = true;
            this.lblPrezimeC.Location = new System.Drawing.Point(36, 52);
            this.lblPrezimeC.Name = "lblPrezimeC";
            this.lblPrezimeC.Size = new System.Drawing.Size(47, 13);
            this.lblPrezimeC.TabIndex = 3;
            this.lblPrezimeC.Text = "Prezime:";
            // 
            // lblPrikaz
            // 
            this.lblPrikaz.AutoSize = true;
            this.lblPrikaz.Location = new System.Drawing.Point(6, 78);
            this.lblPrikaz.Name = "lblPrikaz";
            this.lblPrikaz.Size = new System.Drawing.Size(77, 13);
            this.lblPrikaz.TabIndex = 4;
            this.lblPrikaz.Text = "Prikaži zadnjih:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // gbTrazilica
            // 
            this.gbTrazilica.Controls.Add(this.rBAN);
            this.gbTrazilica.Controls.Add(this.rBAktivni);
            this.gbTrazilica.Controls.Add(this.lblPrikazAN);
            this.gbTrazilica.Controls.Add(this.lblImeC);
            this.gbTrazilica.Controls.Add(this.textBox3);
            this.gbTrazilica.Controls.Add(this.lblPrezimeC);
            this.gbTrazilica.Controls.Add(this.textBox2);
            this.gbTrazilica.Controls.Add(this.lblPrikaz);
            this.gbTrazilica.Controls.Add(this.textBox1);
            this.gbTrazilica.Location = new System.Drawing.Point(39, 31);
            this.gbTrazilica.Name = "gbTrazilica";
            this.gbTrazilica.Size = new System.Drawing.Size(200, 157);
            this.gbTrazilica.TabIndex = 8;
            this.gbTrazilica.TabStop = false;
            this.gbTrazilica.Text = "Tražilica";
            // 
            // lblPrikazAN
            // 
            this.lblPrikazAN.AutoSize = true;
            this.lblPrikazAN.Location = new System.Drawing.Point(39, 117);
            this.lblPrikazAN.Name = "lblPrikazAN";
            this.lblPrikazAN.Size = new System.Drawing.Size(44, 13);
            this.lblPrikazAN.TabIndex = 8;
            this.lblPrikazAN.Text = "Prikaži: ";
            // 
            // rBAktivni
            // 
            this.rBAktivni.AutoSize = true;
            this.rBAktivni.Location = new System.Drawing.Point(89, 104);
            this.rBAktivni.Name = "rBAktivni";
            this.rBAktivni.Size = new System.Drawing.Size(94, 17);
            this.rBAktivni.TabIndex = 9;
            this.rBAktivni.TabStop = true;
            this.rBAktivni.Text = "Aktivni članovi";
            this.rBAktivni.UseVisualStyleBackColor = true;
            // 
            // rBAN
            // 
            this.rBAN.AutoSize = true;
            this.rBAN.Location = new System.Drawing.Point(89, 127);
            this.rBAN.Name = "rBAN";
            this.rBAN.Size = new System.Drawing.Size(107, 17);
            this.rBAN.TabIndex = 10;
            this.rBAN.TabStop = true;
            this.rBAN.Text = "Neaktivni članovi";
            this.rBAN.UseVisualStyleBackColor = true;
            // 
            // gbRegistracija
            // 
            this.gbRegistracija.Controls.Add(this.btnRegistriraj);
            this.gbRegistracija.Controls.Add(this.rbZenskoR);
            this.gbRegistracija.Controls.Add(this.rbMuskoR);
            this.gbRegistracija.Controls.Add(this.dateTimePicker1);
            this.gbRegistracija.Controls.Add(this.textBox9);
            this.gbRegistracija.Controls.Add(this.textBox6);
            this.gbRegistracija.Controls.Add(this.textBox5);
            this.gbRegistracija.Controls.Add(this.textBox4);
            this.gbRegistracija.Controls.Add(this.lblSpolR);
            this.gbRegistracija.Controls.Add(this.lblDatumRodenjaR);
            this.gbRegistracija.Controls.Add(this.lblAdresaR);
            this.gbRegistracija.Controls.Add(this.lblKontaktR);
            this.gbRegistracija.Controls.Add(this.lblPrezimeR);
            this.gbRegistracija.Controls.Add(this.lblImeR);
            this.gbRegistracija.Location = new System.Drawing.Point(29, 216);
            this.gbRegistracija.Name = "gbRegistracija";
            this.gbRegistracija.Size = new System.Drawing.Size(301, 276);
            this.gbRegistracija.TabIndex = 9;
            this.gbRegistracija.TabStop = false;
            this.gbRegistracija.Text = "Obrazac za registraciju";
            // 
            // lblImeR
            // 
            this.lblImeR.AutoSize = true;
            this.lblImeR.Location = new System.Drawing.Point(59, 31);
            this.lblImeR.Name = "lblImeR";
            this.lblImeR.Size = new System.Drawing.Size(27, 13);
            this.lblImeR.TabIndex = 0;
            this.lblImeR.Text = "Ime:";
            // 
            // lblPrezimeR
            // 
            this.lblPrezimeR.AutoSize = true;
            this.lblPrezimeR.Location = new System.Drawing.Point(39, 57);
            this.lblPrezimeR.Name = "lblPrezimeR";
            this.lblPrezimeR.Size = new System.Drawing.Size(47, 13);
            this.lblPrezimeR.TabIndex = 1;
            this.lblPrezimeR.Text = "Prezime:";
            // 
            // lblKontaktR
            // 
            this.lblKontaktR.AutoSize = true;
            this.lblKontaktR.Location = new System.Drawing.Point(40, 159);
            this.lblKontaktR.Name = "lblKontaktR";
            this.lblKontaktR.Size = new System.Drawing.Size(47, 13);
            this.lblKontaktR.TabIndex = 2;
            this.lblKontaktR.Text = "Kontakt:";
            // 
            // lblAdresaR
            // 
            this.lblAdresaR.AutoSize = true;
            this.lblAdresaR.Location = new System.Drawing.Point(41, 185);
            this.lblAdresaR.Name = "lblAdresaR";
            this.lblAdresaR.Size = new System.Drawing.Size(46, 13);
            this.lblAdresaR.TabIndex = 3;
            this.lblAdresaR.Text = "Adresa: ";
            // 
            // lblDatumRodenjaR
            // 
            this.lblDatumRodenjaR.AutoSize = true;
            this.lblDatumRodenjaR.Location = new System.Drawing.Point(7, 80);
            this.lblDatumRodenjaR.Name = "lblDatumRodenjaR";
            this.lblDatumRodenjaR.Size = new System.Drawing.Size(80, 13);
            this.lblDatumRodenjaR.TabIndex = 4;
            this.lblDatumRodenjaR.Text = "Datum rođenja:";
            // 
            // lblSpolR
            // 
            this.lblSpolR.AutoSize = true;
            this.lblSpolR.Location = new System.Drawing.Point(55, 125);
            this.lblSpolR.Name = "lblSpolR";
            this.lblSpolR.Size = new System.Drawing.Size(31, 13);
            this.lblSpolR.TabIndex = 5;
            this.lblSpolR.Text = "Spol:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(92, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(134, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(92, 182);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(134, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(92, 54);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(134, 20);
            this.textBox9.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // rbMuskoR
            // 
            this.rbMuskoR.AutoSize = true;
            this.rbMuskoR.Location = new System.Drawing.Point(92, 111);
            this.rbMuskoR.Name = "rbMuskoR";
            this.rbMuskoR.Size = new System.Drawing.Size(57, 17);
            this.rbMuskoR.TabIndex = 16;
            this.rbMuskoR.TabStop = true;
            this.rbMuskoR.Text = "Muško";
            this.rbMuskoR.UseVisualStyleBackColor = true;
            // 
            // rbZenskoR
            // 
            this.rbZenskoR.AutoSize = true;
            this.rbZenskoR.Location = new System.Drawing.Point(92, 134);
            this.rbZenskoR.Name = "rbZenskoR";
            this.rbZenskoR.Size = new System.Drawing.Size(61, 17);
            this.rbZenskoR.TabIndex = 17;
            this.rbZenskoR.TabStop = true;
            this.rbZenskoR.Text = "Žensko";
            this.rbZenskoR.UseVisualStyleBackColor = true;
            // 
            // btnRegistriraj
            // 
            this.btnRegistriraj.Location = new System.Drawing.Point(92, 222);
            this.btnRegistriraj.Name = "btnRegistriraj";
            this.btnRegistriraj.Size = new System.Drawing.Size(85, 31);
            this.btnRegistriraj.TabIndex = 18;
            this.btnRegistriraj.Text = "Registriraj";
            this.btnRegistriraj.UseVisualStyleBackColor = true;
            // 
            // frmClanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 534);
            this.Controls.Add(this.gbRegistracija);
            this.Controls.Add(this.gbTrazilica);
            this.Controls.Add(this.gbClanovi);
            this.Name = "frmClanovi";
            this.Text = "Članovi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbClanovi.ResumeLayout(false);
            this.gbTrazilica.ResumeLayout(false);
            this.gbTrazilica.PerformLayout();
            this.gbRegistracija.ResumeLayout(false);
            this.gbRegistracija.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbClanovi;
        private System.Windows.Forms.Label lblImeC;
        private System.Windows.Forms.Label lblPrezimeC;
        private System.Windows.Forms.Label lblPrikaz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox gbTrazilica;
        private System.Windows.Forms.RadioButton rBAN;
        private System.Windows.Forms.RadioButton rBAktivni;
        private System.Windows.Forms.Label lblPrikazAN;
        private System.Windows.Forms.GroupBox gbRegistracija;
        private System.Windows.Forms.Button btnRegistriraj;
        private System.Windows.Forms.RadioButton rbZenskoR;
        private System.Windows.Forms.RadioButton rbMuskoR;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblSpolR;
        private System.Windows.Forms.Label lblDatumRodenjaR;
        private System.Windows.Forms.Label lblAdresaR;
        private System.Windows.Forms.Label lblKontaktR;
        private System.Windows.Forms.Label lblPrezimeR;
        private System.Windows.Forms.Label lblImeR;
    }
}