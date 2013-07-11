using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerUnitTest
{
    [TestClass]
    public class PokerHandsIsHighCardTest
    {
        [TestMethod]
        public void IsHighCardTestSeven()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Three,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Seven,CardSuit.Clubs),
                 });
            bool isHighCard = checker.IsHighCard(hand);
            Assert.IsTrue(isHighCard);
        }

        [TestMethod]
        public void IsHighCardTestQueen()
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
            bool isHighCard = checker.IsHighCard(hand);
            Assert.IsFalse(isHighCard);
        }

        [TestMethod]
        public void IsHighCardTestTen()
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
            bool isHighCard = checker.IsHighCard(hand);
            Assert.IsFalse(isHighCard);
        }
    }
}
