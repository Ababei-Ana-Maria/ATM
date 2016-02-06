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
using System.Text;
using System.Windows;

using QUIZ_ATM.a;
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
        public static int punctaj = 0;
        public static int index = 0;
        public static int U = 0;
        public static int ID = 0;
        dbConnection conexiune = new dbConnection();
        public int retU()
        {
            return U;
        }
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
        public void adaugare_cont(string n, string p, string e, string pr)
        {
            if (retU() == 2)
            {
                var a = new[] { new SqlParameter("@num", n), new SqlParameter("@pren", p), new SqlParameter("@em", e), new SqlParameter("@par", pr) };
                string query = "INSERT INTO dbo.Utilizatori (Nume,Prenume,Mail,Parola) VALUES (@num,@pren,@em,@par)";
                conexiune.executeInsertQueryu(query, a);
            }
            else
            {
                var ad = new[] { new SqlParameter("@num", n), new SqlParameter("@pren", p), new SqlParameter("@em", e), new SqlParameter("@par", pr) };
                string query_a = "INSERT INTO dbo.Admin (nume,prenume,mail,parola) VALUES (@num,@pren,@em,@par)";
                conexiune.executeInsertQueryu(query_a, ad);
            }


        }
        public SqlDataReader returnare_intrebari(string v)
        {
            string query = null;
            Random ran = new Random();
            int ranN;
            var par = new[] { new SqlParameter() };
            if (v == "toate")
            {
                query = "SELECT * FROM dbo.Intrebari";
                par = null;
                Intrebari c = new Intrebari();

            }
            else if (v == "random")
            {
                SqlDataReader lung;
                int ab = 0;
                lung = conexiune.executeSelectQueryt("SELECT COUNT(*) FROM dbo.Intrebari", null);
                while (lung.Read())
                {
                    ab = Int32.Parse(lung[0].ToString());
                }
                lung.Close();
                ranN = ran.Next(1, ab);
                par = new[] { new SqlParameter("@random", ranN) };
                query = "SELECT * FROM dbo.Intrebari INNER JOIN dbo.Raspunsuri ON dbo.Intrebari.id_intrebare=dbo.Raspunsuri.id_intrebare WHERE dbo.Intrebari.id_intrebare= @random ";


            }
            SqlDataReader crr;
            crr = conexiune.executeSelectQueryt(query, par);
            return crr;


        }
        public void adugire_intr(string text_intr, string r_1, string r_2, string r_3, string r_4, int r_c)
        {
            string x = text_intr;
            string r1 = r_1;
            string r2 = r_2;
            string r3 = r_3;
            string r4 = r_4;

            var b = new[] { new SqlParameter("@r1", r1), new SqlParameter("@r2", r2), new SqlParameter("@r3", r3), new SqlParameter("@r4", r4) };
            var a = new[] { new SqlParameter("@x", x), new SqlParameter("@r_c", r_c) };
            string sql_r = "INSERT INTO dbo.Raspunsuri (A,B,C,D) VALUES (@r1,@r2,@r3,@r4) ";
            string sql_i = "INSERT INTO dbo.Intrebari (text,varianta_corecta) VALUES (@x,@r_c)";
            conexiune.executeInsertQueryt(sql_i, a);
            conexiune.executeInsertQueryt(sql_r, b);
        }

        public class incrementare
        {

            static int a = 2;
            public int return_nr()
            {

                return a++;
            }

            public void set0()
            {
                a = 2;
            }

        }

        public void verif_raspuns(int varianta, int index)
        {

            SqlDataReader b;
            b = returnare_intrebari("toate");
            while (b.Read())
            {
                if (index == Int32.Parse(b[0].ToString()))
                {
                    if (varianta == Int32.Parse(b[2].ToString()))
                    {
                        punctaj++;
                    }
                }
            }
            b.Close();
        }

        public int r_P()
        {
            return punctaj;
        }
        public void set_ind(int i)
        {
            index = i;
        }
        public int ret_ind()
        {
            return index;
        }
        public Admin return_date_admin()
        {
            conexiune.openConnectionu();
            Admin AdminNou = new Admin();
            SqlDataReader rdr = conexiune.executeSelectQueryu("SELECT * FROM dbo.Admin WHERE id_admin='" + ID.ToString() + "';", null);
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    AdminNou.id_admin = Int32.Parse(rdr[0].ToString());
                    AdminNou.Nume = rdr[1].ToString();
                    AdminNou.Prenume = rdr[2].ToString();
                    AdminNou.mail = rdr[3].ToString();
                    AdminNou.Parola = rdr[4].ToString();
                }
            }
            rdr.Close();
            return AdminNou;
        }
        public SqlDataReader returnare_clasament()
        {
            string query = "SELECT dbo.Utilizatori.Nume,dbo.Utilizatori.Prenume,dbo.Statistica.Medie,dbo.Statistica.Nr_teste_parcurse FROM dbo.Utilizatori INNER JOIN dbo.Statistica ON dbo.Utilizatori.id_utilizator=dbo.Statistica.id_utilizator ";
            var p = new[] { new SqlParameter() };
            p = null;
            SqlDataReader ok;
            ok = conexiune.executeSelectQueryu(query, p);
            return ok;
        }

    }
}