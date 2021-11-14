using System;

namespace Abstract_Classes_and_Interfaces
{

    class Program
    {
        static void Main(string[] args)
        {
            Iguana regularIguana = new Iguana(false, false, true, false, true, "Green");
            regularIguana.MakeSound();
            regularIguana.showInfo();

            Console.WriteLine("");
            
            Lion regularLion = new Lion(5, 4, true, "Orange");
            regularLion.MakeSound();
            regularLion.showInfo();
        }
    }
}
