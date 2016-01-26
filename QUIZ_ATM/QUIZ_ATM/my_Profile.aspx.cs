using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUIZ_ATM
{
    public partial class my_Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // butonul de LOG OUT
        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        //Butonul TEST NOU
        protected void testnou_Click(object sender, EventArgs e)
        {
            Response.Redirect("test_0.aspx");
        }
        //Butonul VEZI CLASAMENT
        protected void clasament_Click(object sender, EventArgs e)
        {
          Response.Redirect("clasament.aspx");
        }
    }
}