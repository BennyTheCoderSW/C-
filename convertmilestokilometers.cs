// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class ConvertMilesToKilometers
{
    static void Main()
    {
        Console.Write("Enter the number of miles: ");
        double miles = double.Parse(Console.ReadLine());

        double kilometers = ConvertToKilometers(miles);

        Console.WriteLine($"{miles} miles is equal to {kilometers} kilometers.");
    }

    static double ConvertToKilometers(double miles)
    {
        const double kilometersPerMile = 1.60934;
        return miles * kilometersPerMile;
    }
}

