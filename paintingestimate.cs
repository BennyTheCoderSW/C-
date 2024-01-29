// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class PaintingEstimate
{
    static void Main()
    {
        Console.Write("Enter the length of the room (in feet): ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Enter the width of the room (in feet): ");
        double width = double.Parse(Console.ReadLine());

        double totalPrice = CalculatePaintingCost(length, width);

        Console.WriteLine($"The cost of painting the room is: ${totalPrice}");
    }

    static double CalculatePaintingCost(double length, double width)
    {
        const double pricePerSquareFoot = 6;
        const double wallHeight = 9;

        double totalArea = 2 * (length + width) * wallHeight;
        double totalPrice = totalArea * pricePerSquareFoot;

        return totalPrice;
    }
}
