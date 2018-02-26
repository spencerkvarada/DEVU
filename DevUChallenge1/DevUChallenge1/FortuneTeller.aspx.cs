using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUChallenge1
{
    public partial class FortuneTeller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void fortuneButton_Click(object sender, EventArgs e)
        {
            string age = ageBox.Text;
            string money = moneyBox.Text;

            string result = "At the age " + age + " I would have expected you to have had more than" + money + "dollars in your pocket.";

            resultLabel.Text = result;
        }
    }
}