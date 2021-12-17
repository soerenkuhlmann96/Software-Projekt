using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace Software_Projekt
{
    public class IndicatorList : List<Indicator>
    {
        public IndicatorList()
        {
        }

        // Läd Liste von Kennzahlen aus CSV Datein
        public IndicatorList Load(string Path)
        {
            IndicatorList indicators = new IndicatorList();
            string line;
            string[] columns;
            var reader = new StreamReader(Path);
            while ((line = reader.ReadLine()) != null)
            {
                columns = line.Split(';');
                Indicator indicator = new Indicator()
                {
                    Name = columns[0],
                    Formel = columns[1],
                    Informationen = columns[2]
                };
                indicators.Add(indicator);
            }
            return indicators;
        }
    }
}
