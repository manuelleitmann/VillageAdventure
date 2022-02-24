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
        private int platformSpeed = 20;
        //Ball
        private int ballWidth = 20;
        private int ballHeight = 20;
        private int locationX;
        private int locationY = 0;
        private int speedBallX = 5;
        private int speedBallY = 5;
        public PingPongGame()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void PingPongGame_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            locationX = rnd.Next(0, ClientSize.Width);   
        }

        private void tmr_moveBall_Tick(object sender, EventArgs e)
        {
            //moveBall
            locationX += speedBallX;
            if(locationX < 0)
            {
                speedBallX = -speedBallX;
            }
            else if(locationX + ballWidth > ClientSize.Width)
            {
                speedBallX = -speedBallX;
            }
            locationY += speedBallY;
            if(locationY < 0)
            {
                speedBallY = -speedBallY;
            }
            if(locationY == ClientSize.Height)
            {
                MessageBox.Show(".");
                speedBallY += speedBallY;
            }
            Refresh();          
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
                Application.Exit();
            }
            #region movement platforms
            if (e.KeyCode == Keys.W)
            {
                pbx_platformLeft.Top -= platformSpeed;
            }
            else if(e.KeyCode == Keys.Up)
            {
                pbx_platformRight.Top -= platformSpeed;
            }
            if(e.KeyCode == Keys.S)
            {
                pbx_platformLeft.Top += platformSpeed;
            }
            else if(e.KeyCode == Keys.Down)
            {
                pbx_platformRight.Top += platformSpeed;
            }
            #endregion
        }

        private void PingPongGame_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void PingPongGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(Brushes.Blue, locationX, locationY, ballWidth, ballHeight);
            e.Graphics.DrawEllipse(Pens.Black, locationX, locationY, ballWidth, ballHeight);
        }

        private void tmr_time_Tick(object sender, EventArgs e)
        {
            time++;
            lbl_time.Text = time.ToString();
        }
    }
}
