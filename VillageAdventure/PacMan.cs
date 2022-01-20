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
    //check if a wall is in Pac-Mans way if he wants to move in a direction!
    public partial class PacMan : Form
    {
        //directions to check in which direction Pac-Man is moving
        public bool checkLeft = false;
        public bool checkRight = false;
        public bool checkUp = false;
        public bool checkDown = false;
        CharacterMovement movePacMan = new CharacterMovement();

        public PacMan()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void PacMan_KeyDown(object sender, KeyEventArgs e)
        {         
            //Movement
            movePacMan.x = pbx_pacMan.Location.X;
            movePacMan.y = pbx_pacMan.Location.Y;

            //check which direction Pac-Man is moving
            if (e.KeyCode == Keys.W && checkLeft == true)
            {
                tmr_PacManUp.Enabled = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                tmr_PacManDown.Enabled = true;
            }
            else if (e.KeyCode == Keys.A && checkLeft == false)
            {
                tmr_PacManLeft.Enabled = true;
            }
            else if (e.KeyCode == Keys.D && checkLeft == true || e.KeyCode == Keys.D && checkUp == true)
            {
                tmr_PacManRight.Enabled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Menu pacManMenu = new Menu();
                this.Hide();
                pacManMenu.ShowDialog();
                this.Close();
            }
        }

        //to move Pac-Man automatically in a direction
        private void tmr_PacManLeft_Tick(object sender, EventArgs e)
        {
            movePacMan.x = pbx_pacMan.Location.X;
            movePacMan.y = pbx_pacMan.Location.Y;

            movePacMan.MoveLeft();
            pbx_pacMan.Location = new Point(movePacMan.x, movePacMan.y);

            if (pbx_pacMan.Bounds.IntersectsWith(pbx_wall4.Bounds))
            {
                tmr_PacManLeft.Enabled = false;
                checkLeft = true;
            }
        }

        private void Reset(int test)
        {
            //to reset everything in starting position after the user collected all coins (not in use yet)
        }

        //to move Pac-Man
        private void tmr_PacManUp_Tick(object sender, EventArgs e)
        {
            
            movePacMan.x = pbx_pacMan.Location.X;
            movePacMan.y = pbx_pacMan.Location.Y;

            movePacMan.MoveUp();
            pbx_pacMan.Location = new Point(movePacMan.x, movePacMan.y);

            if (pbx_pacMan.Bounds.IntersectsWith(pbx_wall4.Bounds))
            {
                //to check in which direction Pac-Man is moving
                tmr_PacManLeft.Enabled = false;
                checkUp = true;
                checkLeft = false;
            }
        }

        private void tmr_PacManRight_Tick(object sender, EventArgs e)
        {
            movePacMan.x = pbx_pacMan.Location.X;
            movePacMan.y = pbx_pacMan.Location.Y;

            movePacMan.MoveRight();
            pbx_pacMan.Location = new Point(movePacMan.x, movePacMan.y);

            if (pbx_pacMan.Bounds.IntersectsWith(pbx_wall4.Bounds))
            {
                tmr_PacManLeft.Enabled = false;
                checkRight = true;
            }
        }

        private void tmr_PacManDown_Tick(object sender, EventArgs e)
        {
            movePacMan.x = pbx_pacMan.Location.X;
            movePacMan.y = pbx_pacMan.Location.Y;

            movePacMan.MoveDown();
            pbx_pacMan.Location = new Point(movePacMan.x, movePacMan.y);
        }

        private void PacMan_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_main openMainfromPacMan = new frm_main();
            this.Hide();
            openMainfromPacMan.ShowDialog();
            this.Close();
        }
    }
}
