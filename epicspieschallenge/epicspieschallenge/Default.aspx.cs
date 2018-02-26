using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace epicspieschallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { 
                //Initializing calendar dates to satisfy Business Rule 1
                endoldCalendar.SelectedDate = DateTime.Now.Date;
                startnewCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                endnewCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            // Spies $500/day
            TimeSpan totalDaysOnDuty = endnewCalendar.SelectedDate.Subtract(startnewCalendar.SelectedDate);
            double totalCost = totalDaysOnDuty.TotalDays * 500.0;

            //Adding $1000 to the total if the assignment is longer than 3 weeks
            if (totalDaysOnDuty.TotalDays > 21)
            {
                totalCost += 1000.0;
            }

            //Result label for the total

            resultLabel.Text = String.Format("{0}'s Assignment to {1} is a go. Budget: {2:C}", codeBox.Text, assignmentbox.Text, totalCost);

            //Satisfying the time between assignments for business rule 2.
            TimeSpan assignmentBreak = startnewCalendar.SelectedDate.Subtract(endoldCalendar.SelectedDate);
            if (assignmentBreak.TotalDays < 14)
            {
                resultLabel.Text = "Error. Not enough time between assignments. Must be 2 weeks.";

                DateTime earliestAvailability = endoldCalendar.SelectedDate.AddDays(14);

                startnewCalendar.SelectedDate = earliestAvailability;
                startnewCalendar.VisibleDate = earliestAvailability;


            }



        }
    }
}