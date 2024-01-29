// See https://aka.ms/new-console-template for more information

using System;

class LoginPage
{
    static void Main()
    {
        string username = "admin";
        string password = "password";
        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Username: ");
            string inputUsername = Console.ReadLine();

            Console.Write("Password: ");
            string inputPassword = Console.ReadLine();

            if (inputUsername == username && inputPassword == password)
            {
                Console.WriteLine("Welcome message");
                break;
            }
            else
            {
                attempts++;
                Console.WriteLine("Incorrect username or password. Attempts remaining: {0}", 3 - attempts);
            }
        }

        if (attempts == 3)
        {
            Console.WriteLine("Suspended account message");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
