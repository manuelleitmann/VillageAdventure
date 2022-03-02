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
    public partial class GameOverPingPong : Form
    {
        public GameOverPingPong()
        {
            InitializeComponent();
        }

        private void btn_restartpp_Click(object sender, EventArgs e)
        {
            PingPongGame ppg = new PingPongGame();
            ppg.Show();
            this.Close();
        }

        private void btn_menupp_Click(object sender, EventArgs e)
        {

        }

        private void btn_closepp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
