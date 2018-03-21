using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace megaWarChallenge
{
    public class Battle
    {
        private List<Card> _winnings;
        private StringBuilder _sb;

        public Battle()
        {
            _winnings = new List<Card>();
            _sb = new StringBuilder();
        }
        public string StartBattle(Player firstPlayer, Player secondPlayer)
        {
            Card firstPlayerCard = getCard(firstPlayer);
            Card secondPlayerCard = getCard(secondPlayer);

            compareCards(firstPlayer, secondPlayer, firstPlayerCard, secondPlayerCard);
            return _sb.ToString();
        }

        private Card getCard(Player player)
        {
            Card card = player.Cards.ElementAt(0);
            player.Cards.Remove(card);
            _winnings.Add(card);
            return card;
        }

        private void compareCards(Player firstPlayer, Player secondPlayer, Card firstCard, Card secondCard)
        {
            displayCards(firstCard, secondCard);
            if (firstCard.CardScore() == secondCard.CardScore())
                war(firstPlayer, secondPlayer);
            if (firstCard.CardScore() > secondCard.CardScore())
                getWinner(firstPlayer);
            else
                getWinner(secondPlayer);
        }

        private void war(Player firstPlayer, Player secondPlayer)
        {
            _sb.Append("</br></strong>War begins..<br/>");
            getCard(firstPlayer);
            Card warCard1 = getCard(firstPlayer);
            getCard(firstPlayer);
            
            getCard(secondPlayer);
            Card warCard2 = getCard(secondPlayer);
            getCard(secondPlayer);
            
            compareCards(firstPlayer, firstPlayer, warCard1, warCard2);
        }

        private void getWinner(Player player)
        {
            if (_winnings.Count == 0) return;
            displayWinnings();
            player.Cards.AddRange(_winnings);
            _winnings.Clear();
            _sb.Append("<br/></strong>");
            _sb.Append(player.Name);
            _sb.Append(" Wins!</strong><br/>");

        }

        private void displayCards(Card firstCard, Card secondCard)
        {
            _sb.Append("<br/>Cards in play: ");
            _sb.Append(firstCard.Type);
            _sb.Append(" of ");
            _sb.Append(firstCard.Suit);
            _sb.Append(" vs. ");
            _sb.Append(secondCard.Type);
            _sb.Append(" of ");
            _sb.Append(secondCard.Suit);
        }

        private void displayWinnings()
        {
            _sb.Append("<br/> Winnings");
            foreach (var card in _winnings)
            {
                _sb.Append("<br/>&nbsp;&nbsp;&nbsp;&nbsp;");
                _sb.Append(card.Type);
                _sb.Append(" of ");
                _sb.Append(card.Suit);
            }
        }
    }
}