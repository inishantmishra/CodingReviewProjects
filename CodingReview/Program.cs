using System;

namespace CodingReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck deck = new Deck();
            deck.DisplayCards();
            deck.Shuffle();
            deck.DisplayCards();
            Deck deck1 = new Deck();
            deck1.DisplayCards();
        }
    }
}
