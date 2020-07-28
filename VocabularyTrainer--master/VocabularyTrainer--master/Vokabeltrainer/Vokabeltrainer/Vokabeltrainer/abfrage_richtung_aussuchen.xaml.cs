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

namespace Vokabeltrainer
{
    /// <summary>
    /// Interaktionslogik für abfrage_richtung_aussuchen.xaml
    /// </summary>
    public partial class abfrage_richtung_aussuchen : Window
    {
        public abfrage_richtung_aussuchen()
        {
            InitializeComponent();
        }

        private void event_Abfrage(object sender, RoutedEventArgs e)
        {
            if(rdobtn_DeuRndEng.IsChecked == true)
            {
                VokabelTest objVokabelTest = new VokabelTest(); // referenz auf das Fenster VokabelEingabe
                this.Visibility = Visibility.Hidden; //lässt das menü verschwinden
                objVokabelTest.Show(); // wechselt VokabelTest ins "VokabelEingabe" fenster
            }
            if(rdobtn_DeuZuEng.IsChecked == true)
            {
                DeutschZuEnglisch objDeutschZuEnglisch = new DeutschZuEnglisch(); // referenz auf das Fenster VokabelEingabe
                this.Visibility = Visibility.Hidden; //lässt das menü verschwinden
                objDeutschZuEnglisch.Show(); // wechselt VokabelTest ins "VokabelEingabe" fenster
            }
            if(rdobtn_EngZuDeu.IsChecked == true)
            {
                EnglischZuDeutsch objEnglischZuDeutsch = new EnglischZuDeutsch(); // referenz auf das Fenster VokabelEingabe
                this.Visibility = Visibility.Hidden; //lässt das menü verschwinden
                objEnglischZuDeutsch.Show(); // wechselt VokabelTest ins "VokabelEingabe" fenster
            }
        }
    }
}
