using System;
using System.Windows;
using System.Windows.Controls;

namespace Software_Projekt.View
{
    /// <summary>
    /// Interaktionslogik für Page1Analyse.xaml
    /// </summary>
    public partial class Page1Analyse : Page
    {
        public Page1Analyse()
        {
            InitializeComponent();
        }

        private void OnReadFile(object sender, RoutedEventArgs e)
        {

        }

        private void OnOpenNextPage(object sender, RoutedEventArgs e)
        {
            //überprüfung ob Angaben gemacht wurden
            if (IndicatorCombobox.SelectedIndex > -1 && ScaleTypeCombobox.SelectedIndex > -1)
            {
                //Erstellen der Liste mit möglichen Kennzahlen



                //Nächste Seite anzeigen
                Uri uri = new Uri("/View/Page2Analyse.xaml", UriKind.Relative);
                this.NavigationService.Navigate(uri);
            }

            //Fehlermeldungen wenn Comboboxen nicht Ausgewählt wurden
            else if (IndicatorCombobox.SelectedIndex == -1 && ScaleTypeCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte Kennzahl und Skalentyp angeben.");
            }
            
            else if (IndicatorCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte Kennzahl angeben.");
            }
            
            else
            {
                MessageBox.Show("Bitte Skalentyp angeben.");
            }

        }
    }
}
