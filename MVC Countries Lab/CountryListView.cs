using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryListView
    {
        public List<Country> Countries
        {
            get;

            set; 
        }


        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }


        public void Display()
        {
            Console.WriteLine("*L I S T  O F  C O U N T R I E S*");

            Console.WriteLine();

            for (int i = 0; i < Countries.Count; i++)
            {
                Country c = Countries[i];

                Console.WriteLine($"{i + 1}. {c.Name} \n");
            }
        }
    }
}