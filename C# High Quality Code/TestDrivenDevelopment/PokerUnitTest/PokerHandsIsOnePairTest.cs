using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerUnitTest
{
    [TestClass]
    public class PokerHandsIsOnePairTest
    {
        [TestMethod]
        public void IsOnePairTestTwo()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Spades),
                new Card(CardFace.Eight,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Clubs),
                 });
            bool isOnePair = checker.IsOnePair(hand);
            Assert.IsTrue(isOnePair);
        }

        [TestMethod]
        public void IsOnePairTest2JackAnd2Quuen()
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
            bool isOnePair = checker.IsOnePair(hand);
            Assert.IsFalse(isOnePair);
        }

        [TestMethod]
        public void IsOnePairTest2SixAnd3Ten()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Diamonds),
                new Card(CardFace.Ten,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Clubs),
                 });
            bool isOnePair = checker.IsOnePair(hand);
            Assert.IsFalse(isOnePair);
        }

        [TestMethod]
        public void IsOnePairTestAllDifferent()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Jack,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Clubs),
                 });
            bool isOnePair = checker.IsOnePair(hand);
            Assert.IsFalse(isOnePair);
        }
    }
}
