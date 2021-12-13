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
    /// Interaktionslogik für HelpPopupWindow.xaml
    /// </summary>
    public partial class HelpPopupWindow : Window
    {
        public HelpPopupWindow()
        {
            InitializeComponent();
        }

        //Speichert das Ergebnis der Fragen in der App.xaml.cs um im Hauptfenster den richtigen Skalentypen anzeigen zu können.
        private void OnClickConfirm(object sender, RoutedEventArgs e)
        {
            if (Combobox1.SelectedIndex == 0)
            {
                (App.Current as App).ScaletypeIndex = 0;

            }
            else
            {
                if (Combobox2.SelectedIndex == 0)
                {
                    (App.Current as App).ScaletypeIndex = 1;
                }
                else
                {
                    if (Combobox3.SelectedIndex == 0)
                    {
                        (App.Current as App).ScaletypeIndex = 2;
                        (App.Current as App).MetricScaletype = "Intervallskala";
                    }
                    else
                    {
                        if (Combobox4.SelectedIndex == 1)
                        {
                            (App.Current as App).ScaletypeIndex = 2;
                            (App.Current as App).MetricScaletype = "Verhältnisskala";
                        }
                        else
                        {
                            (App.Current as App).ScaletypeIndex = 2;
                            (App.Current as App).MetricScaletype = "Absolutskala";
                        }
                    }
                }
            }
            this.Close();
        }

        private void OnCombobox1SelectionChange(object sender, SelectionChangedEventArgs e)
        {
            if (Combobox1.SelectedIndex == 1)
            {
                Question2.Visibility = Visibility.Visible;
            }
            else
            {
                if (Question2 != null)
                {
                    Question2.Visibility = Visibility.Collapsed;
                    Question3.Visibility = Visibility.Collapsed;
                    Question4.Visibility = Visibility.Collapsed;
                }
            }


        }
        private void OnCombobox2SelectionChange(object sender, SelectionChangedEventArgs e)
        {
            if (Combobox2.SelectedIndex == 1)
                Question3.Visibility = Visibility.Visible;
            else
            {
                if (Question3 != null)
                {
                    Question3.Visibility = Visibility.Collapsed;
                    Question4.Visibility = Visibility.Collapsed;
                }
            }
        }
        private void OnCombobox3SelectionChange(object sender, SelectionChangedEventArgs e)
        {
            if (Combobox3.SelectedIndex == 1)
                Question4.Visibility = Visibility.Visible;
            else
            {
                if (Question4 != null)
                {
                    Question4.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
