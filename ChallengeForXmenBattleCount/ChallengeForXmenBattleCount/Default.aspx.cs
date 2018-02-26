using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            int largerNumber = 0;
            int smallerNumber = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] > numbers[largerNumber])
                {
                    largerNumber = i;
                }
                if (numbers[i] < numbers[smallerNumber])
                {
                    smallerNumber = i;
                }
                result = String.Format("Greatest Total Victories: {0} (Victories: {1})<br />", names[largerNumber], numbers[largerNumber]);
                result += String.Format("Least Total Victories: {0} (Victories: {1})", names[smallerNumber], numbers[smallerNumber]);
                resultLabel.Text = result;
            }


           
        }
    }
}