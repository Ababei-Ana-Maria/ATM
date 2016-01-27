using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QUIZ_ATM.conect;

namespace QUIZ_ATM
{
    public partial class test_0 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Butonul de  LOG OUT
        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void start_test_Click(object sender, EventArgs e)
        {
            Response.Redirect("model_test.aspx");
        }
    }
}