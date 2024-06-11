namespace OneMoreDate.Models
{
    public class Deck
    {
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
            Cards.AddRange(new List<Card>
            {
                new Card
            {
                Question = "Hen har aldrig hört talas om Rysslands invasion av Ukraina"
            },
              new Card
            {
                Question = "Hens största dröm är att jobba som clown"
            },
                new Card
            {
                Question = "Hen har tidigare varit med i ett kriminellt gäng"

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
                Question = "Hen har aldrig hört talas om Rysslands invasion av Ukraina"
            },
              new Card
            {
                Question = "Hens största dröm är att jobba som clown"
            },
                new Card
            {
                Question = "Hen har tidigare varit med i ett kriminellt gäng"

            },

                new Card
            {
                Question = "Hen har aldrig hört talas om Rysslands invasion av Ukraina"
            },
              new Card
            {
                Question = "Hens största dröm är att jobba som clown"
            },
                new Card
            {
                Question = "Hen har tidigare varit med i ett kriminellt gäng"

            },

                new Card
            {
                Question = "Hen har aldrig hört talas om Rysslands invasion av Ukraina"
            },
              new Card
            {
                Question = "Hens största dröm är att jobba som clown"
            },
                 new Card
            {
                Question = "Hen tror inte på växthuseffekten"
            },
                new Card
            {
                Question = "Hen har inget hår på huvudet"

            }
            });
        }

    }
}