﻿using System;
using System.Linq;
using System.Collections.Generic;
namespace AssignDecks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cardDeck = new List<string>();

            cardDeck = CreateDeck();
            
            string[] shuffledDeck = ShuffleDeck(cardDeck);
            
            string[] randomThirteenCards = GetRandomThirteenCards(shuffledDeck);
            cardDeck = RemoveCardsFromInitialDeck(cardDeck,randomThirteenCards);
            string[] firstPlayerDeck = shuffledDeck.Take(13).ToArray();
            string[] secondPlayerDeck = shuffledDeck.Skip(13).Take(13).ToArray();
            string[] thirdPlayerDeck = shuffledDeck.Skip(26).Take(13).ToArray();
            string[] fourthPlayerDeck = shuffledDeck.Skip(39).Take(13).ToArray();

            ShowPlayerDecks(firstPlayerDeck, secondPlayerDeck, thirdPlayerDeck, fourthPlayerDeck);
            
        }
        // this is just in case I want something to be changed, like a deck with extra cards and such
        static List<string> CreateDeck()
        {
            List<string> allCardsArray = new List<string>();
            string[] faces = new string[]{"2","3","4","5","6","7","8", "9", "10", "J", "Q", "K", "A"};
            string[] suits = new string[]{"Spade","Heart","Club","Diamond"};
 
            for(int facesCounter = 0; facesCounter<faces.Length; facesCounter++)
            {
                for(int suitsCounter = 0; suitsCounter<suits.Length; suitsCounter++)
                {
                    string finalCard = $"{faces[facesCounter]}" + $" {suits[suitsCounter]}";
                    allCardsArray.Add(finalCard);
                }
            }

            return allCardsArray;
        }
        static string[] ShuffleDeck(List<string> initialDeck)
        {
            Random random = new Random();
            string[] unshuffledArray = initialDeck.OrderBy( c => random.Next()).ToArray();

            return unshuffledArray;
        }
        static string[] GetRandomThirteenCards(string[] shuffledDeck)
        {
            string[] randomCards = shuffledDeck.Take(13).ToArray();
            return randomCards;
        }

        static List<string> RemoveCardsFromInitialDeck(List<string> initialDeck, string[] thirteenCards)
        {
            for(int i = 0; i < 13; i++)
            {
                // get index of the random cards, remove them from the list
                int index = initialDeck.IndexOf(thirteenCards[i]);
                initialDeck.RemoveAt(index);
            }
            return initialDeck;
        }

        static void ShowPlayerDecks(string[] firstPlayerDeck, string[] secondPlayerDeck, string[] thirdPlayerDeck, string[] fourthPlayerDeck)
        {
            Console.WriteLine("----- FIRST PLAYER DECK -----");
            foreach (string card in firstPlayerDeck)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine("----- SECOND PLAYER DECK -----");
            foreach (string card in secondPlayerDeck)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine("----- THIRD PLAYER DECK -----");
            foreach (string card in thirdPlayerDeck)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine("----- FOURTH PLAYER DECK -----");
            foreach (string card in fourthPlayerDeck)
            {
                Console.WriteLine(card);
            }
        }

    }
}