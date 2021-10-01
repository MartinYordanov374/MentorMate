using System;
using System.Collections.Generic;
namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ALL NUMBERS MUST BE IN THE FOLLOWING INTERVAL - [-99.99 - 99.99] !");
            double[] numbersArray = new double[3];

            for(int i = 0; i < 3 ; i++)
            {
                double currNumber = PromptNumber();
                numbersArray[i] = currNumber;
            }

            Console.WriteLine("END OF PROMPT");
            SortArray(numbersArray);
        }

        static bool CheckIntervalValidity(double number)
        {

            if(number < -99.99d || number > 99.99d)
            {
                return false;
            }
            return true;

        }
        
        static double PromptNumber()
        {
            Console.WriteLine("Enter your number: ");
            double number = double.Parse(Console.ReadLine());

            if(!CheckIntervalValidity(number))
            {
                Console.WriteLine($"{number} is an invalid number. Please try again with a number in the following interval -> [-99.99 - 99.99]");
                number = PromptNumber();
            }
            
            return number;
        }

        static void SortArray(double[] numbersArray)
        {
            double temp = 0;
            for(int i = 0; i<numbersArray.Length; i++)
            {
                for(int j = 0; j < numbersArray.Length - i - 1; j++)
                {
                    if(numbersArray[j] > numbersArray[i])
                    {
                        temp = numbersArray[j+1];
                        numbersArray[j+1] = numbersArray[j];
                        numbersArray[i+1] = temp;
                    }
                }
            }

            foreach (var item in numbersArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
