using System;
using Program.Math;
using Program;

namespace Program
{
    
    class MainClass
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            var number = int.Parse(Console.ReadLine());

            var factorial = 1;
            for (var i = number; i >= 1; i--)
            {
                factorial = factorial *i;
            }

            Console.WriteLine(factorial);

            var class1 = new Class1();
           // class1.haha = "my name is this";
            Console.WriteLine(class1.haha);
        }
        

    }
}
