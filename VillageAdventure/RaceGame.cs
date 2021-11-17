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
    public partial class RaceGame : Form
    {
        public RaceGame()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void RaceGame_KeyDown(object sender, KeyEventArgs e)
        {
            CharacterMovement giveDirections = new CharacterMovement();
            giveDirections.x = pbx_car.Location.X;
            giveDirections.y = pbx_car.Location.Y;

            if (e.KeyCode == Keys.W)
            {
                giveDirections.MoveUp();
                //to refresh the location of the picture box
                pbx_car.Location = new Point(giveDirections.x, giveDirections.y);
            }
            else if (e.KeyCode == Keys.S)
            {
                giveDirections.MoveDown();
                pbx_car.Location = new Point(giveDirections.x, giveDirections.y);
            }
            else if (e.KeyCode == Keys.A)
            {
                giveDirections.MoveLeft();
                pbx_car.Location = new Point(giveDirections.x, giveDirections.y);
            }
            else if (e.KeyCode == Keys.D)
            {
                giveDirections.MoveRight();
                pbx_car.Location = new Point(giveDirections.x, giveDirections.y);
            }
        }
        //remove multiple timers --> try to make with one timer
        private void tmr_raceGame_Tick(object sender, EventArgs e)
        {
            int x = 7;
            int y = 0;

            if (pbx_enemy.Bounds.IntersectsWith(pbx_changeDirection.Bounds))
            {
                tmr_down.Enabled = true;
                tmr_raceGame.Enabled = false;
            }
           
            pbx_enemy.Top += y;
            pbx_enemy.Left += x;
        }

        private void tmr_left_Tick(object sender, EventArgs e)
        {
            int x = 7;
            int y = 0;

            pbx_enemy.Top += y;
            pbx_enemy.Left -= x;
        }

        private void tmr_down_Tick(object sender, EventArgs e)
        {
            int x = 0;
            int y = 7;

            if (pbx_enemy.Bounds.IntersectsWith(pbx_changeDirectionLeft.Bounds))
            {
                tmr_down.Enabled = false;
                tmr_left.Enabled = true;
            }

            pbx_enemy.Top += y;
            pbx_enemy.Left += x;
        }
    }
}
