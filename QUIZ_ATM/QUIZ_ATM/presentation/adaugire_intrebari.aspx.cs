using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QUIZ_ATM.a;

namespace QUIZ_ATM
{
    public partial class adaugire_intrebari : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void adauga_intrebare_Click(object sender, EventArgs e)
        {
            bussiness.buss b = new bussiness.buss();
            int x = Int32.Parse(TextBox6.Text);
            b.adugire_intr(Text_intr.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, x);
            Response.Redirect("Default.aspx");
        }
        protected void LogOut_Click(object sender, EventArgs e)
        {

            Response.Redirect("Default.aspx");
        }
    }
}