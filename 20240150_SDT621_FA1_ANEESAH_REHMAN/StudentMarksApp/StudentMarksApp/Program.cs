using System;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Prompting user for student name 
        Console.Write("Enter student name: ");
        string name= Console.ReadLine();

        double mark1 = GetValidMark(" Enter mark for subject 1: ");
        double mark2 = GetValidMark(" Enter mark for subject 2: ");
        double mark3 = GetValidMark(" Enter mark for subject 3: ");

        // calculating total marks and average
        double total = mark1 + mark2 + mark3;
        double average = total / 3;

        // FAIL OR PASS
        string result = (average >= 50) ? "PASS" : "FAIL";

        // OUTPUT 
        Console.WriteLine();
        Console.WriteLine("STUDENT RESULTS");
        Console.WriteLine($"Name:           {name}");
        Console.WriteLine($"Total Marks:    {total}");
        Console.WriteLine($"Average Marks:  {average:F2}");
        Console.WriteLine($"Result:         {result}");
        Console.WriteLine("Result issued at:" + DateTime.Now);

        // Exit message
        Console.WriteLine("\n Press any key to exit ...");
        Console.ReadKey();

    }//close Main

    // GetValidMark Method
    static double GetValidMark(string message)
    {
        double mark;
        Console.Write(message);

        while (!double.TryParse(Console.ReadLine(), out mark))
        {
            Console.Write("Invalid input. Please enter a numeric value: ");
        }

        return mark;

    } //close method

} // close program