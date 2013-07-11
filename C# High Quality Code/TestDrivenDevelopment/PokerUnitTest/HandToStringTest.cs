using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerUnitTest
{
    [TestClass]
    public class HandToStringTest
    {
        [TestMethod]
        public void ToStringWithNoCards()
        {
            Hand hand = new Hand(new List<ICard>());
            string actual = hand.ToString();
            string expected = string.Empty;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringWithOneCardTenOfSpades()
        {
            Hand hand = new Hand(new List<ICard>() { new Card(CardFace.Ten, CardSuit.Spades) });
            string actual = hand.ToString();
            string expected = "10♣";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringWithFiveCards()
        {
            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Seven,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Queen,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Diamonds),

            });
            string actual = hand.ToString();
            string expected = "2♠ 7♥ 10♦ Q♣ A♦";
            Assert.AreEqual(expected, actual);
        }
    }
}
