using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace megaWarChallenge
{
    public class Deck
    {
        private List<Card> _deck;
        private Random _random;
        private StringBuilder _sb;

        public Deck()
        {
            _deck = new List<Card>();
            _random = new Random();
            _sb = new StringBuilder();

            string[] suits = new string[] { "Spades", "Hearts", "Diamonds", "Clubs" };
            string[] types = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (var suit in suits)
            {
                foreach (var type in types)
                {
                    _deck.Add(new Card(){ Suit = suit, Type = type});
                }
            }
        }

        public string Deal(Player firstPlayer, Player secondPlayer)
        {
            while (_deck.Count > 0)
            {
                dealCards(firstPlayer);
                dealCards(secondPlayer);
            }
            return _sb.ToString();
        }

        private void dealCards(Player player)
        {
            Card card = _deck.ElementAt(_random.Next(_deck.Count));
            player.Cards.Add(card);
            _deck.Remove(card);

            _sb.Append("<br/>");
            _sb.Append(player.Name);
            _sb.Append(" has pulled ");
            _sb.Append(card.Type);
            _sb.Append(" of ");
            _sb.Append(card.Suit);
        }
    }
}