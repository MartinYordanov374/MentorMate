using System;
using System.Text.RegularExpressions;
 
namespace Palyndromes
{
    class Program
    {
        static void Main(string[] args)
        {
            // enter number and reverse it
            string input = Console.ReadLine();
            string inputReversed = "";            
            // Regex whitespaceRegex = new Regex(@"\S+");
            for(int i = input.Length - 1; i >= 0; i--)
            {
                inputReversed += input[i];
            }
            string resultInput = Regex.Replace(input,@"\s+","");
            string resultInputReversed = Regex.Replace(inputReversed, @"\s+", "");
            if(resultInput.ToLower() == resultInputReversed.ToLower())
            {
                Console.WriteLine($"{input} is a palyndrome.");
            }
            else
            {
               Console.WriteLine($"{input} is not a palyndrome.");
            }
 
        }
    }
}