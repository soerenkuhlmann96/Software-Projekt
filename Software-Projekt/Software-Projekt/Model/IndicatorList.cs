using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Software_Projekt
{
    public class IndicatorList : List<Indicator>
    {
        private static IndicatorList indicators = new IndicatorList();
        private IndicatorList() { }
        public static IndicatorList Load()
        {
            string line;
            string[] columns;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            projectDirectory += "/Ressourcen/Indicators.csv";
            //string CSV_FilePath =  + "Ressourcen/Indicators.csv";
            var reader = new StreamReader(projectDirectory);
            while ((line = reader.ReadLine()) != null)
            {
                columns = line.Split(';');
                Indicator indicator = new Indicator()
                {
                    Name = columns[0],
                    Formel = columns[1],
                    Beschreibung = columns[2]
                };
                indicators.Add(indicator);
            }
            return indicators;
        }
    }
}
