using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            //string name = "Bob Tabor";
            //string nameReversed = "";
            // In my case, the result would be:
            // robaT boB/*
            /*
            for (int i = name.Length - 1; i >= 0; i--)
            {
                nameReversed += name[i];
            }
            resultLabel.Text = nameReversed;*/

            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke
            string[] newNames = names.Split(',');
            //resultLabel.Text = String.Format("{0},{1},{2},{3}", newNames[3], newNames[2], newNames[1], newNames[0]);


            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***
            string[] styleArray = names.Split(',');
            string styleString = "";
            for (int i = 0; i < styleArray.Length; i++)
            {
                styleString += styleArray[i].PadLeft((7 + styleArray[i].Length / 2), '*').PadRight(14, '*') + "<br />";
            }

            //resultLabel.Text = styleString;



            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            resultLabel.Text = puzzle.ToLower().Remove(10,9).Replace("z", "t").Replace("now", "Now");



        }
    }
}