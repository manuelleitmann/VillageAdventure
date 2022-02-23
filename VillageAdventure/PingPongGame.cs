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
    public partial class PingPongGame : Form
    {
        private int time = 0;
        public PingPongGame()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        //private void KeyDown(object sender, KeyEventArgs e)
        //{

        //}

        //private void KeyUp(object sender, KeyEventArgs e)
        //{

        //}

        private void PingPongGame_Load(object sender, EventArgs e)
        {

        }

        private void tmr_moveBall_Tick(object sender, EventArgs e)
        {
            time++;
            lbl_time.Text = time.ToString();
        }

        private void PingPongGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                PingPongGame ppg = new PingPongGame();
                ppg.Show();
                this.Hide();
            }
            if (e.KeyCode == Keys.C)
            {
                //this.Close();//open the startform afterwards
                Application.Exit();
            }
            if(e.KeyCode == Keys.W)
            {
                pbx_platformLeft.Top -= 20;
            }
            if(e.KeyCode == Keys.S)
            {
                pbx_platformLeft.Top += 20;
            }
            if (e.KeyCode == Keys.Up)
            {
                pbx_platformRight.Top -= 20;
            }
            if (e.KeyCode == Keys.Down)
            {
                pbx_platformRight.Top += 20;
            }
        }

        private void PingPongGame_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
