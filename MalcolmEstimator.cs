/*
Malcolm Movers charges a base rate of $200 per move plus $150 per hour and $2 per mile. 
Write a program named “MoveEstimator” 
that prompts a user for and accepts estimates for the number of hours for a job and the number of miles 
involved in the move and displays the total moving fee.
Output as follows”
“Malcolm Movers Moving Cost”
“The base rate is $200 per move”
“The cost per hour rate is $150 per hour”
“Plus $2 per miles”
“The move requires to move xx miles”	(Note the xx is your miles set)
The total cost is $xxxx.xx	
*/

class Estimator {

    static void Main() {

        Console.WriteLine("Malcolm Movers Moving Cost");
        Console.WriteLine("The base rate is $200 per move");
        Console.WriteLine("The cost per hour rate is $150 per hour");
        Console.WriteLine("Plus $2 per miles");
        Console.Write("Please enter The number of hours for the job: ");
        String hours = Console.ReadLine();
        int convert = Convert.ToInt32(hours);
        Console.Write("Please enter The number of miles for the job: ");
        String miles = Console.ReadLine();
        double convert2 = Convert.ToDouble(miles);
        double sum = (convert * 150) + 200 + (2 * convert2);

        Console.WriteLine("The move requires to move " + convert2 + " Miles.");
        Console.WriteLine("Your total cost for your move will be: $" + sum);


    }
}