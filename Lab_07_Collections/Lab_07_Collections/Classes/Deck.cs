using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab_07_Collections.Classes
{
    /// <summary>
    /// interface for holding a deck of card objects
    /// </summary>
    /// <typeparam name="T">generic type</typeparam>
    public class Deck<T> : IEnumerable
    {
        T[] deck = new T[15];

        int count;

        /// <summary>
        /// adds a card to the deck
        /// </summary>
        /// <param name="card">the card to add to the deck</param>
        /// <returns>true if successfully added card, else false</returns>
        public bool Add(T card)
        {
            bool isInDeck = false;
            try
            {
                for (int i = 0; i < deck.Length; i++)
                {
                    if (card.Equals(deck[i]))
                    {
                        Console.WriteLine("That card already exists!");
                        isInDeck = true;
                        return false;
                    }
                }

                if (isInDeck == false)
                {
                    if (count == deck.Length)
                    {
                        Array.Resize(ref deck, deck.Length * 3 / 2);
                    }
                    deck[count++] = card;
                    return true;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return false;
            }
            return false;
        }

        /// <summary>
        /// removes a card from the deck
        /// </summary>
        /// <param name="card">the card to remove</param>
        /// <returns>returns true if successfully removed, else false</returns>
        public bool Remove(T card)
        {
            try
            {
                for (int i = 0; i < deck.Length; i++)
                {
                    if (card.Equals(deck[i]))
                    {
                        deck[i] = default(T);
                        if (count == deck.Length / 2)
                        {
                            Array.Resize(ref deck, deck.Length * 2 / 3);
                            Console.WriteLine("Shrinking array");
                        }
                        count--;
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return false;
            }
            return false;
        }

        /// <summary>
        /// some voodoo that we need to do to associate the cards with numbers
        /// </summary>
        /// <returns>a bunch of card objects</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return deck[i];
            }
        }

        /// <summary>
        /// shuffles the deck
        /// </summary>
        /// <returns>true if successfully shuffled, else false</returns>
        public bool Shuffle()
        {
            try
            {
                int cardsToShuffle = deck.Length;
                Random rnd1 = new Random();
                while (cardsToShuffle > 1)
                {
                    cardsToShuffle--;
                    int newDeckIndex = rnd1.Next(cardsToShuffle + 1);
                    T value = deck[newDeckIndex];
                    deck[newDeckIndex] = deck[cardsToShuffle];
                    deck[cardsToShuffle] = value;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: failed to shuffle.");
                Console.WriteLine(e.Message);
                return false;
            }

        }

        /// <summary>
        /// Magic - no touching!
        /// </summary>
        /// <returns>GetEnumerator method</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
