using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using QUIZ_ATM.a;
//
using QUIZ_ATM.bussiness;

namespace QUIZ_ATM
{
    public partial class _Default : Page
    {
        bussiness.buss ac = new bussiness.buss();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Log in
        protected void login_Click(object sender, EventArgs e)
        {
            var user = TextBox2.Text;
            var pass = TextBox4.Text;
            int optiune = ac.logare(user, pass);
            if (optiune == 3)
            {
                Label1.Text = "Parola sau E-mail gresite!!";
            }
            if (optiune == 1)
            {

                Response.Redirect("admin_profile.aspx");
            }
            if (optiune == 2)
            {

                Response.Redirect("my_Profile.aspx");
            }
        }
        //Creare cont
        protected void crearecont_Click(object sender, EventArgs e)
        {
            Response.Redirect("creare_cont.aspx");
        }
    }
}