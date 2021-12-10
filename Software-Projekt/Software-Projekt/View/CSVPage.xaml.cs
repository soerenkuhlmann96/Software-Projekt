using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        private List<double[]> DataSeries = new List<double[]>(); //Erstellt neue Liste um Daten für Weiterbearbeitung zu speichern
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

        //Beendet das Programm
        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /** öffnet Datenbeschreibungsfenster (DataDescriptionPage) und Speichert Eingelesene CSV Datei in der App.xaml.cs
         * wenn keine Datei eingelesen wurde Erscheint eine Fehlermeldung, dass eine CSV Ausgewählt werden soll.
         * wenn eine Datei eingelesen wird, wird die Check Methode aufgerufen um zu überprüfen ob die Eingelesene Datei über die angegebene Menge an Datenreihen verfügt.
         */
        private void OnClickContinue(object sender, RoutedEventArgs e)
        {
            if (Path == null)
            {
                MessageBox.Show("Datei auswählen!");
            }
            else
            {
                amount = int.Parse(Amount.Text);

                bool check = Check(Path, amount);
                if (check == false)
                {
                    MessageBox.Show("Zu hohe Anzahl von Zahlenreihen");
                }
                else
                {
                ViewModel.ViewModelDataReader reader = new ViewModel.ViewModelDataReader();
                DataSeries = reader.Load(Path, amount);

                this.NavigationService.Navigate(new Uri("/view/datadescriptionpage.xaml", UriKind.Relative));
                (App.Current as App).DataSeries = DataSeries;

                }
                
            }
        }

        //öffnet vorherige Seite (DataPage)
        private void OnClickGoBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/DataPage.xaml", UriKind.Relative));
        }

        /*öffnet Datei Explorer
         * der Dateipfad wird in der Variablen Path gespeichert
         * in der Textbox wird der neue Pfad angezeigt
         */ 
        private void OnOpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV files (*.csv)|*.csv";
            if (openFile.ShowDialog() == true)
            {
                Path = openFile.FileName;
            }
        }

        //Überprüft ob die Eingelesene Datei über die angegebene Menge an Datenreihen verfügt.
        private bool Check(string Path, int amount)
        {
            bool result = true;

            using (StreamReader reader = new StreamReader(Path))
            {
                string line = reader.ReadLine();
                string[] characters = line.Split(';');
                if (characters.Length < amount)
                    result = false;
            }
            return result;
        }

        //Aktualisiert geänderte Daten im Fenster
        private void OnPropertyChanged<T>(ref T variable, T value, [CallerMemberName] string propertyName = null)
        {
            variable = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }

}
