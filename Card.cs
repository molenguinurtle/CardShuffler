using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler
{
    class Card
    {
        protected Suits Suit;
        protected Ranks Rank;

        public Card(Suits suit, Ranks rank)
        {
            Suit = suit;
            Rank = rank;
        }

        /**
         * Print out the card in format: Rank of Suit
         * Ex: Ace of Spades, Three of Diamonds, Jack of Hearts, etc etc.
         */
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
