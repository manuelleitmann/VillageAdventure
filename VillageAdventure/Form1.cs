﻿using System;
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
    }
}
