using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QUIZ_ATM.a;
using QUIZ_ATM.bussiness;
using System.Data;
using System.Data.SqlClient;

namespace QUIZ_ATM
{
    public partial class modificare_intrebare : System.Web.UI.Page
    {
        bussiness.buss b = new bussiness.buss();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataReader read;

            read = b.returnare_intrebari("toate");
            while (read.Read())
            {
                string complet = read[0].ToString() + " " + read[1].ToString();
                ListBox1.Items.Add(complet);
            }
            read.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            b.logout_f();
            Response.Redirect("Default.aspx");
        }

        protected void sterge_Click(object sender, EventArgs e)
        {
            int intrebare = Int32.Parse(TextBox1.Text);
            b.stergere_intrebare(intrebare);
            Response.Redirect("modificare_intrebare.aspx");
        }
    }
}