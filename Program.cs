using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanetsList = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastPlanetsList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            // foreach (string planet in planetList)
            // {
            //     Console.WriteLine(planet);
            // }

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            // foreach (string rockyPlanet in rockyPlanets)
            // {
            //     Console.WriteLine(rockyPlanet);
            // }

            planetList.Remove("Pluto");

            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }
        }
    }
}


