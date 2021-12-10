using Software_Projekt.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Software_Projekt.ViewModel
{
    class ViewModelDataReader
    {
        List<double[]> Data = new List<double[]>();
        public ViewModelDataReader()
        {
        }
        public List<double[]> Load(string path, int amount)
        {
            
            DataReader dataReader = new DataReader();
            Data = dataReader.Load(path, amount);
            return Data;
        }
    }
}
