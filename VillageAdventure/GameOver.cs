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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            frm_JumpAndRun jar = new frm_JumpAndRun();
            jar.Show();
            this.Hide();
        }
 
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            //frm_main main = new frm_main();
            //main.Show();
            //this.Hide();
        }
    }
}
