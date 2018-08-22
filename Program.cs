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
            //empty list of probes
            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();

            //create probe
            Dictionary<string, string> viking = new Dictionary<string, string>(){
                {"Mars", "viking"}
            };
            //create probe
            Dictionary<string, string> opportunity = new Dictionary<string, string>(){
                {"Mars", "Opportunity"}
            };
            //create probe
            Dictionary<string, string> mariner = new Dictionary<string, string>(){
                {"Mercury", "Mariner 10"}
            };

            //add above probes to the list
            probes.Add(viking);
            probes.Add(opportunity);
            probes.Add(mariner);

            //itterate over the planets
            foreach (string planet in planetList)
            {



            }


        }
    }
}


