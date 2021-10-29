using System;
using System.Collections.Generic;
using System.Linq;
namespace SecondBiggestNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[]{4,5,10,456,2000};

            int maxNumberFirst = int.MinValue;
            
            int maxNumberSecond = int.MinValue;

            int difference = 0;

            int[] differences = new int[numberArray.Length];

            for (int i = 0; i < numberArray.Length; i++)
            {
                if(numberArray[i] > maxNumberFirst)
                {
                    maxNumberFirst = numberArray[i];
                }
                if(i>0)
                {
                    difference = maxNumberFirst - numberArray[i-1];
                    if(difference != 0)
                    {
                        differences[i] = maxNumberFirst - difference;
                        if(differences[i] > maxNumberSecond)
                        {
                            maxNumberSecond = differences[i];
                        }   
                    }
                }
            }
            Console.WriteLine("The second biggest number is " + maxNumberSecond);
        }

    }
}
