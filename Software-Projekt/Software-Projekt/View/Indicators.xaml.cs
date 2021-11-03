using Software_Projekt.View;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Software_Projekt
{
    /// <summary>
    /// Interaktionslogik für Indicators.xaml
    /// </summary>
    public partial class Indicators : Window
    {
        //Property to save button content
        private string _IndicatorName;
        public string IndicatorName 
        { 
            get => _IndicatorName; 
        }
        public Indicators()
        {
            InitializeComponent();
            
        }

        private void OnOpenMainwindow(object sender, RoutedEventArgs e)
        {

        }

        private void OnOpenPopup(object sender, RoutedEventArgs e)
        {
            //saving button content into Property
            _IndicatorName = (e.Source as Button).Content.ToString();
            var PopupWindow = new IndicatorsPopup();
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
