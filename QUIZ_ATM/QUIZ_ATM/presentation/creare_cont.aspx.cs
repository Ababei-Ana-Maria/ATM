using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QUIZ_ATM.a;

namespace QUIZ_ATM
{
    public partial class creare_cont : System.Web.UI.Page
    {
        bussiness.buss util = new bussiness.buss();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //creare cont
        protected void creare_Click(object sender, EventArgs e)
        {
            string nume = TextBox1.Text;
            string prenume = TextBox2.Text;
            string email = TextBox4.Text;
            string parola = TextBox3.Text;
            string vparola = TextBox5.Text;
            if (parola != vparola)
            {
                Label1.Text = "Parola gresita!";
            }
            else
            {
                util.adaugare_cont(nume, prenume, email, parola);
                Response.Redirect("Default.aspx");
            }
        }
    }
}