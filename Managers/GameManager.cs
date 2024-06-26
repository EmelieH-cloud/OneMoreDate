﻿using OneMoreDate.Models;

namespace OneMoreDate.Managers
{
    public static class GameManager
    {
        // Klass som ansvarar för att konvertera deck till rätt decktyp (party, starter osv)
        public static Deck ActiveDeck { get; set; } = new();


        public static StarterDeck? ConvertDeckToStarterDeck(Deck deck)
        {
            if (deck.GetType() == typeof(StarterDeck))
            {
                StarterDeck starterDeck = (StarterDeck)deck;
                return starterDeck;
            }
            else
            {
                return null;
            }

        }

        public static PartyDeck? ConvertDeckToPartyDeck(Deck deck)
        {
            if (deck.GetType() == typeof(PartyDeck))
            {
                PartyDeck partyDeck = (PartyDeck)deck;
                return partyDeck;
            }
            else
            {
                return null;
            }

        }
        public static void AddActiveDeck(string deckName)
        {
            if (deckName == "starterDeck")
            {
                StarterDeck starterDeck = new();
                ActiveDeck = starterDeck;
            }
            if (deckName == "partyDeck")
            {
                PartyDeck partyDeck = new();
                ActiveDeck = partyDeck;
            }
        }
    }
}