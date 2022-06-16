using System;
using System.Drawing;
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
        #region Ghost1
        public bool gmoveLeft = true;
        public bool gmoveRight = true;
        public bool gmoveUp = true;
        public bool gmoveDown = true;
        public bool gUp = true;
        public bool gDown = true;
        public bool gRight = true;
        public bool gLeft = true;
        public int ghostController;
        #endregion
        #region Ghost2
        public bool gmoveLeft2 = true;
        public bool gmoveRight2 = true;
        public bool gmoveUp2 = true;
        public bool gmoveDown2 = true;
        public bool gUp2 = true;
        public bool gDown2 = true;
        public bool gRight2 = true;
        public bool gLeft2 = true;
        public int ghostController2;
        #endregion
        #region Ghost3
        public bool gmoveLeft3 = true;
        public bool gmoveRight3 = true;
        public bool gmoveUp3 = true;
        public bool gmoveDown3 = true;
        public bool gUp3 = true;
        public bool gDown3 = true;
        public bool gRight3 = true;
        public bool gLeft3 = true;
        public int ghostController3;
        #endregion
        #region Ghost4
        public bool gmoveLeft4 = true;
        public bool gmoveRight4 = true;
        public bool gmoveUp4 = true;
        public bool gmoveDown4 = true;
        public bool gUp4 = true;
        public bool gDown4 = true;
        public bool gRight4 = true;
        public bool gLeft4 = true;
        public int ghostController4;
        #endregion
        public bool dead1 = false;
        public bool dead2 = false;
        public bool dead3 = false;
        public bool dead4 = false;
        public bool kable = false;
        public int counter = 0;
        public Random rghost = new Random();


        public PacMan()
        {
            InitializeComponent();
            KeyPreview = true;
        }


        private void PacMan_KeyDown(object sender, KeyEventArgs e)
        {
            #region PacMan Movement
            if (e.KeyCode == Keys.W)
            {
                //set the up bool true to move pacman up
                moveUp = true;
                moveDown = false;
                moveLeft = false;
                moveRight = false;
                pbx_pacMan.Image = Properties.Resources.PacManHeadUp;
            }
            else if (e.KeyCode == Keys.S)
            {
                moveUp = false;
                moveDown = true;
                moveLeft = false;
                moveRight = false;
                pbx_pacMan.Image = Properties.Resources.PacManHeadDown;
            }
            else if (e.KeyCode == Keys.A)
            {
                moveUp = false;
                moveDown = false;
                moveLeft = true;
                moveRight = false;
                pbx_pacMan.Image = Properties.Resources.PacManHeadLeft;
            }
            else if (e.KeyCode == Keys.D)
            {
                moveUp = false;
                moveDown = false;
                moveLeft = false;
                moveRight = true;
                pbx_pacMan.Image = Properties.Resources.PacManHead;
            }
            #endregion

            #region Ghost Movement
            //all combination possibilities for the random directions of the ghosts
            if (e.KeyCode == Keys.W && ghostController == 1)
            {
                gmoveUp = true;
                gmoveDown = false;
                gmoveLeft = false;
                gmoveRight = false;
            }
            else if (e.KeyCode == Keys.W && ghostController == 2)
            {
                gmoveUp = false;
                gmoveDown = true;
                gmoveLeft = false;
                gmoveRight = false;
            }
            else if (e.KeyCode == Keys.W && ghostController == 3)
            {
                gmoveUp = false;
                gmoveDown = false;
                gmoveLeft = true;
                gmoveRight = false;
            }
            else if (e.KeyCode == Keys.W && ghostController == 4)
            {
                gmoveUp = false;
                gmoveDown = false;
                gmoveLeft = false;
                gmoveRight = true;
            }
            else if (e.KeyCode == Keys.S && ghostController == 1)
            {
                gmoveUp = true;
                gmoveDown = false;
                gmoveLeft = false;
                gmoveRight = false;
            }
            else if (e.KeyCode == Keys.S && ghostController == 2)
            {
                gmoveUp = false;
                gmoveDown = true;
                gmoveLeft = false;
                gmoveRight = false;
            }
            else if (e.KeyCode == Keys.S && ghostController == 3)
            {
                gmoveUp = false;
                gmoveDown = false;
                gmoveLeft = true;
                gmoveRight = false;
            }
            else if (e.KeyCode == Keys.S && ghostController == 4)
            {
                gmoveUp = false;
                gmoveDown = false;
                gmoveLeft = false;
                gmoveRight = true;
            }
            else if (e.KeyCode == Keys.D && ghostController == 1)
            {
                gmoveUp = true;
                gmoveDown = false;
                gmoveLeft = false;
                gmoveRight = false;
            }
            else if (e.KeyCode == Keys.D && ghostController == 2)
            {
                gmoveUp = false;
                gmoveDown = true;
                gmoveLeft = false;
                gmoveRight = false;
            }
            else if (e.KeyCode == Keys.D && ghostController == 3)
            {
                gmoveUp = false;
                gmoveDown = false;
                gmoveLeft = true;
                gmoveRight = false;
            }
            else if (e.KeyCode == Keys.D && ghostController == 4)
            {
                gmoveUp = false;
                gmoveDown = false;
                gmoveLeft = false;
                gmoveRight = true;
            }
            else if (e.KeyCode == Keys.A && ghostController == 1)
            {
                gmoveUp = true;
                gmoveDown = false;
                gmoveLeft = false;
                gmoveRight = false;
            }
            else if (e.KeyCode == Keys.A && ghostController == 2)
            {
                gmoveUp = false;
                gmoveDown = true;
                gmoveLeft = false;
                gmoveRight = false;
            }
            else if (e.KeyCode == Keys.A && ghostController == 3)
            {
                gmoveUp = false;
                gmoveDown = false;
                gmoveLeft = true;
                gmoveRight = false;
            }
            else if (e.KeyCode == Keys.A && ghostController == 4)
            {
                gmoveUp = false;
                gmoveDown = false;
                gmoveLeft = false;
                gmoveRight = true;
            }
            #endregion

            #region Ghost Movement 2
            if (e.KeyCode == Keys.W && ghostController2 == 1)
            {
                gmoveUp2 = true;
                gmoveDown2 = false;
                gmoveLeft2 = false;
                gmoveRight2 = false;
            }
            else if (e.KeyCode == Keys.W && ghostController2 == 2)
            {
                gmoveUp2 = false;
                gmoveDown2 = true;
                gmoveLeft2 = false;
                gmoveRight2 = false;
            }
            else if (e.KeyCode == Keys.W && ghostController2 == 3)
            {
                gmoveUp2 = false;
                gmoveDown2 = false;
                gmoveLeft2 = true;
                gmoveRight2 = false;
            }
            else if (e.KeyCode == Keys.W && ghostController2 == 4)
            {
                gmoveUp2 = false;
                gmoveDown2 = false;
                gmoveLeft2 = false;
                gmoveRight2 = true;
            }
            else if (e.KeyCode == Keys.S && ghostController2 == 1)
            {
                gmoveUp2 = true;
                gmoveDown2 = false;
                gmoveLeft2 = false;
                gmoveRight2 = false;
            }
            else if (e.KeyCode == Keys.S && ghostController2 == 2)
            {
                gmoveUp2 = false;
                gmoveDown2 = true;
                gmoveLeft2 = false;
                gmoveRight2 = false;
            }
            else if (e.KeyCode == Keys.S && ghostController2 == 3)
            {
                gmoveUp2 = false;
                gmoveDown2 = false;
                gmoveLeft2 = true;
                gmoveRight2 = false;
            }
            else if (e.KeyCode == Keys.S && ghostController2 == 4)
            {
                gmoveUp2 = false;
                gmoveDown2 = false;
                gmoveLeft2 = false;
                gmoveRight2 = true;
            }
            else if (e.KeyCode == Keys.D && ghostController2 == 1)
            {
                gmoveUp2 = true;
                gmoveDown2 = false;
                gmoveLeft2 = false;
                gmoveRight2 = false;
            }
            else if (e.KeyCode == Keys.D && ghostController2 == 2)
            {
                gmoveUp2 = false;
                gmoveDown2 = true;
                gmoveLeft2 = false;
                gmoveRight2 = false;
            }
            else if (e.KeyCode == Keys.D && ghostController2 == 3)
            {
                gmoveUp2 = false;
                gmoveDown2 = false;
                gmoveLeft2 = true;
                gmoveRight2 = false;
            }
            else if (e.KeyCode == Keys.D && ghostController2 == 4)
            {
                gmoveUp2 = false;
                gmoveDown2 = false;
                gmoveLeft2 = false;
                gmoveRight2 = true;
            }
            else if (e.KeyCode == Keys.A && ghostController2 == 1)
            {
                gmoveUp2 = true;
                gmoveDown2 = false;
                gmoveLeft2 = false;
                gmoveRight2 = false;
            }
            else if (e.KeyCode == Keys.A && ghostController2 == 2)
            {
                gmoveUp2 = false;
                gmoveDown2 = true;
                gmoveLeft2 = false;
                gmoveRight2 = false;
            }
            else if (e.KeyCode == Keys.A && ghostController2 == 3)
            {
                gmoveUp2 = false;
                gmoveDown2 = false;
                gmoveLeft2 = true;
                gmoveRight2 = false;
            }
            else if (e.KeyCode == Keys.A && ghostController2 == 4)
            {
                gmoveUp2 = false;
                gmoveDown2 = false;
                gmoveLeft2 = false;
                gmoveRight2 = true;
            }
            #endregion

            #region Ghost Movement 3
            if (e.KeyCode == Keys.W && ghostController3 == 1)
            {
                gmoveUp3 = true;
                gmoveDown3 = false;
                gmoveLeft3 = false;
                gmoveRight3 = false;
            }
            else if (e.KeyCode == Keys.W && ghostController3 == 2)
            {
                gmoveUp3 = false;
                gmoveDown3 = true;
                gmoveLeft3 = false;
                gmoveRight3 = false;
            }
            else if (e.KeyCode == Keys.W && ghostController3 == 3)
            {
                gmoveUp3 = false;
                gmoveDown3 = false;
                gmoveLeft3 = true;
                gmoveRight3 = false;
            }
            else if (e.KeyCode == Keys.W && ghostController3 == 4)
            {
                gmoveUp3 = false;
                gmoveDown3 = false;
                gmoveLeft3 = false;
                gmoveRight3 = true;
            }
            else if (e.KeyCode == Keys.S && ghostController3 == 1)
            {
                gmoveUp3 = true;
                gmoveDown3 = false;
                gmoveLeft3 = false;
                gmoveRight3 = false;
            }
            else if (e.KeyCode == Keys.S && ghostController3 == 2)
            {
                gmoveUp3 = false;
                gmoveDown3 = true;
                gmoveLeft3 = false;
                gmoveRight3 = false;
            }
            else if (e.KeyCode == Keys.S && ghostController3 == 3)
            {
                gmoveUp3 = false;
                gmoveDown3 = false;
                gmoveLeft3 = true;
                gmoveRight3 = false;
            }
            else if (e.KeyCode == Keys.S && ghostController3 == 4)
            {
                gmoveUp3 = false;
                gmoveDown3 = false;
                gmoveLeft3 = false;
                gmoveRight3 = true;
            }
            else if (e.KeyCode == Keys.D && ghostController3 == 1)
            {
                gmoveUp3 = true;
                gmoveDown3 = false;
                gmoveLeft3 = false;
                gmoveRight3 = false;
            }
            else if (e.KeyCode == Keys.D && ghostController3 == 2)
            {
                gmoveUp3 = false;
                gmoveDown3 = true;
                gmoveLeft3 = false;
                gmoveRight3 = false;
            }
            else if (e.KeyCode == Keys.D && ghostController3 == 3)
            {
                gmoveUp3 = false;
                gmoveDown3 = false;
                gmoveLeft3 = true;
                gmoveRight3 = false;
            }
            else if (e.KeyCode == Keys.D && ghostController3 == 4)
            {
                gmoveUp3 = false;
                gmoveDown3 = false;
                gmoveLeft3 = false;
                gmoveRight3 = true;
            }
            else if (e.KeyCode == Keys.A && ghostController3 == 1)
            {
                gmoveUp3 = true;
                gmoveDown3 = false;
                gmoveLeft3 = false;
                gmoveRight3 = false;
            }
            else if (e.KeyCode == Keys.A && ghostController3 == 2)
            {
                gmoveUp3 = false;
                gmoveDown3 = true;
                gmoveLeft3 = false;
                gmoveRight3 = false;
            }
            else if (e.KeyCode == Keys.A && ghostController3 == 3)
            {
                gmoveUp3 = false;
                gmoveDown3 = false;
                gmoveLeft3 = true;
                gmoveRight3 = false;
            }
            else if (e.KeyCode == Keys.A && ghostController3 == 4)
            {
                gmoveUp3 = false;
                gmoveDown3 = false;
                gmoveLeft3 = false;
                gmoveRight3 = true;
            }
            #endregion

            #region Ghost Movement 4
            if (e.KeyCode == Keys.W && ghostController4 == 1)
            {
                gmoveUp4 = true;
                gmoveDown4 = false;
                gmoveLeft4 = false;
                gmoveRight4 = false;
            }
            else if (e.KeyCode == Keys.W && ghostController4 == 2)
            {
                gmoveUp4 = false;
                gmoveDown4 = true;
                gmoveLeft4 = false;
                gmoveRight4 = false;
            }
            else if (e.KeyCode == Keys.W && ghostController4 == 3)
            {
                gmoveUp4 = false;
                gmoveDown4 = false;
                gmoveLeft4 = true;
                gmoveRight4 = false;
            }
            else if (e.KeyCode == Keys.W && ghostController4 == 4)
            {
                gmoveUp4 = false;
                gmoveDown4 = false;
                gmoveLeft4 = false;
                gmoveRight4 = true;
            }
            else if (e.KeyCode == Keys.S && ghostController4 == 1)
            {
                gmoveUp4 = true;
                gmoveDown4 = false;
                gmoveLeft4 = false;
                gmoveRight4 = false;
            }
            else if (e.KeyCode == Keys.S && ghostController4 == 2)
            {
                gmoveUp4 = false;
                gmoveDown4 = true;
                gmoveLeft4 = false;
                gmoveRight4 = false;
            }
            else if (e.KeyCode == Keys.S && ghostController4 == 3)
            {
                gmoveUp4 = false;
                gmoveDown4 = false;
                gmoveLeft4 = true;
                gmoveRight4 = false;
            }
            else if (e.KeyCode == Keys.S && ghostController4 == 4)
            {
                gmoveUp4 = false;
                gmoveDown4 = false;
                gmoveLeft4 = false;
                gmoveRight4 = true;
            }
            else if (e.KeyCode == Keys.D && ghostController4 == 1)
            {
                gmoveUp4 = true;
                gmoveDown4 = false;
                gmoveLeft4 = false;
                gmoveRight4 = false;
            }
            else if (e.KeyCode == Keys.D && ghostController4 == 2)
            {
                gmoveUp4 = false;
                gmoveDown4 = true;
                gmoveLeft4 = false;
                gmoveRight4 = false;
            }
            else if (e.KeyCode == Keys.D && ghostController4 == 3)
            {
                gmoveUp4 = false;
                gmoveDown4 = false;
                gmoveLeft4 = true;
                gmoveRight4 = false;
            }
            else if (e.KeyCode == Keys.D && ghostController4 == 4)
            {
                gmoveUp4 = false;
                gmoveDown4 = false;
                gmoveLeft4 = false;
                gmoveRight4 = true;
            }
            else if (e.KeyCode == Keys.A && ghostController4 == 1)
            {
                gmoveUp4 = true;
                gmoveDown4 = false;
                gmoveLeft4 = false;
                gmoveRight4 = false;
            }
            else if (e.KeyCode == Keys.A && ghostController4 == 2)
            {
                gmoveUp4 = false;
                gmoveDown4 = true;
                gmoveLeft4 = false;
                gmoveRight4 = false;
            }
            else if (e.KeyCode == Keys.A && ghostController4 == 3)
            {
                gmoveUp4 = false;
                gmoveDown4 = false;
                gmoveLeft4 = true;
                gmoveRight4 = false;
            }
            else if (e.KeyCode == Keys.A && ghostController4 == 4)
            {
                gmoveUp4 = false;
                gmoveDown4 = false;
                gmoveLeft4 = false;
                gmoveRight4 = true;
            }
            #endregion
        }

        private void tmr_movePacman_Tick_1(object sender, EventArgs e)
        {
            //create randoms for the ghosts different directions
            ghostController = rghost.Next(1, 5);
            ghostController2 = rghost.Next(1, 5);
            ghostController3 = rghost.Next(1, 5);
            ghostController4 = rghost.Next(1, 5);

            //if all coins are collected the game ends
            if (counter == 237)
            {
                counter = 0;

                DialogResult dialogD = new DialogResult();
                dialogD = MessageBox.Show("You won! Try again?", "You won!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogD == DialogResult.Yes)
                {
                    PacMan newGame = new PacMan();
                    this.Hide();
                    newGame.ShowDialog();
                    this.Close();
                }
                if (dialogD == DialogResult.No)
                {
                    frm_main backMain = new frm_main();
                    this.Hide();
                    backMain.ShowDialog();
                    this.Close();
                }
            }

            #region PacManControl
            foreach (Control x in Controls)
            {
                //check the directions in which pacman is allowed to move
                if (pbx_pacMan.Bounds.IntersectsWith(pbx_colliderLeftRight13.Bounds))
                {
                    pbx_pacMan.Location = pbx_colliderDown4.Location;
                }
                if (pbx_pacMan.Bounds.IntersectsWith(pbx_ghost1.Bounds) && kable == true)
                {
                    //check if ghosts are killable, if so, they get set to spawnpoint and the timer to bring
                    //them back into the game starts
                    pbx_ghost1.Location = new Point(350, 260);
                    dead1 = true;
                    tmr_ghost1.Start();
                }
                if (pbx_pacMan.Bounds.IntersectsWith(pbx_ghost2.Bounds) && kable == true)
                {
                    pbx_ghost2.Location = new Point(350, 260);
                    dead2 = true;
                    tmr_ghost1.Start();
                }
                if (pbx_pacMan.Bounds.IntersectsWith(pbx_ghost3.Bounds) && kable == true)
                {
                    pbx_ghost3.Location = new Point(350, 260);
                    dead3 = true;
                    tmr_ghost1.Start();
                }
                if (pbx_pacMan.Bounds.IntersectsWith(pbx_ghost4.Bounds) && kable == true)
                {
                    pbx_ghost4.Location = new Point(350, 260);
                    dead4 = true;
                    tmr_ghost1.Start();
                }
                if (x is PictureBox && x.Tag.ToString() == "ghost" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds) && kable == false)
                {
                    //if the ghosts are not killable the player dies if he gets hit
                    pbx_pacMan.Location = new Point(800, 800);
                    PacMan newGame = new PacMan();
                    frm_main backMain = new frm_main();
                    DialogResult dialogD = new DialogResult();
                    dialogD = MessageBox.Show("You died! Try again?", "You died!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogD == DialogResult.Yes)
                    {
                        this.Hide();
                        newGame.ShowDialog();
                        this.Close();
                    }
                    if (dialogD == DialogResult.No)
                    {
                        this.Hide();
                        backMain.ShowDialog();
                        this.Close();
                    }
                }
                if (x is PictureBox && x.Tag.ToString() == "coins" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    //to count the coins and remove them from the form
                    x.Dispose();
                    counter++;
                    lbl_coins.Text = "Coins: " + counter;
                }
                if (x is PictureBox && x.Tag.ToString() == "bigcoins" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    //set killable true if pacman collects a big coin
                    x.Dispose();
                    counter++;
                    kable = true;
                    //start timer to reset the killable status
                    tmr_resetKable.Start();
                    lbl_status.Text = "Kill the ghosts!";
                }
                //all possibilities in which pacman is allowed to move
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
                else if (x is PictureBox && x.Tag.ToString() == "rightUpDownFalse" && pbx_pacMan.Bounds.IntersectsWith(x.Bounds))
                {
                    up = false;
                    down = false;
                    left = true;
                    right = false;
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
                    //if pacman touches the teleporter he gets teleported on the other side
                    pbx_pacMan.Location = new Point(390, 517);
                }

            }
            CharacterMovement giveDirections = new CharacterMovement();

            giveDirections.x = pbx_pacMan.Location.X;
            giveDirections.y = pbx_pacMan.Location.Y;
            //move pacman, if he's allowed to
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

            #region GhostControl1
            //same stuff as the pacman movement for the ghosts
            foreach (Control x in Controls)
            {
                if (pbx_ghost1.Bounds.IntersectsWith(pbx_colliderLeftRight13.Bounds))
                {
                    pbx_ghost1.Location = pbx_colliderDown4.Location;
                }
                if (x is PictureBox && x.Tag.ToString() == "upDownFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = false;
                    gDown = false;
                    gLeft = true;
                    gRight = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = false;
                    gDown = true;
                    gLeft = true;
                    gRight = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightUpDownFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = false;
                    gDown = false;
                    gLeft = true;
                    gRight = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftRightFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = true;
                    gDown = true;
                    gLeft = false;
                    gRight = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = true;
                    gDown = true;
                    gLeft = true;
                    gRight = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = true;
                    gDown = true;
                    gLeft = false;
                    gRight = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upLeftFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = false;
                    gDown = true;
                    gLeft = false;
                    gRight = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftDownFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = true;
                    gDown = false;
                    gLeft = false;
                    gRight = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightUpDownFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = true;
                    gDown = false;
                    gLeft = true;
                    gRight = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upDownLeftFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = false;
                    gDown = false;
                    gLeft = false;
                    gRight = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "downRightFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = true;
                    gDown = false;
                    gLeft = true;
                    gRight = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "downFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = true;
                    gDown = false;
                    gLeft = true;
                    gRight = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "allDirections" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = true;
                    gDown = true;
                    gLeft = true;
                    gRight = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsLeft" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = true;
                    gDown = true;
                    gLeft = false;
                    gRight = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsStopUp" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = false;
                    gDown = true;
                    gLeft = true;
                    gRight = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upRightFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = false;
                    gDown = true;
                    gLeft = true;
                    gRight = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsRight" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = true;
                    gDown = true;
                    gLeft = true;
                    gRight = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upDownLeftRightFalse" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp = false;
                    gDown = false;
                    gLeft = false;
                    gRight = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "teleport" && pbx_ghost1.Bounds.IntersectsWith(x.Bounds))
                {
                    pbx_ghost1.Location = new Point(390, 517);
                }

            }
            CharacterMovement moveGhost = new CharacterMovement();

            moveGhost.x = pbx_ghost1.Location.X;
            moveGhost.y = pbx_ghost1.Location.Y;

            if (gmoveUp == true && gUp == true)
            {
                moveGhost.MoveUp();
            }
            if (gmoveDown == true && gDown == true)
            {
                moveGhost.MoveDown();
            }
            if (gmoveLeft == true && gLeft == true)
            {
                moveGhost.MoveLeft();
            }
            if (gmoveRight == true && gRight == true)
            {
                moveGhost.MoveRight();
            }
            pbx_ghost1.Location = new Point(moveGhost.x, moveGhost.y);
            #endregion

            #region GhostControl2
            foreach (Control x in Controls)
            {
                if (pbx_ghost2.Bounds.IntersectsWith(pbx_colliderLeftRight13.Bounds))
                {
                    pbx_ghost2.Location = pbx_colliderDown4.Location;
                }
                if (x is PictureBox && x.Tag.ToString() == "upDownFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = false;
                    gDown2 = false;
                    gLeft2 = true;
                    gRight2 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = false;
                    gDown2 = true;
                    gLeft2 = true;
                    gRight2 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightUpDownFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = false;
                    gDown2 = false;
                    gLeft2 = true;
                    gRight2 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftRightFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = true;
                    gDown2 = true;
                    gLeft2 = false;
                    gRight2 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = true;
                    gDown2 = true;
                    gLeft2 = true;
                    gRight2 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = true;
                    gDown2 = true;
                    gLeft2 = false;
                    gRight2 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upLeftFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = false;
                    gDown2 = true;
                    gLeft2 = false;
                    gRight2 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftDownFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = true;
                    gDown2 = false;
                    gLeft2 = false;
                    gRight2 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightUpDownFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = true;
                    gDown2 = false;
                    gLeft2 = true;
                    gRight2 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upDownLeftFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = false;
                    gDown2 = false;
                    gLeft2 = false;
                    gRight2 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "downRightFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = true;
                    gDown2 = false;
                    gLeft2 = true;
                    gRight2 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "downFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = true;
                    gDown2 = false;
                    gLeft2 = true;
                    gRight2 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "allDirections" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = true;
                    gDown2 = true;
                    gLeft2 = true;
                    gRight2 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsLeft" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = true;
                    gDown2 = true;
                    gLeft2 = false;
                    gRight2 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsStopUp" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = false;
                    gDown2 = true;
                    gLeft2 = true;
                    gRight2 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upRightFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = false;
                    gDown2 = true;
                    gLeft2 = true;
                    gRight2 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsRight" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = true;
                    gDown2 = true;
                    gLeft2 = true;
                    gRight2 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upDownLeftRightFalse" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp2 = false;
                    gDown2 = false;
                    gLeft2 = false;
                    gRight2 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "teleport" && pbx_ghost2.Bounds.IntersectsWith(x.Bounds))
                {
                    pbx_ghost2.Location = new Point(390, 517);
                }

            }
            CharacterMovement moveGhost2 = new CharacterMovement();

            moveGhost2.x = pbx_ghost2.Location.X;
            moveGhost2.y = pbx_ghost2.Location.Y;

            if (gmoveUp2 == true && gUp2 == true)
            {
                moveGhost2.MoveUp();
            }
            if (gmoveDown2 == true && gDown2 == true)
            {
                moveGhost2.MoveDown();
            }
            if (gmoveLeft2 == true && gLeft2 == true)
            {
                moveGhost2.MoveLeft();
            }
            if (gmoveRight2 == true && gRight2 == true)
            {
                moveGhost2.MoveRight();
            }
            pbx_ghost2.Location = new Point(moveGhost2.x, moveGhost2.y);
            #endregion

            #region GhostControl3
            foreach (Control x in Controls)
            {
                if (pbx_ghost3.Bounds.IntersectsWith(pbx_colliderLeftRight13.Bounds))
                {
                    pbx_ghost3.Location = pbx_colliderDown4.Location;
                }
                if (x is PictureBox && x.Tag.ToString() == "upDownFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = false;
                    gDown3 = false;
                    gLeft3 = true;
                    gRight3 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = false;
                    gDown3 = true;
                    gLeft3 = true;
                    gRight3 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightUpDownFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = false;
                    gDown3 = false;
                    gLeft3 = true;
                    gRight3 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftRightFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = true;
                    gDown3 = true;
                    gLeft3 = false;
                    gRight3 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = true;
                    gDown3 = true;
                    gLeft3 = true;
                    gRight3 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = true;
                    gDown3 = true;
                    gLeft3 = false;
                    gRight3 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upLeftFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = false;
                    gDown3 = true;
                    gLeft3 = false;
                    gRight3 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftDownFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = true;
                    gDown3 = false;
                    gLeft3 = false;
                    gRight3 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightUpDownFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = true;
                    gDown3 = false;
                    gLeft3 = true;
                    gRight3 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upDownLeftFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = false;
                    gDown3 = false;
                    gLeft3 = false;
                    gRight3 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "downRightFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = true;
                    gDown3 = false;
                    gLeft3 = true;
                    gRight3 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "downFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = true;
                    gDown3 = false;
                    gLeft3 = true;
                    gRight3 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "allDirections" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = true;
                    gDown3 = true;
                    gLeft3 = true;
                    gRight3 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsLeft" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = true;
                    gDown3 = true;
                    gLeft3 = false;
                    gRight3 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsStopUp" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = false;
                    gDown3 = true;
                    gLeft3 = true;
                    gRight3 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upRightFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = false;
                    gDown3 = true;
                    gLeft3 = true;
                    gRight3 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsRight" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = true;
                    gDown3 = true;
                    gLeft3 = true;
                    gRight3 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upDownLeftRightFalse" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp3 = false;
                    gDown3 = false;
                    gLeft3 = false;
                    gRight3 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "teleport" && pbx_ghost3.Bounds.IntersectsWith(x.Bounds))
                {
                    pbx_ghost3.Location = new Point(390, 517);
                }

            }
            CharacterMovement moveGhost3 = new CharacterMovement();

            moveGhost3.x = pbx_ghost3.Location.X;
            moveGhost3.y = pbx_ghost3.Location.Y;

            if (gmoveUp3 == true && gUp3 == true)
            {
                moveGhost3.MoveUp();
            }
            if (gmoveDown3 == true && gDown3 == true)
            {
                moveGhost3.MoveDown();
            }
            if (gmoveLeft3 == true && gLeft3 == true)
            {
                moveGhost3.MoveLeft();
            }
            if (gmoveRight3 == true && gRight3 == true)
            {
                moveGhost3.MoveRight();
            }
            pbx_ghost3.Location = new Point(moveGhost3.x, moveGhost3.y);
            #endregion

            #region GhostControl4
            foreach (Control x in Controls)
            {
                if (pbx_ghost4.Bounds.IntersectsWith(pbx_colliderLeftRight13.Bounds))
                {
                    pbx_ghost4.Location = pbx_colliderDown4.Location;
                }
                if (x is PictureBox && x.Tag.ToString() == "upDownFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = false;
                    gDown4 = false;
                    gLeft4 = true;
                    gRight4 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = false;
                    gDown4 = true;
                    gLeft4 = true;
                    gRight4 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightUpDownFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = false;
                    gDown4 = false;
                    gLeft4 = true;
                    gRight4 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftRightFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = true;
                    gDown4 = true;
                    gLeft4 = false;
                    gRight4 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = true;
                    gDown4 = true;
                    gLeft4 = true;
                    gRight4 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = true;
                    gDown4 = true;
                    gLeft4 = false;
                    gRight4 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upLeftFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = false;
                    gDown4 = true;
                    gLeft4 = false;
                    gRight4 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "leftDownFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = true;
                    gDown4 = false;
                    gLeft4 = false;
                    gRight4 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "rightUpDownFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = true;
                    gDown4 = false;
                    gLeft4 = true;
                    gRight4 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upDownLeftFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = false;
                    gDown4 = false;
                    gLeft4 = false;
                    gRight4 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "downRightFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = true;
                    gDown4 = false;
                    gLeft4 = true;
                    gRight4 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "downFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = true;
                    gDown4 = false;
                    gLeft4 = true;
                    gRight4 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "allDirections" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = true;
                    gDown4 = true;
                    gLeft4 = true;
                    gRight4 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsLeft" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = true;
                    gDown4 = true;
                    gLeft4 = false;
                    gRight4 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsStopUp" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = false;
                    gDown4 = true;
                    gLeft4 = true;
                    gRight4 = true;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upRightFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = false;
                    gDown4 = true;
                    gLeft4 = true;
                    gRight4 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "wallsRight" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = true;
                    gDown4 = true;
                    gLeft4 = true;
                    gRight4 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "upDownLeftRightFalse" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    gUp4 = false;
                    gDown4 = false;
                    gLeft4 = false;
                    gRight4 = false;
                }
                else if (x is PictureBox && x.Tag.ToString() == "teleport" && pbx_ghost4.Bounds.IntersectsWith(x.Bounds))
                {
                    pbx_ghost4.Location = new Point(390, 517);
                }

            }
            CharacterMovement moveGhost4 = new CharacterMovement();

            moveGhost4.x = pbx_ghost4.Location.X;
            moveGhost4.y = pbx_ghost4.Location.Y;

            if (gmoveUp4 == true && gUp4 == true)
            {
                moveGhost4.MoveUp();
            }
            if (gmoveDown4 == true && gDown4 == true)
            {
                moveGhost4.MoveDown();
            }
            if (gmoveLeft4 == true && gLeft4 == true)
            {
                moveGhost4.MoveLeft();
            }
            if (gmoveRight4 == true && gRight4 == true)
            {
                moveGhost4.MoveRight();
            }
            pbx_ghost4.Location = new Point(moveGhost4.x, moveGhost4.y);
            #endregion
        }

        private void tmr_removeDoor_Tick(object sender, EventArgs e)
        {
            //timer for spawning the ghost in
            pbx_ghost1.Location = new Point(320, 170);
            tmr_ghost1.Stop();

            //respawm the dead ghosts
            if (dead1 == true)
            {
                pbx_ghost1.Location = new Point(320, 170);
                tmr_ghost1.Stop();
            }
            if (dead2 == true)
            {
                pbx_ghost2.Location = new Point(320, 170);
                tmr_ghost2.Stop();
            }
            if (dead3 == true)
            {
                pbx_ghost3.Location = new Point(320, 170);
                tmr_ghost3.Stop();
            }
            if (dead4 == true)
            {
                pbx_ghost4.Location = new Point(320, 170);
                tmr_ghost4.Stop();
            }
        }

        //spawn the other ghosts in
        private void tmr_ghost2_Tick(object sender, EventArgs e)
        {
            pbx_ghost2.Location = new Point(385, 170);
            tmr_ghost2.Stop();
        }

        private void tmr_ghost3_Tick(object sender, EventArgs e)
        {
            pbx_ghost3.Location = new Point(450, 170);
            tmr_ghost3.Stop();
        }

        private void tmr_ghost4_Tick(object sender, EventArgs e)
        {
            pbx_ghost4.Location = new Point(515, 170);
            tmr_ghost4.Stop();

        }

        //reset the killable status
        private void tmr_resetKable_Tick(object sender, EventArgs e)
        {
            kable = false;
            tmr_resetKable.Stop();
            lbl_status.Text = "You are vulnerable!";
        }

        private void PacMan_Load(object sender, EventArgs e)
        {

        }
    }
}
