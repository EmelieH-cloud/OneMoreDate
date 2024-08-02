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

        public void Shuffle()
        {
            Random rng = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                PlayerCard value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }
    }


    public class TrialDeck : Deck
    {
        public string Name { get; set; } = "Trial Deck";

        public TrialDeck()
        {
            Cards.AddRange(new List<PlayerCard>
        {
            new PlayerCard
            {
                Question = "...Has previously been involved in a criminal gang."
            },
            new PlayerCard
            {
                Question = "...Chews with their mouth open."
            },
            new PlayerCard
            {
                Question = "...Loves TikTok and posts videos every day, but doesn't have many followers and receives a lot of comments saying they're cringe."
            },
            new PlayerCard
            {
                Question = "...Dreams of working as a clown. He/she is currently actively looking for a job at a circus."
            },
            new PlayerCard
            {
                Question = "...Has never read a book."
            },
            new PlayerCard
            {
                Question = "...Is 10 cm taller than you."
            },
            new PlayerCard
            {
                Question = "...Is 10 cm shorter than you."
            },
            new PlayerCard
            {
                Question = "...Is missing a front tooth."
            },
            new PlayerCard
            {
                Question = "...Has no hair on their head."
            },
            new PlayerCard
            {
                Question = "...Does not shave at all, meaning not on their genitals, underarms, legs, or face."
            },
            new PlayerCard
            {
                Question = "...Does not believe in the greenhouse effect."
            },
            new PlayerCard
            {
                Question = "...Smokes a pack of cigarettes a day."
            },
            new PlayerCard
            {
                Question = "...Has slept with more than 150 people and tells you about it on the date."
            },
            new PlayerCard
            {
                Question = "...Is a gamer and spends at least 4 hours a day at their computer."
            },
            new PlayerCard
            {
                Question = "...Is missing a leg."
            },
            new PlayerCard
            {
                Question = "...Never wants to have children."
            },
            new PlayerCard
            {
                Question = "...Has a child from a previous relationship."
            },
            new PlayerCard
            {
                Question = "...Thinks you should pay for the date."
            },
            new PlayerCard
            {
                Question = "...Has OCD and needs to turn the light off and on 10 times every time they enter a room."
            },
            new PlayerCard
            {
                Question = "...Has cheated in a previous relationship."
            },
            new PlayerCard
            {
                Question = "...Has a foot fetish."
            },
            new PlayerCard
            {
                Question = "...Always smells like sweat."
            },
            new PlayerCard
            {
                Question = "...Works as a cleaner."
            },
            new PlayerCard
            {
                Question = "...Has been a contestant on the reality show Big Brother."
            },
            new PlayerCard
            {
                Question = "...Has a butterfly tattooed on their lower back."
            },
            new PlayerCard
            {
                Question = "...Has previously been convicted of assault."
            },
            new PlayerCard
            {
                Question = "...Leans in towards you during the date, and you notice that they have very bad breath."
            },
            new PlayerCard
            {
                Question = "...Posts revealing pictures of themselves on their Instagram."
            },
            new PlayerCard
            {
                Question = "...Has been in a pornographic film."
            },
            new PlayerCard
            {
                Question = "...Is vegan and brings it up twice during the date."
            }
        });
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
                Question = "...Has blue hair."
            },
            new PlayerCard
            {
                Question = "...Wears a cap that says 'Make America Great Again.'"
            },
            new PlayerCard
            {
                Question = "...Starts talking a bit about politics, and you realize that they don't know who Barack Obama is."
            },
            new PlayerCard
            {
                Question = "...Has very long toenails."
            },
            new PlayerCard
            {
                Question = "...Only brushes their teeth once a day."
            },
            new PlayerCard
            {
                Question = "...Spends at least 3 hours a day watching TikTok videos."
            },
            new PlayerCard
            {
                Question = "...Pees in the shower."
            },
            new PlayerCard
            {
                Question = "...Doesn't know how to start a washing machine."
            },
            new PlayerCard
            {
                Question = "...Has a nose piercing."
            },
            new PlayerCard
            {
                Question = "...Wears sweatpants on the date."
            },
            new PlayerCard
            {
                Question = "...Loves Andrew Tate and thinks he 'says what no one else dares to say.'"
            },
            new PlayerCard
            {
                Question = "...Was born as a different gender than they are today."
            },
            new PlayerCard
            {
                Question = "...Is against all forms of religion."
            },
            new PlayerCard
            {
                Question = "...Is 10 years older than you."
            },
            new PlayerCard
            {
                Question = "...Is 10 years younger than you."
            },
            new PlayerCard
            {
                Question = "...Has a visible butt crack."
            },
            new PlayerCard
            {
                Question = "...Smokes cannabis a few times a month."
            },
            new PlayerCard
            {
                Question = "...Is shy and doesn’t make eye contact with you even once during the date."
            },
            new PlayerCard
            {
                Question = "...Works as a taxi driver."
            },
            new PlayerCard
            {
                Question = "...Does not believe in the moon landing."
            },
            new PlayerCard
            {
                Question = "...Mentions that they think it's possible the Earth might be flat."
            },
            new PlayerCard
            {
                Question = "...Has a very annoying laugh."
            },
            new PlayerCard
            {
                Question = "...Doesn’t laugh at your jokes."
            },
            new PlayerCard
            {
                Question = "...Has previously made a living on OnlyFans."
            },
            new PlayerCard
            {
                Question = "...Watches porn at least once a week."
            },
            new PlayerCard
            {
                Question = "...Has a very large snake as a pet."
            },
            new PlayerCard
            {
                Question = "...Has a large spider as a pet and calls it Buddy."
            },
            new PlayerCard
            {
                Question = "...Is rude to the service staff."
            },
            new PlayerCard
            {
                Question = "...Is very jealous and says that they don't think partners should be able to go out and party without each other."
            },
            new PlayerCard
            {
                Question = "...Has long and dirty nails."
            },
            new PlayerCard
            {
                Question = "...Pulls out a guitar and starts playing and singing 'Wonderwall.'"
            },
            new PlayerCard
            {
                Question = "...Uses cocaine twice a month but says they plan to quit in the near future."
            },
            new PlayerCard
            {
                Question = "...Never wants to get married."
            },
            new PlayerCard
            {
                Question = "...Spends at least 1.5 hours getting ready before going out."
            },
            new PlayerCard
            {
                Question = "...Believes in astrology and talks about it for a long time during the date."
            },
            new PlayerCard
            {
                Question = "...Plays online casino 5-10 hours a week, but so far it's been going okay."
            },
            new PlayerCard
            {
                Question = "...Burps loudly twice during the date."
            },
            new PlayerCard
            {
                Question = "...Is an environmental activist and has once glued themselves to a road to stop traffic."
            },
            new PlayerCard
            {
                Question = "...Has a lot of friends of the opposite sex."
            },
            new PlayerCard
            {
                Question = "...Is good friends with their ex."
            },
            new PlayerCard
            {
                Question = "...Has undergone two cosmetic procedures."
            },
            new PlayerCard
            {
                Question = "...Gets botox in their forehead every six months."
            },
            new PlayerCard
            {
                Question = "...Believes that all drugs should be decriminalized."
            },
            new PlayerCard
            {
                Question = "...Believes that prostitution should be legalized."
            },
            new PlayerCard
            {
                Question = "...Has Tourette's and, on two occasions during the date, yells that you are a whore, but then apologizes afterward."
            },
            new PlayerCard
            {
                Question = "...Is 20 kg heavier than in the picture you saw before the date."
            },
            new PlayerCard
            {
                Question = "...Picks their nose twice during the date."
            },
            new PlayerCard
            {
                Question = "...Wants to save sex until marriage."
            },
            new PlayerCard
            {
                Question = "...Has been unemployed for 1.5 years."
            },
            new PlayerCard
            {
                Question = "...Has served time in prison for tax fraud."
            },
            new PlayerCard
            {
                Question = "...Has a child from a previous relationship."
            },
            new PlayerCard
            {
                Question = "...Is a Belieber (a super duper Justin Bieber-fan)."
            },
            new PlayerCard
            {
                Question = "...Doesn’t like to travel and doesn’t see the point of going abroad."
            },
            new PlayerCard
            {
                Question = "...Always wants to live in the countryside and never in a city."
            },
            new PlayerCard
            {
                Question = "...Has severe acne."
            },
            new PlayerCard
            {
                Question = "...Is bald."
            },
            new PlayerCard
            {
                Question = "...Does not wash their hands after using the bathroom."
            },
            new PlayerCard
            {
                Question = "...Has been a contestant on the reality show Love Island."
            },
            new PlayerCard
            {
                Question = "...Was raised in a very religious sect."
            },
            new PlayerCard
            {
                Question = "...Has a lot of hair on their back."
            },
            new PlayerCard
            {
                Question = "...Is a fitness enthusiast and can't understand how someone can just stay home all evening and watch movies."
            },
            new PlayerCard
            {
                Question = "...Loves Lord of the Rings and sometimes dresses up and meet other fans."
            },
            new PlayerCard
            {
                Question = "...Thinks The Shawshank Redemption is the best film ever."
            },
            new PlayerCard
            {
                Question = "...Wants to write an autobiography, but as they share their life story, you realize that they lived a remarkably boring life."
            },
            new PlayerCard
            {
                Question = "...Posts pictures on Instagram every day."
            },
            new PlayerCard
            {
                Question = "...Has four cats."
            },
            new PlayerCard
            {
                Question = "...Believes that Africa is a country."
            },
            new PlayerCard
            {
                Question = "...Has never heard of Britney Spears."
            },
            new PlayerCard
            {
                Question = "...Is a sober alcoholic but still drinks three glasses of wine during the date, justifying it with 'one more can't hurt.'"
            },
            new PlayerCard
            {
                Question = "...Has Kim Kardashian as their biggest role model."
            },
            new PlayerCard
            {
                Question = "...Wants to make it as an artist, but when you ask them to sing, you realize they have terrible singing voice."
            },
            new PlayerCard
            {
                Question = "...Goes to a nightclub every weekend."
            },
            new PlayerCard
            {
                Question = "...Doesn’t like animals and says they would never want to have a pet."
            },
            new PlayerCard
            {
                Question = "...Is 10 cm taller than you."
            },
            new PlayerCard
            {
                Question = "...Is 10 cm shorter than you."
            },
            new PlayerCard
            {
                Question = "...Is a gamer and spends at least 3 hours a day in front of the computer."
            },
            new PlayerCard
            {
                Question = "...Has worked as a stripper but it was many years ago."
            },
            new PlayerCard
            {
                Question = "...Has long nails."
            },
            new PlayerCard
            {
                Question = "...Doesn’t have a driver's license."
            },
            new PlayerCard
            {
                Question = "...Is a huge Swiftie and goes to every Taylor Swift concert."
            },
            new PlayerCard
            {
                Question = "...Thinks you should split the bill."
            },
            new PlayerCard
            {
                Question = "...Is bad at asking questions but is eager to talk a lot about themselves."
            },
            new PlayerCard
            {
                Question = "...Has never heard of Donald Trump."
            },
            new PlayerCard
            {
                Question = "...Is bisexual."
            },
            new PlayerCard
            {
                Question = "...Lives in a van."
            },
            new PlayerCard
            {
                Question = "...Likes to talk about their ex and describes in detail how their ex is an idiot."
            },
            new PlayerCard
            {
                Question = "...Isn't easily embarrassed. When you're at their place, they use the bathroom with the door open."
            },
            new PlayerCard
            {
                Question = "...Enjoys dressing up as various fantasy characters and participating in live role-playing games."
            },
            new PlayerCard
            {
                Question = "...Is a fruitarian."
            },
            new PlayerCard
            {
                Question = "...Says that all news from CNN is fake news."
            },
            new PlayerCard
            {
                Question = "...Admits to having smoked cannabis before the date."
            },
            new PlayerCard
            {
                Question = "...Swears a lot when they talk."
            },
            new PlayerCard
            {
                Question = "...Is an atheist."
            },
            new PlayerCard
            {
                Question = "...Has a large tiger tattooed on their chest."
            },
            new PlayerCard
            {
                Question = "...Says that they are not a feminist."
            },
            new PlayerCard
            {
                Question = "...Is an anti-vaxxer."
            },
            new PlayerCard
            {
                Question = "...Doesn’t know how to boil eggs."
            },
            new PlayerCard
            {
                Question = "...Has never heard of the TV show Friends, and when you tell them about it, they say it sounds really boring."
            },
            new PlayerCard
            {
                Question = "...Works as a plumber."
            },
            new PlayerCard
            {
                Question = "...Carries a Bible in their bag and mentions that they take it with them wherever they go."
            }
        });
        }
    }




public class NaughtyDeck : Deck
    {
        public string Name { get; set; } = "Naughty Deck";

        public NaughtyDeck()
        {
            isPurchased = false;
            Cards.AddRange(new List<PlayerCard>
        {
            new PlayerCard
            {
                Question = "...Wants to be slapped in the face during sex."
            },
            new PlayerCard
            {
                Question = "...Doesn’t want to have sex before marriage."
            },
            new PlayerCard
            {
                Question = "...Wants to wait at least 6 months before having sex."
            },
            new PlayerCard
            {
                Question = "...Likes latex and wants you to wear it from head to toe."
            },
            new PlayerCard
            {
                Question = "...Wants to be spanked during sex."
            },
            new PlayerCard
            {
                Question = "...Has been in a pornographic film."
            },
            new PlayerCard
            {
                Question = "...Wants all the lights off when you have sex."
            },
            new PlayerCard
            {
                Question = "...Is a virgin."
            },
            new PlayerCard
            {
                Question = "...Wants you to put handcuffs on them during sex."
            },
            new PlayerCard
            {
                Question = "...Enjoys combining food and sex, such as eating from each other's bodies."
            },
            new PlayerCard
            {
                Question = "...Is a bad kisser."
            },
            new PlayerCard
            {
                Question = "...Wants you to perform oral sex on them but does not want to do it on you."
            },
            new PlayerCard
            {
                Question = "...Wants to engage in different role-playing scenarios in bed, such as pretending to be your boss."
            },
            new PlayerCard
            {
                Question = "...Wants to be dominated in bed."
            },
            new PlayerCard
            {
                Question = "...Wants to have a threesome."
            },
            new PlayerCard
            {
                Question = "...Is bisexual and has had sex with someone of the same sex before."
            },
            new PlayerCard
            {
                Question = "...Doesn’t shave anywhere, including their legs, underarms, or genital area."
            },
            new PlayerCard
            {
                Question = "...Is completely silent during sex."
            },
            new PlayerCard
            {
                Question = "...Has slept with more than 150 people."
            },
            new PlayerCard
            {
                Question = "...Enjoys phone sex and would like to do it with you frequently."
            },
            new PlayerCard
            {
                Question = "...Never takes the initiative for sex."
            },
            new PlayerCard
            {
                Question = "...Showers for at least 30 minutes after every time you have sex."
            },
            new PlayerCard
            {
                Question = "...Has a foot fetish."
            }
        });
        }
    }

}