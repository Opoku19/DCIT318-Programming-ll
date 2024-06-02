using System;
// this program takes a numerical grade as input and determines the letter grade
class LetterGradeCalculator
{
    static void Main(string[] args)
    {
        // Prompt user for numerical grade
        Console.WriteLine("Enter a numerical grade (0-100): ");

        // Read user input and convert to integer
        int grade;
        while (!int.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100: ");
        }

        // Determine letter grade using a switch statement
        string letterGrade;
        switch (grade)
        {
            case >= 90:
                letterGrade = "A";
                break;
            case >= 80:
                letterGrade = "B";
                break;
            case >= 70:
                letterGrade = "C";
                break;
            case >= 60:
                letterGrade = "D";
                break;
            default:
                letterGrade = "F";
                break;
        }

        // Display the letter grade
        Console.WriteLine($"Your letter grade is: {letterGrade}");
    }
}
