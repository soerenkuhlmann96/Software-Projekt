using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace csv
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var Data = File.ReadAllLines("temp.csv");
            var leng = Data.Length;
            // Console.WriteLine(Data[0]);
            if (Data[0].Length > 2)
            {
                double[] Data1 = new double[leng];
                double[] Data0 = new double[leng];
                var width = Data[0].Length - 1;
                for (int i=0;i <leng;i++) {
                var d = Data[i].Split(',');
                    
                Data0[i] = double.Parse(d[0]);
                Data1[i] = double.Parse(d[1]);
                }
                foreach( var i in Data0) {
                    Console.WriteLine(i);
                }
                Console.ReadKey();

                // Console.WriteLine("width =" + width);
            }
            //Console.WriteLine("Length =" + leng);

            // Array.Sort(double.Parse(Data0));



        }
    }
}
