using System;
namespace Problem_One
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadNumber(1,11);
        }
        static void ReadNumber(int start, int end)
        {
            try
            {
                    double numberOne = double.Parse(Console.ReadLine());
                    double numberTwo = double.Parse(Console.ReadLine());
                    double numberThree = double.Parse(Console.ReadLine());
                    double numberFour = double.Parse(Console.ReadLine());
                    double numberFive = double.Parse(Console.ReadLine());
                    double numberSix = double.Parse(Console.ReadLine());
                    double numberSeven = double.Parse(Console.ReadLine());
                    double numberEight = double.Parse(Console.ReadLine());
                    double numberNine = double.Parse(Console.ReadLine());
                    double numberTen = double.Parse(Console.ReadLine());

                    bool areValidNumbers = 1 < numberOne 
                    && numberOne < numberTwo 
                    && numberTwo < numberThree 
                    && numberThree < numberFour 
                    && numberFour < numberFive 
                    && numberFive < numberSix 
                    && numberSix < numberSeven 
                    && numberSeven < numberEight  
                    && numberEight < numberNine 
                    && numberNine < numberTen 
                    && numberTen < 100 ;

                    System.Console.WriteLine(areValidNumbers);

                    if( areValidNumbers )
                    {
                        System.Console.WriteLine("Your numbers are valid");
                    }
                    else if(areValidNumbers == false)
                    {
                        throw new Exception("Your number are invalid. Are they bigger or equal to 1 or 100 ?");
                    }

                

            }
            catch(Exception)
            {
                System.Console.WriteLine("Invalid input. Your number is likely outside of the specified range or not a number. Consider that they could not be following the required sequence.");
            }
            
        }
    }
}
