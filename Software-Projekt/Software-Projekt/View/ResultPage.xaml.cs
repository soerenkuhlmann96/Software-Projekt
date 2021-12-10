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
    /// Interaktionslogik für ResultPage.xaml
    /// </summary>
    public partial class ResultPage : Page, INotifyPropertyChanged
    {
        private string resultText;
        private string infoText;

        public string InfoText 
        { 
            get => infoText;
            set => OnPropertyChanged<string>(ref infoText, value); 
        }
        public string ResultText
        {
            get => resultText;
            set => OnPropertyChanged<string>(ref resultText, value);
        }
        public ResultPage()
        {
            InitializeComponent();
            ViewModel.ViewModelCalculation vmCalculation = new ViewModel.ViewModelCalculation("Path", "Indicator",1);
            ResultText = vmCalculation.Result.ToString();
        }

        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OnClickBackToMainWindow(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Show();
            string tag = "AnalyseWindow";
            ViewModel.ViewModel.CloseWIndowUsingIdentifier(tag);
        }

        private void OnClickBackToPreviousPage(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/IndicatorSelectionPage.xaml", UriKind.Relative));
        }
        private void OnPropertyChanged<T>(ref T variable, T value, [CallerMemberName] string propertyName = null)
        {
            variable = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
