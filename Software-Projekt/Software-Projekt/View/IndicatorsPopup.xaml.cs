using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using Software_Projekt.Model;

namespace Software_Projekt.View
{
    /// <summary>
    /// Interaktionslogik für IndicatorsPopup.xaml
    /// </summary>
    public partial class IndicatorsPopup : Window, INotifyPropertyChanged
    {
        private string indicatorName;
        private string indicatorRequirements;
        private string indicatorCalculations;
        private string indicatorInfo;
        public string IndicatorName
        {
            get => indicatorName;
            set => OnPropertyChanged<string>(ref indicatorName, value);
        }
        public string IndicatorRequirements
        {
            get => indicatorRequirements;
            set => OnPropertyChanged<string>(ref indicatorRequirements, value);
        }
        public string IndicatorCalculations
        {
            get => indicatorCalculations;
            set => OnPropertyChanged<string>(ref indicatorCalculations, value);
        }
        public string IndicatorInfo
        {
            get => indicatorInfo;
            set => OnPropertyChanged<string>(ref indicatorInfo, value);
        }
        public IndicatorsPopup(IndicatorInformations info)
        {
            InitializeComponent();

            IndicatorName = info.IndicatorName;
            IndicatorRequirements = info.IndicatorRequirements;
            IndicatorCalculations = info.IndicatorCalculations;
            IndicatorInfo = info.IndicatorsInfo;
        }
        private void OnPropertyChanged<T>(ref T variable, T value, [CallerMemberName] string propertyName = null)
        {
            variable = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}