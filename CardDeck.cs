using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler
{
    class CardDeck
    {
        protected string Name;
        protected List<Card> Cards;

        public CardDeck(string deckName)
        {
            Name = deckName;
        }

        /**
        * Shuffle the deck of cards.
        */
        public void Shuffle(/**/)
        {
            //
        }

        /**
        * Insert a card into the deck.
        */
        public void Insert(/**/)
        {
            //
        }

        /*
        * Return the CardDeck in order: loweset to highest
        * A, 2, 3, 4, 5, 6, 7, 8, 9, J, Q, K
        */
        public List<Card> InOrder()
        {
            return Cards;
        }

        /*
        * Return the CardDeck in order: highest to loweset
        * K, Q, J, 9, 8, 7, 6, 5, 4, 3, 2, A
        */
        public List<Card> ReverseOrder()
        {
            return Cards;
        }

        /**
        * Dealing from the top:
        * Return a card from the deck. 
        */
        public Card DealCardFromTop()
        {
            //
        }

        /**
        * Dealing from the bottom:
        * Return a card from the deck. 
        */
        public Card DealCardFromBottom()
        {
            //
        }

        /**
        * Deal from the middle:
        * Return a card from the deck.
        */
        public Card DealCardFromMiddle()
        {
            //
        }
    }
}
