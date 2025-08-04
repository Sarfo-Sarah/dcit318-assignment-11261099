using System;
using System.Diagnostics;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {

    }
    
    static void RunGradeCalculator()
    {
        Console.Clear();
        Console.WriteLine("Grade Calculator");
        Console.WriteLine("----------------");
        
        // Prompt user for numerical grade
        Console.Write("Enter a numerical grade (0-100): ");
        
        // Read and validate input
        if (int.TryParse(Console.ReadLine(), out int numericalGrade))
        {
            // Ensure grade is within valid range
            if (numericalGrade >= 0 && numericalGrade <= 100)
            {
                string letterGrade = CalculateLetterGrade(numericalGrade);
                
                // Display the result
                Console.WriteLine($"\nNumerical Grade: {numericalGrade}");
                Console.WriteLine($"Letter Grade: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Error: Please enter a grade between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid numerical grade.");
        }
        
        Console.WriteLine("\nPress any key to return to main menu...");
        Console.ReadKey();
    }

}