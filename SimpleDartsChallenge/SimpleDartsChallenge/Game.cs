using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace SimpleDartsChallenge
{
    public class Game
    {
        private Player _playerOne;
        private Player _playerTwo;

        private Random _random;

        public Game()
        {
            _playerOne = new Player();
            _playerOne.Name = "Rick";
            _playerTwo = new Player();
            _playerTwo.Name = "Morty";
            _random = new Random();
        }

        public string Play()
        {
            while (_playerOne.Score < 300 && _playerTwo.Score < 300)
            {
                playDarts(_playerOne);
                playDarts(_playerTwo);
            }
            return getResults();
        }

        private string getResults()
        {
            string result = "";
            if (_playerOne.Score > _playerTwo.Score)
                return result = String.Format("{0}: {1}: <br/> {3} <br/> {4} wins!", _playerOne.Name, _playerOne.Score, _playerTwo.Name, _playerTwo.Score, _playerOne.Name);
            else
                return result = String.Format("{0}: {1}: <br/> {3} <br/> {4} wins!", _playerOne.Name, _playerOne.Score, _playerTwo.Name, _playerTwo.Score, _playerTwo.Name);
        }

        private void playDarts(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                Score.ScoreOfGame(player, dart);
            }
        }
    }
}