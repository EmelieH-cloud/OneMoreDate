namespace OneMoreDate.Models
{
    public class Deck
    {
        public bool isPurchased;
        public List<Card> Cards { get; set; }
        public Deck()
        {
            Cards = new List<Card>();
        }
    }

    public class PartyDeck : Deck
    {
        public string Name { get; set; } = "Party Deck";

        public PartyDeck()
        {
            isPurchased = false;
            Cards.AddRange(new List<Card>
            {
                new Card
            {
                Question = "...Insists on being the center of attention at every party"
            },
              new Card
            {
                Question = "...Hates public display of affection at social gatherings"
            },
                new Card
            {
                Question = "...Never wants to try the food offered at parties"

            },
            new Card
            {
                Question = "...Only drinks at social events, but drinks too much everytime"

            },
            new Card
            {
                 Question = "...Eats all the snacks without sharing at parties"
            },
             new Card
            {
                 Question = "...Insists on playing their own music at every party"
            },
             new Card
             {
                 Question ="...Always dominates the beer pong table but gets overly competitive"
             },
             new Card
             {
              Question= "...Consumes illegal drugs at parties"
            },
              new Card
             {
              Question= "...Always wears a clown costume to parties"
            },
              new Card
            {
             Question="...Insists on bringing their pet snake to social gatherings"
            },
              new Card
              {
                  Question="...Always wears heavy and dramatic makeup to parties"
              },
              new Card
              {
                  Question="...Wears glitter and sparkles excessively on their face and body for every event"
              },
              new Card
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
            Cards.AddRange(new List<Card>
            {
                new Card
            {
                Question = "...Has never heard of the Russia-Ukraine conflict."
            },
              new Card
            {
                Question = "...Dreams of working as a full-time clown and declines any other job, even when unemployed"
            },
                new Card
            {
                Question = "...Has a criminal history with a gang notorious for seeking revenge on the loved ones of those who leave"

            },

                new Card
            {
                Question = "...Does not believe in global warming"
            },
              new Card
            {
                Question = "...Collects and displays stuffed animals in their home"
            },
                new Card
            {
                Question = "...Believes in conspiracy theories and brings them up constantly"

            },

                new Card
            {
                Question = "...Owns a pet skunk and doesn't believe in deodorizing their home as it may cause stress to the skunk"
            },
              new Card
            {
                Question = "...Has several but small face tattoos"
            },
                 new Card
            {
                Question = "...Has an obsession with wearing historical clothing from a specific era"
            },
                new Card
            {
                Question = "...Is passionately against vaccinations and argues their stance at social gatherings"

            }
            });
        }

    }
}