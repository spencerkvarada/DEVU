using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //We are first establishing that there will be no opportunity for a negative returned value by creating an if statement.
            //The if statement will act on the code and the else statement will have the same code just reversed.
            if (firstCalendar.SelectedDate > secondCalendar.SelectedDate)
            {
                resultLabel.Text = firstCalendar.SelectedDate.Subtract(secondCalendar.SelectedDate).TotalDays.ToString();
            }
            else //the else statement flips the code above if the first calendar date is earlier than the second calendar date.
            {
                resultLabel.Text = secondCalendar.SelectedDate.Subtract(firstCalendar.SelectedDate).TotalDays.ToString();
            }




        }
    }
}