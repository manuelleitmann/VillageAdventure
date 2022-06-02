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
    public partial class PacMan : Form
    {
        public bool left = true;
        public bool right = true;
        public bool up = true;
        public bool down = true;
        public bool moveLeft = true;
        public bool moveRight = true;
        public bool moveUp = true;
        public bool moveDown = true;
        public bool gUp;
        public bool gDown;
        public bool gRight;
        public bool gLeft;
        public int ghostController;


        public PacMan()
        {
            InitializeComponent();
            KeyPreview = true;
        }


        private void PacMan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                moveUp = true;
                moveDown = false;
                moveLeft = false;
                moveRight = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                moveUp = false;
                moveDown = true;
                moveLeft = false;
                moveRight = false;
            }
            else if (e.KeyCode == Keys.A)
            {
                moveUp = false;
                moveDown = false;
                moveLeft = true;
                moveRight = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                moveUp = false;
                moveDown = false;
                moveLeft = false;
                moveRight = true;
            }
        }

        private void PacMan_Load(object sender, EventArgs e)
        {
            //random only goes left
            Random rghost = new Random();
            ghostController = rghost.Next(1, 2);
        }


        private void tmr_movePacman_Tick_1(object sender, EventArgs e)
        {
        #region PacManControl
            foreach (Control x in Controls)
            {
                if (x is PictureBox && x.Tag.ToString() == "upDownFalse" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = false;
                    down = false;
                    left = true;
                    right = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upFalse" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = false;
                    down = true;
                    left = true;
                    right = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftRightFalse" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = true;
                    down = true;
                    left = false;
                    right = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightFalse" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = true;
                    down = true;
                    left = true;
                    right = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftFalse" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = true;
                    down = true;
                    left = false;
                    right = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upLeftFalse" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = false;
                    down = true;
                    left = false;
                    right = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftDownFalse" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = true;
                    down = false;
                    left = false;
                    right = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightUpDownFalse" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = true;
                    down = false;
                    left = true;
                    right = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upDownLeftFalse" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = false;
                    down = false;
                    left = false;
                    right = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "downRightFalse" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = true;
                    down = false;
                    left = true;
                    right = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "downFalse" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = true;
                    down = false;
                    left = true;
                    right = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "allDirections" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = true;
                    down = true;
                    left = true;
                    right = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsLeft" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = true;
                    down = true;
                    left = false;
                    right = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsStopUp" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = false;
                    down = true;
                    left = true;
                    right = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upRightFalse" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = false;
                    down = true;
                    left = true;
                    right = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsRight" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = true;
                    down = true;
                    left = true;
                    right = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "teleport" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    pbx_pacMan.Location = new Point(390, 517);
                }

            }
            CharacterMovement giveDirections = new CharacterMovement();

            giveDirections.x = pbx_pacMan.Location.X;
            giveDirections.y = pbx_pacMan.Location.Y;

            if (moveUp == true && up == true)
            {
                giveDirections.MoveUp();
            }
            if (moveDown == true && down == true)
            {
                giveDirections.MoveDown();
            }
            if (moveLeft == true && left == true)
            {
                giveDirections.MoveLeft();
            }
            if (moveRight == true && right == true)
            {
                giveDirections.MoveRight();
            }
            pbx_pacMan.Location = new Point(giveDirections.x, giveDirections.y);

            #endregion

            #region GhostControl
            foreach (Control x in Controls)
            {

                if (x is PictureBox && x.Tag.ToString() == "upDownFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                                        
                    if(ghostController == 1)
                    {
                        gLeft = true;
                        gRight = false;
                        gUp = false;
                        gDown = false;
                    }
                    if (ghostController == 2)
                    {
                        gLeft = false;
                        gRight = true;
                        gUp = false;
                        gDown = false;
                    }

                    if (gLeft == true)
                    {
                        lbl_random.Text = "True";
                    }
                    if(gRight == false)
                    {
                        lbl_random2.Text = "False";
                    }
                }
                
            }

            CharacterMovement gDirection = new CharacterMovement();

            gDirection.x = pbx_ghost1.Location.X;
            gDirection.y = pbx_ghost1.Location.Y;

            if (gUp == true)
            {
                gDirection.MoveUp();
            }
            if (gDown == true)
            {
                gDirection.MoveDown();
            }
            if (gLeft == true)
            {
                gDirection.MoveLeft();
            }
            if (gRight == true)
            {
                gDirection.MoveRight();
            }

            pbx_ghost1.Location = new Point(gDirection.x, gDirection.y);
            #endregion
        }

        //Make door come back after a few seconds
        private void tmr_openDoor_Tick(object sender, EventArgs e)
        {   
            pbx_door.Visible = false;
            pbx_door.Enabled = false;
        }
    }
}
