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

            #region Transparent
            pbx_backgroundCarGame.Controls.Add(pbx_street);
            pbx_street.BackColor = Color.Transparent;

            pbx_backgroundCarGame.Controls.Add(pbx_changeDirection);
            pbx_changeDirection.BackColor = Color.Transparent;

            pbx_backgroundCarGame.Controls.Add(pbx_changeDirectionLeft);
            pbx_changeDirectionLeft.BackColor = Color.Transparent;

            pbx_backgroundCarGame.Controls.Add(pbx_finishLine);
            pbx_finishLine.BackColor = Color.Transparent;
            #endregion
        }

        private void RaceGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (pbx_car.Bounds.IntersectsWith(pbx_house.Bounds))
            {
                pbx_house.Location = new Point(800, 800);

                DialogResult checkRaceAgain = MessageBox.Show("You lost! Do you want to play again?", "Race Game", MessageBoxButtons.YesNo);
                if (checkRaceAgain == DialogResult.Yes)
                {
                    RaceGame raceAgain = new RaceGame();
                    this.Hide();
                    raceAgain.ShowDialog();
                    this.Close();
                }
                else if (checkRaceAgain == DialogResult.No)
                {
                    frm_main openMainFromRace = new frm_main();
                    this.Hide();
                    openMainFromRace.ShowDialog();
                    this.Close();
                }
            }

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
                if (pbx_car.Bounds.IntersectsWith(pbx_finishLine.Bounds))
                {
                    pbx_finishLine.Location = new Point(800, 800);
                    pbx_enemy.Location = new Point(800, 800);

                    DialogResult checkRaceAgain = MessageBox.Show("You lost! Do you want to play again?", "Race Game", MessageBoxButtons.YesNo);
                    if (checkRaceAgain == DialogResult.Yes)
                    {
                        RaceGame raceAgain = new RaceGame();
                        this.Hide();
                        raceAgain.ShowDialog();
                        this.Close();
                    }
                    else if (checkRaceAgain == DialogResult.No)
                    {
                        frm_main openMainFromRace = new frm_main();
                        this.Hide();
                        openMainFromRace.ShowDialog();
                        this.Close();
                    }
                }
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

            #region Enemy Intercection
            if (pbx_car.Bounds.IntersectsWith(pbx_enemy.Bounds))
            {
                pbx_enemy.Location = new Point(800, 800);

                DialogResult checkRaceAgain = MessageBox.Show("You lost! Do you want to play again?", "Race Game", MessageBoxButtons.YesNo);
                if (checkRaceAgain == DialogResult.Yes)
                {
                    RaceGame raceAgainEnemy = new RaceGame();
                    this.Hide();
                    raceAgainEnemy.ShowDialog();
                    this.Close();
                }
                else if (checkRaceAgain == DialogResult.No)
                {
                    frm_main openMainFromRace = new frm_main();
                    this.Hide();
                    openMainFromRace.ShowDialog();
                    this.Close();
                }
            }
            #endregion

            CheckBounds();
        }

        private void tmr_left_Tick(object sender, EventArgs e)
        {
            int x = 7;
            int y = 0;

            pbx_enemy.Top += y;
            pbx_enemy.Left -= x;

            #region Enemy Intercection
            if (pbx_car.Bounds.IntersectsWith(pbx_enemy.Bounds))
            {
                pbx_enemy.Location = new Point(800, 800);

                DialogResult checkRaceAgain = MessageBox.Show("You lost! Do you want to play again?", "Race Game", MessageBoxButtons.YesNo);
                if (checkRaceAgain == DialogResult.Yes)
                {
                    RaceGame raceAgainEnemy = new RaceGame();
                    this.Hide();
                    raceAgainEnemy.ShowDialog();
                    this.Close();
                }
                else if (checkRaceAgain == DialogResult.No)
                {
                    frm_main openMainFromRace = new frm_main();
                    this.Hide();
                    openMainFromRace.ShowDialog();
                    this.Close();
                }
            }
            #endregion

            CheckBounds();
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
           
            #region Enemy Intercection
            if (pbx_car.Bounds.IntersectsWith(pbx_enemy.Bounds))
            {
                pbx_enemy.Location = new Point(800, 800);

                DialogResult checkRaceAgain = MessageBox.Show("You lost! Do you want to play again?", "Race Game", MessageBoxButtons.YesNo);
                if (checkRaceAgain == DialogResult.Yes)
                {
                    RaceGame raceAgainEnemy = new RaceGame();
                    this.Hide();
                    raceAgainEnemy.ShowDialog();
                    this.Close();
                }
                else if (checkRaceAgain == DialogResult.No)
                {
                    frm_main openMainFromRace = new frm_main();
                    this.Hide();
                    openMainFromRace.ShowDialog();
                    this.Close();
                }
            }
            #endregion

            CheckBounds();
        }

        public void CheckBounds()
        {
            if (pbx_car.Left < 0 || pbx_car.Width + pbx_car.Left > this.ClientRectangle.Width)
            {
                pbx_car.Location = new Point(12, 77);
                
                DialogResult checkRaceAgain = MessageBox.Show("You lost! Do you want to play again?", "Race Game", MessageBoxButtons.YesNo);
                if (checkRaceAgain == DialogResult.Yes)
                {
                    RaceGame raceAgain = new RaceGame();
                    this.Hide();
                    raceAgain.ShowDialog();
                    this.Close();
                }
                else if (checkRaceAgain == DialogResult.No)
                {
                    frm_main openMainFromRace = new frm_main();
                    this.Hide();
                    openMainFromRace.ShowDialog();
                    this.Close();
                }
            }

            if (pbx_car.Top < 0 || pbx_car.Height + pbx_car.Top > this.ClientRectangle.Height)
            {
                pbx_car.Location = new Point(12, 77);

                DialogResult checkRaceAgain = MessageBox.Show("You lost! Do you want to play again?", "Race Game", MessageBoxButtons.YesNo);
                if (checkRaceAgain == DialogResult.Yes)
                {
                    RaceGame raceAgain = new RaceGame();
                    this.Hide();
                    raceAgain.ShowDialog();
                    this.Close();
                }
                else if (checkRaceAgain == DialogResult.No)
                {
                    frm_main openMainFromRace = new frm_main();
                    this.Hide();
                    openMainFromRace.ShowDialog();
                    this.Close();
                }
            }
        }

        private void RaceGame_Load(object sender, EventArgs e)
        {
        }
    }
}
