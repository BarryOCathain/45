using _45.Model;

namespace _45.Inerfaces
{
    interface IPlayerRound
    {
        IPlayer Player { get; set; }

        Card Card { get; set; }

        bool IsRoundWinner { get; set; }
    }
}
