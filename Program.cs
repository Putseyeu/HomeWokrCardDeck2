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

            while (Convert.ToInt32(Console.ReadLine()) != 1)
            {
                Console.WriteLine("Закончить набирать карты  выбериет  1");
                player.AddCard();

            }

            Console.WriteLine("Игрок закончил набор карт");
            player.ShowItems();
        }
    }

    class Player
    {
        private List<Card> _cardPlayer = new List<Card>();
        Deck _deck = new Deck();       

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
        public List<Card> Card { get; private set; } = new List<Card>();

        public Deck()
        {
            Card.Add(new Card("шесть пики"));
            Card.Add(new Card("шесть трефы"));
            Card.Add(new Card("шесть червы"));
            Card.Add(new Card("шесть бубны"));
            Card.Add(new Card("семь  пики"));
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
