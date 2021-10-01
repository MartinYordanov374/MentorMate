using System;
using System.Linq;

namespace Debugging_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
          decimal input = decimal.Parse(Console.ReadLine());
          
          if(input==1)
          {
              System.Console.WriteLine(0);
          }
          else
          {
            decimal fraction = 1/input;
            
            var result = fraction.ToString().Split(".")[1];
            var convertedResultToArray = result;
                if(convertedResultToArray.Distinct().Count()<=convertedResultToArray.Length)
                {
                    System.Console.WriteLine(convertedResultToArray.Length);
                }
                else
                {
                    System.Console.WriteLine("NO");
                }
          }
        }
    }
}
