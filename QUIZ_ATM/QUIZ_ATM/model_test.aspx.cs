﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUIZ_ATM
{
    public partial class model_test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("my_Profile.aspx");
        }
        protected void Exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("my_Profile.aspx");
        }
        protected void Next_Click(object sender, EventArgs e)
        {
            Response.Redirect("model_test.aspx");
        }
    }
}