using _45.Model;
using System.Collections.Generic;

namespace _45.Inerfaces
{
    interface ICardPrecedence
    {
        Dictionary<int, Card> Precedence { get; set; }

        int GetCardPrecedence(Card card);
    }
}
