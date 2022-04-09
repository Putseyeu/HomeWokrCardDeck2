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
            string end = Console.ReadLine();

            while (end != "end")
            {
                Console.WriteLine("Что бы закончить набирать карты  введите end ");
                player.AddCard();
                end = Console.ReadLine();
            }

            Console.WriteLine("Игрок закончил набор карт");
            player.ShowItems();
        }
    }

    class Player
    {
        private List<Card> _cardPlayer = new List<Card>();
        private Deck _deck = new Deck();

        public void AddCard()
        {
            if (_cardPlayer.Count != _deck.Card.Count)
            {
                bool chekCard = false;
                while (chekCard != true)
                {
                    Random random = new Random();
                    int randomCard = random.Next(0, _deck.Card.Count);
                    if (_cardPlayer.Contains(_deck.Card[randomCard]) == false)
                    {
                        _cardPlayer.Add(_deck.Card[randomCard]);
                        chekCard = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Карт больше нету");
            }
        }

        public void ShowItems()
        {
            foreach (var card in _cardPlayer)
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
            AddCard();
            Card = _card;
        }

        private void AddCard()
        {
            _card.Add(new Card("шесть пики"));
            _card.Add(new Card("шесть трефы"));
            _card.Add(new Card("шесть червы"));
            _card.Add(new Card("шесть бубны"));
            _card.Add(new Card("семь  пики"));
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
