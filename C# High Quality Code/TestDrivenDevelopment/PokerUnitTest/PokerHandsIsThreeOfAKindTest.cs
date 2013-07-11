using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerUnitTest
{
    [TestClass]
    public class PokerHandsIsThreeOfAKindTest
    {
        [TestMethod]
        public void IsThreeOfAKindTen()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Ten,CardSuit.Clubs),
                 });
            bool isThreeOfAKind = checker.IsThreeOfAKind(hand);
            Assert.IsTrue(isThreeOfAKind);
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
            bool isThreeOfAKind = checker.IsThreeOfAKind(hand);
            Assert.IsFalse(isThreeOfAKind);
        }
    }
}
