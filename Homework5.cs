using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int largestQ1 = Q1_method();
            Console.WriteLine($"The largest number from Q1 is: {largestQ1}");

            
            int largestQ2 = Q2_method();
            Console.WriteLine($"The largest number from Q2 is: {largestQ2}");

            
            Q3_method();
        }

        
        static int Q1_method()
        {
            
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            
            return FindLargest(num1, num2);
        }

        
        static int FindLargest(int a, int b)
        {
            return a > b ? a : b;  
        }

       
        static int Q2_method()
        {
            
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fourth number:");
            int num4 = Convert.ToInt32(Console.ReadLine());

            
            int largest12 = FindLargest(num1, num2);
            int largest34 = FindLargest(num3, num4);

            
            return FindLargest(largest12, largest34);
        }

        
        static void Q3_method()
        {
            
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            Console.WriteLine("Re-enter password:");
            string confirmPassword = Console.ReadLine();

            Console.WriteLine("Enter your birth year:");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            
            if (checkAge(birthYear))
            {
               
                if (password == confirmPassword)
                {
                    Console.WriteLine("Account is created successfully");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account");
            }
        }

        
        static bool checkAge(int birthYear)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;

            return age >= 18;  
        }
    }
}

