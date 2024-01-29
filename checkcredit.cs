// See https://aka.ms/new-console-template for more information
/*
 * Write a program named “CheckCredit” that prompts users 
 * to enter a purchase price for an item. 
 * If the value entered is greater than a credit limit of $8,000
 * , display an error message “Disapproved: over credit limit”; otherwise, 
 * display Approved.
 * */

Console.WriteLine("Please enter the purchase price for the item: ");
String input = Console.ReadLine();
double input2 = Convert.ToDouble(input);
double creditlimit = 8000.0;

if (input2 > creditlimit)
    Console.WriteLine("Disapproved: over credit limit");
else Console.WriteLine("Approved");
