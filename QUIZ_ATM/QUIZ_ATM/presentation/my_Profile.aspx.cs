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
    public partial class my_Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn=new SqlConnection(ConfigurationManager.ConnectionStrings["quiz_u"].ConnectionString);

            conn.Open();
            //if (conn.State == ConnectionState.Open)
            //{
            //    Label1.Text = "ok!";
            //}
            //else
            //{
            //    Label1.Text = "NotOK!!!";
            //}
            string s = "SELECT * FROM dbo.Utilizatori WHERE id_utilizator=1";
            SqlCommand c1 = new SqlCommand(s, conn);
            SqlDataReader rd1 = c1.ExecuteReader();
            rd1.Read();
            Label1.Text = rd1[1].ToString();
            Label2.Text = rd1[2].ToString();

            conn.Close();
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