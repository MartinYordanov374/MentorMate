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
                    double[] numbersArr = new double[end];
                    int counter = 0;

                    for(int i = 0; i < numbersArr.Length; i++)
                    {
                        double input = double.Parse(Console.ReadLine());
                        if(input > 1 && input < 100)
                        {
                           numbersArr[i] = input;
                        }
                        else
                        {
                            System.Console.WriteLine("You have a number that does not adhere to the sequence!");
                            break;
                         }
                    }

                    for(int i = 0; i < numbersArr.Length; i++)
                    {
                        for(int j = i + 1; j < numbersArr.Length; j++)
                        {
                            if(numbersArr[i] < numbersArr[j])
                            {
                                counter ++;
                                if(counter == numbersArr.Length)
                                {
                                    Console.WriteLine("Your numbers are valid");
                                    break;
                                }
                            }
                            else
                            {
                                throw new Exception("Your number are invalid. Are they bigger or equal to 1 or 100 ?");
                            }
                        }
                    }
            }

            catch(Exception)
            {
                Console.WriteLine("Invalid input. Your number is likely outside of the specified range or not a number. Consider that they could not be following the required sequence.");
            }
            
        }
    }
}
