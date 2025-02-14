using System;

class Program
{
    
    static int FindLargest(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1; 
        }
        else
        {
            return num2; 
        }
    }

    
    static void PrintTriangle(int N, string shape)
    {
        
        Console.WriteLine($"N = {N}, Shape = {shape}");
        
        if (shape == "left")
        {
            
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();  
            }
        }
        else if (shape == "right")
        {
            
            for (int i = 1; i <= N; i++)
            {
                
                for (int j = 1; j <= N - i; j++)
                {
                    Console.Write(" ");
                }
                
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();  
            }
        }
        else
        {
            Console.WriteLine("Invalid shape input. Please choose 'left' or 'right'.");
        }
    }

    
    static void Main(string[] args)
    {
        
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine()); 
        
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine()); 

        
        int largest = FindLargest(number1, number2);

        
        Console.WriteLine("The largest number is: " + largest);

        
        Console.Write("Enter the number N for the triangle: ");
        int N = Convert.ToInt32(Console.ReadLine());  

        Console.Write("Enter the shape (left or right): ");
        string shape = Console.ReadLine().ToLower();  

        
        PrintTriangle(N, shape);
    }
}

