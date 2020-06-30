using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wolfgang
{
    public partial class SiteMaster : MasterPage
    {
        public static string loggedInUser { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (loggedInUser != null)
            {
                lblusername.InnerText = loggedInUser;
            }
            else
            {
                displayLoggedInUser(loggedInUser);
            }
           
            
        }
        
        
        public void displayLoggedInUser(string user)
        {
            loggedInUser = user;
        }
    }
}