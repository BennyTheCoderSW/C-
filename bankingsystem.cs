// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


public class bankAccount
{
    public String Accountnumber;
    public String AccountHolderName;
    public double checkBalance = 5000.00;
    public double saveBalance = 3000.00;
public static void Main()
    {
        //Create objects  for classes

        bankAccount account1 = new bankAccount();
        SavingsAccount savings = new SavingsAccount();
        CheckingAccount checking = new CheckingAccount();

        //Start program writing for banking system (list bank, prompt for info)
        Console.WriteLine("Welcome to this Benny's Bank!");
        Console.WriteLine("Please enter your Account number: ");
        String Accountnumber = Console.ReadLine();
        Console.WriteLine("Please enter your Account Holder Name: ");
        String AccountHolderName = Console.ReadLine();
        Console.WriteLine("Checking or Savings account? (Please type Checking or Savings) ");
        String response = Console.ReadLine();

        //if statements for the specific accounts and calls to their withdraw method
        if (response == "Checking")
            Console.WriteLine("Your current checking account balance is: $" + account1.checkBalance);
            checking.Withdraw()
        if (response == "Savings")
            Console.WriteLine("Your current Savings account balance is: $" + account1.saveBalance);
            savings.Withdraw();
    }
}

class SavingsAccount : bankAccount
{
    double interestrate = 0.05;

    public static void Withdraw(double amount)
    {
        // defining method for withdraws for Savings account

        bankAccount account1 = new bankAccount();
        SavingsAccount savings = new SavingsAccount();
        Console.WriteLine("Please enter the amount you would like to withdraw from Checking: ");
        Console.WriteLine("EX: 100.00");
        String amountTakenSaving = Console.ReadLine();
        double convert2doubleSaving = Convert.ToDouble(amountTakenSaving);
        Math.Round(convert2doubleSaving, 2);
        Console.WriteLine("An interest rate of " + savings.interestrate + "Will be applied is this okay? Y/N");
        String reply = Console.ReadLine();
        if (reply == "Y")
            Console.WriteLine("An interest of $" + (convert2doubleSaving * savings.interestrate) + " has been applied");
            Console.WriteLine("Your new balance is $" + (account1.saveBalance - convert2doubleSaving));
        //provides catch for InvalidOperationException
    }
}
class CheckingAccount : bankAccount
    {
        double overdraftlimit = 10000.00;

    public static void Withdraw(double amount)
        {
        //defining method for withdraw for checking account

        bankAccount account1 = new bankAccount();
        CheckingAccount checking = new CheckingAccount();
        Console.WriteLine("Your current overdraft limit is $" + checking.overdraftlimit);
        Console.WriteLine("Please enter the amount you would like to withdraw from Checking: ");
        Console.WriteLine("EX: 100.00");
        String amountTakenChecking = Console.ReadLine();
        double convert2doubleChecking = Convert.ToDouble(amountTakenChecking);
        Math.Round(convert2doubleChecking, 2);
        Console.WriteLine("Your new Checking Account Balance is: $" + (account1.checkBalance - convert2doubleChecking));
         //provides catch for InvalidOperationException
        }
    }


