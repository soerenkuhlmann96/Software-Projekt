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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Software_Projekt.View
{
    /// <summary>
    /// Interaktionslogik für InputPage.xaml
    /// </summary>
    public partial class InputPage : Page
    {
        private List<double[]> DataSeries = new List<double[]>(); //Erstellt neue Liste um Daten für Weiterbearbeitung zu speichern
        private int amount = 1;
        public InputPage()
        {
            InitializeComponent();
        }

        //Ruft nächste seite auf (DataDescriptionPage) und speichert Eingegebene Daten und Anzahl der Datenreihen in der App.xaml.cs
        //Bei unausreichender eingabe wird ein Infofenster aufgerufen
        private void OnClickContinue(object sender, RoutedEventArgs e)
        {
            if (SaveData() == true) //speichert eingegebene Datenreihen in Variable DataSeries und überprüft ob eingaben gemacht wurden
            {
                if (DataSeries != null)
                {
                    (App.Current as App).DataSeries = DataSeries;
                    (App.Current as App).Amount = ComboboxAmount.SelectedIndex + 1;
                    this.NavigationService.Navigate(new Uri("/View/DataDescriptionPage.xaml", UriKind.Relative));
                }
                else
                {
                MessageBox.Show("Bitte Datenreihen eingeben!");
                }
            }
            else
            {
                MessageBox.Show("Bitte Datenreihen eingeben!");
            }
        }

        //Beendet Programm
        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //Ruft vorherige Seite auf(DataPage)
        private void OnClickGoBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/DataPage.xaml", UriKind.Relative));
        }

        //Aktualisiert Menge der angezeigten Eingabemöglichkeiten
        private void OnComboboxAmountSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;
            amount = int.Parse(text);


            if (text == "1")
            {
                if (Stackpanel1 != null) //Bei initialisierung ist Stackpanel1 null. Es würde eine Fehlermeldung geben.
                {
                    Stackpanel1.Visibility = Visibility.Collapsed;
                    Stackpanel2.Visibility = Visibility.Collapsed;
                    Stackpanel3.Visibility = Visibility.Collapsed;
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                }
            }
            else if (text == "2")
            {
                Stackpanel1.Visibility = Visibility.Visible;
                Stackpanel2.Visibility = Visibility.Collapsed;
                Stackpanel3.Visibility = Visibility.Collapsed;
                TextBox3.Text = "";
                TextBox4.Text = "";

            }
            else if (text == "3")
            {
                Stackpanel1.Visibility = Visibility.Visible;
                Stackpanel2.Visibility = Visibility.Visible;
                Stackpanel3.Visibility = Visibility.Collapsed;
                TextBox4.Text = "";
            }
            else if (text == "4")
            {
                Stackpanel1.Visibility = Visibility.Visible;
                Stackpanel2.Visibility = Visibility.Visible;
                Stackpanel3.Visibility = Visibility.Visible;
            }
        }

        //Speichert Eingegebene Datenreihen in der Variablen DataSeries
        public bool SaveData()
        {
            if (TextBox1.Text == "")
                return false;

            double[] series = new double[0];
            string text;
            string[] seperatedText;

            text = TextBox1.Text;
            seperatedText = text.Split(';');
            for (int i = 0; i < seperatedText.Length; i++)
            {
                Array.Resize(ref series, series.Length + 1);
                series[i] = double.Parse(seperatedText[i]);
            }

            DataSeries.Add(series);
            if (amount > 1)
            {
                if (TextBox2.Text == "")
                    return false;

                Array.Resize(ref series, 0);

                text = TextBox2.Text;
                seperatedText = text.Split(';');
                for (int i = 0; i < seperatedText.Length; i++)
                {
                    Array.Resize(ref series, series.Length + 1);
                    series[i] = double.Parse(seperatedText[i]);
                }
                DataSeries.Add(series);
            }
            if (amount > 2)
            {
                if (TextBox3.Text == "")
                    return false;

                Array.Resize(ref series, 0);

                text = TextBox3.Text;
                seperatedText = text.Split(';');
                for (int i = 0; i < seperatedText.Length; i++)
                {
                    Array.Resize(ref series, series.Length + 1);
                    series[i] = double.Parse(seperatedText[i]);
                }
                DataSeries.Add(series);
            }
            if (amount > 3)
            {
                if (TextBox4.Text == "")
                    return false;

                Array.Resize(ref series, 0);

                text = TextBox4.Text;
                seperatedText = text.Split(';');
                for (int i = 0; i < seperatedText.Length; i++)
                {
                    Array.Resize(ref series, series.Length + 1);
                    series[i] = double.Parse(seperatedText[i]);
                }
                DataSeries.Add(series);
            }
            return true;
        }
    }
}
