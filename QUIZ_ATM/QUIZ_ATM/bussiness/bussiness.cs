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

using QUIZ_ATM.bussiness;
using QUIZ_ATM;

// includeri pentru Entity
using System.Data.Entity;
using System.Data.EntityClient;
using System.Data.Mapping;
using System.Data.Entity.Infrastructure;
using System.Data.EntityModel;

namespace QUIZ_ATM.bussiness
{
    public class buss
    {
        public int logare(string u, string p)
        {
            // ne conectam la bd
            conexiune.openConnectionu();
            string q = "SELECT * FROM dbo.Admin";
            SqlCommand c1 = new SqlCommand(q, conexiune.connu);
            SqlDataReader rd1 = c1.ExecuteReader();
            while (rd1.Read())
            {
                if (u == rd1[1].ToString())
                {
                    if (p == rd1[4].ToString())
                    {
                        ID = Int32.Parse(rd1[0].ToString());
                        return 1;
                    }
                }
            }
            // trebuie sa verificam daca e admin sau nu ca sa stim la ce pagina sa facem redirectarea
            if (rd1 != null)
            {
                rd1.Close();
            }
            string q2 = "SELECT * FROM dbo.Utilizatori";
            SqlCommand c2 = new SqlCommand(q2, conexiune.connu);
            SqlDataReader rd2 = c2.ExecuteReader();
            while (rd2.Read())
            {
                if (u == rd2[1].ToString())
                {
                    if (p == rd2[4].ToString())
                    {
                        ID = Int32.Parse(rd2[0].ToString());
                        return 2;
                    }
                }
            }
            if (rd2 != null)
            {
                rd2.Close();
            }

            conexiune.connu.Close();
            return 3;

        }
    }
}