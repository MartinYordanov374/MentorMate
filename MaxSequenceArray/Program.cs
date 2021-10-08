using System;
using System.Collections.Generic;
using System.Linq;
namespace MaxSequenceArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[]{2, 1, 1, 2, 3, 3, 2, 2, 2, 1};

            List<double> outerSequenceKeeper = new List<double>();
            for (int i = 0; i < array.Length; i++)
            {
                List<double> innerSequenceKeeper = new List<double>();
                for (int j = i; j < array.Length; j++)
                {
                    if(array[i] == array[j])
                    {
                        innerSequenceKeeper.Add(array[i]);
                    }
                    else
                    {
                        break;
                    }
                }
                if(innerSequenceKeeper.Count > outerSequenceKeeper.Count)
                {
                    outerSequenceKeeper = innerSequenceKeeper;
                }
            }
            foreach (var item in outerSequenceKeeper)
            {
                Console.WriteLine(item);
            }
        }
    }
}
