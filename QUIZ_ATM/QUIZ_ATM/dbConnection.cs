using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QUIZ_ATM.conect
{
    public class dbConnection
    {
        private SqlDataAdapter myAdapter;
        //variabile pentru conexiunile la teste si utilizatori
        private SqlConnection connt;
        private SqlConnection connu;
        //initializare conexiuni cu bazele de date
        public dbConnection()
        {
            myAdapter = new SqlDataAdapter();
            connt = new SqlConnection(ConfigurationManager.ConnectionStrings["quiz_t"].ConnectionString);
            connu = new SqlConnection(ConfigurationManager.ConnectionStrings["quiz_u"].ConnectionString);
        }
        //verificam daca conexiunea la Teste este deschisa daca nu e ,o deschide
        private SqlConnection openConnectiont()
        {
            if (connt.State == ConnectionState.Closed || connt.State == ConnectionState.Broken)
            {
                connt.Open();
            }
            return connt;
        }
        //verificam daca conexiunea la Utilizatori este deschisa daca nu e ,o deschide
        private SqlConnection openConnectionu()
        {
            if (connu.State == ConnectionState.Closed || connu.State == ConnectionState.Broken)
            {
                connu.Open();
            }
            return connu;
        }
        //Select Query din Teste si Utilizatori
        public DataTable executeSelectQueryt(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommandt = new SqlCommand();
            DataTable dataTablet = new DataTable();
            dataTablet = null;
            DataSet dst = new DataSet();
            try
            {
                myCommandt.Connection = openConnectiont();
                myCommandt.CommandText = _query;
                myCommandt.Parameters.AddRange(sqlParameter);
                myCommandt.ExecuteNonQuery();                
                myAdapter.SelectCommand = myCommandt;
                myAdapter.Fill(dst);
                dataTablet = dst.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {
            }
            return dataTablet;
        }
        public DataTable executeSelectQueryu(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommandu = new SqlCommand();
            DataTable dataTableu = new DataTable();
            dataTableu = null;
            DataSet dsu = new DataSet();
            try
            {
                myCommandu.Connection = openConnectiont();
                myCommandu.CommandText = _query;
                myCommandu.Parameters.AddRange(sqlParameter);
                myCommandu.ExecuteNonQuery();                
                myAdapter.SelectCommand = myCommandu;
                myAdapter.Fill(dsu);
                dataTableu = dsu.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {
            }
            return dataTableu;
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
            return true;
        }
    }
}