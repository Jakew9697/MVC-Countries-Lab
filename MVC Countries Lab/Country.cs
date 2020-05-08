using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class Country
    {
        public string Name 
        {
            get; 
            
            set;
        }
        
        public string Continent 
        { 
            get;
            
            set;
        }

        public List<string> Colors 
        { 
            get;
            
            set; 
        }
    }
}
