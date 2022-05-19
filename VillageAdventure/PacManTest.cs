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
    public partial class PacManTest : Form
    {
        //public bool testMoveUp;
        //public bool testMoveDown;
        //public bool testMoveLeft;
        //public bool testMoveRight;
        //public int pTop;
        //public int top;
        public int xSpeed, ySpeed;
        CharacterMovement giveDirections = new CharacterMovement();


        public PacManTest()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void tmr_moveTest_Tick(object sender, EventArgs e)
        {

        }

        private void PacManTest_KeyDown_1(object sender, KeyEventArgs e)
        {
            //test in which direction pacman collides and set pacman a few pixels in opposite direction
            if (e.KeyCode == Keys.W)
            {
                ySpeed = -5;
                xSpeed = 0;
            }
            else if (e.KeyCode == Keys.S)
            {
                ySpeed = 5;
                xSpeed = 0;
            }
            else if (e.KeyCode == Keys.A)
            {
                ySpeed = 0;
                xSpeed = -5;
            }
            else if (e.KeyCode == Keys.D)
            {
                ySpeed = 0;
                xSpeed = 5;
            }
        }

        private void PacManTest_Load(object sender, EventArgs e)
        {

        }
    }
}
