using Software_Projekt.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Software_Projekt.ViewModel
{
    class ViewModelDataReader
    {
        public ViewModelDataReader(string path)
        {
            DataReader dataReader = new DataReader();
            dataReader.Load(path);
        }
    }
}
