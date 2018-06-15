using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_07_Collections.Classes
{
    public class Suit
    {
        public SuitNum CardSuit { get; set; }
    }

    /// <summary>
    /// associates card suit with a number
    /// </summary>
    public enum SuitNum
    {

        Hearts = 1,
        Diamonds,
        Clubs,
        Spades,
        None
    }
}
