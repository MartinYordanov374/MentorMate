using System;

namespace FakeZodiac
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] interpretations =new string[]{
            "you are a bold person.", "you are a somewhat shy person.", "you are a natural leader.", 
            "you have got quite the sense of humor!", "you are quite the life of the party.", "you enjoy life to the fullest.", 
            "you really can appreciate art in all of its forms.", "you are attracted toward technology.", "you talk about politics a bit too much and that's okay."};

            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your second name: ");
            string secondName = Console.ReadLine();

            Console.WriteLine("Enter your third name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your birth year: ");
            int yearOfBirth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your month of birth: ");
            int monthOfBirth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your day of birth: ");
            int dayOfBirth = int.Parse(Console.ReadLine());

            int sumOfAllNameCharacters = firstName.Length+secondName.Length+lastName.Length;
            int condensed = condenseNumber(sumOfAllNameCharacters);

            Console.WriteLine($"Your complete name length is {sumOfAllNameCharacters} which is the condensed number of {condensed}. It means that ");
            
            switch(condensed)
            {
                case 1:
                {
                    Console.Write(interpretations[0]+"\n");
                    break;
                }
                case 2:
                {
                    Console.Write(interpretations[1]+"\n");
                    break;
                }
                case 3:
                {
                    Console.Write(interpretations[2]+"\n");
                    break;
                }
                case 4:
                {     
                    Console.Write(interpretations[3]+"\n");
                    break;
                }
                case 5:
                {
                    Console.Write(interpretations[4]+"\n");
                    break;
                }
                case 6:
                {
                    Console.Write(interpretations[5]+"\n");
                    break;
                }
                case 7:
                {
                    Console.Write(interpretations[6]+"\n");
                    break;
                }
                case 8:
                {
                    Console.Write(interpretations[7]+"\n");
                    break;
                }
                case 9:
                {
                    Console.Write(interpretations[8]+"\n");
                    break;
                }
            }

            int dateSum = yearOfBirth+monthOfBirth+dayOfBirth;

            int lastNumberOfDateSum = dateSum % 10; 
            
            Console.WriteLine($"Your day of birth sum is {dateSum}. It means that {interpretations[lastNumberOfDateSum]}");
        }
        static int condenseNumber(int number)
        {

            if(number < 10)
            {
                return number;
            }

            return condenseNumber(number / 10) + number % 10;
        }
    }
}
