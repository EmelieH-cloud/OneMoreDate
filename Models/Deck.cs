namespace OneMoreDate.Models
{
    public class Deck
    {
        public bool isPurchased;
        public List<PlayerCard> Cards { get; set; }
        public Deck()
        {
            Cards = new List<PlayerCard>();
        }
    }

    public class PartyDeck : Deck
    {
        public string Name { get; set; } = "Party Deck";

        public PartyDeck()
        {
            isPurchased = false;
            Cards.AddRange(new List<PlayerCard>
            {
                new PlayerCard
            {
                Question = "...Insists on being the center of attention at every party"
            },
              new PlayerCard
            {
                Question = "...Hates public display of affection at social gatherings"
            },
                new PlayerCard
            {
                Question = "...Never wants to try the food offered at parties"

            },
            new PlayerCard
            {
                Question = "...Only drinks at social events, but drinks too much everytime"

            },
            new PlayerCard
            {
                 Question = "...Eats all the snacks without sharing at parties"
            },
             new PlayerCard
            {
                 Question = "...Insists on playing their own music at every party"
            },
             new PlayerCard
             {
                 Question ="...Always dominates the beer pong table but gets overly competitive"
             },
             new PlayerCard
             {
              Question= "...Consumes illegal drugs at parties"
            },
              new PlayerCard
             {
              Question= "...Always wears a clown costume to parties"
            },
              new PlayerCard
            {
             Question="...Insists on bringing their pet snake to social gatherings"
            },
              new PlayerCard
              {
                  Question="...Always wears heavy and dramatic makeup to parties"
              },
              new PlayerCard
              {
                  Question="...Wears glitter and sparkles excessively on their face and body for every event"
              },
              new PlayerCard
              {

                  Question="...Wears a neon-colored suit and tie combination to formal events"
              }

            });

        }
    }


    public class StarterDeck : Deck
    {
        public string Name { get; set; } = "Starter Deck";


        public StarterDeck()
        {
            Cards.AddRange(new List<PlayerCard>
            {
                new PlayerCard
            {
                Question = "...Has never heard of the Russia-Ukraine conflict."
            },
              new PlayerCard
            {
                Question = "...Dreams of working as a full-time clown and declines any other job, even when unemployed"
            },
                new PlayerCard
            {
                Question = "...Has a criminal history with a gang notorious for seeking revenge on the loved ones of those who leave"

            },

                new PlayerCard
            {
                Question = "...Does not believe in global warming"
            },
              new PlayerCard
            {
                Question = "...Collects and displays stuffed animals in their home"
            },
                new PlayerCard
            {
                Question = "...Believes in conspiracy theories and brings them up constantly"

            },

                new PlayerCard
            {
                Question = "...Owns a pet skunk and doesn't believe in deodorizing their home as it may cause stress to the skunk"
            },
              new PlayerCard
            {
                Question = "...Has several but small face tattoos"
            },
                 new PlayerCard
            {
                Question = "...Has an obsession with wearing historical clothing from a specific era"
            },
                new PlayerCard
            {
                Question = "...Is passionately against vaccinations and argues their stance at social gatherings"

            }
            });
        }

    }
}