using _45.Model;
using _45.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.Inerfaces
{
    interface IDeck
    {
        void LoadDeck(Card[] cards);

        Card[] GetCards();

        Card DealCard();
    }
}
