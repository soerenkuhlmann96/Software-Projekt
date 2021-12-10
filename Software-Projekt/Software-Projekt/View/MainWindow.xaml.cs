using System.Windows;

namespace Software_Projekt.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Öffnet neues Analyse Fenster und schließt MainWindow 
        private void OnAnalyseFile(object sender, RoutedEventArgs e)
        {
            var Analyse_Window = new AnalyseWindow();
            Analyse_Window.Show();
            this.Close();
        }

        //Öffnet neues Indicators Fenster und schließt MainWindow
        private void OnOpenIndicators(object sender, RoutedEventArgs e)
        {
            var IndicatorsWindow = new Indicators();
            IndicatorsWindow.Show();
            this.Close();
            
        }

        //Beendet das Programm
        private void OnClickEnd(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
