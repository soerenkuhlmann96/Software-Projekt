using Software_Projekt.View;
using System;
using System.Windows;
using System.Windows.Controls;
using Software_Projekt.ViewModel;

namespace Software_Projekt
{
    /// <summary>
    /// Interaktionslogik für Indicators.xaml
    /// </summary>
    public partial class Indicators : Window
    {
        //Property to save button content



        public Indicators()
        {
            InitializeComponent();
            
        }

        private void OnOpenMainwindow(object sender, RoutedEventArgs e)
        {

        }

        private void OnOpenPopupNominal(object sender, RoutedEventArgs e)
        {
            ViewModel.ViewModel vm = new ViewModel.ViewModel();
            Model.IndicatorInformations info = new Model.IndicatorInformations();
            info = vm.SaveIndicator((e.Source as Button).Content.ToString(), "Nominal");

            var PopupWindow = new IndicatorsPopup(info);
            PopupWindow.ShowDialog();
        }

        private void OnOpenPopupOrdinal(object sender, RoutedEventArgs e)
        {
            ViewModel.ViewModel vm = new ViewModel.ViewModel();
            Model.IndicatorInformations info = new Model.IndicatorInformations();
            info = vm.SaveIndicator((e.Source as Button).Content.ToString(), "Ordinal");

            var PopupWindow = new IndicatorsPopup(info);
            PopupWindow.ShowDialog();
        }

        private void OnOpenPopupMetrisch(object sender, RoutedEventArgs e)
        {
            ViewModel.ViewModel vm = new ViewModel.ViewModel();
            Model.IndicatorInformations info = new Model.IndicatorInformations();
            info = vm.SaveIndicator((e.Source as Button).Content.ToString(), "Metrisch");

            var PopupWindow = new IndicatorsPopup(info);
            PopupWindow.ShowDialog();
        }

        private void OnClickBack(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();

        }

        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
