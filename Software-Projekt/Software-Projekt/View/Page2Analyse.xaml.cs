using System;
using System.Windows;
using System.Windows.Controls;

namespace Software_Projekt.View
{
    /// <summary>
    /// Interaktionslogik für Page2Analyse.xaml
    /// </summary>
    public partial class Page2Analyse : Page
    {
        public Page2Analyse()
        {
            InitializeComponent();
        }

        private void OnReadFile(object sender, RoutedEventArgs e)
        {

        }

        private void OnOpenNextPage(object sender, RoutedEventArgs e)
        {
            //überprüfung ob Angaben gemacht wurden
            if (true)
            {

                Uri uri = new Uri("/View/Page3Analyse.xaml", UriKind.Relative);
                this.NavigationService.Navigate(uri);
            }
            else
            {
                MessageBox.Show("Wählen sie eine Kennzahl aus");
            }

        }
    }
}
