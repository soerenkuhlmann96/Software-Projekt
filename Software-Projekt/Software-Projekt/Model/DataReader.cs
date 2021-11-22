using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Software_Projekt.Model
{
    class DataReader
    {
        public static void Load(string path)
        {

            Calculation cal = new Calculation();
            string curFile = path;//@"c:\temp\test.txt";
            if (!File.Exists(curFile))
            {
                File.Create(curFile);
            }

            var Data = File.ReadAllLines(curFile);
            var leng = Data.Length;
            // Console.WriteLine(Data[0]);
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
                /* foreach( var i in Data0) {
                     Console.WriteLine(i);
                 }*/
                //double hauf = cal.Relativehaufigkeit(Data0, Data0[1]);
                //Console.WriteLine(cal.Median(Data0));
                //Console.ReadKey();

                // Console.WriteLine("width =" + width);
            }
            //Console.WriteLine("Length =" + leng);



        }
    }
}
