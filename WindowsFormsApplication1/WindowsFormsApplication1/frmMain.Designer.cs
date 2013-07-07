namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.članoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tereniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipTerenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.korisnikToolStripMenuItem,
            this.pomoćToolStripMenuItem,
            this.članoviToolStripMenuItem,
            this.zaposleniciToolStripMenuItem,
            this.izmjeneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaRezervacijaToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.datotekaToolStripMenuItem.Text = "Rezervacija";
            // 
            // novaRezervacijaToolStripMenuItem
            // 
            this.novaRezervacijaToolStripMenuItem.Name = "novaRezervacijaToolStripMenuItem";
            this.novaRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.novaRezervacijaToolStripMenuItem.Text = "Nova Rezervacija";
            this.novaRezervacijaToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.novaRezervacijaToolStripMenuItem_MouseUp);
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.pomoćToolStripMenuItem.Text = "Izvještaji";
            this.pomoćToolStripMenuItem.Click += new System.EventHandler(this.pomoćToolStripMenuItem_Click);
            // 
            // članoviToolStripMenuItem
            // 
            this.članoviToolStripMenuItem.Name = "članoviToolStripMenuItem";
            this.članoviToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.članoviToolStripMenuItem.Text = "Članovi";
            this.članoviToolStripMenuItem.Click += new System.EventHandler(this.članoviToolStripMenuItem_Click);
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            this.zaposleniciToolStripMenuItem.Click += new System.EventHandler(this.zaposleniciToolStripMenuItem_Click);
            // 
            // izmjeneToolStripMenuItem
            // 
            this.izmjeneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uslugeToolStripMenuItem,
            this.tereniToolStripMenuItem,
            this.tipTerenaToolStripMenuItem});
            this.izmjeneToolStripMenuItem.Name = "izmjeneToolStripMenuItem";
            this.izmjeneToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izmjeneToolStripMenuItem.Text = "Izmjene";
            // 
            // uslugeToolStripMenuItem
            // 
            this.uslugeToolStripMenuItem.Name = "uslugeToolStripMenuItem";
            this.uslugeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uslugeToolStripMenuItem.Text = "Usluge";
            this.uslugeToolStripMenuItem.Click += new System.EventHandler(this.uslugeToolStripMenuItem_Click);
            // 
            // tereniToolStripMenuItem
            // 
            this.tereniToolStripMenuItem.Name = "tereniToolStripMenuItem";
            this.tereniToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tereniToolStripMenuItem.Text = "Tereni";
            this.tereniToolStripMenuItem.Click += new System.EventHandler(this.tereniToolStripMenuItem_Click);
            // 
            // tipTerenaToolStripMenuItem
            // 
            this.tipTerenaToolStripMenuItem.Name = "tipTerenaToolStripMenuItem";
            this.tipTerenaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tipTerenaToolStripMenuItem.Text = "Tip terena";
            this.tipTerenaToolStripMenuItem.Click += new System.EventHandler(this.tipTerenaToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel4.Text = "Status:";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel5.Text = "toolStripStatusLabel3";
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.ssStatus.Location = new System.Drawing.Point(0, 531);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1051, 22);
            this.ssStatus.TabIndex = 6;
            this.ssStatus.Text = "statusStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1051, 553);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacija sportskih terena";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem članoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaRezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripMenuItem izmjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tereniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipTerenaToolStripMenuItem;
    }
}

