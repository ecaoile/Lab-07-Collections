using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_07_Collections.Classes
{
    public class Card
    {
        public SuitNum Suit { get; set; }
        public ValNum Value { get; set; }

        /// <summary>
        /// constructor method for the object of card class
        /// </summary>
        /// <param name="suit">the suit of card</param>
        /// <param name="value">number of card</param>
        public Card(SuitNum suit, ValNum value)
        {
            Suit = suit;
            Value = value;
        }
    }
}
