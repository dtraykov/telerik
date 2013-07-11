using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerUnitTest
{
    [TestClass]
    public class CardToStringTest
    {
        [TestMethod]
        public void ToStringAceOfHearts()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Hearts);
            string actual = card.ToString();
            string expected = "A♥";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringTwoOfSpades()
        {
            Card card = new Card(CardFace.Two, CardSuit.Spades);
            string actual = card.ToString();
            string expected = "2♣";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringQueenOfClubs()
        {
            Card card = new Card(CardFace.Queen, CardSuit.Clubs);
            string actual = card.ToString();
            string expected = "Q♠";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringTenOfDiamonds()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Diamonds);
            string actual = card.ToString();
            string expected = "10♦";
            Assert.AreEqual(expected, actual);
        }
    }
}
