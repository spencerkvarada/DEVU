using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace megaWarChallenge
{
    public class Game
    {
        private Player _firstPlayer;
        private Player _secondPlayer;

        public Game(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayer = new Player() { Name = firstPlayerName };
            _secondPlayer = new Player() { Name = secondPlayerName };
        }

        public string Play()
        {
            Deck deck = new Deck();
            int round = 0;
            string result = "<h2>Dealing Cards...</h2>";
            result += deck.Deal(_firstPlayer, _secondPlayer);
            result += "<h2>Begin!</h2>";

            while (_firstPlayer.Cards.Count != 0 && _secondPlayer.Cards.Count != 0)
            {
                Battle battle = new Battle();
                result += battle.StartBattle(_firstPlayer, _secondPlayer);
                round++;
                if (round > 20)
                    break;
            }
            result += findWinner();
            return result;
        }
        private string findWinner()
        {
            string result = "";
            if (_firstPlayer.Cards.Count > _secondPlayer.Cards.Count)
                result += "<br/></strong>Odie wins!";
            else
                result += "<br/></strong>Czar Wins!";
            result += "<br/>Odie's Cards:" + _firstPlayer.Cards.Count + " Czar's Cards:" + _secondPlayer.Cards.Count;
            return result;
        }
    }
}