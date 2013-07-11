using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {

            bool haveDuplicates = false;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face &&
                       hand.Cards[i].Suit == hand.Cards[j].Suit)
                    {
                        haveDuplicates = true;
                    }
                }
            }

            bool haveFiveCards = hand.Cards.Count == 5;

            bool isValid = !haveDuplicates && haveFiveCards;
            return isValid;
        }

        public bool IsStraightFlush(IHand hand)
        {
            bool isStraightFlush = IsStraight(hand) && IsFlush(hand);

            return isStraightFlush;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            int pair;
            int maxCount = SameCardsOfAKind(hand, out pair);
            if (maxCount == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //private int SameCardsOfAKind(IHand hand)
        //{
        //    int counter = 1;
        //    int maxCount = 1;
        //    for (int i = 0; i < hand.Cards.Count - 1; i++)
        //    {
        //        for (int j = i + 1; j < hand.Cards.Count; j++)
        //        {
        //            if (hand.Cards[i].Face == hand.Cards[j].Face)
        //            {
        //                counter++;
        //            }
        //            else
        //            {
        //                counter = 1;
        //            }

        //            if (maxCount < counter)
        //            {
        //                maxCount = counter;
        //            }
        //        }

        //        counter = 1;
        //    }

        //    return maxCount;
        //}

        private int SameCardsOfAKind(IHand hand, out int pair)
        {
            int counter = 1;
            int maxCount = 1;
            pair = 0;
            bool isNewPair = true;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Face == hand.Cards[i + 1].Face)
                {
                    counter++;
                    if (counter > 1)
                    {
                        if (isNewPair)
                        {
                            pair++;
                            isNewPair = false;
                        }
                    }
                }
                else
                {
                    counter = 1;
                    isNewPair = true;
                }

                if (maxCount < counter)
                {
                    maxCount = counter;
                }
            }

            return maxCount;
        }

        public bool IsFullHouse(IHand hand)
        {
            int pair;
            int maxCount = SameCardsOfAKind(hand, out pair);
            if (maxCount == 3 && pair == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFlush(IHand hand)
        {
            bool isFlush = true;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Suit != hand.Cards[j].Suit)
                    {
                        isFlush = false;
                        return isFlush;
                    }
                }
            }

            return isFlush;
        }

        public bool IsStraight(IHand hand)
        {
            if ((hand.Cards[4].Face - hand.Cards[0].Face) == 4)
            {
                return true;
            }

            if (hand.Cards[4].Face == CardFace.Ace &&
                hand.Cards[3].Face == CardFace.Five)
            {
                // a wheel: A, 2, 3, 4, 5
                return true;
            }

            return false;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            int pair;
            int maxCount = SameCardsOfAKind(hand, out pair);
            if (maxCount == 3 && pair == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsTwoPair(IHand hand)
        {
            int pair;
            int maxCount = SameCardsOfAKind(hand, out pair);
            if (maxCount == 2 && pair == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsOnePair(IHand hand)
        {
            int pair;
            int maxCount = SameCardsOfAKind(hand, out pair);
            if (maxCount == 2 && pair == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsHighCard(IHand hand)
        {
            if (IsValidHand(hand) && 
                !IsOnePair(hand) && 
                !IsTwoPair(hand) &&
                !IsThreeOfAKind(hand) && 
                !IsStraight(hand) && 
                !IsFlush(hand) &&
                !IsFourOfAKind(hand) && 
                !IsStraightFlush(hand) && 
                !IsFullHouse(hand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            int straightFlush = 9;
            int fourOfKind = 8;
            int fullHouse = 7;
            int flush = 6;
            int straight = 5;
            int threeOfAKind = 4;
            int twoPair = 3;
            int onePair = 1;
            int highCard = 0;

            return 0;
        }
    }
}
