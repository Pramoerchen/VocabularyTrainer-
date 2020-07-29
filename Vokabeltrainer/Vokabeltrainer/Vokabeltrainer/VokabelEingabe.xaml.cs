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
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class VokabelEingabe : Window
    {
        public VokabelEingabe()
        {
            InitializeComponent();
        }

        void vokabel_schreiben()
        {

            StreamWriter sW = new StreamWriter(@"..\..\..\Wörterbücher\Deutsch+Englisch.txt",true); 

            sW.WriteLine(sprache_2_textbox.Text+"/"+sprache_1_textbox.Text);
            

            sW.Close();



        }

        private void Zurück_Klick(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow(); // referenz auf das Fenster VokabelEingabe
            this.Visibility = Visibility.Hidden; //lässt das menü verschwinden
            objMainWindow.Show(); // wechselt zur ins "VokabelEingabe" fenster
        }

        

        private void enter_voc_Click(object sender, RoutedEventArgs e)
        {
            vokabel_schreiben();
            sprache_1_textbox.Clear();
            sprache_2_textbox.Clear();
            
        }
    }
}
