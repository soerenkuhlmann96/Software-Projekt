using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Reflection;
using Software_Projekt.Model;

namespace Software_Projekt.ViewModel
{
    class ViewModel
    {
        public List<Indicator> IndicatorsNominal { get; set; }
        public IndicatorList IndicatorsOrdinal { get; set; }
        public IndicatorList IndicatorsMetrisch { get; set; }

        public ViewModel()
        {
            string workingDirektory = Environment.CurrentDirectory;
            string IndicatorsPath = Directory.GetParent(workingDirektory).Parent.Parent.FullName;
            string IndicatorsPathNominal = IndicatorsPath + "/Ressourcen/IndicatorsNominal.csv";
            string IndicatorsPathOrdinal = IndicatorsPath + "/Ressourcen/IndicatorsOrdinal.csv";
            string IndicatorsPathMetrisch = IndicatorsPath + "/Ressourcen/IndicatorsMetrisch.csv";

            IndicatorList indicators = new IndicatorList();

            IndicatorsNominal = indicators.Load(IndicatorsPathNominal);

            IndicatorsOrdinal = indicators.Load(IndicatorsPathOrdinal);

            IndicatorsMetrisch = indicators.Load(IndicatorsPathMetrisch);


        }

        //schließt übergebenes Fenster (Für das Schließen vom AnalyseWindow)
        public static void CloseWIndowUsingIdentifier(string windowTag)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            foreach (Window w in Application.Current.Windows)
            {
                if (w.GetType().Assembly == currentAssembly && w.Tag.Equals(windowTag))
                {
                    w.Close();
                    break;
                }
            }
        }

        //speichert Informationen über ausgewählte Kennzahl
        public IndicatorInformations SaveIndicator(string name, string list)
        {
            IndicatorInformations indicatorInformation = new IndicatorInformations();

            
            if (list == "Nominal")
            {
                foreach (var item in IndicatorsNominal)
                {
                    if (item.Name == name)
                    {

                        indicatorInformation.IndicatorName = name;
                        indicatorInformation.IndicatorsInfo = item.Informationen;
                        indicatorInformation.IndicatorCalculations = item.Formel;
                        break;
                    }
                }
                return indicatorInformation;
            }

            else if(list == "Ordinal")
            {
                
                foreach (var item in IndicatorsOrdinal)
                {
                    if (item.Name == name)
                    {
                        indicatorInformation.IndicatorName = name;
                        indicatorInformation.IndicatorsInfo = item.Informationen;
                        indicatorInformation.IndicatorCalculations = item.Formel;
                        break;
                    }
                }
                return indicatorInformation;
            }
            else
            {
                
                foreach (var item in IndicatorsMetrisch)
                {
                    if (item.Name == name)
                    {
                        indicatorInformation.IndicatorName = name;
                        indicatorInformation.IndicatorsInfo = item.Informationen;
                        indicatorInformation.IndicatorCalculations = item.Formel;
                        break;
                    }
                }
                return indicatorInformation;
            }

        }

    }
}
