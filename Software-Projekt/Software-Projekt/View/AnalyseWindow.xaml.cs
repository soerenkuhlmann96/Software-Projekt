using System;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Navigation;

namespace Software_Projekt.View
{
    /// <summary>
    /// Interaktionslogik für AnalyseWindow.xaml
    /// </summary>
    public partial class AnalyseWindow : NavigationWindow
    {
        public AnalyseWindow()
        {
            InitializeComponent();
        }

        private void OnReadFile(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                Filter = "spreadsheet|*.csv;"
            };
            if (dialog.ShowDialog(this) == true)
            {
                Uri uri = new Uri(dialog.FileName);
                //Datei einlesen (Klasse)
            }
        }
    }
}
