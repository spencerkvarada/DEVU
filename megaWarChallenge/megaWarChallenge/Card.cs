using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace megaWarChallenge
{
    public class Card
    {
        public string Suit { get; set; }
        public string Type { get; set; }

        public int CardScore()
        {
            int value = 0;

            switch (this.Type)
            {
                case "Jack":
                    value = 11;
                    break;
                case "Queen":
                    value = 12;
                    break;
                case "King":
                    value = 13;
                    break;
                case "Ace":
                    value = 14;
                    break;
                default:
                    value = int.Parse(this.Type);
                    break;
            }
            return value;
        }
    }
}