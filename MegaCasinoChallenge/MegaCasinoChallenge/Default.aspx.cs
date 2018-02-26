using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaCasinoChallenge
{
    public partial class Default : System.Web.UI.Page
    {

        int playerMoney = 0; int bet = 0; int winnings;
        int oneImage = 0; int twoImage = 0; int threeImage = 0;
        string[] images = new string[12] { "Bar.png", "Bell.png", "Cherry.png", "Clover.png", "Diamond.png", "HorseShoe.png", "Lemon.png", "Orange.png", "Plum.png", "Seven.png", "Strawberry.png", "Watermellon.png" };
        Random random = new Random();



        protected void Page_Load(object sender, EventArgs e)
        {
            playerMoney = 100;
            moneyLabel.Text = String.Format("{0:C}", playerMoney);
            spinReels();
            if (!Page.IsPostBack)
                ViewState.Add("playerCash", playerMoney);
        }

        protected void leverButton_Click(object sender, EventArgs e)
        {
            fetchBet();
            spinReels();
            if (checkBars())
                checkWinnings();
            else youLost();
            noBet();
        }

        private bool fetchBet()
        {
            betExists();
            if (!int.TryParse(betTextBox.Text.Trim(), out bet)) return false;
            return true;
        }

        private bool betExists()
        {
            if (betTextBox.Text.Length < 0) return false;
            return true;
        }

        private void spinReels()
        {
            oneImage = random.Next(11);
            twoImage = random.Next(11);
            threeImage = random.Next(11);
            reel1.ImageUrl = images[oneImage];
            reel2.ImageUrl = images[twoImage];
            reel3.ImageUrl = images[threeImage];
        }
        /*
        private string spinReels()
        {
            string[] images = new string[] { "Bar", "Bell", "Cherry", "Clover", "Diamond", "HorseShoe", "Lemon", "Orange", "Plum", "Seven", "Strawberry", "Watermelon" };
            
            return images[random.Next(11)];

        }

        private void setReels()
        {
            string[] reelOnes = new string[] { spinReels(), spinReels(), spinReels() };

            reel1.ImageUrl = reelOnes[0] + ".png";
            reel2.ImageUrl = reelOnes[1] + ".png";
            reel3.ImageUrl = reelOnes[2] + ".png";
            
        }*/

        private bool checkBars()
        {
            if (oneImage == 0 || twoImage == 0 || threeImage == 0) return false;
            else return true;
        }

        private void checkWinnings()
        {
            checkCherries();
            checkSevens();
            if (winnings > 0) youWon();
            else youLost();
        }

        private int checkCherries()
        {
            if (oneImage == 2 || twoImage == 2 || threeImage == 2) winnings = bet * 2;
            if ((oneImage == 2 && twoImage == 2) || (oneImage == 2 && threeImage == 2)
                || (twoImage == 2 && threeImage == 2)) winnings = bet * 3;
            if (oneImage == 2 && twoImage == 2 && threeImage == 2) winnings = bet * 4;
            return winnings;
        }

        private int checkSevens()
        {
            if (oneImage == 9 && twoImage == 9 && threeImage == 9) winnings = bet * 100;
            return winnings;
        }

        private void youLost()
        {
            int playerMoney = (int)ViewState["playerCash"];
            playerMoney -= bet;
            moneyLabel.Text = String.Format("{0:C}", playerMoney);
            ViewState.Add("playerCash", playerMoney);
            resultLabel.Text = String.Format("You lost {0:C}! Try again!", bet);
        }

        private void youWon()
        {
            int playerMoney = (int)ViewState["playerCash"];
            playerMoney += winnings;
            moneyLabel.Text = String.Format("{0:C}", playerMoney);
            ViewState.Add("playerCash", playerMoney);
            resultLabel.Text = String.Format("You won {0:C} on a bet of {1:C}!", winnings, bet);
        }

        private void noBet()
        {
            if (!fetchBet()) resultLabel.Text = "Please set your bet to play!";
        }

        
    }
}