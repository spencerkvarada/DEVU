using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void groundRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateShipping();
        }

        protected void airRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateShipping();
        }

        protected void nextDayRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateShipping();
        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateShipping();
        }

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateShipping();
        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateShipping();
        }

        private void calculateShipping()
        {
            if (!valuesReal()) return;

            int dimensions = 0;
            if (!tryDimensions(out dimensions)) return;

            double modifier = getModifier();
            double cost = dimensions * modifier;
            resultLabel.Text = String.Format("Shipping total: {0:C} ", cost);
            
            /*
            if (widthTextBox.Text.Trim().Length == 0)
                return;
            double width = 0.0;
            if (!Double.TryParse(widthTextBox.Text, out width))
                return;
            double width =

            if (heightTextBox.Text.Trim().Length == 0)
                return;
            double height = 0.0;
            if (!Double.TryParse(heightTextBox.Text, out height))
                return;


            if (lengthTextBox.Text.Trim().Length == 0)
                return;
            double length = 0.0;
            if (!Double.TryParse(lengthTextBox.Text, out length))
                return;*/
            /*
            double width = int.Parse(widthTextBox.Text);
            double height = int.Parse(heightTextBox.Text);
            double length = int.Parse(lengthTextBox.Text);


            double price1 = width * height;
            double price2 = price1 * length;
            double price = price2 * modifier;

            /*
            if (groundRadio.Checked) price = width * height * length * 1.15;
            else if (airRadio.Checked) price = width * height * length * 1.25;
            else if (nextDayRadio.Checked) price = width * height * length * 1.45;*/
            /*
            resultLabel.Text = String.Format("The total is {0} for method {1}. ", price, tryString); */

        }

        private bool valuesReal()
        {
            if (!groundRadio.Checked && !airRadio.Checked && !nextDayRadio.Checked) return false;
            if (widthTextBox.Text.Trim().Length == 0 || heightTextBox.Text.Trim().Length == 0) return false;
            return true;
        }

        private bool tryDimensions(out int dimensions)
        {
            dimensions = 0;
            int width = 0;
            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;

            int height = 0;
            if (!int.TryParse(widthTextBox.Text.Trim(), out height)) return false;

            int length = 0;
            if (!int.TryParse(widthTextBox.Text.Trim(), out length)) length = 1;

            dimensions = width * height * length;
            return true;
        }

        private double getModifier()
        {
            if (groundRadio.Checked) return .15;
            else if (airRadio.Checked) return .25;
            else if (nextDayRadio.Checked) return .45;
            else return 0;
        }
        
    }
}