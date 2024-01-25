/*
Write a C# program named “InchesToCentmeters” that declares a named constant that holds the number of centimeters in an inch: 2.54. 
Also declare a variable to represent a measurement in inches, and assign a value. 
Display the measurement in both inches and centimeters—for example, 3 inches is 7.62 centimeters.
*/

class conversion {


    static void Main() {

        int inch = 6;
        double centimeter = 2.54;
        double conversion = inch * centimeter;

        System.Console.WriteLine("Your number of inches is " + inch);
        System.Console.WriteLine("Your centimeters are " + conversion);

    }

   
}