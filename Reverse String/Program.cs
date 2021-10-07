using System;
 
namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // enter number and reverse it
            string input = Console.ReadLine();
            string inputReversed = "";            
 
            for(int i = input.Length - 1; i >= 0; i--)
            {
                inputReversed += input[i];
            }
            Console.WriteLine(inputReversed);
        }
        
    }
}