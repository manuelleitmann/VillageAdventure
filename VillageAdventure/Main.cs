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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            this.KeyPreview = true;
            #region Transparent
            pbx_background.Controls.Add(pbx_fire);
            pbx_fire.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_fir1);
            pbx_fir1.BackColor = Color.Transparent;
            
            pbx_background.Controls.Add(pbx_fir2);
            pbx_fir2.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_fir3);
            pbx_fir3.BackColor = Color.Transparent;
            
            pbx_background.Controls.Add(pbx_tree1);
            pbx_tree1.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_tree2);
            pbx_tree2.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_tent1);
            pbx_tent1.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_tent2);
            pbx_tent2.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_tent3);
            pbx_tent3.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_tent4);
            pbx_tent4.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_bush1);
            pbx_bush1.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_bush2);
            pbx_bush2.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_bush3);
            pbx_bush3.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_bush4);
            pbx_bush4.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_mainCharacter);
            pbx_mainCharacter.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_logo);
            pbx_logo.BackColor = Color.Transparent;
           
            pbx_background.Controls.Add(pbx_menuButton);
            pbx_menuButton.BackColor = Color.Transparent;
            #endregion
        }

        private void frm_main_KeyDown(object sender, KeyEventArgs e)
        {
            //to get the methods and variables from the "CharacterMovement" class
            CharacterMovement giveDirections = new CharacterMovement();

            giveDirections.x = pbx_mainCharacter.Location.X;
            giveDirections.y = pbx_mainCharacter.Location.Y;

            //write in timer not in KeyDown
            #region Keys
            if (e.KeyCode == Keys.W)
            {
                    giveDirections.MoveUp();
                    //to refresh the location of the picture box
                    pbx_mainCharacter.Location = new Point(giveDirections.x, giveDirections.y);
            }
            else if (e.KeyCode == Keys.S)
            {
                giveDirections.MoveDown();
                pbx_mainCharacter.Location = new Point(giveDirections.x, giveDirections.y);
            }
            else if (e.KeyCode == Keys.A)
            {
                giveDirections.MoveLeft();
                pbx_mainCharacter.Location = new Point(giveDirections.x, giveDirections.y);
            }
            else if (e.KeyCode == Keys.D)
            {
                giveDirections.MoveRight();
                pbx_mainCharacter.Location = new Point(giveDirections.x, giveDirections.y);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Menu openMenu = new Menu();
                this.Hide();
                openMenu.ShowDialog();
                this.Close();
            }
            #endregion

            if (pbx_mainCharacter.Bounds.IntersectsWith(pbx_tent1.Bounds))
            {
                pbx_tent1.Location = new Point(800, 800);

                DialogResult dialogResult = MessageBox.Show("Do you want to play the Race Game?", "Race Game", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    RaceGame openRace = new RaceGame();
                    this.Hide();
                    openRace.ShowDialog();
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    pbx_tent1.Location = new Point(426, 319);
                }
            }
            if (pbx_mainCharacter.Bounds.IntersectsWith(pbx_tent2.Bounds))
            {
                pbx_tent2.Location = new Point(800, 800);

                DialogResult dialogResult = MessageBox.Show("Do you want to play PacMan?", "PacMan", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    PacMan openPacMan = new PacMan();
                    this.Hide();
                    openPacMan.ShowDialog();
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    pbx_tent2.Location = new Point(33, 352);
                }
            }

            CheckBounds();
        }

        private void tmr_main_Tick(object sender, EventArgs e)
        {
            //to make the logo invisable
            pbx_logo.Visible = false;
            //to disable the timer --> timer only starts when mouse hovers the menu button --> hover effect always lasts for exactly one second
            tmr_main.Enabled = false;
            tmr_main.Interval = 1000;
            //change image of the menu button back to normal
            pbx_menuButton.Image = VillageAdventure.Properties.Resources.menuButton;
        }

        private void pbx_menuButton_MouseHover(object sender, EventArgs e)
        {
            //switch picture when mouse hovers
            pbx_menuButton.Image = VillageAdventure.Properties.Resources.menuButtonHover;
            //enable the timer
            tmr_main.Enabled = true;
        }

        private void pbx_menuButton_Click(object sender, EventArgs e)
        {
            Menu openMenu = new Menu();
            this.Hide();
            openMenu.ShowDialog();
            this.Close();
        }

        public void CheckBounds()
        {
            if (pbx_mainCharacter.Left < 0 || pbx_mainCharacter.Width + pbx_mainCharacter.Left > this.ClientRectangle.Width)
            {
                pbx_mainCharacter.Location = new Point(233, 442);

                DialogResult checkBounds = MessageBox.Show("You can't go there!", "Stay in the Village!", MessageBoxButtons.OK);
            }
           
            if (pbx_mainCharacter.Top < 0 || pbx_mainCharacter.Height + pbx_mainCharacter.Top > this.ClientRectangle.Height)
            {
                pbx_mainCharacter.Location = new Point(233, 442);
                DialogResult checkBounds = MessageBox.Show("You can't go there!", "Stay in the Village!", MessageBoxButtons.OK);
            }
        }

            private void pbx_background_Click(object sender, EventArgs e)
            {
                
            }

        private void frm_main_Load(object sender, EventArgs e)
        {
            pbx_mainCharacter.BringToFront();
        }

        private void pbx_logo_Click(object sender, EventArgs e)
        {

        }
    }
}
