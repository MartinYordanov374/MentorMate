using System;
using System.Collections.Generic;
using System.Linq;
namespace SecondBiggestNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine($"Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] numberArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Enter element at index {i}: ");
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The second biggest number in your array is {MergeSort(numberArray)}.");
        }

        static int MergeSort(int[] unsortedArray)
        {
            int midPoint = unsortedArray.Length/2;

            List<int> leftSide = new List<int>();
            List<int> rightSide = new List<int>();

            for (int i = 0; i < midPoint; i++)
            {
                leftSide.Add(unsortedArray[i]);
            }

            for (int i = midPoint-1; i < unsortedArray.Length; i++)
            {
                // System.Console.WriteLine(i);
                rightSide.Add(unsortedArray[i]);
            }
            
            leftSide = SortList(leftSide);
            rightSide = SortList(rightSide);
            List<int> sortedMergedList = SortList(MergeList(leftSide,rightSide)).Distinct().ToList();

            int secondBiggestNumber = sortedMergedList[sortedMergedList.Count-2];
            return secondBiggestNumber;

        }

        static List<int> SortList(List<int> targetList)
        {
            for (int i = 0; i < targetList.Count-1; i++)
            {
                for (int j = 0; j < targetList.Count- i - 1; j++)
                {
                    if(targetList[j]>targetList[j+1])
                    {
                        int temp = targetList[j]; 
                        targetList[j] = targetList[j+1]; 
                        targetList[j+1] = temp; 
                    }
                }
            }
            return targetList;
        }

        static List<int> MergeList(List<int> firstList, List<int> secondList)
        {
            List<int> mergedLists = new List<int>();
            return mergedLists.Concat(firstList).Concat(secondList).ToList();
        }
    }
}
