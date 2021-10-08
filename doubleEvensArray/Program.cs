using System;

namespace doubleEvensArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your array size");
            int n = int.Parse(Console.ReadLine());

            double[] numbersArray = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the element at index {i}: ");
                numbersArray[i] = double.Parse(Console.ReadLine());
                if(numbersArray[i] % 2 == 0)
                {
                    numbersArray[i] = numbersArray[i] * 2;
                }
            }

            foreach (double item in numbersArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
