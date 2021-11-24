using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Software_Projekt.Model
{
    class DataReader
    {
        public void Load(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            var Data = File.ReadAllLines(path);
            var leng = Data.Length;

            if (Data.Length > 0 && Data[0].Length > 2)
            {
                double[] Data1 = new double[leng];
                double[] Data0 = new double[leng];
                var width = Data[0].Length - 1;
                for (int i = 0; i < leng; i++)
                {
                    var d = Data[i].Split(',');

                    Data0[i] = double.Parse(d[0]);
                    Data1[i] = double.Parse(d[1]);
                }
            }
        }
    }
}
