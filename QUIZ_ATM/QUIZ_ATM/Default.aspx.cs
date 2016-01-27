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
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["quiz_u"].ConnectionString);
            
            conn.Open();
            string q = "SELECT * FROM dbo.Admin";
            SqlCommand c1 = new SqlCommand(q, conn);
            SqlDataReader rd1 = c1.ExecuteReader();
            var user = TextBox2.Text;
            var pass = TextBox4.Text;
            if (user.Length == 0 || pass.Length == 0)
            {
                Label1.Text = "NU ATI INTRODUS USER SAU PAROLA !!!";
            }
            while (rd1.Read())
            {
                if (user == rd1[1].ToString()){
                    if (pass == rd1[4].ToString())
                    {
                        Response.Redirect("admin_profile.aspx");
                        break;
                    }
                }
                //else Response.Redirect("my_Profile.aspx");
            }
            // trebuie sa verificam daca e admin sau nu ca sa stim la ce pagina sa facem redirectarea
           
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