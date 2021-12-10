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
                    Beschreibung = columns[2],
                    Informationen = columns[3]
                };
                indicators.Add(indicator);
            }
            return indicators;
        }
    }
}
