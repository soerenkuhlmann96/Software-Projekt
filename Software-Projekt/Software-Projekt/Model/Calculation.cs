using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Software_Projekt.Model
{
    class Calculation
    {
        /**************************************/
        public double GeometrischesMittel(double[] array)
        {
            double xBar_g = 1;
            for (var i = 0; i < array.Length; i++)
            {
                xBar_g *= array[i];
            }
            return Math.Pow(xBar_g, (1 / array.Length));
        }
        /**************************************/
        public double Varianz(double[] array)
        {
            var avg = array.Average();
            double[] vari = { };
            for (var i = 0; i < array.Length; i++)
            {
                vari[i] = Math.Pow(array[i] - avg, 2);
            }
            return vari.Sum() / vari.Length;
        }
        /**************************************/
        // Array.Sort(double.Parse(Data0));
        // haufigkeit in ein array : 
        /*public double[][] haufigkeit(double[] array)
        {
            int i, j, N, count;
            N = array.Length;
            double[] hauf = new double[N];
            Array.ForEach(hauf, (n) => { n = -1; });

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

                hauf[i] = (hauf[i] != 0) ? 0 : count;

            }
            for (i = 0; i < N; i++)
            {
                if (hauf[i] != 0)
                {
                    Console.WriteLine(array[i].ToString() + " " + hauf[i].ToString());
                }
            }
            return new double[][] { array, hauf };
        }*/
        public int Relativehaufigkeit(double[] array, double num)
        {
            int hauf = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    hauf++;
                }
            }
            return hauf;
        }

        /**************************************/
        public double Median(double[] array)
        {
            Array.Sort(array);
            var L = array.Length;
            var x_z = (L % 2 == 1) ? array[(L - 1) / 2] : array[L / 2 - 1];
            return x_z;
        }
        /**************************************/
        public double Mittelwert(double[] array)
        {
            return array.Average();
        }
        /**************************************/
        public double Spennweite(double[] array)
        {
            return array.Max() - array.Min();
        }
        /**************************************/
        public double Standardabweichung(double[] array)
        {
            return Math.Pow(Varianz(array), 1 / 2);
        }
        /**************************************/
        public double Variationskoeffizient(double[] array)
        {
            return Standardabweichung(array) / Mittelwert(array);

        }
        /**************************************/
        public double Merkmalssumme(double[] array)
        {
            return array.Sum();
        }
        /**************************************/

        public double Anteilswerte(double[] array, int i)
        {
            if (i > 0)
            {
                return array[i - 1] / array.Sum();
            }
            else
            {
                return 0;
            }
        }
        /**************************************/
        public double Konzentrationsrate(double[] array, int i)
        {
            double CRM = 0;
            Array.Sort(array);
            for (int j = 0; j < i; j++)
            {
                CRM = CRM + array[j];
            }
            return CRM;
        }
        /**************************************/
        public double[][] Lorenzkurve(double[] array)
        {
            int l = array.Length;
            double[] g = new double[l];
            double[] f = new double[l];
            double[] G = new double[l];
            double[] F = new double[l];
            for (int i = 0; i < array.Length; i++)
            {
                g[i] = Anteilswerte(array, i);
                f[i] = Relativehaufigkeit(array, array[i]);
            }
            Array.Sort(g, f); // wenn der resultat nicht richtig ist, koennen wir auch g und f tauschen
            for (int i = 0; i < array.Length; i++)
            {
                G[i] = (i > 0) ? G[i - 1] + g[i] : g[i];
                F[i] = (i > 0) ? F[i - 1] + f[i] : f[i];
            }
            return new double[][] { g, f };
        }

        public double Kovarianz(double[] array1, double[] array2)
        {
            var avg1 = array1.Average();
            var avg2 = array2.Average();
            double[] kovari = { };
            for (var i = 0; i < array1.Length; i++)
            {
                kovari[i] = (array1[i] - avg1) * (array2[i] - avg2);
            }
            return kovari.Sum() / kovari.Length;
        }
        /**************************************/
        public double GiniMass(double[] array)
        {
            return 1 - (2 * array.Sum() / (array.Length - 1));
        }
        /**************************************/
        public double Korrelationskoeffizient(double[] array1, double[] array2)
        {
            return Kovarianz(array1, array2) / (Standardabweichung(array1) * Standardabweichung(array2));
        }
        /**************************************/
        public double[] Regressionskoeffizienten(double[] x, double[] y)
        {
            double b, a;
            b = Kovarianz(x, y) / Standardabweichung(x);
            a = y.Average() - b * x.Average();
            return new double[] { b, a };
        }
        /**************************************/
        public double Residium(double[] y, double[] x, double b, double a)
        {
            double summe = 0;
            for (int i = 0; i < y.Length; i++)
            {
                summe += Math.Pow(y[i] - (a + b * x[i]), 2);
            }
            return summe / y.Length;
        }
        /**************************************/
        public double Bestimmtheitsmaß(double Residium, double[] y)
        {
            return 1 - (Residium / Varianz(y));
        }
        /**************************************/
        public double Wertindex(double[] p_jo, double[] q_jo, double[] p_jt, double[] q_jt)
        {
            double sum1 = 0;
            double sum2 = 0;
            for (int i = 0; i < p_jo.Length; i++)
            {
                sum1 += p_jo[i] * q_jo[i];
            }
            for (int i = 0; i < p_jt.Length; i++)
            {
                sum2 += p_jt[i] * q_jt[i];
            }
            return sum2 / sum1;
        }
        /**************************************/
        public double Preisindex_Laspeyres(double[] p_jo, double[] q_jo, double[] p_jt)
        {
            double sum1 = 0;
            double sum2 = 0;
            for (int i = 0; i < p_jo.Length; i++)
            {
                sum1 += p_jo[i] * q_jo[i];
                sum2 += p_jt[i] * q_jo[i];
            }
            return sum2 / sum1;
        }
        /**************************************/
        public double Preisindex_Paasche(double[] p_jo, double[] q_jt, double[] p_jt)
        {
            double sum1 = 0;
            double sum2 = 0;
            for (int i = 0; i < p_jo.Length; i++)
            {
                sum1 += p_jo[i] * q_jt[i];
                sum2 += p_jt[i] * q_jt[i];
            }
            return sum2 / sum1;
        }
        /**************************************/
        public double Mengenindex_Laspeyres(double[] p_jo, double[] q_jo, double[] q_jt)
        {
            double sum1 = 0;
            double sum2 = 0;
            for (int i = 0; i < p_jo.Length; i++)
            {
                sum1 += p_jo[i] * q_jo[i];
                sum2 += p_jo[i] * q_jt[i];
            }
            return sum2 / sum1;
        }
        /**************************************/
        public double Mengenindex_Paasche(double[] p_jt, double[] q_jo, double[] q_jt)
        {
            double sum1 = 0;
            double sum2 = 0;
            for (int i = 0; i < p_jt.Length; i++)
            {
                sum1 += p_jt[i] * q_jo[i];
                sum2 += p_jt[i] * q_jt[i];
            }
            return sum2 / sum1;
        }
    }
}
