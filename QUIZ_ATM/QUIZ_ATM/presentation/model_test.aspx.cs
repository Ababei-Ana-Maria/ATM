using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QUIZ_ATM.a;
using QUIZ_ATM.bussiness;
using System.Windows;
using System.Data;
using System.Data.SqlClient;



namespace QUIZ_ATM
{


    public partial class model_test : System.Web.UI.Page
    {

        buss.incrementare nr = new buss.incrementare();
        bussiness.buss obj = new bussiness.buss();


        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = obj.r_P().ToString();

            int numar = nr.return_nr() / 2;

            if (numar <= 10)
            {
                questionnr.Text = numar.ToString();
                SqlDataReader a;
                a = obj.returnare_intrebari("random");
                while (a.Read())
                {
                    obj.set_ind(Int32.Parse(a[0].ToString()));
                    question.Text = a[1].ToString();
                    answer1.Text = a[4].ToString();
                    answer2.Text = a[5].ToString();
                    answer3.Text = a[6].ToString();
                    answer4.Text = a[7].ToString();
                }
                a.Close();
            }
            else
            {
                nr.set0();
                Response.Redirect("clasament.aspx");
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            obj.logout_f();
            Response.Redirect("Default.aspx");
        }
        protected void Exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("my_Profile.aspx");
        }
        protected void Next_Click(object sender, EventArgs e)
        {
            Response.Redirect("model_test.aspx");

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                obj.verif_raspuns(1, obj.ret_ind());
            }

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                obj.verif_raspuns(2, obj.ret_ind());
            }
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == true)
            {
                obj.verif_raspuns(3, obj.ret_ind());
            }
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox4.Checked == true)
            {
                obj.verif_raspuns(4, obj.ret_ind());
            }
        }
    }
}