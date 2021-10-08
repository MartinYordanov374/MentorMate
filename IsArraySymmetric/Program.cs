using System;

namespace IsArraySymmetric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your array size: ");
            int arraySize = int.Parse(Console.ReadLine());

            string[] targetArray = new string[arraySize];

            bool isSymmetric = false;

            for(int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Enter element {i}:");
                targetArray[i] = Console.ReadLine();
            }

            for (int i = targetArray.Length-1; i >= 0; i--)
            {
                if(targetArray[i] == targetArray[targetArray.Length-1-i])
                {

                    if(i>targetArray.Length/2)
                    {
                        isSymmetric = true;
                    }

                }
                
            }

            if(isSymmetric==true)
            {
                Console.WriteLine("your array is symmetric");
            }

            else
            {
                Console.WriteLine("Your array is not symmetric");
            }

        }
    }
}
