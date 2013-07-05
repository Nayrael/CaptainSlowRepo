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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClanoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PIDataSet1 = new WindowsFormsApplication1.PIDataSet1();
            this.ZaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TereniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UslugeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClanoviTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.ClanoviTableAdapter();
            this.ZaposleniciTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.ZaposleniciTableAdapter();
            this.RezervacijeTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.RezervacijeTableAdapter();
            this.TereniTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.TereniTableAdapter();
            this.UslugeTableAdapter = new WindowsFormsApplication1.PIDataSet1TableAdapters.UslugeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClanoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TereniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UslugeBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
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
            // UslugeBindingSource
            // 
            this.UslugeBindingSource.DataMember = "Usluge";
            this.UslugeBindingSource.DataSource = this.PIDataSet1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 614);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ispis Članova";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "IspisClanova";
            reportDataSource1.Value = this.ClanoviBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.IspisClanova.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(968, 585);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ispis Zaposlenika";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "IspisZaposlenika";
            reportDataSource2.Value = this.ZaposleniciBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.IspisZaposlenika.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(6, 6);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(927, 576);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(939, 588);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ispis Svih Rezervacija";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "IspisRezervacija";
            reportDataSource3.Value = this.RezervacijeBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.IspisSvihRezervacija.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(6, 6);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(933, 576);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(939, 588);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ispis Terena";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            reportDataSource4.Name = "ispisterena";
            reportDataSource4.Value = this.TereniBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.tereni.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(933, 582);
            this.reportViewer4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(939, 588);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ispis Tipova Terena";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            reportDataSource5.Name = "IspisUsluga";
            reportDataSource5.Value = this.UslugeBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Usluge.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(3, 3);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.Size = new System.Drawing.Size(933, 582);
            this.reportViewer5.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.reportViewer6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(939, 588);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ispis Usluga";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // reportViewer6
            // 
            this.reportViewer6.Location = new System.Drawing.Point(3, 3);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.Size = new System.Drawing.Size(933, 582);
            this.reportViewer6.TabIndex = 0;
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
            // frmIzvjestaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 638);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmIzvjestaji";
            this.Text = "Izvještaji";
            this.Load += new System.EventHandler(this.frmIzvjestaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClanoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TereniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UslugeBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClanoviBindingSource;
        private PIDataSet1 PIDataSet1;
        private PIDataSet1TableAdapters.ClanoviTableAdapter ClanoviTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource ZaposleniciBindingSource;
        private PIDataSet1TableAdapters.ZaposleniciTableAdapter ZaposleniciTableAdapter;
        private System.Windows.Forms.BindingSource RezervacijeBindingSource;
        private PIDataSet1TableAdapters.RezervacijeTableAdapter RezervacijeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.BindingSource TereniBindingSource;
        private PIDataSet1TableAdapters.TereniTableAdapter TereniTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.BindingSource UslugeBindingSource;
        private PIDataSet1TableAdapters.UslugeTableAdapter UslugeTableAdapter;
    }
}