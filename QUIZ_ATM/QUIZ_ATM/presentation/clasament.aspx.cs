using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QUIZ_ATM.a;

namespace QUIZ_ATM
{
    public partial class clasament : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("my_Profile.aspx");
        }
    }
}