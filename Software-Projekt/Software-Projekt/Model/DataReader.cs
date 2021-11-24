using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Software_Projekt.Model
{
    class DataReader
    {
        List<double[]> DataSeries = new List<double[]>();
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



            //if (Data.Length > 0 && Data[0].Length > 2)
            //{
            //    double[] Data1 = new double[leng];
            //    double[] Data0 = new double[leng];
            //    var width = Data[0].Length - 1;
            //    for (int i = 0; i < leng; i++)
            //    {
            //        var d = Data[i].Split(',');

            //        Data0[i] = double.Parse(d[0]);
            //        Data1[i] = double.Parse(d[1]);
            //    }
            //}
        }
    }
}
