using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace Szymzilla
{
    public partial class Form1 : Form
    {
        private List<Ulubione> _ulubione;

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
            if (textBox1.Text.Contains(".") && !textBox1.Text.Contains("\""))
            {
                Wczytaj(textBox1.Text);
            }
            else
            {
                Wczytaj("https://www.google.pl/search?q=" + textBox1.Text);
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
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                IdzDoStrony();
            }

            if (e.KeyChar == (char)ConsoleKey.F5)
            {
                Odswiez();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Gotowe";
        }

        // Funkcja pokazująca postęp ładowania strony (pokazuje w procentach)
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                toolStripProgressBar1.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
                PostepTekst.Text = toolStripProgressBar1.Value.ToString() + "%";
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
            toolStripStatusLabel1.Text = "Stop";
        }

        // pokazuje adres strony w pasku

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            WebBrowser web = zakladki.SelectedTab.Controls[0] as WebBrowser;
            textBox1.Text = web.Url.ToString();
        }

        // Przycisk odświeżający

        private void odswiez_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Wczytaj("http://www.google.pl");
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
        
        // Klasa strona
        public class Strona
        {
            public string nazwa;
            public string adres;
            public Strona() { }
            public Strona(string wpis1, string wpis2)
            {
                this.nazwa = wpis1;
                this.adres = wpis2;
            }
        }

        private void ulub_Click(object sender, EventArgs e)
        {
            if (_ulubione.Any(u => u.Nazwa == nazwa_ulub.Text)) //sprawdzam czy istnieje już taka nazwa w ulubionych w pamięci (na liście)
            {
                MessageBox.Show("Ulubiona o podanej nazwie już istnieje.\n Proszę podać inną nazwę!");
                return; //jeśli istnieje to po pokazaniu komunikatu kończę metodę
            }

            Ulubione ulubione = new Ulubione //z odczytanych danych tworzę nowy obiekt Ulubione
            {
                Nazwa = nazwa_ulub.Text,
                Url = textBox1.Text
            };

            _ulubione.Add(ulubione); //dodaję nową ulubioną stronę do listy ulubionych
            ulubioneToolStripMenuItem.DropDownItems.Add(ulubione.Nazwa, null, UlubioneWybierz); //dodaję nowo dodaną ulubioną do menu

            XDocument doc = XDocument.Load("ulub.xml"); //odczytuję plik xml
            doc.Root.Add(new XElement("ulubiona", //dodaję kolejny element
                new XAttribute("Nazwa", ulubione.Nazwa),  //dodaję do elementu atrybut nazwa
                new XAttribute("Url", ulubione.Url)));
            doc.Save("ulub.xml"); //zapisuję zmiany w pliku xml
            ulub.BackColor = Color.Gold;
            nazwa_ulub.Text = "Nazwa ulubionej";
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            Wczytaj("http://google.pl"); //przejdź na google.pl
            _ulubione = new List<Ulubione>(); //tworzę pustą listę ulubionych 
            XDocument doc = XDocument.Load("ulub.xml"); //odczytaj plik ulub.xml jako XDocument (LINQ to XML)
            foreach (var element in doc.Root.Elements("ulubiona")) //przechodzimy po każdym elemencie
            {
                _ulubione.Add(new Ulubione //tworzymy nowy obiekt na podstawie elementu odczytanego z XMLa i dodaję go do listy ulubionych w aplikacji
                {
                    Nazwa = element.Attribute("Nazwa").Value, //odczytuję wartość atrybutu nazwa i wstawiam jego wartość do pola Nazwa
                    Url = element.Attribute("Url").Value
                });
            }

            foreach (var ulubione in _ulubione) //przechodzę po wszystkich odczytanych ulubionych
            {
                ulubioneToolStripMenuItem.DropDownItems.Add(ulubione.Nazwa, null, UlubioneWybierz); //dodaję do rozwijanej listy menu elementy, nazwa jest wyświetlana
            }
        }

        private void UlubioneWybierz(object sender, EventArgs eventArgs)
        {
            string nazwa = ((ToolStripMenuItem) sender).Text; //czyli przycisk w menu na górze, odczytuję jaki ma napis
            Ulubione wybraneUlubione = _ulubione.FirstOrDefault(u => u.Nazwa == nazwa); //na podstawie nazwy szukam pierwszej ulubionej, która ma taką nazwę
            if (wybraneUlubione == null) //jeśli jest nulll (firstordefault nic nie znalazł) to poinformuj, że się nie da wczytać strony
            {
                MessageBox.Show("Nie mogę załadować ulubionej strony");
                return; //return kończy metodę
            }
            Wczytaj(wybraneUlubione.Url); // jeśli nie zakończyła się metoda, czyli nie wszedł do powyższego ifa, to znaczy, że znalazłem ulubioną stronę, więc mogę do niej przejść
        }

        private void Wczytaj(string url)
        {
            WebBrowser web = zakladki.SelectedTab.Controls[0] as WebBrowser;
            web.Navigate(url);
        }

        private void Odswiez()
        {
            WebBrowser web = zakladki.SelectedTab.Controls[0] as WebBrowser;
            web.Refresh();
        }

        private void webBrowser1_Navigated_1(object sender, WebBrowserNavigatedEventArgs e) //event wywoływany w momencie zmiany adresu url
        {
            textBox1.Text = ((WebBrowser) sender).Url.ToString(); //sender to WebBrowser, dlatego rzutuję i wyciągam z niego url do którego aktualnie się przeglądarka odwołuje
            string url = textBox1.Text;
            Ulubione adres_strony = _ulubione.FirstOrDefault(u => u.Url == url); //na podstawie nazwy szukam pierwszej ulubionej, która ma taki adres URL
            if (adres_strony != null)
            {
                ulub.BackColor = Color.Gold;  //Jeśli istnieje strona w ulubionych o tym adresie URL to zmień kolor tła ikony ulubione na złoty
                return; 
            }
            else
            {
                ulub.BackColor = Color.Transparent; //Inaczej zostaje przezroczysta
            }
        }
    } 
}
