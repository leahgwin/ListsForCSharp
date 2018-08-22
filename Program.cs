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
            //
            // foreach (string planet in planetList)
            // {
            //     Console.WriteLine(planet);
            // }
            //empty list of probes
            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();


            //create probe
            Dictionary<string, string> opportunity = new Dictionary<string, string>(){
                {"Mars", "Opportunity"}
            };
            //create probe
            Dictionary<string, string> voyager2 = new Dictionary<string, string>(){
                {"Neptune", "Voyager 2"}
            };
            //create probe
            Dictionary<string, string> Cassini = new Dictionary<string, string>(){
                {"Saturn", "Cassini"}
            };
            //create probe
            Dictionary<string, string> viking = new Dictionary<string, string>(){
                {"Mars", "Viking"}
            };
            //create probe
            Dictionary<string, string> pioneer11 = new Dictionary<string, string>(){
                {"Saturn", "Pioneer 11"}
            };
            //create probe
            Dictionary<string, string> voyager2Saturn = new Dictionary<string, string>(){
                {"Saturn", "Voyager 2"}
            };
            //create probe
            Dictionary<string, string> mariner = new Dictionary<string, string>(){
                {"Mercury", "Mariner 10"}
            };


            //add above probes to the list
            probes.Add(viking);
            probes.Add(opportunity);
            probes.Add(mariner);
            probes.Add(voyager2);
            probes.Add(Cassini);
            probes.Add(pioneer11);
            probes.Add(voyager2Saturn);

            //INSTRUCTIONS: Iterate over your list of planets from above, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.

            //itterate over the planets
            foreach (string planet in planetList)
            {
                //holds matching probe names
                List<string> visitedProbes = new List<string>();
                //itterate over probes
                foreach (Dictionary<string, string> probe in probes)
                {
                    if (probe.ContainsKey(planet))
                    {
                        visitedProbes.Add(probe[planet]);
                    }
                }
                //this makes sure only the planets with probes prints
                if (visitedProbes.Count > 0)
                {
                    Console.WriteLine($"{planet}: {String.Join(", ", visitedProbes)}");
                }
            }
        }
    }
}


