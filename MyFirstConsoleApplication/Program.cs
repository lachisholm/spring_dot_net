using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variables to store your name and location
            string myName = "Lora Chisholm";
            string myLocation = "Salt Lake City, UT";

            // Outputting name and location using String Interpolation
            Console.WriteLine($"My name is {myName}");
            Console.WriteLine($"I am from {myLocation}");

            // Outputting the current date without time
            Console.WriteLine($"Today's date is {DateTime.Now.ToString("MM/dd/yyyy")}");

            // Calculating the number of days until Christmas
            DateTime today = DateTime.Now;
            DateTime nextChristmas = new DateTime(today.Year, 12, 25);
            if (today > nextChristmas)
            {
                nextChristmas = nextChristmas.AddYears(1); // If today is past this year's Christmas, use next year's Christmas
            }
            int daysUntilChristmas = (nextChristmas - today).Days;
            Console.WriteLine($"Number of days until Christmas: {daysUntilChristmas}");

            // Added program example from the C# Programming Yellow Book by Rob Miles textbook
            
            // Requesting dimensional input with labels
            Console.WriteLine("Enter the width in meters:");
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter the height in meters:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine($"The length of the wood is {woodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} square metres");

            // Pause the program in the console
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
