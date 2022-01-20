using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VillageAdventure
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

            //SQLInteraction.SetConnectionString();

            SQLInteraction.CreateDatabase("VillageAdventure");
            SQLInteraction.CreateTable("VillageAdventure", "Login");
        }

     
        private void btn_login_Click_1(object sender, EventArgs e)
        {
            SQLInteraction.CheckTable("Login", txt_username.Text, txt_password.Text);
        }

        private void chck_showPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chck_showPassword.Checked == true)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_newaccount_Click_1(object sender, EventArgs e)
        {
            frm_newAccount frm = new frm_newAccount();
            frm.ShowDialog();
        }
    }
}
