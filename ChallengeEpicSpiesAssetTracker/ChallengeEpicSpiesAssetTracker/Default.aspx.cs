using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Creating 3 separate arrays for each one.
                //Didn't want to mess with that level of multi-dimensional arrays
                string[] assets = new string[0];
                int[] elections = new int[0];
                int[] subtrefuge = new int[0];
                //Creating viewstate entries for each array
                ViewState.Add("Assets", assets);
                ViewState.Add("Elections", elections);
                ViewState.Add("Subtrefuge", subtrefuge);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            //casting to arrays
            string[] assets = (string[])ViewState["Assets"];
            int[] elections = (int[])ViewState["Elections"];
            int[] subtrefuge = (int[])ViewState["Subtrefuge"];
            //creating a new length for each one instead of repeating myself (stolen from the solution video)
            int newSpan = assets.Length + 1;
            //Resizing each array to fit with the new length
            Array.Resize(ref assets, newSpan);

            Array.Resize(ref elections, newSpan);

            Array.Resize(ref subtrefuge, newSpan);

            //making a new index to tie all 3 arrays together
            int useIndex = assets.GetUpperBound(0);
            assets[useIndex] = assetBox.Text;
            elections[useIndex] = int.Parse(electionBox.Text);
            subtrefuge[useIndex] = int.Parse(subBox.Text);
            //Putting everything back into viewstate
            ViewState["Assets"] = assets;
            ViewState["Elections"] = elections;
            ViewState["Subtrefuge"] = subtrefuge;
            //Making the string.format for the result label. 
            resultLabel.Text = String.Format("Elections Rigged: {0}<br />Average Subterfuge per Asset: {1}<br />Last Asset added: {2}",
                elections.Sum(), subtrefuge.Average(), assets[useIndex]);
            //Clear the text boxes

            assetBox.Text = "";
            electionBox.Text = "";
            subBox.Text = "";


        }
    }
}