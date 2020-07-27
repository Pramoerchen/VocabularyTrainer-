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
        public VokabelTest()
        {
            InitializeComponent();
        }

        private void Btn_Bestätigen(object sender, RoutedEventArgs e)
        {
            VokabelnHolen();
        }

        private void Btn_Zurück(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow(); // referenz auf das Fenster VokabelEingabe
            this.Visibility = Visibility.Hidden; //lässt das menü verschwinden
            objMainWindow.Show(); // wechselt zur ins "VokabelEingabe" fenster
        }
        void VokabelnHolen()
        {
            StreamReader SR = new StreamReader(@"C:\Users\Starc\Documents\GitHub\VocabularyTrainer-\Vokabeltrainer\Vokabeltrainer\Vokabeltrainer\Wörterbücher\Deutsch+Englisch.txt");
            int maxZeilenAnzahl = File.ReadLines(@"C:\Users\Starc\Documents\GitHub\VocabularyTrainer-\Vokabeltrainer\Vokabeltrainer\Vokabeltrainer\Wörterbücher\Deutsch+Englisch.txt").Count(); // enthält die zeilen anzahl
            var Rnd = new Random();
            int rndInt = Rnd.Next(1, maxZeilenAnzahl);
            for(int i = 0; i <rndInt;i++)
            {
                SR.ReadLine();
            }
            if (rndInt % 2!= 0) // Dann deutsch
            {
                txt_Eingabe2.Text = SR.ReadLine();
            }
            else
            {
                txt_Eingabe1.Text = SR.ReadLine();
            }
        }
    }
}
