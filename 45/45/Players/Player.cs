using _45.Inerfaces;
using _45.Model;
using System;
using System.Linq;

namespace _45.Players
{
    class Player : IPlayer
    {
        public Player(int handSize)
        {
            Cards = new HandCard[handSize];
        }

        public HandCard[] Cards { get; set; }

        public void TakeCard(Card card)
        {
            // If the hand is full
            if (!Cards.Any(c => c == null))
                throw new InvalidOperationException("The Hand is already full. No more cards can be taken.");

            int index = Array.IndexOf(Cards, null);

            Cards[index] = new HandCard(card);
        }

        public int GetNumberOfCardsInHand()
        {
            return Cards.Where(c => c != null).Count();
        }

        public void PlayCard(HandCard card)
        {
            Cards.Where(c => c.Card.Equals(card)).FirstOrDefault().ToBePlayedOrDiscarded = true;
        }

        public Card[] CardToBePlayedIsSelected()
        {
            return Cards.Where(c => c.ToBePlayedOrDiscarded == true).Select(c => c.Card).ToArray();
        }
    }
}
