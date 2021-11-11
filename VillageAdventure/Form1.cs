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
        private int gravity = 15;
        private int force = 0;
        private int speed = 10;
        private bool playerOnFloor;
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
        }

        private void tmr_move_Tick(object sender, EventArgs e)
        {

            if (left && pbx_player.Left > 0)
            {
                pbx_player.Left -= speed;
            }
            if (right && pbx_player.Left + pbx_player.Width < ClientSize.Width)
            {
                pbx_player.Left += speed;
            }

            if (jump)
            {
                pbx_player.Top -= force;
                force -= 2;
            }
            if (pbx_player.Bounds.IntersectsWith(pbx_platform.Bounds))
            {
                pbx_player.Top = ClientSize.Height - pbx_player.Height - pbx_platform.Height;                
            }

        }
    }
}
