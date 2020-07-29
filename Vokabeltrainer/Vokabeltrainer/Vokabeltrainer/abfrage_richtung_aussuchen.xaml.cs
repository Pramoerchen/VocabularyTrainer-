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
        public List<string> sprachen = new List<string>()
        {
            "Französisch", "Spanisch", "Latein" // Sprachen können hier einfach ergänzt werden Deutsch und Englisch sind automatisch dabei
        }; 
        
        public abfrage_richtung_aussuchen()
        {
            InitializeComponent();
            foreach(string item in sprachen)
            {
                sprache_1_selector.Items.Add(item);
                sprache_2_selector.Items.Add(item);
            }
            
        }

        private void event_Abfrage(object sender, RoutedEventArgs e)
        {
            if(rdobtn_DeuRndEng.IsChecked == true)
            {
                VokabelTest objVokabelTest = new VokabelTest(); // referenz auf das Fenster VokabelEingabe
                this.Visibility = Visibility.Hidden; //lässt das menü verschwinden
                objVokabelTest.Show(); // wechselt VokabelTest ins "VokabelEingabe" fenster
            }
            else if(rdobtn_DeuZuEng.IsChecked == true) // Falls du dich fragst warum "else if" statt nur "if": Wenn das erste True ist, wird hier nicht mehr geprüft. Das spart Arbeitsspeicher.
            {
                DeutschZuEnglisch objDeutschZuEnglisch = new DeutschZuEnglisch(); // referenz auf das Fenster VokabelEingabe
                this.Visibility = Visibility.Hidden; //lässt das menü verschwinden
                objDeutschZuEnglisch.Show(); // wechselt VokabelTest ins "VokabelEingabe" fenster
            }
            else if(rdobtn_EngZuDeu.IsChecked == true)
            {
                EnglischZuDeutsch objEnglischZuDeutsch = new EnglischZuDeutsch(); // referenz auf das Fenster VokabelEingabe
                this.Visibility = Visibility.Hidden; //lässt das menü verschwinden
                objEnglischZuDeutsch.Show(); // wechselt VokabelTest ins "VokabelEingabe" fenster
            }
        }

        

        

        private void sprache_1_selector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var selected_item = sprache_1_selector.SelectedItem;
            var beide_sprachen = rdobtn_DeuZuEng.Content.ToString().Split(" -> ");
            

            
            sprache_2_selector.Items.Remove(selected_item);

            if (!sprache_1_selector.Items.Contains(beide_sprachen[0])) 
            {
                sprache_1_selector.Items.Add(beide_sprachen[0]);
            }

            if (!sprache_2_selector.Items.Contains(beide_sprachen[0]))
            {
                sprache_2_selector.Items.Add(beide_sprachen[0]);
            }


            
            


            rdobtn_DeuZuEng.Content = selected_item + " -> " + beide_sprachen[1];
            rdobtn_EngZuDeu.Content = selected_item + " <- " + beide_sprachen[1];
            rdobtn_DeuRndEng.Content = selected_item + " <-> " + beide_sprachen[1];





        }

        private void sprache_2_selector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected_item = sprache_2_selector.SelectedItem;
            var test_var = rdobtn_DeuZuEng.Content.ToString().Split(" -> ");

            sprache_1_selector.Items.Remove(selected_item);
            if (!sprache_1_selector.Items.Contains(test_var[1]))
            {
                sprache_1_selector.Items.Add(test_var[1]);
            }

            if (!sprache_2_selector.Items.Contains(test_var[1]))
            {
                sprache_2_selector.Items.Add(test_var[1]);
            }

            rdobtn_DeuZuEng.Content = test_var[0] + " -> " + selected_item;
            rdobtn_EngZuDeu.Content =   test_var[0] + " <- " + selected_item;
            rdobtn_DeuRndEng.Content = test_var[0] + " <-> " + selected_item;
        }
    }
}
