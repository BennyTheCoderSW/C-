// See https://aka.ms/new-console-template for more information
/*
 * Write a program named “Admission” for a college’s admissions office. 
 * The user enters a numeric high school grade point average (for example, 3.2) 
 * and an admission test score. 
 * Display the message Accept if the student meets either of the following requirements: 
•	A grade point average of 3.0 or higher, and an admission test score of at least 60 
•	A grade point average of less than 3.0, and an admission test score of at least 80 
•	If the student does not meet either of the qualification criteria, display Reject.
*/

Console.WriteLine("Please enter your current GPA: ");
Console.WriteLine("ex. 3.2");
String input = Console.ReadLine();
double studentgpa = Convert.ToDouble(input);
Console.WriteLine("Please enter an admission test score"); 
String input2 = Console.ReadLine();
double admissiontestscore = Convert.ToDouble(input2);

if (studentgpa > 3.0 && admissiontestscore > 60.0)
    Console.WriteLine("Accept");
if(studentgpa < 3.0 && admissiontestscore >= 80.0)
    Console.WriteLine("Accept");
else
    Console.WriteLine("Reject");
