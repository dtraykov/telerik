using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerUnitTest
{
    [TestClass]
    public class PokerHandsIsValidHandTest
    {
        [TestMethod]
        public void IsValidHandWithNullCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>());
            bool isValid = checker.IsValidHand(hand);
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsValidHandWithTwoCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Two,CardSuit.Clubs),

            });
            bool isValid = checker.IsValidHand(hand);
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsValidHandWithTenCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Seven,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Queen,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Ten,CardSuit.Diamonds),
            });
            bool isValid = checker.IsValidHand(hand);
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsValidHandWithFiveCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Seven,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Queen,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Diamonds),
                 });
            bool isValid = checker.IsValidHand(hand);
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsValidHandWithDuplicatesOneAndFive()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Seven,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Queen,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                 });
            bool isValid = checker.IsValidHand(hand);
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsValidHandWithDuplicatesFourAndFive()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Seven,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Queen,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                 });
            bool isValid = checker.IsValidHand(hand);
            Assert.IsFalse(isValid);
        }
    }
}
