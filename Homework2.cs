using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a letter grade (A, B, C, D, F): ");
            string grade = Console.ReadLine().ToUpper();

            switch (grade)
            {
                case "A":
                    Console.WriteLine("GPA Points: 4");
                    break;
                case "B":
                    Console.WriteLine("GPA Points: 3");
                    break;
                case "C":
                    Console.WriteLine("GPA Points: 2");
                    break;
                case "D":
                    Console.WriteLine("GPA Points: 1");
                    break;
                case "F":
                    Console.WriteLine("GPA Points: 0");
                    break;
                default:
                    Console.WriteLine("Wrong Letter Grade!");
                    break;
            }
            FindSmallestValue();
            CheckLeapYear();
        }

        private static void FindSmallestValue()
        {
            Console.WriteLine("\n=== Find the Smallest Number ===");
            
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int smallest = Math.Min(num1, Math.Min(num2, num3));
            Console.WriteLine("The smallest value is: " + smallest);
        }

        static void CheckLeapYear()
        {
            Console.WriteLine("\n=== Check Leap Year ===");

            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
    }
}
