using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards.OrderBy(x => x.Face).ToList();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (ICard card in this.Cards)
            {
                sb.AppendFormat("{0} ", card.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
