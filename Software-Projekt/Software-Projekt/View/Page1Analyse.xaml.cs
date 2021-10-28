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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            Uri uri = new Uri("/View/Page2Analyse.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}
