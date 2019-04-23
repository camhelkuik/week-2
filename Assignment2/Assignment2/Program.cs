using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var continueLoop = true;

            do
            {
                try
                {
                    Console.Write("Enter miles driven: ");
                    double inputMiles = double.Parse(Console.ReadLine());

                    Console.Write("Enter gallons used: ");
                    double inputGallons = double.Parse(Console.ReadLine());

                    double mpg = inputMiles / inputGallons;

                    Console.WriteLine($"{mpg:F2} miles per gallon"); 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter decimal numbers for the miles driven and gallons used");
                }

                Console.Write("Quit (yes/no)? ");
                string quitResponse = Console.ReadLine();

                if (quitResponse == "yes")
                {
                    continueLoop = false;
                }

            } while (continueLoop);
        }
    }
}
