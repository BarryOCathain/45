using _45.Inerfaces;
using _45.Model;
using System;
using System.Collections.Generic;

namespace _45.Players
{
    class Deck : IDeck
    {
        #region Private Members
        private Stack<Card> _cards;
        #endregion

        #region Constructors
        // Creates an empty Deck with a Stack to deal the cards from.
        public Deck()
        {
            _cards = new Stack<Card>();
        } 
        #endregion

        #region Public Methods
        public Card DealCard()
        {
            if (_cards.Count == 0)
                throw new InvalidOperationException("There are no cards left in the deck");

            return _cards.Pop();
        }

        public Card[] GetCards()
        {
            List<Card> cards = new List<Card>();

            foreach (Enums.Suit suit in Enum.GetValues(typeof(Enums.Suit)))
            {
                foreach (Enums.CardValue value in Enum.GetValues(typeof(Enums.CardValue)))
                    cards.Add(new Card(suit, value));
            }
            return cards.ToArray();
        }

        //Takes the argument Card[] shuffles it, and loads it to the internal Stack.
        public void LoadDeck(Card[] cards)
        {
            foreach (var card in Shuffle(cards))
                _cards.Push(card);
        } 
        #endregion

        #region Helper Methods
        private Card[] Shuffle(Card[] cards)
        {
            if (null == cards || cards.Length == 0)
                throw new ArgumentException("The array of cards cannot be null or empty.");

            Random r = new Random();

            for (int i = cards.Length - 1; i > 0; i--)
            {
                int k = r.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[k];
                cards[k] = temp;
            }
            return cards;
        } 
        #endregion
    }
}
