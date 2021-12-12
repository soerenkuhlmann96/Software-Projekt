using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Software_Projekt
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public List<double[]> DataSeries = new List<double[]>();
        public string[] DataDescriptor;
        public string Skalentyp;
        public string MetricScaletype;
        public string ChoosenIndicator;
        public int Amount;
        public string[] description;

    }
}
