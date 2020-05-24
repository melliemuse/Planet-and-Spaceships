using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main()
        {
            List<string> planetList = new List<string>() {
                "Mercury", "Mars"
                };

            // Add() Jupiter and Saturn at the end of the list.


            planetList.Add("Jupiter");
            planetList.Insert(planetList.Count, "Saturn");


            // Create another List that contains that last two planet of our solar system.

            List<string> lastTwoPlanets = new List<string>() {
                    "Uranus", "Neptune"
            };


            // Combine the two lists by using AddRange().
            planetList.AddRange(lastTwoPlanets);

            // Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            // planetList.ForEach(planet => Console.WriteLine(planet));

            // Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            // List<string> rockyPlanets = new List<string>() {
            // };
            string[] rockyPlanets = planetList.GetRange(0, 4).ToArray();
            //    foreach(string planets in rockyPlanets)
            //    {
            //        Console.WriteLine(planets);
            //    }


            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.

            planetList.Remove("Pluto");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

        }

    }
}