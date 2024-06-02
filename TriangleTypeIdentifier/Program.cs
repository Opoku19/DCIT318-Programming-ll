using System;
// this program takes the lengths of the sides of a triangle as input and determines the type of the triangle

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the first side: ");
            bool isValidSide1 = int.TryParse(Console.ReadLine(), out int side1);

            Console.WriteLine("Enter the length of the second side: ");
            bool isValidSide2 = int.TryParse(Console.ReadLine(), out int side2);

            Console.WriteLine("Enter the length of the third side: ");
            bool isValidSide3 = int.TryParse(Console.ReadLine(), out int side3);

            if (isValidSide1 && isValidSide2 && isValidSide3 && side1 > 0 && side2 > 0 && side3 > 0)
            {
                string triangleType;

                if (side1 == side2 && side2 == side3)
                {
                    triangleType = "Equilateral";
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    triangleType = "Isosceles";
                }
                else
                {
                    triangleType = "Scalene";
                }

                Console.WriteLine("The triangle is: " + triangleType);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter positive integers for the lengths of the sides.");
            }
        }
    }
}
