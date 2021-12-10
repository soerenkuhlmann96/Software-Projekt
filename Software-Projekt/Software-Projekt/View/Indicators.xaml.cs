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

        public Indicators()
        {
            InitializeComponent();
            
        }

        //Öffnet PopupFenster mit Nominalen Kennzahl
        private void OnOpenPopupNominal(object sender, RoutedEventArgs e)
        {
            ViewModel.ViewModel vm = new ViewModel.ViewModel();
            Model.IndicatorInformations info = new Model.IndicatorInformations();
            info = vm.SaveIndicator((e.Source as Button).Content.ToString(), "Nominal");

            var PopupWindow = new IndicatorsPopup(info);
            PopupWindow.ShowDialog();
        }

        //Öffnet PopupFenster mit Ordinalen Kennzahl
        private void OnOpenPopupOrdinal(object sender, RoutedEventArgs e)
        {
            ViewModel.ViewModel vm = new ViewModel.ViewModel();
            Model.IndicatorInformations info = new Model.IndicatorInformations();
            info = vm.SaveIndicator((e.Source as Button).Content.ToString(), "Ordinal");

            var PopupWindow = new IndicatorsPopup(info);
            PopupWindow.ShowDialog();
        }

        //Öffnet PopupFenster mit Metrischer Kennzahl
        private void OnOpenPopupMetrisch(object sender, RoutedEventArgs e)
        {
            ViewModel.ViewModel vm = new ViewModel.ViewModel();
            Model.IndicatorInformations info = new Model.IndicatorInformations();
            info = vm.SaveIndicator((e.Source as Button).Content.ToString(), "Metrisch");

            var PopupWindow = new IndicatorsPopup(info);
            PopupWindow.ShowDialog();
        }

        //Schließt aktuelles Fenster und öffnet Hauptfenster
        private void OnClickBack(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();

        }

        //Beendet Programm
        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
