﻿using System;
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
    /// Interaktionslogik für DeutschZuEnglisch.xaml
    /// </summary>
    public partial class DeutschZuEnglisch : Window
    {

        public string richtige_vokabel;
        public int vorherigeRndZeile;

        Dictionary<string, string> andere_sprache = new Dictionary<string, string>();


        public DeutschZuEnglisch()
        {
            InitializeComponent();

            richtige_vokabel = VokabelnHolen();
        }

        private void Btn_Zurück(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow(); // referenz auf das Fenster VokabelEingabe
            this.Visibility = Visibility.Hidden; //lässt das menü verschwinden
            objMainWindow.Show(); // wechselt zur ins "VokabelEingabe" fenster
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

        string VokabelnHolen()
        {
            txt_Eingabe1.Clear();
            txt_Eingabe2.Clear();

            StreamReader SR = new StreamReader(@"..\..\..\Wörterbücher\Deutsch+Englisch.txt");
            int maxZeilenAnzahl = File.ReadLines(@"..\..\..\Wörterbücher\Deutsch+Englisch.txt").Count(); // enthält die zeilen anzahl
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
            for (int i = 0; i < rndInt2; i++)
            {
                zeile = SR.ReadLine();
                sprache_1_vokabel = zeile.Split("/")[0];
                sprache_2_vokabel = zeile.Split("/")[1];
                andere_sprache[sprache_1_vokabel] = sprache_2_vokabel;
                andere_sprache[sprache_2_vokabel] = sprache_1_vokabel;
            }
                txt_Eingabe2.Text = sprache_1_vokabel;
                return andere_sprache[sprache_1_vokabel]; 

            
            


        }
    }
}