using Software_Projekt.View;
using System;
using System.Windows;

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

        private void OnOpenMainwindow(object sender, RoutedEventArgs e)
        {

        }

        private void OnOpenPopup(object sender, RoutedEventArgs e)
        {
            var PopupWindow = new IndicatorsPopup();
            PopupWindow.ShowDialog();
        }
    }
}
