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
        public static SqlConnection con = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Integrated Security=SSPI;");
        static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter sda = new SqlDataAdapter();
        private static SqlCommandBuilder cmdbuild = new SqlCommandBuilder();
        private static DataTable dt = new DataTable();

        public static bool CheckDB()
        {
            bool result = false;
            string dbcmd;

            try
            {
                dbcmd = string.Format("SELECT 'username' FROM sys.databases WHERE Name = 'VillageAdventure';");

                //SetConnectionString("DataSource=(Localdb)\\MSSQLLocalDB;Intergrated Security=SSPI;");
                using (con)
                {
                    using (SqlCommand com = new SqlCommand(dbcmd, con))
                    {
                        con.Open();

                        object resultObj = com.ExecuteScalar();

                        int databaseID = 0;

                        if (resultObj != null)
                        {
                            int.TryParse(resultObj.ToString(), out databaseID);
                        }

                        con.Close();

                        result = databaseID > 0;
                    }
                }
                MessageBox.Show("Database exist!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            return result;
        }

        public static bool CreateDatabase(string dbname)
        {
            String CreateDatabase;
            
            bool IsExits = CheckDB(); //Check database exists in sql server.
            if (!IsExits)
            {
                CreateDatabase = "CREATE DATABASE " + dbname + " ; ";
                SqlCommand command = new SqlCommand(CreateDatabase, con);
                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Database created!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
                return true;
            }
            return false;
        }

        public static string GetConnectionString()
        {
            return con.ConnectionString;
        }

        public static void SetConnectionString(string setConStr)
        {
            con.ConnectionString = GetConnectionString();
            cmd.Connection = con;
        }

        
        
        public static void Execute(string command)
        {
            try
            {
                con.Open();
                cmd.CommandText = command;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
