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
    public partial class frm_JumpAndRun : Form
    {
        #region variables
        private bool left = false;
        private bool right = false;
        private bool jump = false;
        private int gravity = 35;
        private int force = 0;
        private int speed = 10;
        private bool playerOnFloor;
        #endregion
        #region Lists
        List<PictureBox> list = new List<PictureBox>();
        #endregion
        public frm_JumpAndRun()
        {
            InitializeComponent();
        }


        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }
            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = gravity;
                }
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            left = false;
            right = false;
        }

        private void frm_JumpAndRun_Load(object sender, EventArgs e)
        {
            pbx_player.Location = new Point(0, ClientSize.Height - pbx_player.Height - pbx_platform.Height);
            this.DoubleBuffered = true;//makes the movement of the player smoother
                                       //set image
            #region List
            
            list.Add(pbx_platform);
            list.Add(pbx_platform2);

            #endregion
        }

        private void tmr_move_Tick(object sender, EventArgs e)
        {
            #region FormDetection
            if (left && pbx_player.Left > 0)//left
            {
                pbx_player.Left -= speed;
            }
            else if (right && pbx_player.Left + pbx_player.Width < ClientSize.Width)//right
            {
                pbx_player.Left += speed;
            }
            if (jump)//jump
            {
                pbx_player.Top -= force;
                force -= 2;
            }
            if (pbx_player.Top +pbx_player.Height >= ClientSize.Height)
            {
                pbx_player.Top = ClientSize.Height - pbx_player.Height;
            }
            #endregion
            playerOnFloor = false;
            foreach(PictureBox p in list)
            {
                if(pbx_player.Bounds.IntersectsWith(p.Bounds) && pbx_player.Top > p.Top - pbx_player.Height +2 && pbx_player.Top < p.Bottom && p.Right-10 > pbx_player.Left)//-10
                {
                    pbx_player.Left = p.Left - pbx_player.Width;
                    left = false;
                }
                else if (pbx_player.Bounds.IntersectsWith(p.Bounds) && pbx_player.Top > p.Top - pbx_player.Height +2 && pbx_player.Top < p.Bottom && p.Left+10 > pbx_player.Right)//+10
                {
                    pbx_player.Left = p.Right;
                    left = false;
                }
                else if(pbx_player.Bounds.IntersectsWith(p.Bounds) && pbx_player.Right > p.Left && pbx_player.Left < p.Right && pbx_player.Top < p.Top)
                {
                    pbx_player.Top = p.Top - pbx_player.Height +1;
                    playerOnFloor = true;
                    jump = false;
                }
                else if(jump == false)
                {
                    pbx_player.Top += 1;
                }
                else if(jump && pbx_player.Bounds.IntersectsWith(p.Bounds) && force >= 0)
                {
                    force = 0;
                }
            }            
        }
    }
}
