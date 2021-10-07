using System;
 
namespace Faces_And_Suits
{
    class Program
    {
        static void Main(string[] args)
        {
            // show all possible cards from a deck without jocker
            string[] faces = new string[]{"2","3","4","5","6","7","8","9","10", "J", "Q", "K", "A"};
            string[] suits = new string[]{"Heart", "Spade", "Diamond", "Club"};
 
            for(int facesCounter = 0; facesCounter<faces.Length; facesCounter++)
            {
                for(int suitsCounter = 0; suitsCounter<suits.Length; suitsCounter++)
                {
                    System.Console.WriteLine($"{faces[facesCounter]} {suits[suitsCounter]}");
                }
            }
        }
    }
}