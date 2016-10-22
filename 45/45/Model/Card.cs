using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.Model
{
    class Card
    {
        public Card(Enums.Suit suit, Enums.CardValue value)
        {
            Suit = suit;
            Value = value;
        }
        public Enums.Suit Suit { get; set; }
        public Enums.CardValue Value { get; set; }
    }
}
