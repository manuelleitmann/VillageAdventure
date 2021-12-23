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

        private void PacMan_Load(object sender, EventArgs e)
        {
           
        }

        private void PacMan_KeyDown(object sender, KeyEventArgs e)
        {          
            movePacMan.x = pbx_pacMan.Location.X;
            movePacMan.y = pbx_pacMan.Location.Y;

            if (e.KeyCode == Keys.W && checkLeft == true)
            {
                tmr_PacManUp.Enabled = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                
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
            //to reset everything in starting position after the user collected all coins
        }

        private void tmr_PacManUp_Tick(object sender, EventArgs e)
        {
            movePacMan.x = pbx_pacMan.Location.X;
            movePacMan.y = pbx_pacMan.Location.Y;

            movePacMan.MoveUp();
            pbx_pacMan.Location = new Point(movePacMan.x, movePacMan.y);

            if (pbx_pacMan.Bounds.IntersectsWith(pbx_wall4.Bounds))
            {
                tmr_PacManLeft.Enabled = false;
                checkUp = true;
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
    }
}
