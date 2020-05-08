﻿using System;

namespace MVCCountriesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController cc = new CountryController();

            bool cont = true;

            while (cont)
            {

            cc.WelcomeAction();

                Console.WriteLine("Would you like to learn about another country? y/n");

                string answer = Console.ReadLine().Trim().ToLower();

                if (answer == "y")
                {
                    Console.WriteLine();

                    cont = true;
                }

                if (answer == "n")
                {
                    Console.WriteLine("See ya later aligator...");
                    cont = false;
                }
            }
        }
    }
}


//Task: Create a Lab to display information on different countries in the world using
//the Model View Controller Design Pattern.

//What will the application do?
//Make a Country model with the following properties: 
//Public string Name
//Public string Continent
//Public List<string> Colors

//Next Create a CountryView Class. In the constructor require a Country be taken in and set to DisplayCountry.
//Create the following property and method: 

//Public Country DisplayCountry
//Public void Display() - This method will print out the Name, Continent,
//and Colors of the Country DisplayCountry property

//Next Create a CountryListView class. This view will take a list of countries in its constructor.
//It should have the following property and method: 

//Public List<Country> Countries - store the parameter from the constructor here.
//Public void Display() - Print the name of each country in the list along with the index for each country

//Lastly make a CountryController class. This class will be the big boss of your app.
//This class should have the following properties and methods: 

//List<Country> CountryDb - this stands in for our country database.We’ll learn those later,
//but know the info from the database gets stored in a list
//Public void CountryAction(Country c) - This will take in a Country model,
//passing the model into the CountryView constructor, and call Display Country on your CountryView object. 
//Public void WelcomeAction() - This will take no parameter and pass CountryDb into the CountryListView class.
//Then, it will print “Hello, welcome to the country app.
//Please select a country from the following list:” Then it will call Display() on the CountryListView.
//Next allow the user to select a country by index.Upon getting the country out of CountryDb, 
//pass that country along to the CountryAction() method. After that’s done, 
//ask if the user would like to learn about another country.

//Extended Exercise: 
//Use Console.Color to change the console’s colors to the country’s colors upon select that country. For Example, for USA, Change the console colors to Red, White, and Blue. Note that Countries have either 2 OR 3 colors, you will have to account for this.

