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
        buss BussNou = new buss();
        protected void Page_Load(object sender, EventArgs e)
        {
            //+++
            //verificare daca este logat sau nu
            //daca nu e logat ==> default.aspx
            Utilizatori Unou = new Utilizatori();
            Unou = BussNou.return_date_utiliz();
            Statistica SNou = BussNou.return_date_statistice();

            Label1.Text = Unou.Nume;
            Label2.Text = Unou.Prenume;
            Label3.Text = SNou.Medie.ToString();
        }

        // butonul de LOG OUT
        protected void logoutButton_Click(object sender, EventArgs e)
        {
            BussNou.logout_f();
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