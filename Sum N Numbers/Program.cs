using System;
 
namespace Sum_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // number input, integer, bigger than 1
            int n = int.Parse(Console.ReadLine());
            // sum the first numbers from 1 to n
            int sum = (n*((n+1)))/2;
            Console.WriteLine(sum);
        }
    }
}