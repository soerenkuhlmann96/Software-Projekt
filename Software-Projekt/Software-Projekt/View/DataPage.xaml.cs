using System;
using System.Collections.Generic;
using System.Reflection;
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
    /// Interaktionslogik für DataPage.xaml
    /// </summary>
    public partial class DataPage : Page
    {
        public DataPage()
        {
            InitializeComponent();
        }

        private void OnOpenCSVPopup(object sender, RoutedEventArgs e)
        {
            var PopupWindow = new CSVPopupWindow();
            PopupWindow.ShowDialog();
        }

        private void OnOpenDataDiscriptionPopup(object sender, RoutedEventArgs e)
        {
            var PopupWindow = new InputPopupWindow();
            PopupWindow.ShowDialog();
        }

        private void OnClickGoBackToMainWindow(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Show();
            string tag = "AnalyseWindow";
            ViewModel.ViewModel.CloseWIndowUsingIdentifier(tag);
        }

        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OnClickContiue(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/DataDescriptionPage.xaml", UriKind.Relative));
        }
    }
}
