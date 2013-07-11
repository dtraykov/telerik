using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerUnitTest
{
    [TestClass]
    public class PokerHandsIsFlushTest
    {
        [TestMethod]
        public void IsFlushWithHearts()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Seven,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Ten,CardSuit.Hearts),
                 });
            bool isFlush = checker.IsFlush(hand);
            Assert.IsTrue(isFlush);
        }

        [TestMethod]
        public void IsFlushWithDifferentSuits()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Seven,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Ten,CardSuit.Hearts),
                 });
            bool isFlush = checker.IsFlush(hand);
            Assert.IsFalse(isFlush);
        }
    }
}
