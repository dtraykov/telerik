using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerUnitTest
{
    [TestClass]
    public class PokerHandsIsStraightFlushTest
    {
        [TestMethod]
        public void IsStraightFlushAceToFiveHearts()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Hearts),
                 });
            bool isStraight = checker.IsStraight(hand);
            Assert.IsTrue(isStraight);
        }

        [TestMethod]
        public void IsStraightFlushAceToFiveDifferentSuits()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Seven,CardSuit.Diamonds),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Eight,CardSuit.Clubs),
                new Card(CardFace.Ten,CardSuit.Spades),
                new Card(CardFace.Nine,CardSuit.Diamonds),
                 });
            bool isStraight = checker.IsStraight(hand);
            Assert.IsTrue(isStraight);
        }
    }
}
