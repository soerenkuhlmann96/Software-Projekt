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
            var reader = new StreamReader("/Ressourcen/Indicators.csv");
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
