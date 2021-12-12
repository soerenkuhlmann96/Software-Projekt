using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Software_Projekt.ViewModel
{
    class ViewModelNormalize
    {
        private string[] description;
        public ViewModelNormalize(List<double[]> DataSeries)
        {
            description = (App.Current as App).description;
            Normalize(DataSeries, description);
        }
        private List<double[]> Normalize(List<double[]> DataSeries, string[] description)
        {
            List<double[]> normalizedList;

            double[] r1 = DataSeries[0];
            double[] r2 = DataSeries[1];
            double[] r3 = DataSeries[2];
            double[] r4 = DataSeries[3];
            List<double[]> temp;



            if (description[1] != "Absolutreihe")
            {


                double[] absolutreihe1 = new double[r1.Length];
                for (int i = 0; i < r1.Length; i++)
                {
                    absolutreihe1[i] = 1;
                }
                normalizedList = Sorter(r1, absolutreihe1);
                //mit reihe2 weiter machen für r2
                if (description[2] != "Absolutreihe")
                {
                    //absolutreihe mit nur einsen erstellen
                    double[] absolutreihe2 = new double[r2.Length];
                    for (int i = 0; i < r2.Length; i++)
                    {
                        absolutreihe2[i] = 1;
                    }
                    //reihe2 sotieren und beschreibung kriegen
                    temp = Sorter(r1, absolutreihe1);
                    normalizedList[3] = temp[0];
                    normalizedList[4] = temp[1];
                    normalizedList[5] = temp[2];
                }
                else
                {
                    //reihe2 sotieren und beschreibung kriegen für r2
                    temp = Sorter(r2, r3);
                    normalizedList[3] = temp[0];
                    normalizedList[4] = temp[1];
                    normalizedList[5] = temp[2];
                }
            }
            else
            {
                //reihe1 sotieren und beschreibung kriegen für r1
                normalizedList = Sorter(r1, r2);
                //mit reihe2 weiter machen für r3
                if (description[3] != "Absolutreihe")
                {
                    //absolutreihe mit nur einsen erstellen
                    double[] absolutreihe2 = new double[r3.Length];
                    for (int i = 0; i < r3.Length; i++)
                    {
                        absolutreihe2[i] = 1;
                    }
                    //reihe2 sotieren und beschreibung kriegen
                    temp = Sorter(r3, absolutreihe2);
                    normalizedList[3] = temp[0];
                    normalizedList[4] = temp[1];
                    normalizedList[5] = temp[2];
                }
                else
                {
                    //reihe2 sotieren und beschreibung kriegen für r3
                    temp = Sorter(r3, r4);
                    normalizedList[3] = temp[0];
                    normalizedList[4] = temp[1];
                    normalizedList[5] = temp[2];
                }
            }

            return normalizedList;
            /*normalizedList aufbau
            0 Datenreihe
            1 Absolureihe für 0
            2 Relativreihe für 0
            3 Datenreihe
            4 Absolureihe für 3
            5 RElativreihe für 3
            */


        }
        private List<double[]> Sorter(double[] r1, double[] r2)
        {
            int x1 = r1.Length;
            double[] nr = new double[x1];
            double[] nrdes = new double[x1];



            //dopplungen entfernen
            int count = 0;
            for (int i = 0; i < x1; i++)
            {
                //for (int j = 0; j <= i; j++)
                bool machweiter = true;
                int j = 0;
                while (machweiter)
                {
                    if (r1[i] == nr[j])
                    {
                        nrdes[j] = nrdes[j] + r2[i];
                        machweiter = false;
                    }
                    //dann weiter mit r3[2] mir nr[0]
                    else if (j == i)
                    {
                        nr[count] = r1[j];
                        nrdes[count] = r2[j];
                        count++;
                        machweiter = false;
                    }
                    j++;
                }
            }
            //arraygröße anpassen
            //da die dopplungen entfernt wurden braucht das array jetzt nicht mehr so viele stellen die arraygröße wird angepasst
            Array.Resize(ref nr, count);
            Array.Resize(ref nrdes, count);



            //sotieren
            //die arrays werden sotiert sie werden so sotiert das Datenarray der größe nach aufsteigend sotiert wird
            int x2 = nr.Length;
            double[] nrsort = new double[x2];
            double[] nrdessort = new double[x2];



            double zahl = 0;
            double zahl2 = 0;
            int delite = 0;
            for (int i = 0; i < x2; i++)
            {
                for (int j = 0; j < nr.Length; j++)
                {



                    if (j == 0)
                    {
                        zahl = nr[j];
                        zahl2 = nrdes[j];
                        delite = j;
                    }
                    else if (nr[j] < zahl)
                    {
                        zahl = nr[j];
                        zahl2 = nrdes[j];
                        delite = j;
                    }
                }



                nrsort[i] = zahl;
                nrdessort[i] = zahl2;
                nr = nr.Where((source, index) => index != delite).ToArray();
                nrdes = nrdes.Where((source, index) => index != delite).ToArray();



            }
            double summe = 0;
            double[] nrrela = new double[count];
            int zähler = 0;
            foreach (double i in nrdessort)
            {
                summe = summe + i * nrdessort[zähler];
                zähler++;
            }
            zähler = 0;
            foreach (double i in nrdessort)
            {
                nrrela[zähler] = nrsort[zähler] * nrdessort[zähler] / summe;
                zähler++;
            }

            var returner = new List<double[]> { nrsort, nrdessort, nrrela };

            return returner;
        }
    }
}
