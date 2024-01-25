/*
Write a program named “FahrenheitToCelsius” that accepts a temperature in Fahrenheit
from a user and converts it to Celsius by subtracting 32 from the Fahrenheit value and multiplying the result by 5/9. 
Display both values to one decimal place.
“Fahrenheit to Celsius Conversion”
*/

class CtoF {

    static void Main() {

        Console.Write("Please Enter a Temperature in Fahrenheit: ");
        String input = Console.ReadLine();
        double convert = Convert.ToDouble(input);
        double celsius = (convert - 32) * .55;
        Console.WriteLine("Your Temperature is " + input);
        Console.WriteLine("Your Temperature in Celsius is " + celsius);
    }
}