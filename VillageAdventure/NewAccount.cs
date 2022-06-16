using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageAdventure
{
    public partial class frm_newAccount : Form
    {
        public frm_newAccount()
        {
            InitializeComponent();
        }

        private void chck_showPasswordRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_showPasswordRegister.Checked == true)
            {
                txt_password1.UseSystemPasswordChar = false;
                txt_password2.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password1.UseSystemPasswordChar = true;
                txt_password2.UseSystemPasswordChar = true;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string salt;
            string hashedpw;

            if (txt_password1.Text == txt_password2.Text)
            {
                salt = BCrypt.GenerateSalt();
                
                hashedpw = BCrypt.HashPassword(txt_password2.Text, salt);

                SQLInteraction.InsertInto("Login", txt_usernameRegister.Text, hashedpw);

                MessageBox.Show("New Account created!", "Account created!");
            }
            else
            {
                MessageBox.Show("Passwords not matching", "Password Error!");
            }
            
        }

        private void frm_newAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
