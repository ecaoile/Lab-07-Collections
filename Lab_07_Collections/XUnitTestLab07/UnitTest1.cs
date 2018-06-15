using System;
using Xunit;
using Lab_07_Collections;
using Lab_07_Collections.Classes;
using static Lab_07_Collections.Program;

namespace XUnitTestLab07
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddCard()
        {
            Card card1 = new Card((SuitNum)4, (ValNum)1);
            Card card2 = new Card((SuitNum)1, (ValNum)2);
            Card card3 = new Card((SuitNum)3, (ValNum)3);

            Deck<Card> testDeck = new Deck<Card> { card1, card2, card3 };
            Card card4 = new Card((SuitNum)2, (ValNum)4);
            Card card5 = new Card((SuitNum)4, (ValNum)5);
            Card card6 = new Card((SuitNum)1, (ValNum)6);

            Assert.True(testDeck.Add(card4));
            Assert.True(testDeck.Add(card5));
            Assert.False(testDeck.Add(card1));
            Assert.False(testDeck.Add(card4));
        }

        [Fact]
        public void CanRemoveCard()
        {
            Card card1 = new Card((SuitNum)4, (ValNum)1);
            Card card2 = new Card((SuitNum)1, (ValNum)2);
            Card card3 = new Card((SuitNum)3, (ValNum)3);

            Deck<Card> testDeck = new Deck<Card> { card1, card2, card3 };
            Card card4 = new Card((SuitNum)2, (ValNum)4);
            Card card5 = new Card((SuitNum)4, (ValNum)5);
            Card card6 = new Card((SuitNum)1, (ValNum)6);

            Assert.True(testDeck.Remove(card1));
            Assert.True(testDeck.Remove(card2));
            Assert.False(testDeck.Remove(card4));
            Assert.False(testDeck.Remove(card1));
        }

        [Fact]
        public void CanVerifyProperties()
        {
            Card card1 = new Card((SuitNum)4, (ValNum)1);
            Card card6 = new Card((SuitNum)1, (ValNum)6);

            Assert.Equal("Spades", card1.Suit.ToString());
            Assert.Equal("Ace", card1.Value.ToString());
            Assert.Equal("Hearts", card6.Suit.ToString());
            Assert.Equal("Six", card6.Value.ToString());
        }

        [Fact]
        public void CanShuffle()
        {
            Card card1 = new Card((SuitNum)4, (ValNum)1);
            Card card2 = new Card((SuitNum)1, (ValNum)2);
            Card card3 = new Card((SuitNum)3, (ValNum)3);

            Deck<Card> testDeck = new Deck<Card> { card1, card2, card3 };

            Assert.True(testDeck.Shuffle());
        }
    }
}
