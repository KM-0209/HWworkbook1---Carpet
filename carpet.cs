using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// <summary>
// This program calculates the total cost of fitting a carpet based on user input for length, width
// </summary>

class Program
{
    // This method calculates the cost of fitting a carpet based on the length, width, and cost per square meter.
    static void carpetFittingCost(double length, double width, double costPerSquareMeter)
    {
        
        // Calculate the area of the carpet, the cost of underlay, and the cost of grippers, then compute the total cost.
        double area = length * width;
        double grippers = 1 * ((width * 2) + (length * 2));
        double underlayCost = area * 3;
        double fittingCost = 50;
        double totalCost = (area * costPerSquareMeter) + underlayCost + grippers + fittingCost;
        Console.WriteLine($"The total cost of fitting the carpet is: {totalCost:C}");
    }
    // The Main method prompts the user for input and validates it before calling the carpetFittingCost method.
    static void Main(string[] args)
    {
        double length;
        double width;
        double costPerSquareMeter;

        // Prompt the user for the length, width, and cost per square meter of the carpet, ensuring valid input.
        Console.Write("Enter the length of the carpet in meters: ");
        while (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
        {
            Console.WriteLine("Please enter a valid positive number for the length.");
            Console.Write("Enter the length of the carpet in meters: ");
        }
        Console.Write("Enter the width of the carpet in meters: ");
        while (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
        {
            Console.WriteLine("Please enter a valid positive number for the width.");
            Console.Write("Enter the width of the carpet in meters: ");
        }
        Console.Write("Enter the cost per square meter of the carpet: ");
        while (!double.TryParse(Console.ReadLine(), out costPerSquareMeter) || costPerSquareMeter <= 0)
        {
            Console.WriteLine("Please enter a valid positive number for the cost per square meter.");
            Console.Write("Enter the cost per square meter of the carpet: ");
        }
        carpetFittingCost(length, width, costPerSquareMeter);
    }
}
