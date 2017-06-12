using _45.Inerfaces;
using _45.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.Model
{
    class PlayerRound : IPlayerRound
    {
        public PlayerRound(IPlayer player, Card card)
        {
            Player = player;
            Card = card;
        }

        public IPlayer Player { get; set; }

        public Card Card { get; set; }

        public bool IsRoundWinner { get; set; } = false;
    }
}
