using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Software_Projekt.Model;

namespace Software_Projekt.View
{
    /// <summary>
    /// Interaktionslogik für IndicatorsPopup.xaml
    /// </summary>
    public partial class IndicatorsPopup : Window
    {
        public IndicatorsPopup(IndicatorInformations info)
        {
            IndicatorInformations informations = info;
            InitializeComponent();

        }
    }
}