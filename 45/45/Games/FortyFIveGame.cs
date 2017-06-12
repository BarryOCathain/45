using _45.Inerfaces;
using _45.Model;
using _45.Players;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _45.Games
{
    class FortyFiveGame : IGame
    {
        // There must be at least one IDealPattern, the last one in the array will be used for the remaining rounds in the game.
        //
        // Example : 
        // var game = new FortyFiveGame(playerArray, new ThreesAndTwos(), new Singles());
        //
        // In the example above, the first deal will use the ThreesAndTwos() pattern,
        // and all subsequent rounds will be dealt using the Singles() pattern.
        public FortyFiveGame(IPlayer[] players, params IDealPattern[] dealPatterns)
        {
            if (null == players || players.Length == 0)
                throw new ArgumentException("Players cannot be null or empty.");

            if (!players.Any(p => p.GetType() == typeof(Player)))
                throw new ArgumentException("There must be at least one non-AI player.");

            if (null == dealPatterns || dealPatterns.Length < 1)
                throw new ArgumentException("There must be at least one deal pattern");

            Players = players;
            DealPatterns = dealPatterns;
        }

        public IPlayer[] Players { get; set; }

        public IDealPattern[] DealPatterns { get; set; }

        public Dictionary<int, IPlayer> HandsWon { get; set; }

        public void DealCards()
        {

        }

        public void GetPlayedCards()
        {

        }

        public IPlayer CalculateHandWinner()
        {
            
        }

        public Dictionary<int, Card[]> SetCardPrecedence(Card playedCard)
        {
            throw new NotImplementedException("");
        }

        private Dictionary<int, Card[]> GetRedPrecedence()
        {

        }

        private Dictionary<int, Card[]> GetBlackPrecedence()
        {

        }
    }
}
