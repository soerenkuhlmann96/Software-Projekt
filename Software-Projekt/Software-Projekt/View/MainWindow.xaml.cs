﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnReadFile(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                Filter = "spreadsheet|*.xlsx;*.csv;"
            };
            if(dialog.ShowDialog(this) == true)
            {
                Uri uri = new Uri(dialog.FileName);
                //Datei einlesen (Klasse)
            }
        }

        private void OnAnalyseFile(object sender, RoutedEventArgs e)
        {

        }

        private void OnOpenIndicators(object sender, RoutedEventArgs e)
        {
            var IndicatorsWindow = new Indicators();
            IndicatorsWindow.Show();
            this.Close();
            
        }
    }
}
