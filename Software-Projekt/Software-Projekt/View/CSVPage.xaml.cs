using Microsoft.Win32;
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
    /// Interaktionslogik für CSVPage.xaml
    /// </summary>
    public partial class CSVPage : Page, INotifyPropertyChanged
    {
        private string path;
        public int amount;
        public string Path
        {
            get => path;
            set => OnPropertyChanged<string>(ref path, value);
        }
        public CSVPage()
        {
            InitializeComponent();
        }

        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OnClickContinue(object sender, RoutedEventArgs e)
        {
            if (Path == null)
            {
                MessageBox.Show("Datei auswählen!");
            }
            else
            {
                //DataDescriptionPage page = new DataDescriptionPage(Path);
                //this.NavigationService.Navigate(page);
                this.NavigationService.Navigate(new Uri("/view/datadescriptionpage.xaml", UriKind.Relative));

            }
        }
        private void OnClickGoBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/DataPage.xaml", UriKind.Relative));
        }

        private void OnOpenFile(object sender, RoutedEventArgs e)
        {
            amount = int.Parse(Amount.Text);


            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV files (*.csv)|*.csv";
            if (openFile.ShowDialog() == true)
            {
                Path = openFile.FileName;
            }
        }
        private void OnPropertyChanged<T>(ref T variable, T value, [CallerMemberName] string propertyName = null)
        {
            variable = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }

}
