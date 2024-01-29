// See https://aka.ms/new-console-template for more information


using System;

class StudentScores
{
    static void Main()
    {
        Console.WriteLine("Enter your scores for the following subjects:");
        Console.WriteLine();

        string[] subjects = { "Math", "Science", "History", "Computer", "Philosophy" };
        int[] scores = new int[5];
        int lessThan60Count = 0;

        for (int i = 0; i < subjects.Length; i++)
        {
            Console.Write(subjects[i] + ": ");
            scores[i] = int.Parse(Console.ReadLine());

            if (scores[i] < 60)
            {
                lessThan60Count++;
            }
        }

        Console.WriteLine();

        if (lessThan60Count > 2)
        {
            Console.WriteLine("You have less than 60 in {0} subjects.", lessThan60Count);
        }
        else if (lessThan60Count == 0)
        {
            Console.WriteLine("Great work.");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
