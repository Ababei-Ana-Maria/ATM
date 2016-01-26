using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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