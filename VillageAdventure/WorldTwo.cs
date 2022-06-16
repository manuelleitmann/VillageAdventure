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
    public partial class WorldTwo : Form
    {
        public WorldTwo()
        {
            InitializeComponent();
            this.KeyPreview = true;
            #region Transparent
            pbx_bg2.Controls.Add(pbx_fire2);
            pbx_fire2.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_fir12);
            pbx_fir12.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_fir22);
            pbx_fir22.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_fir32);
            pbx_fir32.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_tree12);
            pbx_tree12.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_tree22);
            pbx_tree22.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_tent12);
            pbx_tent12.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_tent22);
            pbx_tent22.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_tent32);
            pbx_tent32.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_tent42);
            pbx_tent42.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_bush12);
            pbx_bush12.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_bush22);
            pbx_bush22.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_bush32);
            pbx_bush32.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_bush42);
            pbx_bush42.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_mainCharacter2);
            pbx_mainCharacter2.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_menuButton2);
            pbx_menuButton2.BackColor = Color.Transparent;

            pbx_bg2.Controls.Add(pbx_signWorld1);
            pbx_signWorld1.BackColor = Color.Transparent;
            #endregion
        }

        private void WorldTwo_Load(object sender, EventArgs e)
        {
            pbx_mainCharacter2.BringToFront();
        }

        public void CheckBounds()
        {
            if (pbx_mainCharacter2.Left < 0 || pbx_mainCharacter2.Width + pbx_mainCharacter2.Left > this.ClientRectangle.Width)
            {
                pbx_mainCharacter2.Location = new Point(233, 442);

                DialogResult checkBounds = MessageBox.Show("You can't go there!", "Stay in the Village!", MessageBoxButtons.OK);
            }
        }

        private void WorldTwo_KeyDown_1(object sender, KeyEventArgs e)
        {
            //to get the methods and variables from the "CharacterMovement" class
            CharacterMovement giveDirections = new CharacterMovement();

            giveDirections.x = pbx_mainCharacter2.Location.X;
            giveDirections.y = pbx_mainCharacter2.Location.Y;

            //write in timer not in KeyDown
            #region Keys
            if (e.KeyCode == Keys.W)
            {
                giveDirections.MoveUp();
                //to refresh the location of the picture box
                pbx_mainCharacter2.Location = new Point(giveDirections.x, giveDirections.y);
            }
            else if (e.KeyCode == Keys.S)
            {
                giveDirections.MoveDown();
                pbx_mainCharacter2.Location = new Point(giveDirections.x, giveDirections.y);
            }
            else if (e.KeyCode == Keys.A)
            {
                giveDirections.MoveLeft();
                pbx_mainCharacter2.Location = new Point(giveDirections.x, giveDirections.y);
            }
            else if (e.KeyCode == Keys.D)
            {
                giveDirections.MoveRight();
                pbx_mainCharacter2.Location = new Point(giveDirections.x, giveDirections.y);
            }
            #endregion

            if (pbx_mainCharacter2.Bounds.IntersectsWith(pbx_w1.Bounds))
            {
                pbx_w1.Location = new Point(800, 800);

                frm_main goToWorltOne = new frm_main();
                this.Hide();
                goToWorltOne.ShowDialog();
                this.Close();
            }
            if (pbx_mainCharacter2.Bounds.IntersectsWith(pbx_checkBounds.Bounds))
            {
                pbx_mainCharacter2.Location = new Point(233, 442);
                DialogResult checkBounds = MessageBox.Show("You can't go there!", "Stay in the Village!", MessageBoxButtons.OK);
            }

            CheckBounds();
        }

        private void tmr_w2_Tick_1(object sender, EventArgs e)
        {
            tmr_w2.Enabled = false;
            //change image of the menu button back to normal
            pbx_menuButton2.Image = VillageAdventure.Properties.Resources.menuButton;
        }

        private void pbx_menuButton2_MouseHover_1(object sender, EventArgs e)
        {
            //switch picture when mouse hovers
            pbx_menuButton2.Image = VillageAdventure.Properties.Resources.menuButtonHover;
            //enable the timer
            tmr_w2.Enabled = true;
        }
    }
}
