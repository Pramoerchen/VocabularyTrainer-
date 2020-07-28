using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vokabeltrainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Vokabel_Eingabe(object sender, RoutedEventArgs e)
        {
            VokabelEingabe objVokabelEingabe = new VokabelEingabe(); // referenz auf das Fenster VokabelEingabe
            this.Visibility = Visibility.Hidden; //lässt das menü verschwinden
            objVokabelEingabe.Show(); // wechselt zur ins "VokabelEingabe" fenster

        }

        

        private void Vokabel_Test(object sender, RoutedEventArgs e)
        {
            VokabelTest objVokabelTest = new VokabelTest(); // referenz auf das Fenster VokabelTest
            this.Visibility = Visibility.Hidden; //lässt das menü verschwinden
            objVokabelTest.Show(); // wechselt zur ins "VokabelTest" fenster
        }

        private void Verlassen(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // beendet die anwendung
        }

    }
}
