using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleOktaWebformsExample
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string labelText;
            if (Request.IsAuthenticated)
            {
                labelText = "Some hidden resource";
            }
            else
            {
                labelText = "You are not authenticated!";
            }

            var label = new Label
            {
                Text = labelText
            };

            var mainContent = (ContentPlaceHolder)Page.Form.FindControl("MainContent");
            mainContent.Controls.Add(label);
        }
    }
}