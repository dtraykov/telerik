using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerUnitTest
{
    [TestClass]
    public class PokerHandsIsFullHouseTest
    {
        [TestMethod]
        public void IsFullHouseTest3TenAnd2Two()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Clubs),
                 });
            bool isFullHouse = checker.IsFullHouse(hand);
            Assert.IsTrue(isFullHouse);
        }

        [TestMethod]
        public void IsFullHouseTest2QeenAnd2Jack()
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
            bool isFullHouse = checker.IsFullHouse(hand);
            Assert.IsFalse(isFullHouse);
        }

        [TestMethod]
        public void IsFullHouseTestSix()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Diamonds),
                new Card(CardFace.Ten,CardSuit.Spades),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Clubs),
                 });
            bool isFullHouse = checker.IsFullHouse(hand);
            Assert.IsFalse(isFullHouse);
        }

        [TestMethod]
        public void IsFullHouseTestAllDifferent()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Spades),
                 });
            bool isFullHouse = checker.IsFullHouse(hand);
            Assert.IsFalse(isFullHouse);
        }
    }
}
