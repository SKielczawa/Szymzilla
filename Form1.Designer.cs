namespace Szymzilla
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulubioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Idz = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.PostepTekst = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Wstecz = new System.Windows.Forms.Button();
            this.Naprzod = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.odswiez = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.dodaj_karte = new System.Windows.Forms.Button();
            this.zakladki = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.usun_karte = new System.Windows.Forms.Button();
            this.ulub = new System.Windows.Forms.Button();
            this.nazwa_ulub = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.zakladki.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.opcjeToolStripMenuItem,
            this.ulubioneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1061, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyjdźToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wyjdźToolStripMenuItem
            // 
            this.wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            this.wyjdźToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.wyjdźToolStripMenuItem.Text = "Wyjdź";
            this.wyjdźToolStripMenuItem.Click += new System.EventHandler(this.wyjdźToolStripMenuItem_Click);
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorzyToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // autorzyToolStripMenuItem
            // 
            this.autorzyToolStripMenuItem.Name = "autorzyToolStripMenuItem";
            this.autorzyToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.autorzyToolStripMenuItem.Text = "Autorzy";
            this.autorzyToolStripMenuItem.Click += new System.EventHandler(this.autorzyToolStripMenuItem_Click);
            // 
            // ulubioneToolStripMenuItem
            // 
            this.ulubioneToolStripMenuItem.Name = "ulubioneToolStripMenuItem";
            this.ulubioneToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.ulubioneToolStripMenuItem.Text = "Ulubione";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(183, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "http://";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Idz
            // 
            this.Idz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Idz.Location = new System.Drawing.Point(907, 30);
            this.Idz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Idz.Name = "Idz";
            this.Idz.Size = new System.Drawing.Size(75, 28);
            this.Idz.TabIndex = 2;
            this.Idz.Text = "➔";
            this.Idz.UseVisualStyleBackColor = true;
            this.Idz.Click += new System.EventHandler(this.Idz_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.PostepTekst,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1061, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 20);
            // 
            // PostepTekst
            // 
            this.PostepTekst.Name = "PostepTekst";
            this.PostepTekst.Size = new System.Drawing.Size(53, 21);
            this.PostepTekst.Text = "Postęp";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 21);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // Wstecz
            // 
            this.Wstecz.Location = new System.Drawing.Point(13, 30);
            this.Wstecz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Wstecz.Name = "Wstecz";
            this.Wstecz.Size = new System.Drawing.Size(55, 28);
            this.Wstecz.TabIndex = 5;
            this.Wstecz.Text = "↶";
            this.Wstecz.UseVisualStyleBackColor = true;
            this.Wstecz.Click += new System.EventHandler(this.Wstecz_Click);
            // 
            // Naprzod
            // 
            this.Naprzod.Location = new System.Drawing.Point(74, 30);
            this.Naprzod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Naprzod.Name = "Naprzod";
            this.Naprzod.Size = new System.Drawing.Size(53, 28);
            this.Naprzod.TabIndex = 6;
            this.Naprzod.Text = "↷";
            this.Naprzod.UseVisualStyleBackColor = true;
            this.Naprzod.Click += new System.EventHandler(this.Naprzod_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.Location = new System.Drawing.Point(745, 31);
            this.Stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 27);
            this.Stop.TabIndex = 7;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // odswiez
            // 
            this.odswiez.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.odswiez.Location = new System.Drawing.Point(827, 30);
            this.odswiez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.odswiez.Name = "odswiez";
            this.odswiez.Size = new System.Drawing.Size(75, 28);
            this.odswiez.TabIndex = 8;
            this.odswiez.Text = "↻";
            this.odswiez.UseVisualStyleBackColor = true;
            this.odswiez.Click += new System.EventHandler(this.odswiez_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Home.Location = new System.Drawing.Point(133, 30);
            this.Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(44, 28);
            this.Home.TabIndex = 10;
            this.Home.Text = "🏠";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // dodaj_karte
            // 
            this.dodaj_karte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dodaj_karte.Location = new System.Drawing.Point(988, 30);
            this.dodaj_karte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodaj_karte.Name = "dodaj_karte";
            this.dodaj_karte.Size = new System.Drawing.Size(25, 28);
            this.dodaj_karte.TabIndex = 11;
            this.dodaj_karte.Text = "+";
            this.dodaj_karte.UseVisualStyleBackColor = true;
            this.dodaj_karte.Click += new System.EventHandler(this.dodaj_karte_Click);
            // 
            // zakladki
            // 
            this.zakladki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zakladki.Controls.Add(this.tabPage1);
            this.zakladki.Location = new System.Drawing.Point(13, 62);
            this.zakladki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zakladki.Name = "zakladki";
            this.zakladki.SelectedIndex = 0;
            this.zakladki.Size = new System.Drawing.Size(1037, 384);
            this.zakladki.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1029, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 2);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1023, 351);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.google.pl", System.UriKind.Absolute);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated_1);
            // 
            // usun_karte
            // 
            this.usun_karte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usun_karte.Location = new System.Drawing.Point(1019, 30);
            this.usun_karte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usun_karte.Name = "usun_karte";
            this.usun_karte.Size = new System.Drawing.Size(23, 28);
            this.usun_karte.TabIndex = 13;
            this.usun_karte.Text = "-";
            this.usun_karte.UseVisualStyleBackColor = true;
            this.usun_karte.Click += new System.EventHandler(this.usun_karte_Click);
            // 
            // ulub
            // 
            this.ulub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ulub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ulub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ulub.Location = new System.Drawing.Point(988, 3);
            this.ulub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ulub.Name = "ulub";
            this.ulub.Size = new System.Drawing.Size(54, 23);
            this.ulub.TabIndex = 14;
            this.ulub.Text = "❤";
            this.ulub.UseVisualStyleBackColor = true;
            this.ulub.Click += new System.EventHandler(this.ulub_Click);
            // 
            // nazwa_ulub
            // 
            this.nazwa_ulub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nazwa_ulub.Location = new System.Drawing.Point(815, 4);
            this.nazwa_ulub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwa_ulub.Name = "nazwa_ulub";
            this.nazwa_ulub.Size = new System.Drawing.Size(167, 22);
            this.nazwa_ulub.TabIndex = 15;
            this.nazwa_ulub.Text = "Nazwa ulubionej";
            this.nazwa_ulub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1061, 473);
            this.Controls.Add(this.nazwa_ulub);
            this.Controls.Add(this.ulub);
            this.Controls.Add(this.usun_karte);
            this.Controls.Add(this.zakladki);
            this.Controls.Add(this.dodaj_karte);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.odswiez);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Naprzod);
            this.Controls.Add(this.Wstecz);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Idz);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Szymzilla";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.zakladki.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdźToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorzyToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Idz;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button Wstecz;
        private System.Windows.Forms.Button Naprzod;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ToolStripStatusLabel PostepTekst;
        private System.Windows.Forms.Button odswiez;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button dodaj_karte;
        private System.Windows.Forms.TabControl zakladki;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button usun_karte;
        private System.Windows.Forms.Button ulub;
        private System.Windows.Forms.TextBox nazwa_ulub;
        private System.Windows.Forms.ToolStripMenuItem ulubioneToolStripMenuItem;
    }
}

