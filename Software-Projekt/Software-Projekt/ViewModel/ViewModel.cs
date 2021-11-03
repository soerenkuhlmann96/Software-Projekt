using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Software_Projekt.ViewModel
{
    class ViewModel 
    {
        public IndicatorList IndicatorsNominal { get; set; }
        public IndicatorList IndicatorsOrdinal { get; set; }
        public IndicatorList IndicatorsMetrisch { get; set; }
        //IndicatorsPath
        public ViewModel()
        {
            string workingDirektory = Environment.CurrentDirectory;
            string IndicatorsPath = Directory.GetParent(workingDirektory).Parent.Parent.FullName;
            string IndicatorsPathNominal = IndicatorsPath + "/Ressourcen/IndicatorsNominal.csv";

            IndicatorsNominal = IndicatorList.Load(IndicatorsPathNominal);

            string IndicatorsPathOrdinal = IndicatorsPath + "/Ressourcen/IndicatorsOrdinal.csv";

            IndicatorsOrdinal = IndicatorList.Load(IndicatorsPathOrdinal);

            string IndicatorsPathMetrisch = IndicatorsPath + "/Ressourcen/IndicatorsMetrisch.csv";

            IndicatorsMetrisch = IndicatorList.Load(IndicatorsPathMetrisch);
        }
    }
}
