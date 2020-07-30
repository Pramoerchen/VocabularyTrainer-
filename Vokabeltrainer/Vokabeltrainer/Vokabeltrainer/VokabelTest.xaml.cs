using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Linq;

namespace Vokabeltrainer
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class VokabelTest : Window
    {
        public string richtige_vokabel;
        public int vorherigeRndZeile;

        public Dictionary<string, string> andere_sprache = new Dictionary<string, string>();
        public int maxZeilenAnzahl;
        public StreamReader SR;

        public string sprache_aus_datei_name_1;
        public string sprache_aus_datei_name_2;
        




        public VokabelTest()
        {
            InitializeComponent();
            
            richtige_vokabel = VokabelnHolen();
            sprache_1_lbl.Content = abfrage_richtung_aussuchen.sprache_1;
            sprache_2_lbl.Content = abfrage_richtung_aussuchen.sprache_2;

        }

        private void Btn_Bestätigen(object sender, RoutedEventArgs e)
        {

            if (txt_Eingabe1.Text == richtige_vokabel)
            {
                uerberschrift.Content = "Richtig!";
            }

            else
            {
                uerberschrift.Content = "Leider Falsch!";
            }
                



            


            richtige_vokabel = VokabelnHolen();
        }

        private void Btn_Zurück(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow(); // referenz auf das Fenster VokabelEingabe
            this.Visibility = Visibility.Hidden; //lässt das menü verschwinden
            objMainWindow.Show(); // wechselt zur ins "VokabelEingabe" fenster


        }
        string VokabelnHolen()
        {

            txt_Eingabe1.Clear();
            txt_Eingabe2.Clear();

            string pfad_1_abfrage = @"..\..\..\Wörterbücher\" + abfrage_richtung_aussuchen.sprache_1 + "+" + abfrage_richtung_aussuchen.sprache_2 + ".txt";
            string pfad_2_abfrage = @"..\..\..\Wörterbücher\" + abfrage_richtung_aussuchen.sprache_2 + "+" + abfrage_richtung_aussuchen.sprache_1 + ".txt";

            
            

            if (File.Exists(pfad_1_abfrage))
            {
                SR = new StreamReader(pfad_1_abfrage);
                maxZeilenAnzahl = File.ReadLines(pfad_1_abfrage).Count();
                sprache_aus_datei_name_1 = pfad_1_abfrage.Replace(@"..\..\..\Wörterbücher\", "").Split("+")[0];
                sprache_aus_datei_name_2 = pfad_1_abfrage.Replace(@"..\..\..\Wörterbücher\", "").Split("+")[1];
            }

            else
            {
                SR = new StreamReader(pfad_2_abfrage);
                maxZeilenAnzahl = File.ReadLines(pfad_2_abfrage).Count();
                sprache_aus_datei_name_1 = pfad_2_abfrage.Replace(@"..\..\..\Wörterbücher\", "").Split("+")[0];
                sprache_aus_datei_name_2 = pfad_2_abfrage.Replace(@"..\..\..\Wörterbücher\", "").Split("+")[1];
            }


            var Rnd = new Random();
            int rndInt = Rnd.Next(0, 2);
            int rndInt2;

            do
            {
                rndInt2 = Rnd.Next(1, maxZeilenAnzahl + 1);
            } 
            while (rndInt2 == vorherigeRndZeile);
            vorherigeRndZeile = rndInt2;
            
            string sprache_1_vokabel = ""; // Der Variable muss ein Wert zugeweisen werden, da sonst ein Fehler erscheint
            string sprache_2_vokabel = "";
            string zeile;
            if(sprache_aus_datei_name_1 == abfrage_richtung_aussuchen.sprache_1)
            {
                for (int i = 0; i < rndInt2; i++)
                {
                    zeile = SR.ReadLine();
                    sprache_1_vokabel = zeile.Split("/")[0];
                    sprache_2_vokabel = zeile.Split("/")[1];
                    andere_sprache[sprache_1_vokabel] = sprache_2_vokabel;
                    andere_sprache[sprache_2_vokabel] = sprache_1_vokabel;
                }
            }
            else
            {
                for (int i = 0; i < rndInt2; i++)
                {
                    zeile = SR.ReadLine();
                    sprache_1_vokabel = zeile.Split("/")[1];
                    sprache_2_vokabel = zeile.Split("/")[0];
                    andere_sprache[sprache_1_vokabel] = sprache_2_vokabel;
                    andere_sprache[sprache_2_vokabel] = sprache_1_vokabel;
                }
            }
            
            if (rndInt == 1) // Dann deutsch
            {


                
                txt_Eingabe2.Text = sprache_1_vokabel;
                return andere_sprache[sprache_1_vokabel]; // Weißt du warum diese und

            }
            else
            {
                
                txt_Eingabe1.Text = sprache_2_vokabel;
                return andere_sprache[sprache_1_vokabel]; // diese Zeile sprach_1_vokabel nutzen??? Wenn ich hier oder oben 2 eintrage ist es falsch!
            }

            
        }

    }
}
