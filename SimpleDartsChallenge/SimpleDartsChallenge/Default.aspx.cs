using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleDartsChallenge
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dartsButton_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            string result = game.Play();
            resultLabel.Text = result;
        }
    }
}