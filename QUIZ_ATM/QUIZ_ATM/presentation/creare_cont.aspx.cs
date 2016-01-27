using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QUIZ_ATM.conect;

namespace QUIZ_ATM
{
    public partial class creare_cont : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //creare cont
        protected void creare_Click(object sender, EventArgs e)
        {
            Response.Redirect("my_Profile.aspx");
        }
    }
}