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

            int sumOfAllNameCharacters = firstName.Length + secondName.Length + lastName.Length;
            int condensed = CondenseNumber(sumOfAllNameCharacters);

            int lastDigitOfTotalNameSum = sumOfAllNameCharacters % 10;
            int firstDigitOfTotalNameSum = sumOfAllNameCharacters / 10;
            System.Console.WriteLine(firstDigitOfTotalNameSum);
            Console.WriteLine($"Your complete name length is {sumOfAllNameCharacters}. {firstDigitOfTotalNameSum} + {lastDigitOfTotalNameSum} gives us the number of {condensed}. It means that {interpretations[lastDigitOfTotalNameSum-1]}");

            int dateSum = yearOfBirth+monthOfBirth+dayOfBirth;

            int lastNumberOfDateSum = dateSum % 10; 
            
            Console.WriteLine($"Your day of birth sum is {dateSum}. It means that {interpretations[lastNumberOfDateSum-1]}");
        }
        static int CondenseNumber(int number)
        {

            if(number >= 1 && number <= 9)
            {
                return number;
            }

            return CondenseNumber(number / 10) + number % 10;
        }
    }
}
