using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Software_Projekt.View
{
    /// <summary>
    /// Interaktionslogik für DataPage.xaml
    /// </summary>
    public partial class DataPage : Page
    {
        public DataPage()
        {
            InitializeComponent();
        }

        //Öffnet CSV Einlese Seite (CSVPage)
        private void OnOpenCSVPage(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/CSVPage.xaml", UriKind.Relative));
        }

        //Öffnet manuelle Eingabe Seite(Inputpage)
        private void OnOpenInputPage(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/InputPage.xaml", UriKind.Relative));
        }

        //Öffnet Hauptfenster und schließt aktuelles Fenster
        private void OnClickGoBackToMainWindow(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Show();
            string tag = "AnalyseWindow";
            ViewModel.ViewModel.CloseWIndowUsingIdentifier(tag);
        }

        //Beendet Programm
        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
