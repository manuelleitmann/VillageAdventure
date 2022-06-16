﻿using System;
using System.Drawing;
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
            //to add the graphics to the background to make them transparent
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

            pbx_background.Controls.Add(pbx_sign);
            pbx_sign.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_w2);
            pbx_w2.BackColor = Color.Transparent;
            #endregion
        }

        private void frm_main_KeyDown(object sender, KeyEventArgs e)
        {
            //to get the methods and variables from the "CharacterMovement" class
            CharacterMovement giveDirections = new CharacterMovement();

            giveDirections.x = pbx_mainCharacter.Location.X;
            giveDirections.y = pbx_mainCharacter.Location.Y;

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
            #endregion

            if (pbx_mainCharacter.Bounds.IntersectsWith(pbx_logo.Bounds))
            {
                pbx_logo.Visible = false;
            }
            if (pbx_mainCharacter.Bounds.IntersectsWith(pbx_tent1.Bounds))
            {
                //set the tent to a new location to prevent getting in a loop
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
            if (pbx_mainCharacter.Bounds.IntersectsWith(pbx_w2.Bounds))
            {
                pbx_w2.Location = new Point(800, 800);

                WorldTwo openWorldTwo = new WorldTwo();
                this.Hide();
                openWorldTwo.ShowDialog();
                this.Close();
            }

            CheckBounds();
        }

        public void CheckBounds()
        {
            //to check if the player leaves the form
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

        private void frm_main_Load(object sender, EventArgs e)
        {
            pbx_mainCharacter.BringToFront();
        }
    }
}