using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerUnitTest
{
    [TestClass]
    public class PokerHandsIsFourOfAKindTest
    {
        [TestMethod]
        public void IsFourOfAKindFive()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Diamonds),
                new Card(CardFace.Five,CardSuit.Spades),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Clubs),
                 });
            bool isFourOfAKind = checker.IsFourOfAKind(hand);
            Assert.IsTrue(isFourOfAKind);
        }

        [TestMethod]
        public void IsFourOfAKindAce()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Spades),
                 });
            bool isFourOfAKind = checker.IsFourOfAKind(hand);
            Assert.IsFalse(isFourOfAKind);
        }
    }
}
