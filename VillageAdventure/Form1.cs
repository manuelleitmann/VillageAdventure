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
        private int gravity = 25;
        private int force = 0;
        private int speed = 10;
        private bool playerOnFloor;
        PictureBox pbx_randomPlatform = new PictureBox();//first platform
        PictureBox pbx_newPlatform = new PictureBox();//second platform
        PictureBox pbx_newPlatform2 = new PictureBox();//third platform
        PictureBox pbx_newPlatform3 = new PictureBox();//fourth platform
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
                //this.Close();//open the startform afterwards
                Application.Exit();
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
            pbx_player.Location = new Point(0, ClientSize.Height - pbx_player.Height);
            this.DoubleBuffered = true;//makes the movement of the player smoother
            
            #region random Platforms
            Random rnd = new Random();                     
            
            int platformPositionHeight = rnd.Next(0, 591 - pbx_randomPlatform.Height);//create first platform
            pbx_randomPlatform.BackColor = Color.Black;
            pbx_randomPlatform.Size = new Size(100, 20);
            pbx_randomPlatform.Location = new Point(1000, platformPositionHeight);
            pbx_randomPlatform.Tag = "platform";
            pbx_randomPlatform.Visible = true;
            Controls.Add(pbx_randomPlatform);
            #endregion
            pbx_collisionSpawnEnd.Location = new Point(0,-1);//set new point outside of the form
            pbx_reEnableEnd.Location = new Point(-110, -1);//set new point to set the pbx_collisionSpawnEnd to the old position
            #region List
            
            list.Add(pbx_platform2);
            list.Add(pbx_randomPlatform);
            list.Add(pbx_newPlatform);
            list.Add(pbx_newPlatform2);
            list.Add(pbx_newPlatform3);
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
            if (jump == true)//jump
            {
                pbx_player.Top -= force;
                force -= 2;
            }      
            if (pbx_player.Top + pbx_player.Height >= ClientSize.Height)
            {
                pbx_player.Top = ClientSize.Height - pbx_player.Height;
            }
            if(pbx_player.Top <= 0)
            {
                pbx_player.Top = 0;
            }
            DoubleBuffered = true;
            #endregion
            
            #region ColissionDetection
            foreach (PictureBox p in list)
            {
                //top
                if (pbx_player.Bounds.IntersectsWith(p.Bounds) && pbx_player.Top + pbx_player.Height >= p.Top && pbx_player.Left >= p.Left && pbx_player.Left + pbx_player.Width <= p.Left + p.Width)
                {
                    //MessageBox.Show("aha", "Interesting", MessageBoxButtons.OK);
                    pbx_player.Top = p.Top - pbx_player.Height;
                }
                //left side of the platform
                if (pbx_player.Bounds.IntersectsWith(p.Bounds) && pbx_player.Left + pbx_player.Width >= p.Left && pbx_player.Left <= p.Left + p.Width)
                {
                    //pbx_player.Left = p.Left - pbx_player.Width;
                    right = false;
                }
                //right side of the platform
                if (pbx_player.Bounds.IntersectsWith(p.Bounds) && pbx_player.Left <= p.Left + p.Width/* && pbx_player.Left >= p.Left + p.Width - 1*/)
                {
                    //pbx_player.Left = p.Left + p.Width;
                    left = false;
                }
                if (jump == false)
                {
                    pbx_player.Top += 1;
                }

                if (jump && pbx_player.Bounds.IntersectsWith(p.Bounds) && force >= 0)
                {
                    force = 0;
                }
                #endregion
            }
        }

        private void tmr_movePlatforms_Tick(object sender, EventArgs e)
        {
            //if (pbx_randomPlatform.Bounds.IntersectsWith(pbx_collisionSpawnEnd.Bounds))//spawn random platform again if it is on the end -->black platform
            //{
            //    Random rnd = new Random();
            //    int platformPositionHeight = rnd.Next(0, 591 - pbx_randomPlatform.Height);
            //    pbx_randomPlatform.BackColor = Color.Black;
            //    pbx_randomPlatform.Size = new Size(100, 20);
            //    pbx_randomPlatform.Location = new Point(1000, platformPositionHeight);
            //    pbx_randomPlatform.Tag = "platform";
            //    pbx_randomPlatform.Visible = true;
            //    Controls.Add(pbx_randomPlatform);
            //    pbx_collisionSpawnEnd.Location = new Point(800, 800);
            //}
            if(pbx_randomPlatform.Left < 0)
            {
                pbx_randomPlatform.Left = ClientSize.Width + pbx_randomPlatform.Width;
                Random rnd = new Random();
                pbx_randomPlatform.Top = rnd.Next(0, 591 - pbx_randomPlatform.Height);
            }
            //if (pbx_randomPlatform.Bounds.IntersectsWith(pbx_reEnableEnd.Bounds))
            //{
            //    pbx_collisionSpawnEnd.Location = new Point(0, -1);
            //}

            pbx_randomPlatform.Left -= 7;//for the first platform
            DoubleBuffered = true;

            if (pbx_randomPlatform.Bounds.IntersectsWith(pbx_collisionSpawnNew.Bounds))//spawn blue platform
            {
                Random rnd = new Random();
                int platformPositionHeight = rnd.Next(0, 591 - pbx_newPlatform.Height);
                pbx_newPlatform.BackColor = Color.Blue;
                pbx_newPlatform.Size = new Size(100, 20);
                pbx_newPlatform.Location = new Point(1000, platformPositionHeight);
                pbx_newPlatform.Tag = "platform";
                pbx_newPlatform.Visible = true;
                Controls.Add(pbx_newPlatform);
                pbx_collisionSpawnNew.Location = new Point(800,800);//set new location so the platforms don't spawn too often
            }
            
            if (pbx_randomPlatform.Bounds.IntersectsWith(pbx_reEnable.Bounds))
            {
                pbx_collisionSpawnNew.Location = new Point(679, -1);
            }

            pbx_newPlatform.Left -= 7;
            DoubleBuffered = true;

            if (pbx_newPlatform.Bounds.IntersectsWith(pbx_collisionSpawnNew.Bounds))//spawn yellow platform
            {
                Random rnd = new Random();
                int platformPositionHeight = rnd.Next(0, 591 - pbx_newPlatform2.Height);
                pbx_newPlatform2.BackColor = Color.Yellow;
                pbx_newPlatform2.BorderStyle = BorderStyle.FixedSingle;
                pbx_newPlatform2.Size = new Size(100, 20);
                pbx_newPlatform2.Location = new Point(1000, platformPositionHeight);
                pbx_newPlatform2.Tag = "platform";
                pbx_newPlatform2.Visible = true;
                Controls.Add(pbx_newPlatform2);
                pbx_collisionSpawnNew.Location = new Point(800, 800);
            }
            if (pbx_newPlatform.Bounds.IntersectsWith(pbx_reEnable.Bounds))
            {
                pbx_collisionSpawnNew.Location = new Point(679, -1);
            }
            pbx_newPlatform2.Left -= 7;
            DoubleBuffered = true;

            if (pbx_newPlatform2.Bounds.IntersectsWith(pbx_collisionSpawnNew.Bounds))//spawn red platform
            {
                Random rnd = new Random();
                int platformPositionHeight = rnd.Next(0, 591 - pbx_newPlatform3.Height);
                pbx_newPlatform3.BackColor = Color.Red;
                pbx_newPlatform3.Size = new Size(100, 20);
                pbx_newPlatform3.Location = new Point(1000, platformPositionHeight);
                pbx_newPlatform3.Tag = "platform";
                pbx_newPlatform3.Visible = true;
                Controls.Add(pbx_newPlatform3);
                pbx_collisionSpawnNew.Location = new Point(800, 800);
            }
            if (pbx_newPlatform2.Bounds.IntersectsWith(pbx_reEnable.Bounds))
            {
                pbx_collisionSpawnNew.Location = new Point(679, -1);
            }
            pbx_newPlatform3.Left -= 7;
            DoubleBuffered = true;
        }
    }
}
