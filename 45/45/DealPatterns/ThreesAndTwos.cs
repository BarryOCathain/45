using _45.Inerfaces;
using System;

namespace _45.DealPatterns
{
    class ThreesAndTwos : IDealPattern
    {
        public void Deal(IPlayer[] players, IDeck deck)
        {
            for (int i = 0; i < 2; i++)
            {
                DealRound(players, deck, i == 0 ? false : true); 
            }
        }

        private void DealRound(IPlayer[] players, IDeck deck, bool invertOrder)
        {
            for (int i = 0; i < players.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (players[i].GetNumberOfCardsInHand() != 0)
                        players[i].TakeCard(deck.DealCard());
                }

                if (players[i].GetNumberOfCardsInHand() != 0)
                {
                    if (invertOrder)
                    {
                        if (i % 2 != 0)
                            players[i].TakeCard(deck.DealCard());
                    }
                    else
                    {
                        if (i % 2 == 0)
                            players[i].TakeCard(deck.DealCard());
                    } 
                }
            }
        }
    }
}
