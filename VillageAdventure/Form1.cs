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
            if (e.KeyCode == Keys.R)
            {
                frm_JumpAndRun jar = new frm_JumpAndRun();
                jar.Show();
                this.Hide();
            }
            if (e.KeyCode == Keys.C)
            {
                this.Close();//open the startform afterwards
            }
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }
            
            if (e.KeyCode == Keys.Space)
            {
                    jump = true;
                    force = gravity;
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
            //if(pbx_player.Top + pbx_player.Height == 0)
            //{
                if (jump == true)//jump
                {
                    pbx_player.Top -= force;
                    force -= 2;
                }
            //}         
            if (pbx_player.Top + pbx_player.Height >= ClientSize.Height)
            {
                pbx_player.Top = ClientSize.Height - pbx_player.Height;
            }
            if(pbx_player.Top <= 0)
            {
                pbx_player.Top = 0;
            }

            #endregion
            //playerOnFloor = false;
            #region ColissionDetection
            foreach (PictureBox p in list)
            {
                //top
                if (pbx_player.Bounds.IntersectsWith(p.Bounds) && pbx_player.Top + pbx_player.Height >= p.Top)
                {
                    //MessageBox.Show("aha", "Interesting", MessageBoxButtons.OK);
                    pbx_player.Top = p.Top - pbx_player.Height;
                }
                //down side of platform
                else dif (pbx_player.Bounds.IntersectsWith(p.Bounds) && pbx_player.Top <= p.Top + p.Height)
                {
                    MessageBox.Show("aha", "Interesting", MessageBoxButtons.OK);
                    pbx_player.Top = p.Top + p.Height;
                }

                if (jump == false)
                {
                    pbx_player.Top += 1;
                }
                if(jump && pbx_player.Bounds.IntersectsWith(p.Bounds) && force >= 0)
                {
                    force = 0;
                }
                #endregion
            }
        }
    }
}
