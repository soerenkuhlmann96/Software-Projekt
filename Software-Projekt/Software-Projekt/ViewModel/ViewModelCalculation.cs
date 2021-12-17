using System;
using System.Collections.Generic;
using System.Text;
using Software_Projekt.Model;

namespace Software_Projekt.ViewModel
{
    class ViewModelCalculation
    {
        public double Result;
        public double[] Resultarray;
        public double[][] Resultarray2x;
        double[] data;
        double[] frequency;
        double[] frequencyrelativ;
        public string output;
        public ViewModelCalculation(List<double[]> DataSeries, string indicator)
        {
            Calculation calculation = new Calculation();

            //dataReader.Load(path, amount);

            switch (indicator)
            {
                case "Geometrisches Mittel":
                    if (DataSeries.Count > 1)
                    {
                        data = DataSeries[0];
                        Result = calculation.GeometrischesMittel(data);

                        output = "Erste Datenreihe: " + Result.ToString();

                        data = DataSeries[1];
                        Result = calculation.GeometrischesMittel(data);
                        output += " Zweite Datenreihe: " + Result.ToString();
                        break;
                    }
                    else
                    {
                        data = DataSeries[0];
                        Result = calculation.GeometrischesMittel(data);
                        output = Result.ToString();
                        break;
                    }

                case "Varianz":
                    if (DataSeries.Count > 1)
                    {
                        data = DataSeries[0];
                        Result = calculation.Varianz(data);

                        output = "Erste Datenreihe: " + Result.ToString();

                        data = DataSeries[1];
                        Result = calculation.Varianz(data);
                        output += " Zweite Datenreihe: " + Result.ToString();
                        break;
                    }
                    else
                    {
                        data = DataSeries[0];
                        Result = calculation.Varianz(data);
                        output = Result.ToString();
                        break;
                    }

                case "Absolutehaufigkeit":
                    //Result = calculation.Absolutehaufigkeit(data);
                    break;

                case "Relativehaufigkeit":
                    //Result = calculation.Relativehaufigkeit
                    break;

                case "Median":
                    if (DataSeries.Count > 1)
                    {
                        data = DataSeries[0];
                        Result = calculation.Median(data);

                        output = "Erste Datenreihe: " + Result.ToString();

                        data = DataSeries[1];
                        Result = calculation.Median(data);
                        output += " Zweite Datenreihe: " + Result.ToString();
                        break;
                    }
                    else
                    {
                        data = DataSeries[0];
                        Result = calculation.Median(data);
                        output = Result.ToString();
                        break;
                    }
                case "Quantil":
                    //Result = calculation.Quantil
                    break;

                case "Quartilsabstand":
                    if (DataSeries.Count > 1)
                    {
                        data = DataSeries[0];
                        Result = calculation.Quartilsabstand(data);

                        output = "Erste Datenreihe: " + Result.ToString();

                        data = DataSeries[1];
                        Result = calculation.Quartilsabstand(data);
                        output += " Zweite Datenreihe: " + Result.ToString();
                        break;
                    }
                    else
                    {
                        data = DataSeries[0];
                        Result = calculation.Quartilsabstand(data);
                        output = Result.ToString();
                        break;
                    }

                case "Mittelwert":
                    if (DataSeries.Count > 1)
                    {
                        data = DataSeries[0];
                        Result = calculation.Mittelwert(data);

                        output = "Erste Datenreihe: " + Result.ToString();

                        data = DataSeries[1];
                        Result = calculation.Mittelwert(data);
                        output += " Zweite Datenreihe: " + Result.ToString();
                        break;
                    }
                    else
                    {
                        data = DataSeries[0];
                        Result = calculation.Mittelwert(data);
                        output = Result.ToString();
                        break;
                    }

                case "Spennweite":
                    if (DataSeries.Count > 1)
                    {
                        data = DataSeries[0];
                        Result = calculation.Spennweite(data);

                        output = "Erste Datenreihe: " + Result.ToString();

                        data = DataSeries[1];
                        Result = calculation.Spennweite(data);
                        output += " Zweite Datenreihe: " + Result.ToString();
                        break;
                    }
                    else
                    {
                        data = DataSeries[0];
                        Result = calculation.Spennweite(data);
                        output = Result.ToString();
                        break;
                    }

                case "Standardabweichung":
                    if (DataSeries.Count > 1)
                    {
                        data = DataSeries[0];
                        Result = calculation.Standardabweichung(data);

                        output = "Erste Datenreihe: " + Result.ToString();

                        data = DataSeries[1];
                        Result = calculation.Standardabweichung(data);
                        output += " Zweite Datenreihe: " + Result.ToString();
                        break;
                    }
                    else
                    {
                        data = DataSeries[0];
                        Result = calculation.Standardabweichung(data);
                        output = Result.ToString();
                        break;
                    }

                case "Variationskoeffizient":
                    if (DataSeries.Count > 1)
                    {
                        data = DataSeries[0];
                        Result = calculation.Variationskoeffizient(data);

                        output = "Erste Datenreihe: " + Result.ToString();

                        data = DataSeries[1];
                        Result = calculation.Variationskoeffizient(data);
                        output += " Zweite Datenreihe: " + Result.ToString();
                        break;
                    }
                    else
                    {
                        data = DataSeries[0];
                        Result = calculation.Variationskoeffizient(data);
                        output = Result.ToString();
                        break;
                    }

                case "Merkmalssumme":
                    if (DataSeries.Count > 1)
                    {
                        data = DataSeries[0];
                        Result = calculation.Merkmalssumme(data);

                        output = "Erste Datenreihe: " + Result.ToString();

                        data = DataSeries[1];
                        Result = calculation.Merkmalssumme(data);
                        output += " Zweite Datenreihe: " + Result.ToString();
                        break;
                    }
                    else
                    {
                        data = DataSeries[0];
                        Result = calculation.Merkmalssumme(data);
                        output = Result.ToString();
                        break;
                    }

                case "Anteilswerte":
                    //Result = calculation.Anteilswerte
                    break;

                case "Konzentrationsrate":
                    //Result = calculation.Konzentrationrate
                    break;

                case "Lorenzkurve":
                    if (DataSeries.Count > 1)
                    {
                        data = DataSeries[0];
                        Resultarray2x = calculation.Lorenzkurve(data);

                        output = "Erste Datenreihe: " + Resultarray2x.ToString();

                        data = DataSeries[1];
                        Resultarray2x = calculation.Lorenzkurve(data);
                        output += " Zweite Datenreihe: " + Resultarray2x.ToString();
                        break;
                    }
                    else
                    {
                        data = DataSeries[0];
                        Resultarray2x = calculation.Lorenzkurve(data);
                        output = Resultarray2x.ToString();
                        break;
                    }


                case "GiniMass":
                    if (DataSeries.Count > 1)
                    {
                        data = DataSeries[0];
                        Result = calculation.GiniMass(data);

                        output = "Erste Datenreihe: " + Result.ToString();

                        data = DataSeries[1];
                        Result = calculation.GiniMass(data);
                        output += " Zweite Datenreihe: " + Result.ToString();
                        break;
                    }
                    else
                    {
                        data = DataSeries[0];
                        Result = calculation.GiniMass(data);
                        output = Result.ToString();
                        break;
                    }


                case "Randverteilung":
                    //Result = calculation.Randverteilung
                    break;

                case "CHI_Quadrat":
                    //Result = calculation.CHI_Quadrat
                    break;

                case "Cramersches_Kontigenzmaß":
                    //Result = calculation.Cramersches_Kontigenzmaß
                    break;

                case "Kovarianz":
                    if (DataSeries.Count > 1)
                    {
                        Result = calculation.Kovarianz(DataSeries[0], DataSeries[1]);
                        output = Result.ToString();
                        break;
                    }
                    else
                    {
                        output = "es werden 2 Merkmale benötigt";
                        break;
                    }

                case "Korrelationskoeffizient":
                    if (DataSeries.Count > 1)
                    {
                        Result = calculation.Korrelationskoeffizient(DataSeries[0], DataSeries[1]);
                        output = Result.ToString();
                        break;
                    }
                    else
                    {
                        output = "es werden 2 Merkmale benötigt";
                        break;
                    }

                case "Rangzahl":
                    if (DataSeries.Count > 1)
                    {
                        data = DataSeries[0];
                        Resultarray = calculation.Rangzahl(data);

                        output = "Erste Datenreihe: " + Resultarray.ToString();

                        data = DataSeries[1];
                        Resultarray = calculation.Rangzahl(data);
                        output += " Zweite Datenreihe: " + Resultarray.ToString();
                        break;
                    }
                    else
                    {
                        data = DataSeries[0];
                        Resultarray = calculation.Rangzahl(data);
                        output = Resultarray.ToString();
                        break;
                    }

                case "Rangkorrelationskoeffizient":
                    if (DataSeries.Count > 1)
                    {
                        Result = calculation.Rangkorrelationskoeffizient(DataSeries[0], DataSeries[1]);
                        output = Result.ToString();
                        break;
                    }
                    else
                    {
                        output = "es werden 2 Merkmale benötigt";
                        break;
                    }

                case "Regressionskoeffizienten":
                    if (DataSeries.Count > 1)
                    {
                        Resultarray = calculation.Regressionskoeffizienten(DataSeries[0], DataSeries[1]);
                        output = Resultarray.ToString();
                        break;
                    }
                    else
                    {
                        output = "es werden 2 Merkmale benötigt";
                        break;
                    }

                case "Residium":
                    //Result = calculation.Residium
                    break;

                case "Bestimmtheitsmaß":
                    //Result = calculation.Bestimmtheitsmaß
                    break;

                case "Wertindex":
                    //Result = calculation.Wertindex
                    break;

                case "Preisindex_Laspeyres":
                    //Result = calculation.Preisindex_Laspeyres
                    break;

                case "Preisindex_Paasche":
                    //Result = calculation.Preisindex_Paasche
                    break;

                case "Mengenindex_Laspeyres":
                    //Result = calculation.Mengenindex_Laspeyres
                    break;

                case "Mengenindex_Paasche":
                    //Result = calculation.Mengenindex_Paasche
                    break;
            }
        }
    }
}
