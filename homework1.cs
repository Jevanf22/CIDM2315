﻿using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 2.5;
            double y = 3.3;

            double z = 4 * x * x + 3 * y;

            Console.WriteLine($"X = {x}, Y = {y}");
            Console.WriteLine($"The value of Z is: {z:F1}");
            
            Console.ReadLine();
        }
    }
}
