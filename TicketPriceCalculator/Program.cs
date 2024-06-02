using System;
// this program takes the age of a person as input and determines the price of a ticket based on the age

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int regularPrice = 10;
            const int discountedPrice = 7;

            Console.WriteLine("Enter your age: ");

            if (int.TryParse(Console.ReadLine(), out int age) && age >= 0)
            {
                int ticketPrice = (age <= 12 || age >= 65) ? discountedPrice : regularPrice;
                Console.WriteLine("The ticket price is: GHC" + ticketPrice);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
