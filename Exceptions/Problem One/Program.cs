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
                        numbersArr[i] = double.Parse(Console.ReadLine());
                    }

                    for(int i = 0; i < numbersArr.Length; i++)
                    {
                        for(int j = i + 1; j < numbersArr.Length; j++)
                        {
                            if(numbersArr[i] > 1 && numbersArr[i] < 100 && numbersArr[i] < numbersArr[j])
                            {
                                counter ++;
                                if(counter == numbersArr.Length * 2)
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
