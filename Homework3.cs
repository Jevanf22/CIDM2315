namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a number to check if it's prime: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(num))
            {
                Console.WriteLine(num + " is a prime number.");
            }
            else
            {
                Console.WriteLine(num + " is non-prime.");
            }

            
            Console.Write("Enter an integer for square pattern: ");
            int squareSize = Convert.ToInt32(Console.ReadLine());
            PrintSquarePattern(squareSize);

            
            Console.Write("Enter an integer for right-aligned star pattern: ");
            int starSize = Convert.ToInt32(Console.ReadLine());
            PrintRightAlignedStarPattern(starSize);

            
            Console.Write("Enter an integer for number pyramid pattern: ");
            int numberPyramidSize = Convert.ToInt32(Console.ReadLine());
            PrintNumberPyramidPattern(numberPyramidSize);
        }

        
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;  

            for (int i = 2; i <= Math.Sqrt(number); i++)  
            {
                if (number % i == 0)
                    return false;  
            }
            return true;  
        }

        
        static void PrintSquarePattern(int num)
        {
            for (int i = 0; i < num; i++) 
            {
                for (int j = 0; j < num; j++)  
                {
                    Console.Write("* ");  
                }
                Console.WriteLine(); 
            }
        }

       
        static void PrintRightAlignedStarPattern(int num)
        {
            for (int i = 1; i <= num; i++)  
            {
                for (int j = 1; j <= num - i; j++) 
                {
                    Console.Write(" ");  
                }
                for (int j = 1; j <= i; j++)  
                {
                    Console.Write("*");  
                }
                Console.WriteLine();  
            }
        }

        
        static void PrintNumberPyramidPattern(int num)
        {
            for (int i = 1; i <= num; i++)  
            {
                for (int j = 1; j <= num - i; j++)  
                {
                    Console.Write(" "); 
                }
                for (int j = 1; j <= i; j++)  
                {
                    Console.Write(i);  
                }
                Console.WriteLine();  
            }
        }
    }
}