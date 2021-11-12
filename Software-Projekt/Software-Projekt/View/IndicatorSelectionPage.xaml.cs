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
    /// Interaktionslogik für IndicatorSelectionPage.xaml
    /// </summary>
    public partial class IndicatorSelectionPage : Page
    {
        public IndicatorSelectionPage()
        {
            InitializeComponent();
        }

        // Close Application
        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Go to next Page
        private void OnClickContinue(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/ResultPage.xaml", UriKind.Relative));
        }

        // Go back to Previous Page
        private void OnClickBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/DataDescriptionPage.xaml", UriKind.Relative));
        }
    }
}
