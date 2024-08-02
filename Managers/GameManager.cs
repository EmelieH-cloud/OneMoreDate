using OneMoreDate.Models;

namespace OneMoreDate.Managers
{
    public static class GameManager
    {

        public static Deck ActiveDeck { get; set; } = new Deck();

        public static void AddActiveDeck(string deckName)
        {
            switch (deckName)
            {
                case "trialDeck":
                    ActiveDeck = new TrialDeck();
                    break;
                case "partyDeck":
                    ActiveDeck = new PartyDeck();
                    break;
                case "naughtyDeck":
                    ActiveDeck = new NaughtyDeck();
                    break;
                default:
                    throw new ArgumentException("Invalid deck name");
            }
        }

        public static TrialDeck? GetActiveTrialDeck()
        {
            return ActiveDeck as TrialDeck;
        }

        public static PartyDeck? GetActivePartyDeck()
        {
            return ActiveDeck as PartyDeck;
        }

        public static NaughtyDeck? GetActiveNaughtyDeck()
        {
            return ActiveDeck as NaughtyDeck;
        }
    }

}