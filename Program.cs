using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWokrCardDeck2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine("Игрок достает карты, пока не решит, что ему хватит карт. end - закончить набор карт.");
            string userInput = Console.ReadLine();

            while (userInput != "end")
            {
                Console.WriteLine("Вы получили карту. Что бы закончить набирать карты  введите end ");
                player.AddCard();
                userInput = Console.ReadLine();
            }

            Console.WriteLine("Игрок закончил набор карт");
            player.ShowItems();
        }
    }

    class Player
    {
        private List<Card> _card = new List<Card>();
        private Deck _deck = new Deck();

        public void AddCard()
        {
            if (_deck.Card.Count != 0)
            {
                Random random = new Random();
                int randomCard = random.Next(0, _deck.Card.Count);
                _card.Add(_deck.Card[randomCard]);
                _deck.Card.Remove(_deck.Card[randomCard]);
            }
            else
            {
                Console.WriteLine("Карт больше нету");
            }
        }

        public void ShowItems() 
        {
            foreach (var card in _card)
            {
                Console.WriteLine(card.Title);
            }
        }
    }
    class Deck
    {
        private List<Card> _card = new List<Card>();

        public List<Card> Card { get; private set; }

        public Deck()
        {
            AddCards();
            GreatDeck();
        }

        private void AddCards()
        {
            List<string> cardSuit = new List<string>() { "бубны", "червы", "червы", "трефы" };
            List<string> cardRank = new List<string>() { "шесть", "семь","восемь","девять", "десять", "валет", "дама", "король", "туз"};

            for (int i = 0; i < cardRank.Count; i++)
            {
                for (int j = 0; j < cardSuit.Count; j++)
                {
                    _card.Add(new Card(cardRank[i] + " " + cardSuit[j]));
                }
            }
        }

        private void GreatDeck()
        {
            Card = _card;
        }
    }

    class Card
    {
        public string Title { get; private set; }

        public Card(string title)
        {
            Title = title;
        }
    }
}
