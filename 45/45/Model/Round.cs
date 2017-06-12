using _45.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.Model
{
    class Round : IRound
    {
        public Round(int roundNumber, ICardPrecedence precedence, params IPlayerRound[] playerRounds)
        {
            RoundNumber = roundNumber;
            Precedence = precedence;
            PlayerRounds = playerRounds;
        }

        public int RoundNumber { get; set; }
        public ICardPrecedence Precedence { get; set; }
        public IPlayerRound[] PlayerRounds { get; set; }

        public IPlayer GetRoundWinner()
        {
            if (!PlayerRounds.Any(p => p.IsRoundWinner == true))
                CalculateWinner();

            return PlayerRounds.Where(p => p.IsRoundWinner).FirstOrDefault().Player;
        }

        private void CalculateWinner()
        {
            Dictionary<int, IPlayerRound> order = new Dictionary<int, IPlayerRound>();

            foreach (var playerRound in PlayerRounds)
                order.Add(CalculatePrecedence(playerRound.Card), playerRound);

            order[order.Keys.Min()].IsRoundWinner = true;
        }

        private int CalculatePrecedence(Card card)
        {
            throw new NotImplementedException();
        }
    }
}
