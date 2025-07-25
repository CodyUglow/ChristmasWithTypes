using System;
using System.Diagnostics;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Thursday;

            // Set Santa's name to Kris Kringle
            xmas.Santa = "Kris Kringle";

            // Insert 3 presents you would like for xmas. They must be strings
            xmas.Presents = new string[] { "Get a home", "Become an oil tycoon", "Learn to manage expectations." };

            // Set the TreeHeight to 10
            xmas.TreeHeight = 10;

            // Optionally set the ChristmasDay property
            xmas.ChristmasDay = xmasDay;

            Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents I would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to call Santa, {xmas.Santa}");
        }
    }
}
