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
        public static SqlConnection con = new SqlConnection();
        static SqlCommand cmd = new SqlCommand();
        private static SqlCommandBuilder cmdbuild = new SqlCommandBuilder();


        //Creates Database if not exists
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
                //MessageBox.Show("Database created!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        //Creates Table if not exists
        public static void CreateTable(string dbname, string tablename)
        {
            try
            {
                con.Open();
                cmd.CommandText = "use [" + dbname + "] if not exists(select * from sysobjects where name = '" + tablename + "') begin create table " + tablename + "(Id int NOT NULL Primary Key,username varchar(20),password varchar(70)) end";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Login Check for the password
        public static void CheckTable(string tablename, string v_username, string v_password)
        {
            string hashedpw;
            try
            {
                con.ConnectionString = @"Server=(localdb)\MSSQLLocalDB; Database=VillageAdventure";
                con.Open();
                cmd.CommandText = "Select password From Login Where username='" + v_username + "'";
                hashedpw = (string)cmd.ExecuteScalar();
                //hashedpw = v_password;
                if (hashedpw != null)
                {
                    if (BCrypt.CheckPassword(v_password, hashedpw))
                    {
                        MessageBox.Show("You are now logged in!", "Logged In!");
                    }
                    else
                    {
                        MessageBox.Show("Password is not matching!", "Password wrong!");
                    }
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //New Account inserts into the database 
        public static void InsertInto(string tablename, string v_username, string v_password)
        {

            try
            {
                con.ConnectionString = @"Server=(localdb)\MSSQLLocalDB; Database=VillageAdventure";
                con.Open();
                cmd.CommandText = "INSERT INTO " + tablename + "(username,password) VALUES('" + v_username + "', '" + v_password + "')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
