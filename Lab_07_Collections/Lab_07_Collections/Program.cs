using System;
using System.Collections;
using System.Collections.Generic;
using Lab_07_Collections.Classes;

namespace Lab_07_Collections
{
    public class Program
    {
        /// <summary>
        /// main method to show in the console shuffling of cards
        /// </summary>
        /// <param name="args">array of string args need for the program
        /// to run</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lab 07!");
            Card card1 = new Card((SuitNum)4, (ValNum)1);
            Card card2 = new Card((SuitNum)1, (ValNum)2);
            Card card3 = new Card((SuitNum)3, (ValNum)3);
            Card card4 = new Card((SuitNum)2, (ValNum)4);
            Card card5 = new Card((SuitNum)4, (ValNum)5);
            Card card6 = new Card((SuitNum)1, (ValNum)6);
            Card card7 = new Card((SuitNum)2, (ValNum)7);
            Card card8 = new Card((SuitNum)3, (ValNum)8);
            Card card9 = new Card((SuitNum)1, (ValNum)9);
            Card card10 = new Card((SuitNum)4, (ValNum)10);
            Card card11 = new Card((SuitNum)4, (ValNum)11);
            Card card12 = new Card((SuitNum)4, (ValNum)12);
            Card card13 = new Card((SuitNum)1, (ValNum)13);
            Card card14 = new Card((SuitNum)2, (ValNum)1);
            Card card15 = new Card((SuitNum)3, (ValNum)2);

            Deck<Card> myDeck = new Deck<Card> { card1, card2, card3,
                card4, card5, card6, card7, card8, card9, card10, card11,
            card12, card13, card14, card15};

            Deal(myDeck);

            Card card16 = new Card((SuitNum)4, (ValNum)3);
            Console.WriteLine($"\nLet's add a {card16.Value} of {card16.Suit}");
            myDeck.Add(card16);

            Console.WriteLine($"Next, let's remove the {card3.Value} of {card3.Suit}.");
            myDeck.Remove(card3);

            Console.WriteLine();
            Console.WriteLine("Here's what your deck looks like now:");
            Show(myDeck);

            Console.WriteLine("\nThank you for playing. Press any button to exit.");
            Console.ReadKey();
        }

        public static void Deal(Deck<Card> myDeck)
        {
            Console.WriteLine("\nHere's your deck of cards!");
            Show(myDeck);

            myDeck.Shuffle();
            Console.WriteLine("\nHere is your card order after the shuffle:");
            Show(myDeck);
        }

        public static void Show(Deck<Card> myDeck)
        {
            int count = 1;

            foreach (Card card in myDeck)
            {
                if (card != null)
                    Console.WriteLine($"Card #{count} is the {card.Value} of {card.Suit}.");
                count++;
            }
        }
    }
}
