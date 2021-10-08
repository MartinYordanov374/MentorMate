using System;

namespace IsArraySorted
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbersArray = new double[]{56,23,0,1};
            bool isSorted = false;
            for (int i = 0; i < numbersArray.Length-1; i++)
            {
                if(numbersArray[i]>numbersArray[i+1])
                {
                    isSorted = true;
                }
                else
                {
                    isSorted = false;
                }
            }
            if(isSorted)
            {
                System.Console.WriteLine("Your array is sorted");
            }
            else
            {
                System.Console.WriteLine("Your array is not sorted");
            }


        }

    }
}
