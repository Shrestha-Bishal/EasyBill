using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Web;

namespace EasyBill
{
    /// <summary>
    /// This is a class Name "Connection_Class" to perform Insert, Update Delete Serch options
    /// Show Data in DataGridView and also Perform SqlDataReader Options.
    /// </summary>
    public class mydbConnection
    {
        string currentDBPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\lmslocaldb.mdf";
        //F:\RFID BY SIRnew\RFID_LMS\lmslocaldb.mdf

        string ConnectionString = null;
        SqlConnection con;

        public void OpenConection()
        {
            //ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+@"D:\notes\#Assignments and projects\EasyBill Project\Easy Bill program\Easy Bill\EasyBill.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
             // ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+@"D:\notes\#Assignments and projects\EasyBill Project\Easy Bill program\Easy Bill\EasyBillDatabase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
             // ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+@"C:\Users\Bishal\Documents\EasyBillDatabase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
              ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+@"C:\Users\Bishal\Documents\EasyBillDatabaseE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
             // ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+@"C:\Users\Bishal\Documents\EasyBillDatabaseE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            con = new SqlConnection(ConnectionString);
            con.Open();
        }


        public void CloseConnection()
        {
            con.Close();
        }


        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_,con);
            cmd.ExecuteNonQuery();
        }

        public void ExecuteCommand(SqlCommand cmd)
        {
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }
        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_,con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataAdapter DataAdapter(string Query_)
        {
            SqlDataAdapter sda = new SqlDataAdapter(Query_,con);
            return sda;
        }
        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
}