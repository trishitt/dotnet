﻿using System;
using Program.Math;

namespace Program
{
    
    class MainClass
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial *i;
            }

            Console.WriteLine(factorial);
        }
    }
}
