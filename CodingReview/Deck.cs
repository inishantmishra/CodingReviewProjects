using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingReview
{
    public class Deck
    {
        List<Card> Cards { get; set; }
        public Deck()
        {
            Cards = new List<Card>();
            foreach (Suite suite in Enum.GetValues(typeof(Suite)))
            {
                for (int i = 2; i <= 10; i++)
                {
                    Card card = new Card();
                    card.cardSuite = suite;
                    card.cardValue = i.ToString();
                    Cards.Add(card);
                }

                Cards.Add(new Card() { cardSuite = suite, cardValue = "J" });
                Cards.Add(new Card() { cardSuite = suite, cardValue = "Q" });
                Cards.Add(new Card() { cardSuite = suite, cardValue = "K" });
                Cards.Add(new Card() { cardSuite = suite, cardValue = "A" });
            }

        }

        public void DisplayCards()
        {
            foreach(Card card in Cards)
            {
                Console.WriteLine($" Suite is - {card.cardSuite} and Value is- {card.cardValue}");
            }
            Console.WriteLine($"Total cards in deck is - {Cards.Count}");
        }

        public void Shuffle()
        {
            //Cards = Cards.OrderBy(c => Guid.NewGuid()).ToList();
            Random random = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                var temp = Cards[i];
                int index = random.Next(i, Cards.Count);
                Cards[i] = Cards[index];
                Cards[index] = temp;
            }
        }
    }
}
