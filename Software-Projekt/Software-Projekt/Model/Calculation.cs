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
        public double GeometrischesMittel(double[] array, double[] frequence)
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
        private double Häufigkeit(double[] array, double num)
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
        private double Kumulierte_Häufigkeit(double[] array, double min_num, double max_num, bool abs)
        {
            int hauf = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min_num || array[i] < max_num)
                {
                    hauf++;
                }
            }
            return (abs) ? hauf : hauf / array.Length;
        }
        /**************************************/
        public double Absolutehaufigkeit(double[][] array, double num)
        {
            double abs_hauf = 0;
            for (int i = 0; i < array.Length; i++)
            {
                abs_hauf += Häufigkeit(array[i], num);
            }
            return abs_hauf;
        }
        /**************************************/
        public double Relativehaufigkeit(double[] array, double num)
        {
            double hauf = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    hauf++;
                }
            }
            return hauf / array.Length;
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
        public double Quantil(double[] array, double alpha)
        {
            int L = array.Length;
            double x_z = 0;
            Array.Sort(array);
            switch (alpha)
            {
                case 0.25:
                    x_z = (L % 2 == 1) ? array[(L - 1) / 4] : array[L / 4 - 1];
                    break;
                case 0.5:
                    x_z = Median(array);
                    break;
                case 0.75:
                    x_z = (L % 2 == 1) ? array[(L - 1) * 3 / 4] : array[L * 3 / 4 - 1];
                    break;
            }
            return x_z;
        }
        /**************************************/
        public double Quartilsabstand(double[] array)
        {
            int L = array.Length;
            Array.Sort(array);
            return (L % 2 == 1) ? array[(L - 1) * 3 / 4] - array[(L - 1) / 4] : array[L * 3 / 4 - 1] - array[L / 4 - 1];
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
        /**************************************/
        public double GiniMass(double[] array)
        {
            return 1 - (2 * array.Sum() / (array.Length - 1));
        }
        /**************************************/
        public double[] Randverteilung(double[][] array, int indexx, int indexy, int mode)
        {
            double[] aus = new double[0];
            double summe = 0;
            switch (mode)
            {
                case 0:// Häufigkeitsverteilung von X wenn Y unberücksichtigt
                    for (int i = 0; i < array.Length; i++)
                    {
                        aus[i] = array[i][indexy];
                    }

                    break;
                case 1:// Häufigkeitsverteilung von Y wenn X unberücksichtigt
                    for (int i = 0; i < array[0].Length; i++)
                    {
                        aus[i] = array[indexx][i];
                    }
                    break;
                case 2:// Häufigkeitsverteilung von X wenn Y fest
                    for (int i = 0; i < array[0].Length; i++)
                    {
                        summe += array[indexx][i];
                    }
                    for (int i = 0; i < array.Length; i++)
                    {
                        aus[i] = array[i][indexy] / summe;
                    }
                    break;
                case 3:// Häufigkeitsverteilung von Y wenn X fest
                    for (int i = 0; i < array[0].Length; i++)
                    {
                        summe += array[i][indexy];
                    }
                    for (int i = 0; i < array.Length; i++)
                    {
                        aus[i] = array[indexx][i] / summe;
                    }
                    break;
            }
            return aus;
        }
        /**************************************/
        public double CHI_Quadrat(double[][] array)
        {
            // n, Xs, YS rechnen
            double n = 0;
            double X2 = 0;
            double[] Xs = new double[array.Length];
            double[] Ys = new double[array[0].Length];
            for (int i = 0; i < array.Length; i++)// x lange
            {
                for (int i2 = 0; i2 < array[0].Length; i2++)// y lange
                {
                    Xs[i] += array[i][i2];
                }
            }
            for (int i = 0; i < array[0].Length; i++)//y lange
            {
                for (int i2 = 0; i2 < array.Length; i2++)// x lange
                {
                    Ys[i] += array[i2][i];
                }
            }
            n = Xs.Sum(); // oder Ys.Sum();
                          // Indifferenz tabelle rechnen
                          // for schleife uber alle splaten
            for (int i = 0; i < array.Length; i++)//x lange
            {
                for (int i2 = 0; i2 < array[0].Length; i2++)//y lange
                {
                    // Indifferenz spalte rechnung´und zusammen addieren
                    X2 += Math.Pow(array[i][i2] - (Xs[i] * Ys[i2] / n), 2) / (Xs[i] * Ys[i2] / n);
                }
            }
            return X2;
        }
        /**************************************/
        public double Cramersches_Kontigenzmaß(double[][] array)
        {
            double n = 0;
            double X2 = CHI_Quadrat(array);
            int xl = array.Length;
            int yl = array[0].Length;
            double[] Xs = new double[array.Length];
            for (int i = 0; i < array.Length; i++)// x lange
            {
                for (int i2 = 0; i2 < array[0].Length; i2++)// y lange
                {
                    Xs[i] += array[i][i2];
                }
            }
            n = Xs.Sum();
            return Math.Pow(X2 / (n * (Math.Min(xl, yl) - 1)), (1 / 2));
        }
        /**************************************/
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
        public double Korrelationskoeffizient(double[] array1, double[] array2)
        {
            return Kovarianz(array1, array2) / (Standardabweichung(array1) * Standardabweichung(array2));
        }
        /**************************************/
        public double[] Rangzahl(double[] x)
        {
            double[] o = new double[0];     // o organisiert
            double[] r = new double[0];     // r rangen
            double[] rang = new double[0];  // rang ausgabe
            double r1 = 0;                  // r1 index der erste merkmale aus wiederholte merkmale
            double ra;                      // ra der Summe der range von wiederholte merkmale
            double r_;                      // r_ der rang die wiederholte merkmale
            bool go = false;                // go spezifiert wenn der code behandelt widerholte merkmale
            Array.Copy(x, o, x.Length);     // x array wird ins o array kopiert
            Array.Sort(o);                  // o array wird sortiert
            for (int i = 0; i < o.Length; i++)      // geht durch alle zahlen um der rang zu rechnen
            {
                if (i != o.Length)
                {
                    if (o[i] != o[i + 1] && (go == false))          // im fall einzige merkmal
                    {
                        r[i] = Convert.ToDouble(i);
                    }
                    else if ((o[i] != o[i + 1]) && (go == true))    // im fall letzte merkmal von wiederholte merkmale
                    {
                        ra = 0;
                        for (int i2 = Convert.ToInt32(r1); i2 < i; i2++)
                        { ra += i2; }
                        r_ = ra / (i - r1 + 1);
                        for (int i3 = Convert.ToInt32(r1); i3 < i; i3++)
                        { r[i3] = r_; }
                        go = false;
                    }
                    else if ((o[i] == o[i + 1]) && (go == false))   // im fall erste merkmal von weiderholte merkmale
                    {
                        r1 = i;
                        go = true;
                    }
                }
                else
                {                  // behandelt der letzte merkmal der eingabe array
                    if (go == true)
                    {
                        ra = 0;
                        for (int i2 = Convert.ToInt32(r1); i2 < i; i2++)
                        { ra += i2; }
                        r_ = ra / (i - r1 + 1);
                        for (int i3 = Convert.ToInt32(r1); i3 < i; i3++)
                        { r[i3] = r_; }
                    }
                    else if (go == false)
                    {
                        r[i] = Convert.ToDouble(i);
                    }
                }
            }
            for (int i = 0; i < x.Length; i++)  // gibt der ausgabe in der reinvolge der originale eigabe
            {
                for (int i1 = 0; i1 < o.Length; i1++)
                {
                    if (x[i] == o[i1])
                    {
                        rang[i] = r[i1];
                    }
                }
            }
            return rang;
        }
        /**************************************/
        public double Rangkorrelationskoeffizient(double[] x, double[] y)
        {
            return Korrelationskoeffizient(Rangzahl(x), Rangzahl(y));
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
    }
}
