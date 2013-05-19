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
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.korisnikToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.članoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prijavaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.podaciOKorisnikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.korisnikToolStripMenuItem,
            this.pomoćToolStripMenuItem,
            this.članoviToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.datotekaToolStripMenuItem.Text = "Rezervacija";
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
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.ssStatus.Location = new System.Drawing.Point(0, 417);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(749, 22);
            this.ssStatus.TabIndex = 2;
            this.ssStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem1,
            this.korisnikToolStripMenuItem1,
            this.pomoćToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(749, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // datotekaToolStripMenuItem1
            // 
            this.datotekaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaToolStripMenuItem1,
            this.odjavaToolStripMenuItem1,
            this.izlazToolStripMenuItem1});
            this.datotekaToolStripMenuItem1.Name = "datotekaToolStripMenuItem1";
            this.datotekaToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem1.Text = "Datoteka";
            // 
            // korisnikToolStripMenuItem1
            // 
            this.korisnikToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podaciOKorisnikuToolStripMenuItem});
            this.korisnikToolStripMenuItem1.Name = "korisnikToolStripMenuItem1";
            this.korisnikToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.korisnikToolStripMenuItem1.Text = "Korisnik";
            // 
            // pomoćToolStripMenuItem1
            // 
            this.pomoćToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikacijiToolStripMenuItem});
            this.pomoćToolStripMenuItem1.Name = "pomoćToolStripMenuItem1";
            this.pomoćToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.pomoćToolStripMenuItem1.Text = "Pomoć";
            // 
            // članoviToolStripMenuItem
            // 
            this.članoviToolStripMenuItem.Name = "članoviToolStripMenuItem";
            this.članoviToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.članoviToolStripMenuItem.Text = "Članovi";
            // 
            // prijavaToolStripMenuItem1
            // 
            this.prijavaToolStripMenuItem1.Image = global::WindowsFormsApplication1.Properties.Resources.Login_in_icon;
            this.prijavaToolStripMenuItem1.Name = "prijavaToolStripMenuItem1";
            this.prijavaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.prijavaToolStripMenuItem1.Text = "Prijava";
            this.prijavaToolStripMenuItem1.Click += new System.EventHandler(this.prijavaToolStripMenuItem1_Click);
            // 
            // odjavaToolStripMenuItem1
            // 
            this.odjavaToolStripMenuItem1.Image = global::WindowsFormsApplication1.Properties.Resources.Login_out_icon;
            this.odjavaToolStripMenuItem1.Name = "odjavaToolStripMenuItem1";
            this.odjavaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.odjavaToolStripMenuItem1.Text = "Odjava";
            // 
            // izlazToolStripMenuItem1
            // 
            this.izlazToolStripMenuItem1.Image = global::WindowsFormsApplication1.Properties.Resources.Actions_file_close_icon;
            this.izlazToolStripMenuItem1.Name = "izlazToolStripMenuItem1";
            this.izlazToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.izlazToolStripMenuItem1.Text = "Izlaz";
            // 
            // podaciOKorisnikuToolStripMenuItem
            // 
            this.podaciOKorisnikuToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.user__2_;
            this.podaciOKorisnikuToolStripMenuItem.Name = "podaciOKorisnikuToolStripMenuItem";
            this.podaciOKorisnikuToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.podaciOKorisnikuToolStripMenuItem.Text = "Podaci o korisniku";
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.imeem;
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oAplikacijiToolStripMenuItem.Text = "O aplikaciji";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel2.Text = "Status:";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 439);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Rezervacija sportskih terena";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prijavaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem podaciOKorisnikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem članoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

