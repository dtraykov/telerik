using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerUnitTest
{
    [TestClass]
    public class PokerHandsIsTwoPairTest
    {
        [TestMethod]
        public void IsTwoPairTenAndTwo()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Clubs),
                 });
            bool isTwoPair = checker.IsTwoPair(hand);
            Assert.IsTrue(isTwoPair);
        }

        [TestMethod]
        public void IsTwoPairQeenAndJack()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Clubs),
                 });
            bool isTwoPair = checker.IsTwoPair(hand);
            Assert.IsTrue(isTwoPair);
        }

        [TestMethod]
        public void IsTwoPairSixAndTen()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Diamonds),
                new Card(CardFace.Ten,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Clubs),
                 });
            bool isTwoPair = checker.IsTwoPair(hand);
            Assert.IsTrue(isTwoPair);
        }

        [TestMethod]
        public void IsThreeOfAKindAce()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Spades),
                 });
            bool isTwoPair = checker.IsTwoPair(hand);
            Assert.IsFalse(isTwoPair);
        }
    }
}
