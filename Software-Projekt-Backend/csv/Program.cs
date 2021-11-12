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
               /* foreach( var i in Data0) {
                    Console.WriteLine(i);
                }*/
                double[][] hauf = haufigkeit(Data0);
                Console.WriteLine(Median(Data0));
                Console.ReadKey();

                // Console.WriteLine("width =" + width);
            }
            //Console.WriteLine("Length =" + leng);


            /**************************************/
            double GeometrischesMittel(double[] array)
            {
                double xBar_g = 1;
                for (var i = 0; i < array.Length; i++)
                {
                    xBar_g *= array[i];
                }
                return Math.Pow(xBar_g,(1/array.Length));
            }
            /**************************************/
            double Varianz(double[] array)
            {
                var avg = array.Average();
                double[] vari = { };
                for(var i = 0 ; i<array.Length; i++)
                {
                    vari[i] = Math.Pow(array[i] - avg,2);
                }
                return vari.Sum()/vari.Length;
            }
            /**************************************/
            // Array.Sort(double.Parse(Data0));
            // haufigkeit in ein array : 
            double[][] haufigkeit(double[] array)
             {
                int i, j, N, count;
                N = array.Length;
                double[] hauf = new double[N];
                Array.ForEach(hauf, (n) => { n = -1;});

                for (i = 0; i < N; i++)
                {
                    count = 1;
                    for (j = i + 1; j < N; j++)
                    {
                        if (array[i] == array[j])
                        {
                            count++;
                            hauf[j] = 0;
                        }
                    }

                    hauf[i] = (hauf[i] != 0) ? 0: count;
                   
                }
                for (i = 0; i < N; i++)
                {
                    if (hauf[i] != 0)
                    {
                        Console.WriteLine( array[i].ToString() +" "+ hauf[i].ToString());
                    }
                }
                return new double[][] {array,hauf}; 
             }
            /**************************************/
            double Median(double[] array)
            {
                Array.Sort(array);
                var L = array.Length;
                var x_z = (L % 2 == 1) ? array[(L - 1) / 2] : array[L / 2 - 1];
                return x_z;
            }
            /**************************************/
            double Mittelwert(double[] array) 
            {
                return array.Average();
            }
            /**************************************/
            double Spennweite(double[] array)
            { 
                return array.Max() - array.Min();
            }
            /**************************************/
            double Standardabweichung(double[] array)
            { 
                return Math.Pow(Varianz(array),1/2); 
            }
            /**************************************/
            double Variationskoeffizient(double[] array)
            {
                return Standardabweichung(array) / Mittelwert(array);

            }
            /**************************************/
            double Merkmalssumme(double[] array)
            {
                return array.Sum();
            }
            /**************************************/

            double Kovarianz(double[] array1, double[] array2)
            {
                var avg1 = array1.Average();
                var avg2 = array2.Average();
                double[] kovari = { };
                for (var i = 0; i < array1.Length; i++)
                {
                    kovari[i] = (array1[i] - avg1)* (array2[i] - avg2);
                }
                return kovari.Sum() / kovari.Length;
            }
            /**************************************/
            double Korrelationskoeffizient(double[] array1, double[] array2)
            { 
                return Kovarianz(array1,array2)/(Standardabweichung(array1)*Standardabweichung(array2));
            }
        }
    }
}
