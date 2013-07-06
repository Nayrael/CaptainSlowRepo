namespace WindowsFormsApplication1
{
    partial class frmIzvjestaji
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClanoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PIDataSet1 = new WindowsFormsApplication1.PIDataSet1();
            this.ZaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TereniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tip_terenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UslugeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClanoviTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.ClanoviTableAdapter();
            this.ZaposleniciTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.ZaposleniciTableAdapter();
            this.RezervacijeTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.RezervacijeTableAdapter();
            this.TereniTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.TereniTableAdapter();
            this.UslugeTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.UslugeTableAdapter();
            this.Tip_terenaTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.Tip_terenaTableAdapter();
            this.dtNOW = new System.Windows.Forms.DateTimePicker();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.reportViewer7 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ClanoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TereniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tip_terenaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UslugeBindingSource)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClanoviBindingSource
            // 
            this.ClanoviBindingSource.DataMember = "Clanovi";
            this.ClanoviBindingSource.DataSource = this.PIDataSet1;
            // 
            // PIDataSet1
            // 
            this.PIDataSet1.DataSetName = "PIDataSet1";
            this.PIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ZaposleniciBindingSource
            // 
            this.ZaposleniciBindingSource.DataMember = "Zaposlenici";
            this.ZaposleniciBindingSource.DataSource = this.PIDataSet1;
            // 
            // RezervacijeBindingSource
            // 
            this.RezervacijeBindingSource.DataMember = "Rezervacije";
            this.RezervacijeBindingSource.DataSource = this.PIDataSet1;
            // 
            // TereniBindingSource
            // 
            this.TereniBindingSource.DataMember = "Tereni";
            this.TereniBindingSource.DataSource = this.PIDataSet1;
            // 
            // Tip_terenaBindingSource
            // 
            this.Tip_terenaBindingSource.DataMember = "Tip_terena";
            this.Tip_terenaBindingSource.DataSource = this.PIDataSet1;
            // 
            // UslugeBindingSource
            // 
            this.UslugeBindingSource.DataMember = "Usluge";
            this.UslugeBindingSource.DataSource = this.PIDataSet1;
            // 
            // ClanoviTableAdapter
            // 
            this.ClanoviTableAdapter.ClearBeforeFill = true;
            // 
            // ZaposleniciTableAdapter
            // 
            this.ZaposleniciTableAdapter.ClearBeforeFill = true;
            // 
            // RezervacijeTableAdapter
            // 
            this.RezervacijeTableAdapter.ClearBeforeFill = true;
            // 
            // TereniTableAdapter
            // 
            this.TereniTableAdapter.ClearBeforeFill = true;
            // 
            // UslugeTableAdapter
            // 
            this.UslugeTableAdapter.ClearBeforeFill = true;
            // 
            // Tip_terenaTableAdapter
            // 
            this.Tip_terenaTableAdapter.ClearBeforeFill = true;
            // 
            // dtNOW
            // 
            this.dtNOW.Location = new System.Drawing.Point(522, 12);
            this.dtNOW.Name = "dtNOW";
            this.dtNOW.Size = new System.Drawing.Size(200, 20);
            this.dtNOW.TabIndex = 3;
            this.dtNOW.ValueChanged += new System.EventHandler(this.dtNOW_ValueChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.reportViewer7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(691, 491);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "REZERVACIJE DANA";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // reportViewer7
            // 
            reportDataSource7.Name = "rezervacije";
            reportDataSource7.Value = this.RezervacijeBindingSource;
            this.reportViewer7.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer7.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Rezervacije.rdlc";
            this.reportViewer7.Location = new System.Drawing.Point(6, 6);
            this.reportViewer7.Name = "reportViewer7";
            this.reportViewer7.Size = new System.Drawing.Size(678, 480);
            this.reportViewer7.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.reportViewer6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(691, 491);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ispis Usluga";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // reportViewer6
            // 
            reportDataSource8.Name = "IspisUsluga";
            reportDataSource8.Value = this.UslugeBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Usluge.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(0, 3);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.Size = new System.Drawing.Size(688, 485);
            this.reportViewer6.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(691, 491);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ispis Tipova Terena";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            reportDataSource9.Name = "TipTerena";
            reportDataSource9.Value = this.Tip_terenaBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.TipoviTerena.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(3, 3);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.Size = new System.Drawing.Size(685, 485);
            this.reportViewer5.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(691, 491);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ispis Terena";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            reportDataSource10.Name = "ispisterena";
            reportDataSource10.Value = this.TereniBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.tereni.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(3, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(685, 488);
            this.reportViewer4.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(691, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ispis Zaposlenika";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource11.Name = "IspisZaposlenika";
            reportDataSource11.Value = this.ZaposleniciBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.IspisZaposlenika.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(682, 488);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(693, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ispis Članova";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource12.Name = "IspisClanova";
            reportDataSource12.Value = this.ClanoviBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.IspisClanova.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 6);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(679, 479);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 517);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // frmIzvjestaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 569);
            this.Controls.Add(this.dtNOW);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmIzvjestaji";
            this.Text = "Izvještaji";
            this.Load += new System.EventHandler(this.frmIzvjestaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClanoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TereniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tip_terenaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UslugeBindingSource)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ClanoviBindingSource;
        private PIDataSet1 PIDataSet1;
        private PIDataSet1TableAdapters.ClanoviTableAdapter ClanoviTableAdapter;
        private System.Windows.Forms.BindingSource ZaposleniciBindingSource;
        private PIDataSet1TableAdapters.ZaposleniciTableAdapter ZaposleniciTableAdapter;
        private System.Windows.Forms.BindingSource RezervacijeBindingSource;
        private PIDataSet1TableAdapters.RezervacijeTableAdapter RezervacijeTableAdapter;
        private System.Windows.Forms.BindingSource TereniBindingSource;
        private PIDataSet1TableAdapters.TereniTableAdapter TereniTableAdapter;
        private System.Windows.Forms.BindingSource UslugeBindingSource;
        private PIDataSet1TableAdapters.UslugeTableAdapter UslugeTableAdapter;
        private System.Windows.Forms.BindingSource Tip_terenaBindingSource;
        private PIDataSet1TableAdapters.Tip_terenaTableAdapter Tip_terenaTableAdapter;
        private System.Windows.Forms.DateTimePicker dtNOW;
        private System.Windows.Forms.TabPage tabPage7;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer7;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}