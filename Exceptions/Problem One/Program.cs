using System;
namespace Problem_One
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadNumber(1,10);
        }
        static void ReadNumber(int start, int end)
        {
            try
            {
                for(int i = 0; i < 10; i++)
                {
                    double number = double.Parse(Console.ReadLine());
                    if(number >= start && number <= end)
                    {
                        System.Console.WriteLine($"Your number is {number}");
                    }
                    else if(number <= 1 || number >= 100)
                    {
                        throw new Exception("Your number is invalid. Is it bigger or equal to 1 or 100?");
                    }
                    else
                    {
                        throw new Exception("Your number was not in the interval you have provided.");
                    }
                }

            }
            catch(Exception)
            {
                System.Console.WriteLine("Invalid input");
            }
            
        }
    }
}
