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
        //fix not moving
        private void tmr_raceGame_Tick(object sender, EventArgs e)
        {
            int x = 7;
            int y = 0;

            if (pbx_enemy.Bounds.IntersectsWith(pbx_changeDirection.Bounds))
            {
                x = 0;
                y = 7;
            }
            else if (pbx_enemy.Bounds.IntersectsWith(pbx_changeDirection2.Bounds))
            {
                x = 14;
                y = 0;
                
                pbx_enemy.Left -= x;
            }

            pbx_enemy.Top += y;
            pbx_enemy.Left += x;
        }
    }
}
