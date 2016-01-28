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
            //+++
            //verificare daca este logat sau nu
            //daca nu e logat ==> default.aspx
            SqlConnection conn=new SqlConnection(ConfigurationManager.ConnectionStrings["quiz_u"].ConnectionString);

            conn.Open();

            string s = "SELECT * FROM dbo.Utilizatori WHERE id_utilizator=1"; //pune id-ul utilizatorului cerut
            SqlCommand c1 = new SqlCommand(s, conn);
            SqlDataReader rd1 = c1.ExecuteReader();
            rd1.Read();
            Label1.Text = rd1[1].ToString();
            Label2.Text = rd1[2].ToString();
            Label6.Text = rd1[5].ToString();

            conn.Close();

            conn.Open();

            string s2 = "SELECT * FROM dbo.Statistica WHERE id_utilizator=1"; //pune id-ul utilizatorului cerut
            SqlCommand c2 = new SqlCommand(s2, conn);
            SqlDataReader rd2 = c2.ExecuteReader();
            rd2.Read();
            Label3.Text = rd2[1].ToString();
            Label4.Text = rd2[2].ToString();
            Label5.Text = rd2[3].ToString();

            conn.Close();
        }
        // butonul de LOG OUT
        protected void logoutButton_Click(object sender, EventArgs e)
        {
            //+++
            //tip->0;
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