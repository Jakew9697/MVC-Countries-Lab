using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;

namespace MVCCountriesLab
{
    class CountryController
    {
        public List<Country> CountryDb = new List<Country>();

        public CountryController()
        {
            Country usa = new Country();

            List<string> usacolor = new List<string>() { "Red", "White", "Blue" };

            usa.Name = "United States of America";

            usa.Continent = "North America";

            usa.Colors = usacolor;

            CountryDb.Add(usa);


            Country cnd = new Country();

            List<string> cndcolor = new List<string>() { "Red", "White" };

            cnd.Name = "Canada";

            cnd.Continent = "North America";

            cnd.Colors = cndcolor;

            CountryDb.Add(cnd);


            Country ger = new Country();

            List<string> gercolor = new List<string>() { "Black", "Red", "Yellow" };

            ger.Name = "Germany";

            ger.Continent = "Europe";

            ger.Colors = gercolor;

            CountryDb.Add(ger);


            Country bra = new Country();

            List<string> bracolor = new List<string>() { "Green", "Yellow", "Blue", "White" };

            bra.Name = "Brazil";

            bra.Continent = "South America";

            bra.Colors = bracolor;

            CountryDb.Add(bra);
        }


        public void CountryAction(Country c)
        {
            CountryView country = new CountryView(c);

            country.Display();
        }


        public void WelcomeAction()
        {
            CountryListView countries = new CountryListView(CountryDb);

            while (true)
            {
                Console.WriteLine();
            countries.Display();

            Console.Write("Hello welcome to the country app. Please select a country from the following list by number: ");

            string answer = Console.ReadLine();

                try
                {
                    int index = int.Parse(answer);
                    Console.WriteLine();
                    CountryAction(CountryDb[index - 1]);
                    Console.WriteLine();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("That is not a valid number. Please enter a corresponding number, not a letter or character. ");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine();
                    Console.WriteLine("That number did not correspond to a country. Please enter a valid number. ");
                }
            }
            
        }


        public void SecondAction()
        {
            CountryListView countries = new CountryListView(CountryDb);

            countries.Display();

            Console.Write("Please select a country from the following list by number: ");

            string answer = Console.ReadLine();

            int index = int.Parse(answer);

            Console.WriteLine();
            CountryAction(CountryDb[index]);
            Console.WriteLine();
        }
    }
}
