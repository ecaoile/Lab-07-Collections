using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_07_Collections.Classes
{
    public class Value
    {
        public ValNum CardNum { get; set; }
    }

    /// <summary>
    /// associates card value with a number
    /// </summary>
    public enum ValNum
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
}
