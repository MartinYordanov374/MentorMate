using System;
using System.Linq;
using System.Collections.Generic;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 15 == 0)
                {
                   Console.WriteLine(i + " - FizzBuzz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine(i + " - Buzz");
                }
                else if(i % 3 == 0)
                {
                    System.Console.WriteLine(i + " - Fizz");
                }
            }
        }

    }
}