using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
    /// Interaktionslogik für DataDescriptionPage.xaml
    /// </summary>
    public partial class DataDescriptionPage : Page
    {
        private string MetricScaleType;
        public DataDescriptionPage()
        {
            InitializeComponent();
        }

        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OnClickContinue(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/IndicatorSelectionPage.xaml", UriKind.Relative));
            (App.Current as App).Merkmalsausprägung = ComboBoxMerkmalsausprägung.Text;
            (App.Current as App).Ordnung = ComboBoxOrdnung.Text;
            if (ComboboxScaleType.Text == "Metrisch")
                (App.Current as App).MetricScaletype = MetricScaleType;
            (App.Current as App).Skalentyp = ComboboxScaleType.Text;
        }

        private void OnClickBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/DataPage.xaml", UriKind.Relative));
        }

        private void OnCheckIntervallskala(object sender, RoutedEventArgs e)
        {
            MetricScaleType = "Intervallskala";
        }

        private void OnCheckVerhältnisskala(object sender, RoutedEventArgs e)
        {
            MetricScaleType = "Verhältnisskala";
        }

        private void OnCheckAbsolutskala(object sender, RoutedEventArgs e)
        {
            MetricScaleType = "Absolutskala";
        }
    }
}
