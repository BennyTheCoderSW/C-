// See https://aka.ms/new-console-template for more information

using static System.Console;

class LoopingBankBal
{
    static void Main()
    {
        double bankBal;
        double rate;
        int year;
        const double START_BAL = 1000, START_INT = 0.04, INT_INCREASE = 0.02, LAST_INT = 0.08;
        const int END_YEAR = 5;

        rate = START_INT;

        while (rate <= LAST_INT)
        {
            bankBal = START_BAL;
            WriteLine("Starting bank balance is {0}", bankBal.ToString("C"));
            WriteLine("Interest Rate: {0}", rate.ToString("P"));

            year = 1;
            while (year <= END_YEAR)
            {
                bankBal = bankBal + bankBal * rate;
                WriteLine("After year {0}, bank balance is {1}", year, bankBal.ToString("C"));
                year++;
            }

            rate += INT_INCREASE;
        }
    }
}

