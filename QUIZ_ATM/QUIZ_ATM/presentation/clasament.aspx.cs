using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QUIZ_ATM.a;
using System.Data;
using System.Data.SqlClient;

namespace QUIZ_ATM
{
    public partial class clasament : System.Web.UI.Page
    {
        bussiness.buss a = new bussiness.buss();
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlDataReader read;

            read = a.returnare_clasament();
            while (read.Read())
            {
                GridView1.DataSource = read;
                GridView1.DataBind();
            }
            read.Close();
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