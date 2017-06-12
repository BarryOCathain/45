using _45.Interfaces;
using System;
using System.Linq;

namespace _45.Model
{
    class Player
    {
        private HandCard[] _cards;

        public Player(int handSize)
        {
            _cards = new HandCard[handSize];
        }

        public void TakeCard(Card card)
        {
            // If the hand is full
            if (!_cards.Any(c => c == null))
                throw new InvalidOperationException("The Hand is already full. No more cards can be taken.");

            int index = Array.IndexOf(_cards, null);

            _cards[index] = new HandCard(card);
        }

        public void PlayCard(HandCard card)
        {
            _cards.Where(c => c.Card.Equals(card)).FirstOrDefault().ToBePlayedOrDiscarded = true;
        }

        public ICard[] CardToBePlayedIsSelected()
        {
            return _cards.Where(c => c.ToBePlayedOrDiscarded == true).Select(c => c.Card).Cast<ICard>().ToArray();
        }
    }
}
