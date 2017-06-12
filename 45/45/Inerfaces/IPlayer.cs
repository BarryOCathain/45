using _45.Model;

namespace _45.Inerfaces
{
    interface IPlayer
    {
        HandCard[] Cards { get; set; }

        void TakeCard(Card card);

        int GetNumberOfCardsInHand();

        void PlayCard(HandCard card);

        Card[] CardToBePlayedIsSelected();
    }
}
