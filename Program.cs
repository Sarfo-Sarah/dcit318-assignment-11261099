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

    static string CalculateLetterGrade(int grade)
    {
        if (grade >= 90) return "A";
        if (grade >= 80) return "B";
        if (grade >= 70) return "C";
        if (grade >= 60) return "D";
        return "F";
    }
    
     static void RunTicketPriceCalculator()
{
    Console.Clear();
    Console.WriteLine("Ticket Price Calculator");
    Console.WriteLine("------------------------");
    
    Console.Write("Please enter your age: ");
    
    if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
    {
        const double standardPrice = 10.0;
        const double discountedPrice = 7.0;
        
        double ticketPrice = (age <= 12 || age >= 65) ? discountedPrice : standardPrice;
        
        Console.WriteLine("\nTicket Information:");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Ticket Price: GHC{ticketPrice:F2}");
        
        if (ticketPrice == discountedPrice)
        {
            Console.WriteLine("Note: Discounted price applied (Senior Citizen or Child)");
        }
    }
    else
    {
        Console.WriteLine("\nError: Please enter a valid age (positive number).");
    }
    
    Console.WriteLine("\nPress any key to return to main menu...");
    Console.ReadKey();
}

}