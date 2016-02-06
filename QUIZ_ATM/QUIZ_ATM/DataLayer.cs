using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;

namespace QUIZ_ATM.a
{
    public class dbConnection
    {

        private SqlDataAdapter myAdapter;
        //variabile pentru conexiunile la teste si utilizatori
        public SqlConnection connt;
        public SqlConnection connu;
        //initializare conexiuni cu bazele de date
        public dbConnection()
        {
            myAdapter = new SqlDataAdapter();
            connt = new SqlConnection(ConfigurationManager.ConnectionStrings["quiz_t"].ConnectionString);
            connu = new SqlConnection(ConfigurationManager.ConnectionStrings["quiz_u"].ConnectionString);
        }
        //verificam daca conexiunea la Teste este deschisa daca nu e ,o deschide
        public SqlConnection openConnectiont()
        {
            if (connt.State == ConnectionState.Closed || connt.State == ConnectionState.Broken)
            {
                connt.Open();
            }
            return connt;
        }
        //verificam daca conexiunea la Utilizatori este deschisa daca nu e ,o deschide
        public SqlConnection openConnectionu()
        {
            if (connu.State == ConnectionState.Closed || connu.State == ConnectionState.Broken)
            {
                connu.Open();
            }
            return connu;
        }
        //Select Query din Teste si Utilizatori
        public SqlDataReader executeSelectQueryt(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommandt = new SqlCommand();
            SqlDataReader rdr;
            try
            {
                myCommandt.Connection = openConnectiont();
                myCommandt.CommandText = _query;
                if (sqlParameter != null)
                {
                    myCommandt.Parameters.AddRange(sqlParameter);
                }
                rdr = myCommandt.ExecuteReader();

            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {
            }
            //     string s = rdr[0].ToString();
            return rdr;
        }

        public SqlDataReader executeSelectQueryu(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommandu = new SqlCommand();
            SqlDataReader rdr;
            try
            {
                myCommandu.Connection = openConnectionu();
                myCommandu.CommandText = _query;
                if (sqlParameter != null)
                {
                    myCommandu.Parameters.AddRange(sqlParameter);
                }
                rdr = myCommandu.ExecuteReader();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {
            }
            return rdr;
        }
        // Insert Query in Teste si Utilizatori
        public bool executeInsertQueryt(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommandt = new SqlCommand();
            try
            {
                myCommandt.Connection = openConnectiont();
                myCommandt.CommandText = _query;
                myCommandt.Parameters.AddRange(sqlParameter);
                myAdapter.InsertCommand = myCommandt;
                myCommandt.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }
        public bool executeInsertQueryu(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommandu = new SqlCommand();
            try
            {
                myCommandu.Connection = openConnectionu();
                myCommandu.CommandText = _query;
                myCommandu.Parameters.AddRange(sqlParameter);
                myAdapter.InsertCommand = myCommandu;
                myCommandu.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }
        // Update Query pentru Teste si Utilizatori
        public bool executeUpdateQueryt(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommandt = new SqlCommand();

            try
            {
                myCommandt.Connection = openConnectiont();
                myCommandt.CommandText = _query;
                myCommandt.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCommandt;
                myCommandt.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            myCommandt.Parameters.Clear();
            return true;
        }
        public bool executeUpdateQueryu(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommandu = new SqlCommand();

            try
            {
                myCommandu.Connection = openConnectionu();
                myCommandu.CommandText = _query;
                myCommandu.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCommandu;
                myCommandu.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            myCommandu.Parameters.Clear();
            return true;
        }
        public void closeConnection()
        {
            if (connu.State == ConnectionState.Open)
            {
                connu.Close();
            }
            if (connt.State == ConnectionState.Open)
            {
                connt.Close();
            }
        }
    }
}