// See https://aka.ms/new-console-template for more information
/*
 * 
 * Write a program named “GuessingGame” that generates a random number between 1 and 10.
 * (In other words, in the example above, min is 1 and max is 11.) 
Ask a user to guess the random number, 
then display the random number and a message indicating whether the user’s guess was too high,
too low, or correct.
Note: 
Random ranNumberGenerator = new Random(); 
int randomNumber; 
randomNumber = ranNumberGenerator.Next(min, max);
*/


int min = 1;
int max = 11;
Random randonumber = new Random();
int randomNumber;
randomNumber = randonumber.Next(min, max);

Console.WriteLine("Please guess a number between 1 and 11");
String input = Console.ReadLine();
int numberguess = Convert.ToInt32(input);
Console.WriteLine("The number is " + randomNumber);
if (numberguess > randomNumber)
    Console.WriteLine("Your number was too high");
if (numberguess < randomNumber)
    Console.WriteLine("Your guess was too low");
if (numberguess == randomNumber)
    Console.WriteLine("Congrats you have selected the right number!");
