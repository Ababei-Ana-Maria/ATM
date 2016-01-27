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

namespace QUIZ_ATM
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Log in
        protected void login_Click(object sender, EventArgs e)
        {
            // verificare conexiune- MERGE!!!!!
            ////SqlConnection conn =new SqlConnection(ConfigurationManager.ConnectionStrings["quiz_t"].ConnectionString );
            ////Label1.Text = conn.ToString();
            ////conn.Open();
            ////string q = "SELECT text FROM dbo.Intrebari";
            ////SqlCommand c1 = new SqlCommand(q, conn);
            ////SqlDataReader rd1 = c1.ExecuteReader();
            ////while (rd1.Read())
            ////{
            ////    Label1.Text = rd1[0].ToString();
            ////}
            // trebuie sa verificam daca e admin sau nu ca sa stim la ce pagina sa facem redirectarea
            Response.Redirect("my_Profile.aspx");
        }
        //Guest
        protected void guestmode_Click(object sender, EventArgs e)
        {
            Response.Redirect("my_Profile.aspx");
        }
        //Creare cont
        protected void crearecont_Click(object sender, EventArgs e)
        {
            Response.Redirect("creare_cont.aspx");
        }
    }
}