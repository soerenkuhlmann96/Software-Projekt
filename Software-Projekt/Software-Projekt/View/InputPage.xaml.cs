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
        public InputPage()
        {
            InitializeComponent();
        }

        private void OnClickContinue(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/DataDescriptionPage.xaml", UriKind.Relative));
        }
        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OnClickGoBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/View/DataPage.xaml", UriKind.Relative));
        }

        private void OnComboboxAmountSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;


            if (text == "1")
            {
                if (Stackpanel1 != null) //Bei initialisierung ist Stackpanel1 null. Es würde eine Fehlermeldung geben.
                {
                Stackpanel1.Visibility = Visibility.Collapsed;
                Stackpanel2.Visibility = Visibility.Collapsed;
                Stackpanel3.Visibility = Visibility.Collapsed;                    
                }
            }
            else if (text == "2")
            {
                Stackpanel1.Visibility = Visibility.Visible;
                Stackpanel2.Visibility = Visibility.Collapsed;
                Stackpanel3.Visibility = Visibility.Collapsed;
            }
            else if (text == "3")
            {
                Stackpanel1.Visibility = Visibility.Visible;
                Stackpanel2.Visibility = Visibility.Visible;
                Stackpanel3.Visibility = Visibility.Collapsed;
            }
            else if (text == "4")
            {
                Stackpanel1.Visibility = Visibility.Visible;
                Stackpanel2.Visibility = Visibility.Visible;
                Stackpanel3.Visibility = Visibility.Visible;
            }
        }
    }
}
