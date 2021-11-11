using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace VillageAdventure
{
    class SQLInteraction
    {
        //string conStr = "";
        public static SqlConnection con = new SqlConnection();
        static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter sda = new SqlDataAdapter();
        private static SqlCommandBuilder cmdbuild = new SqlCommandBuilder();
        private static DataTable dt = new DataTable();


        public static void CreateDatabase(string dbname)
        {
            try
            {
                con.ConnectionString = @"Server=(localdb)\MSSQLLocalDB;";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "if not exists(select * from sys.databases where name = '" + dbname + "') begin create database[" + dbname + "] end";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();               
                MessageBox.Show("Database created!");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        
        public static void CreateTable(string dbname, string tablename)
        {
            try
            {
                con.Open();
                cmd.CommandText = "use [" + dbname + "] if not exists(select * from sysobjects where name = '" + tablename + "') begin create table " + tablename + "(Id int NOT NULL Primary Key,username varchar(50),password varchar(50)) end";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void InsertInto(string tablename)
        {

        }
    }
}
