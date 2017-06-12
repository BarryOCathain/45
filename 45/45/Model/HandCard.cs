namespace _45.Model
{
    class HandCard
    {
        public HandCard(Card card)
        {
            Card = card;
            ToBePlayedOrDiscarded = false;

        }

        public Card Card { get; set; }
        public bool ToBePlayedOrDiscarded { get; set; }

        public void PlayOrDiscard()
        {
            ToBePlayedOrDiscarded = true;
        }

        public void Reset()
        {
            ToBePlayedOrDiscarded = false;
        }
    }
}
