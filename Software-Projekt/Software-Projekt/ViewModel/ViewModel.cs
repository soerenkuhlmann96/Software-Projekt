using System;
using System.Collections.Generic;
using System.Text;

namespace Software_Projekt.ViewModel
{
    class ViewModel 
    {
        public IndicatorList Indicators { get; set; }
        public ViewModel()
        {
                Indicators = IndicatorList.Load();
        }
    }
}
