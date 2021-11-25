using System;
using System.Collections.Generic;
using System.IO;

namespace FirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            string heroName = GetHeroName();

            Hero hero = new Hero(heroName);
            hero.DisplayObject();

            Console.WriteLine();
            Console.WriteLine("press a key to continue..");
            Console.ReadKey();

            BeginFights(hero);
        }

        private static void BeginFights(Hero hero)
        {
            do
            {
                Console.Clear();

                BaseFighter enemy = FindEnemyForTheRound(hero.Level);

                Console.WriteLine("Your enemy for the next fight is:");
                enemy.DisplayObject();

                Console.WriteLine();
                Console.WriteLine("Your hero is:");
                hero.DisplayObject();

                Booster booster = null;
                Console.WriteLine("Press 'b' to add booster or any other key for the fight to start!");
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.KeyChar == 'b' || key.KeyChar == 'B')
                {
                    booster = SelectBooster(hero);
                }

                hero.Fight(enemy, booster);
                
                if (hero.IsAlive)
                {
                    Console.WriteLine("You Won!! Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (hero.IsAlive);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YOU IS DEAD!!! XAXXAXAXAXAXA");
            Console.ReadKey();

            Cockroach cocki = new Cockroach();
            cocki.DisplayObject();
        }

        private static Booster SelectBooster(Hero hero)
        {
            Booster result = null;
            Console.Clear();

            if (hero.AvailableBoosters.Count < 1)
            {
                Console.WriteLine("It's empty in here!");
                Console.WriteLine("Press any key to proceed to the fight.");
                Console.ReadKey();
            }
            else
            {
                foreach (Booster booster in hero.AvailableBoosters)
                {
                    booster.DisplayObject();
                }

                Console.WriteLine($"Enter number for the booster to user from 1 to {hero.AvailableBoosters.Count}, accprding to the line");
                int boosterNumber = int.Parse(Console.ReadLine());

                if (boosterNumber >= 1 && boosterNumber <= hero.AvailableBoosters.Count)
                {
                    result = hero.AvailableBoosters[boosterNumber - 1];
                }
                else
                {
                    Console.WriteLine("You did it wronh!! No booster for you this round!! Press any key to fight");
                    Console.ReadKey();
                }
            }

            return result;
        }

        private static BaseFighter FindEnemyForTheRound(int level)
        {
            BaseFighter result;

            Random random = new Random();

            if (level < 3)
            {
                result = new Cockroach();
            }
            else if (level < 10)
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        result = new Cockroach();
                        break;
                    case 2:
                        result = new Spider();
                        break;
                    case 3:
                        result = new Aligator();
                        break;
                    default:
                        result = new Cockroach();
                        break;
                }
            }
            else
            {
                switch (random.Next(1, 2))
                {
                    case 1:
                        result = new RedMagician();
                        break;
                    case 2:
                        result = new BlueMagician();
                        break;
                    default:
                        result = new RedMagician();
                        break;
                }
            }    

            return result;
        }

        private static string GetHeroName()
        {
            Console.WriteLine("Wellcome to our hero game!!");
            Console.WriteLine("Please give your hero a name:");

            string heroName = string.Empty;

            do
            {
                heroName = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(heroName));

            Console.Clear();
            Console.WriteLine("Excellent, you have a hero now!!");
            return heroName;
        }
    }
}
