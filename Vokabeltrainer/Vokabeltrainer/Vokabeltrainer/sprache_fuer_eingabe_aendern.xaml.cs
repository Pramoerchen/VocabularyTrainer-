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

namespace Vokabeltrainer
{
    /// <summary>
    /// Interaktionslogik für sprache_fuer_eingabe_aendern.xaml
    /// </summary>
    public partial class sprache_fuer_eingabe_aendern : Window
    {
        public List<string> sprachen = abfrage_richtung_aussuchen.sprachen;
        

        

        public sprache_fuer_eingabe_aendern()
        {
            InitializeComponent();
            foreach (string sprache in sprachen)
            {
                sprache_1_selector.Items.Add(sprache);
                sprache_2_selector.Items.Add(sprache);
            }

        }

        public static string pfad_1; 
        public static string pfad_2;
        public static string lang_1;
        public static string lang_2;

        





        private void sprache_1_selector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var selected_item = sprache_1_selector.SelectedItem;
            var test_var = abfrage_starten_btn.Content.ToString().Replace(" eingeben", "").Split(" + ");

            lang_1 = selected_item.ToString();

            sprache_2_selector.Items.Remove(selected_item);

            if (!sprache_1_selector.Items.Contains(test_var[0]))
            {
                sprache_1_selector.Items.Add(test_var[0]);
            }

            if (!sprache_2_selector.Items.Contains(test_var[0]))
            {
                sprache_2_selector.Items.Add(test_var[0]);
            }






            abfrage_starten_btn.Content = selected_item.ToString() + " + " + test_var[1] + " eingeben";
            





        }

        private void sprache_2_selector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected_item = sprache_2_selector.SelectedItem;
            var beide_sprachen = abfrage_starten_btn.Content.ToString().Replace(" eingeben", "").Split(" + ");

            lang_1 = selected_item.ToString();

            sprache_1_selector.Items.Remove(selected_item);
            if (!sprache_1_selector.Items.Contains(beide_sprachen[1]))
            {
                sprache_1_selector.Items.Add(beide_sprachen[1]);
            }

            if (!sprache_2_selector.Items.Contains(beide_sprachen[1]))
            {
                sprache_2_selector.Items.Add(beide_sprachen[1]);
            }

            abfrage_starten_btn.Content = beide_sprachen[0] + " + " + selected_item + " eingeben";
            
        }

        private void abfrage_starten_btn_Click(object sender, RoutedEventArgs e)
        {
            pfad_1 = @"..\..\..\Wörterbücher\" + abfrage_starten_btn.Content.ToString().Replace(" eingeben", "").Split(" + ")[0] + "+" + abfrage_starten_btn.Content.ToString().Replace(" eingeben", "").Split(" + ")[1] + ".txt";
            pfad_2 = @"..\..\..\Wörterbücher\" + abfrage_starten_btn.Content.ToString().Replace(" eingeben", "").Split(" + ")[1] + "+" + abfrage_starten_btn.Content.ToString().Replace(" eingeben", "").Split(" + ")[0] + ".txt";

            

            if ((!File.Exists(pfad_1)) && (!File.Exists(pfad_2)))
            {
                File.Create(pfad_1);
            }
            
            

            
            

            

            

            VokabelEingabe objVokabelEingabe = new VokabelEingabe();
            this.Visibility = Visibility.Hidden; 
            objVokabelEingabe.Show();
        }

        private void zurück_abfrage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Show();
        }
    }
}
