using System;
 
namespace Reverse_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // enter number and reverse it
            int numberInput = int.Parse(Console.ReadLine());
            string numberReversed = "";            
 
            string numberToString = numberInput.ToString();
            for(int i = numberToString.Length - 1; i >= 0; i--)
            {
                numberReversed += numberToString[i];
            }
            Console.WriteLine(numberReversed);
        }
        
    }
}