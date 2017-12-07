using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szymzilla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void autorzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projekt zrealizowany przez Szymona Kiełczawę");
        }

        // Funkcja nawigująca do strony

        private void IdzDoStrony()
        {
            WebBrowser web = zakladki.SelectedTab.Controls[0] as WebBrowser;
            Idz.Enabled = true;
            textBox1.Enabled = true;
            odswiez.Enabled = true;
            if (textBox1.Text.Contains(".") && !textBox1.Text.Contains("\""))
            {
                web.Navigate(textBox1.Text);
            }
            else
            {
                web.Navigate("https://www.google.pl/search?q=" + textBox1.Text);
            }
        }

        // Przycisk nawigujący do porządanej strony internetowej

        private void Idz_Click(object sender, EventArgs e)
        {
            IdzDoStrony();
        } 

        /* Funkcja, która powodojue, że przy wciśnięciu Enter pojawi nam się strona (nie trzeba
           będzie klikać na przycisk idź)        
        */

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)ConsoleKey.Enter)
            {
                IdzDoStrony();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Gotowe";
            Idz.Enabled = true;
            textBox1.Enabled = true;
            odswiez.Enabled = true;
            Stop.Enabled = false;
        }
        
        // Funkcja pokazująca postęp ładowania strony (pokazuje w procentach)
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
                PostepTekst.Text = toolStripProgressBar1.ProgressBar.Value.ToString()+"%";
                toolStripStatusLabel1.Text = "Ładowanie";
            }
        }

        private void Wstecz_Click(object sender, EventArgs e)
        {
            WebBrowser web = zakladki.SelectedTab.Controls[0] as WebBrowser;
            if (web.CanGoBack)
                web.GoBack();
        }

        private void Naprzod_Click(object sender, EventArgs e)
        {
            WebBrowser web = zakladki.SelectedTab.Controls[0] as WebBrowser;
            if (web.CanGoForward)
                web.GoForward();
        }

        // Przycisk stopujący wyszukiwanie

        private void Stop_Click(object sender, EventArgs e)
        {
            WebBrowser web = zakladki.SelectedTab.Controls[0] as WebBrowser;
            web.Stop();
            toolStripStatusLabel1.Text = "Stop" ;
            Idz.Enabled = true;
            textBox1.Enabled = true;
            odswiez.Enabled = true;
        }

        // pokazuje adres strony w pasku
        
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            WebBrowser web = zakladki.SelectedTab.Controls[0] as WebBrowser;
            textBox1.Text = web.Url.ToString();
        }

        // Przycisk odświeżający

        private void odswierz_Click(object sender, EventArgs e)
        {
            WebBrowser web = zakladki.SelectedTab.Controls[0] as WebBrowser;
            web.Refresh();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            WebBrowser web = zakladki.SelectedTab.Controls[0] as WebBrowser;
            web.Navigate("http://www.google.pl");
        }

        //Dodawanie nowej karty

        WebBrowser nowaStrona = null;

        private void dodaj_karte_Click(object sender, EventArgs e)
        {
            TabPage karta = new TabPage();        
            zakladki.Controls.Add(karta);
            zakladki.SelectTab(zakladki.TabCount - 1);
            nowaStrona = new WebBrowser() { ScriptErrorsSuppressed = true };
            nowaStrona.Parent = karta;
            nowaStrona.Dock = DockStyle.Fill;
            nowaStrona.Navigate("http://www.google.pl");
            nowaStrona.DocumentCompleted += NowaStrona_DocumentCompleted; ;
        }

        // Funkcja, ktróra wyświetla nazwę strony jako nazwę zakładki
        private void NowaStrona_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            zakladki.SelectedTab.Text = nowaStrona.DocumentTitle;
        }
        
        // Funkcja, która usuwa kartę
        private void usun_karte_Click(object sender, EventArgs e)
        {
            zakladki.SelectedTab.Dispose();
        }
    }
}
