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
        static SqlConnection con = new SqlConnection();
        static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter sda = new SqlDataAdapter();
        private static SqlCommandBuilder cmdbuilder = new SqlCommandBuilder();
        private static DataTable datTab = new DataTable();


        //Checks if Connection to Database is possible
        public static bool TryConnection()
        {
            try
            {
                con.Open();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static DataTable GetDataTable(string command)
        {
            try
            {
                datTab = new DataTable();
                sda.SelectCommand = new SqlCommand(command, con);
                sda.Fill(datTab);
                return datTab;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                datTab = new DataTable();
                return datTab;
            }
        }
    }
}
