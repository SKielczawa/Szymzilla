﻿using System;
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
            toolStripStatusLabel1.Text = "Ładowanie";
            Idz.Enabled = false;
            textBox1.Enabled = false;
            odswiez.Enabled = false;
            webBrowser1.Navigate(textBox1.Text);
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
                toolStripStatusLabel2.Text = toolStripProgressBar1.ProgressBar.Value.ToString()+"%";
            }
        }

        private void Wstecz_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Naprzod_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        // Przycisk stopujący wyszukiwanie

        private void Stop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
            toolStripStatusLabel1.Text = "Stop" ;
            Idz.Enabled = true;
            textBox1.Enabled = true;
            odswiez.Enabled = true;
        }

        // pokazuje adres strony w pasku
        
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        // Przycisk odświeżający

        private void odswierz_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}