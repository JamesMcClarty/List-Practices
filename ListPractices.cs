using System;
using System.Collections.Generic;

namespace list_practices
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Saturn");

            List<string> anotherPlanetList = new List<string>() { "Uranus", "Neptune" };

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            anotherPlanetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 3);
            anotherPlanetList.Remove("Pluto");

            Random random = new Random();

            List<int> numbers = new List<int>
            {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

            for (int i = 0; i < numbers.Count; i++)
            {
                // Determine if the current loop index is contained inside of the `numbers` list.
                // Print a message to the console indicating whether the index is in the list.
                if(numbers.Contains(i))
                    Console.WriteLine($"The list contains the number {i}");
                else
                    Console.WriteLine($"The list doesn't contain the number {i}");
            }
        }
    }
}