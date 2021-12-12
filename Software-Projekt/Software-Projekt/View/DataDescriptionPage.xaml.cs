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
    /// Interaktionslogik für DataDescriptionPage.xaml
    /// </summary>
    public partial class DataDescriptionPage : Page
    {
        private string MetricScaleType;
        private int amount;
        private string[] description;
        public DataDescriptionPage()
        {
            InitializeComponent();
            amount = (App.Current as App).Amount; //Liest die anzahl der Übergebenen Datenreihen aus der App.xaml.cs
            ShowChoices();
        }

        //Beendet Programm
        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //öffnet nächste Seite (IndicatorSelectionPage) und Speichert die Datenbeschreibung in der App.xaml.cs
        private void OnClickContinue(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/IndicatorSelectionPage.xaml", UriKind.Relative));
            if (ComboboxScaleType.Text == "Metrisch")
                (App.Current as App).MetricScaletype = MetricScaleType;
            (App.Current as App).Skalentyp = ComboboxScaleType.Text;
            SaveDescription();
            (App.Current as App).description = description;
        }

        //Öffnet vorherige Seite (DataPage)
        private void OnClickBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/DataPage.xaml", UriKind.Relative));
        }

        //Ändert gespeicherten SKalentyp auf "Intervallskala
        private void OnCheckIntervallskala(object sender, RoutedEventArgs e)
        {
            MetricScaleType = "Intervallskala";
        }

        //Ändert gespeicherten SKalentyp auf Verhältnisskala
        private void OnCheckVerhältnisskala(object sender, RoutedEventArgs e)
        {
            MetricScaleType = "Verhältnisskala";
        }

        //Ändert gespeicherten SKalentyp auf Absolutskala
        private void OnCheckAbsolutskala(object sender, RoutedEventArgs e)
        {
            MetricScaleType = "Absolutskala";
        }

        private void OnClickHelp(object sender, RoutedEventArgs e)
        {
            var PopupWindow = new HelpPopupWindow();
            PopupWindow.ShowDialog();
            //update Skalentyp
        }
        //Macht richtige anzahl an Beschreibemöglichkeiten der Daten sichtbar
        private void ShowChoices()
        {
            if (amount == 1)
            {
            }
            else if (amount == 2)
            {
                StackPanelCombobox2.Visibility = Visibility.Visible;
            }
            else if (amount == 3)
            {
                StackPanelCombobox2.Visibility = Visibility.Visible;
                StackPanelCombobox3.Visibility = Visibility.Visible;
            }
            else
            {
                StackPanelCombobox2.Visibility = Visibility.Visible;
                StackPanelCombobox3.Visibility = Visibility.Visible;
                StackPanelCombobox4.Visibility = Visibility.Visible;
            }
        }
        //Speichert Beschreibung der Datenreihen in der App.xaml.cs
        private void SaveDescription()
        {
            Array.Resize(ref description, amount);
            if (amount == 1)
            {
                description[0] = ComboBox1.Text;
            }
            else if (amount == 2)
            {
                description[0] = ComboBox1.Text;
                description[1] = ComboBox2.Text;
            }
            else if (amount == 3)
            {
                description[0] = ComboBox1.Text;
                description[1] = ComboBox2.Text;
                description[2] = ComboBox3.Text;
            }
            else
            {
                description[0] = ComboBox1.Text;
                description[1] = ComboBox2.Text;
                description[2] = ComboBox3.Text;
                description[3] = ComboBox4.Text;
            }
        }
    }
}
