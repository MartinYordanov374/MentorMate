using System;
using System.Linq;

namespace Debugging_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("NUMBERS IN BILLIONS");

           Console.WriteLine("Enter business industry");
           string businessSector = Console.ReadLine();

           Console.WriteLine("Enter business assets");
           double totalBusinessAssets = double.Parse(Console.ReadLine());

           Console.WriteLine("Enter business liabilities");
           double totalBusinessLiabilities = double.Parse(Console.ReadLine());

           Console.WriteLine("Enter business goodwill");
           double totalBusinessGoodwill = double.Parse(Console.ReadLine());

           double totalBusinessWorkingCapital = totalBusinessAssets-totalBusinessLiabilities;

           Business business = new Business(businessSector, totalBusinessAssets, totalBusinessLiabilities, totalBusinessWorkingCapital, totalBusinessGoodwill);
           businessObject.ShowBusinessData();
        }
    }
}
