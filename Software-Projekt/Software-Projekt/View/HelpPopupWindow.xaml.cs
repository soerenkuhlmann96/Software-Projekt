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
            if (Combobox1.SelectedIndex == 1)
            {
                (App.Current as App).Skalentyp = "irgendwas";

            }
            else
            {
                if (Combobox2.SelectedIndex == 1)
                {
                    (App.Current as App).Skalentyp = "irgendwas";
                }
                else
                {
                    if (Combobox3.SelectedIndex == 1)
                    {
                        (App.Current as App).Skalentyp = "Metrisch";
                        (App.Current as App).MetricScaletype = "Intervallskala";
                    }
                    else
                    {
                        if (Combobox4.SelectedIndex == 1)
                        {
                            (App.Current as App).Skalentyp = "Metrisch";
                            (App.Current as App).MetricScaletype = "Verhältnisskala";
                        }
                        else
                        {
                            if (Combobox5.SelectedIndex == 1)
                            {
                                (App.Current as App).Skalentyp = "Metrisch";
                                (App.Current as App).MetricScaletype = "Absolutskala";
                            }
                            else
                            {
                                (App.Current as App).Skalentyp = "Metrisch";
                                (App.Current as App).MetricScaletype = "Absolutskala";
                            }
                        }
                    }
                }
            }
            this.Close();
        }
    }
}
