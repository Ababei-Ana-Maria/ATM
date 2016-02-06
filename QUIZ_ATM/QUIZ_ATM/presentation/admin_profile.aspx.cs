using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QUIZ_ATM.a;
//
using QUIZ_ATM.bussiness;

namespace QUIZ_ATM
{
    public partial class admin_profile : System.Web.UI.Page
    {
        bussiness.buss obj = new bussiness.buss();
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin Anou = new Admin();
            Anou = obj.return_date_admin();
            label_nume.Text = Anou.Nume.ToString() + " " + Anou.Prenume.ToString();

        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            obj.logout_f();
            Response.Redirect("Default.aspx");
        }

        protected void adminadd_Click(object sender, EventArgs e)
        {
            Response.Redirect("creare_cont.aspx");
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