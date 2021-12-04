using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Software_Projekt.Model
{
    public class DataReader
    {
        private List<double[]> DataSeries = new List<double[]>();
        public List<double[]> Load(string path, int amount)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            var Data = File.ReadAllLines(path);
            var leng = Data.Length;

            for (int i = 0; i < amount; i++)
            {
                double[] Series = new double[leng];
                for (int j = 0; j < leng; j++)
                {
                    var d = Data[j].Split(';');
                    Series[j] = double.Parse(d[i]);
                }
                DataSeries.Add(Series);

            }
            return DataSeries;
        }
    }
}
