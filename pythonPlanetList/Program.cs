using System;
using System.Collections.Generic;

namespace pythonPlanetList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() {"Mercury", "Mars"};
            //Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            //Create another List that contains that last two planet of our solar system.
            int planetListCount = planetList.Count;

            List<string> lastTwo = planetList.GetRange((planetListCount - 2), 2);

            //Combine the two lists by using AddRange().
            planetList.AddRange(lastTwo);

            //Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(3, "Earth");
            planetList.Insert(2, "Venus");

            //Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            //Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets.
            List<string> rockyPlanets = planetList.GetRange(3, 5);
            //I dont know which ones are rocky, this is random :)

            //Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove("Pluto");

            foreach(string planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }

            List<Dictionary<string, List<string>>> solarSystemProbes = new List<Dictionary<string, List<string>>>();{
                
            }

        }
    }
}
