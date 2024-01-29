// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

//Console.WriteLine("Hello, World!");
/*
Write a program named “ArrayDemo” that stores an array of 10 integers. 
After the user enters all 10 integers, allow the user four options: 
(1) to view the list in order from the first to last position in the stored array,
(2) to choose a specific position to view, or
(3) to quit the application.
NOTE: Loop and enter 10 integers
While loop until user enters 3 to quit, otherwise do either option 1or 2 
*/

using System;

class ArrayDemo
{
    static int[] array = new int[10];

    static void Main()
    {
        TakeInput();

        int option;
        do
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1. View the list in order");
            Console.WriteLine("2. View a specific position");
            Console.WriteLine("3. Quit");

            Console.Write("Enter your option (1-3): ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ViewList();
                    break;
                case 2:
                    ViewSpecificPosition();
                    break;
                case 3:
                    Console.WriteLine("Quitting the application...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        } while (option != 3);
    }

    static void TakeInput()
    {
        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Integer {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    static void ViewList()
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Position {i}: {array[i]}");
        }
    }

    static void ViewSpecificPosition()
    {
        Console.Write("Enter a position (0-9): ");
        int position = int.Parse(Console.ReadLine());

        if (position >= 0 && position < array.Length)
        {
            Console.WriteLine($"Value at position {position}: {array[position]}");
        }
        else
        {
            Console.WriteLine("Invalid position.");
        }
    }
}


