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
using System.Windows.Shapes;

namespace Software_Projekt.View
{
    /// <summary>
    /// Interaktionslogik für CSVPopupWindow.xaml
    /// </summary>
    public partial class CSVPopupWindow : Window
    {
        public CSVPopupWindow()
        {
            InitializeComponent();
        }

        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OnClickContinue(object sender, RoutedEventArgs e)
        {
            // Daten einlesen
            this.Close();
        }
    }
}
