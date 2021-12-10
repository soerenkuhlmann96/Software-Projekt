using System;
using System.Collections.Generic;
using System.Text;
using Software_Projekt.Model;

namespace Software_Projekt.ViewModel
{
    class ViewModelCalculation
    {
        public double Result;
        double[] data;
        public ViewModelCalculation(string path, string indicator,int amount)
        {
            Calculation calculation = new Calculation();
            DataReader dataReader= new DataReader();
            dataReader.Load(path, amount);
            
            switch(indicator)
            {
                case "Geometrisches Mittel":
                    Result = calculation.GeometrischesMittel(data);
                    break;

                case "Varianz":
                    Result = calculation.Varianz(data);
                    break;

                case "Häufigkeit":
                    //Result = calculation.Häufigkeit(data);
                    break;

                case "Kumulierte_Häufigkeit":
                    //Result = calculation.Kumulierte_Häufigkeit(data);
                    break;

                case "Absolutehaufigkeit":
                    //Result = calculation.Absolutehaufigkeit(data);
                    break;

                case "Relativehaufigkeit":
                    //Result = calculation.Relativehaufigkeit
                    break;

                case "Median":
                    //Result = calculation.Median
                    break;
                    
                case "Quantil":
                    //Result = calculation.Quantil
                    break;
                    
                case "Quartilsabstand":
                    //Result = calculation.Quartilsabstand
                    break;
                    
                case "Mittelwert":
                    //Result = calculation.Mittelwert
                    break;
                    
                case "Spennweite":
                    //Result = calculation.Spennweite
                    break;
                    
                case "Standardabweichung":
                    //Result = calculation.Standardabweichung
                    break;
                    
                case "Variationskoeffizient":
                    //Result = calculation.Variationskoeffizient
                    break;
                    
                case "Merkmalssumme":
                    //Result = calculation.Merkmalssumme
                    break;
                    
                case "Anteilswerte":
                    //Result = calculation.Anteilswerte
                    break;      
                    
                case "Konzentrationsrate":
                    //Result = calculation.Konzentrationsrate
                    break;            
                    
                case "Lorenzkurve":
                    //Result = calculation.Lorenzkurve
                    break;         
                    
                case "GiniMass":
                    //Result = calculation.GiniMass
                    break;        
                    
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
                    //Result = calculation.Kovarianz
                    break;
                                        
                case "Korrelationskoeffizient":
                    //Result = calculation.Korrelationskoeffizient
                    break;
                                        
                case "Rangzahl":
                    //Result = calculation.Rangzahl
                    break;
                                        
                case "Rangkorrelationskoeffizient":
                    //Result = calculation.Rangkorrelationskoeffizient
                    break;
                                        
                case "Regressionskoeffizienten":
                    //Result = calculation.Regressionskoeffizienten
                    break;
                                        
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
