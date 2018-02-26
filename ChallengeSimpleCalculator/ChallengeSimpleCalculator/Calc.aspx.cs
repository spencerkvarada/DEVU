using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            int first = int.Parse(firstInput.Text);
            int second = int.Parse(secondInput.Text);
            int result = first + second;
            resultLabel.Text = result.ToString();
        }

        protected void subButton_Click(object sender, EventArgs e)
        {
            int first = int.Parse(firstInput.Text);
            int second = int.Parse(secondInput.Text);
            int result = first - second;
            resultLabel.Text = result.ToString();
        }

        protected void multButton_Click(object sender, EventArgs e)
        {
            int first = int.Parse(firstInput.Text);
            int second = int.Parse(secondInput.Text);
            int result = first * second;
            resultLabel.Text = result.ToString();
        }

        protected void divButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstInput.Text);
            double second = double.Parse(secondInput.Text);
            double result = first / second;
            resultLabel.Text = result.ToString();
        }

        protected void firstInput_TextChanged(object sender, EventArgs e)
        {

        }

        protected void secondInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}