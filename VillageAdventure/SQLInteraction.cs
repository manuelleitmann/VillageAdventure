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

        public static void CheckDB()
        {
            try
            {
                SetConnectionString("DataSource=(Localdb)\\MSSQLLocalDB;Intergrated Security=SSPI;");
                con.Open();
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
