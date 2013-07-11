using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerUnitTest
{
    [TestClass]
    public class PokerHandsIsStraightTest
    {
        [TestMethod]
        public void IsStraightTwoToSix()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Diamonds),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts),
                 });
            bool isStraight = checker.IsStraight(hand);
            Assert.IsTrue(isStraight);
        }

        [TestMethod]
        public void IsStraightNineToKing()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Jack,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Diamonds),
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Nine,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Hearts),
                 });
            bool isStraight = checker.IsStraight(hand);
            Assert.IsTrue(isStraight);
        }

        [TestMethod]
        public void IsStraightAceToFive()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Diamonds),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Hearts),
                 });
            bool isStraight = checker.IsStraight(hand);
            Assert.IsTrue(isStraight);
        }

        [TestMethod]
        public void IsStraightTenToAce()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                  new Card(CardFace.Jack,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Diamonds),
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Hearts),
                 });
            bool isStraight = checker.IsStraight(hand);
            Assert.IsTrue(isStraight);
        }
    }
}
