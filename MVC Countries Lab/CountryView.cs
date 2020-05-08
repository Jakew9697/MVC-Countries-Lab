using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace MVCCountriesLab
{
    class CountryView
    {
        public Country DisplayCountry 
        { 
            get;

            set;
        }


        public CountryView(Country c)
        {
            DisplayCountry = c;
        }


        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}");

            Console.WriteLine($"Continent: {DisplayCountry.Continent}");

            for (int i = 0; i < DisplayCountry.Colors.Count; i++)
            {
                if (DisplayCountry.Colors[i] == "Red")
                {
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.Red;
                }

                else if (DisplayCountry.Colors[i] == "Blue")
                {
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                else if (DisplayCountry.Colors[i] == "White")
                {
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (DisplayCountry.Colors[i] == "Yellow")
                {
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                else if (DisplayCountry.Colors[i] == "Black")
                {
                    Console.BackgroundColor = ConsoleColor.White;

                    Console.ForegroundColor = ConsoleColor.Black;
                }

                else if (DisplayCountry.Colors[i] == "Green")
                {
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.Green;
                }

                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine($"Colors: {DisplayCountry.Colors[i]}");
            }
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
