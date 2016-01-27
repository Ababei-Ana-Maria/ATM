using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QUIZ_ATM.conect;

namespace QUIZ_ATM
{
    public partial class admin_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void adminadd_Click(object sender, EventArgs e)
        {

        }

        protected void questionadd_Click(object sender, EventArgs e)
        {
            Response.Redirect("adaugire_intrebari.aspx");
        }

        protected void modifyquestion_Click(object sender, EventArgs e)
        {
            Response.Redirect("modificare_intrebare.aspx");
        }
    }
}