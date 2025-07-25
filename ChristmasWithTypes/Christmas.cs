using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents { get; set; } = { "Get a home", "Become an oil tycoon", "Learn to manage expectations." };

        public string Santa { get; set; }

        public int? TreeHeight { get; set; }

        // Enum for days of the week
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        // Property of type Day
        public Day ChristmasDay { get; set; }
    }
}
