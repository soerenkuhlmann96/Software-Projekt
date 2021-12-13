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
    /// Interaktionslogik für IndicatorSelectionPage.xaml
    /// </summary>
    public partial class IndicatorSelectionPage : Page, INotifyPropertyChanged
    {
        private string choosenIndicator = "Auswählen";
        private string choosenScaleType;
        public string ChoosenIndicator
        {
            get => choosenIndicator;
            set => OnPropertyChanged<string>(ref choosenIndicator, value);
        }
        public string ChoosenScaleType
        {
            get => choosenScaleType;
            set => OnPropertyChanged<string>(ref choosenScaleType, value);
        }

        public IndicatorSelectionPage()
        {
            InitializeComponent();
            ShowListBox();
        }

        //Fügt der ListBox Buttons mit Kennzahlen des Ausgewählten Skalentyps hinzu 
        private void ShowListBox()
        {
            ChoosenScaleType = (App.Current as App).Skalentyp;
            ViewModel.ViewModel viewModel = new ViewModel.ViewModel();

            if (ChoosenScaleType == "Nominal")
            {
                foreach (var indicator in viewModel.IndicatorsNominal)
                {
                    Button button = new Button();
                    button.Content = indicator.Name;
                    button.Click += OnSelectIndicator;
                    button.Width = 300;
                    ListBox.Items.Add(button);
                }
            }
            else if (ChoosenScaleType == "Ordinal")
            {
                foreach (var indicator in viewModel.IndicatorsOrdinal)
                {
                    Button button = new Button();
                    button.Content = indicator.Name;
                    button.Click += OnSelectIndicator;
                    button.Width = 300;
                    ListBox.Items.Add(button);
                }
            }
            else
            {
                foreach (var indicator in viewModel.IndicatorsMetrisch)
                {
                    Button button = new Button();
                    button.Content = indicator.Name;
                    button.Click += OnSelectIndicator;
                    button.Width = 300;
                    ListBox.Items.Add(button);
                }
            }
        }

        // Beendet Programm
        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Öffnet nächste Seite (ResultPage)
        private void OnClickContinue(object sender, RoutedEventArgs e)
        {
            if (ChoosenIndicator != "Auswählen")
            {
            this.NavigationService.Navigate(new Uri("/View/ResultPage.xaml", UriKind.Relative));
            (App.Current as App).ChoosenIndicator = ChoosenIndicator;
            }
            else
            {
                MessageBox.Show("Bitte Kennzahl auswählen");
            }
        }

        // Öffnet vorheriges Fenster (DataDescriptionPage)
        private void OnClickBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/DataDescriptionPage.xaml", UriKind.Relative));
        }

        //Speichert ausgewählte Kennzahl in der Variablen ChoosenIndicator
        private void OnSelectIndicator(object sender, RoutedEventArgs e)
        {
            ChoosenIndicator = (sender as System.Windows.Controls.Button).Content.ToString();
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
