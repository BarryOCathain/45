using _45.Inerfaces;

namespace _45.DealPatterns
{
    class Singles : IDealPattern
    {
        public void Deal(IPlayer[] players, IDeck deck)
        {
            int rounds = players[0].Cards.Length;
            for (int i = 0; i < rounds; i++)
            {
                foreach (var player in players)
                {
                    if (player.GetNumberOfCardsInHand() != 0)
                        player.TakeCard(deck.DealCard());
                }
            }
        }
    }
}
