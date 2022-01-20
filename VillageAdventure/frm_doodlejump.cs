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
    public partial class frm_doodlejump: Form
    {
        public frm_doodlejump()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void frm_doodlejump_Load(object sender, EventArgs e)
        {
            MakePlatform();
        }
        #region Variablen
        int gravity = 1;
        int pbx_y = 5;
        int force = -1;
        //for random platform locations
        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();
        //create new picture box
        PictureBox pbx_test = new PictureBox();
        #endregion


        public void CheckBounds()
        {
            //check if character is out of bounds --> if character is out of bounds he spawns on the other side
            if (pbx_character.Width + pbx_character.Left > this.ClientRectangle.Width)
            {
                pbx_character.Location = new Point(1, pbx_character.Location.Y);
            }
            if (pbx_character.Bounds.IntersectsWith(pbx_left.Bounds))
            {
                pbx_character.Location = new Point(288, pbx_character.Location.Y);
            }
        }

        private void MakePlatform()
        {
            //values for the platforms
            pbx_test.Height = 30;
            pbx_test.Width = 55;
            pbx_test.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_test.Image = Properties.Resources.DoodleJumpPlatformtransparent;

            //random locations
            int x = rand.Next(0, 275);
            int y = rand.Next(0, 350);

            pbx_test.Location = new Point(x, y);

            //add the picture boxes to list
            items.Add(pbx_test);
            this.Controls.Add(pbx_test);
        }


        public void GravityDown()
        {
            //to drag the character down
            pbx_y += gravity;
            pbx_character.Location = new Point(pbx_character.Location.X, pbx_y);
        }

        private void frm_doodlejump_KeyDown_1(object sender, KeyEventArgs e)
        {
            //to move the character left and right
            CharacterMovement locations = new CharacterMovement();
            locations.x = pbx_character.Location.X;
            locations.y = pbx_character.Location.Y;

            if (e.KeyCode == Keys.D)
            {
                locations.MoveRight();
                pbx_character.Location = new Point(locations.x, locations.y);
            }
            else if (e.KeyCode == Keys.A)
            {
                locations.MoveLeft();
                pbx_character.Location = new Point(locations.x, locations.y);
            }
        }

        private void tmr_gravity_Tick_1(object sender, EventArgs e)
        {
            //to let the character jump if he hits a platform
            if (pbx_character.Bounds.IntersectsWith(pbx_test.Bounds) && pbx_test.Top + pbx_test.Height >= pbx_test.Top)
            {
                gravity = -1;
            }

            //if the caracter falls out of the map, the player has lost
            if (pbx_character.Bounds.IntersectsWith(pbx_down.Bounds))
            {
                pbx_down.Location = new Point(800, 800);
                DialogResult message = MessageBox.Show("Do you want to play again?", "You missed a platform!", MessageBoxButtons.YesNo);

                if (message == DialogResult.Yes)
                {
                    frm_doodlejump dj = new frm_doodlejump();
                    this.Hide();
                    dj.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void tmr_falldown_Tick_1(object sender, EventArgs e)
        {
            GravityDown();
        }

        private void tmr_checkbounds_Tick_1(object sender, EventArgs e)
        {
            CheckBounds();
        }

        private void tmr_spawnplatform_Tick_1(object sender, EventArgs e)
        {
            //timer for letting the character jump
            if (pbx_character.Bounds.IntersectsWith(pbx_test.Bounds))
            {
                gravity = force;
            }
        }

        private void frm_doodlejump_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_main openMainfromDJ = new frm_main();
            this.Hide();
            openMainfromDJ.ShowDialog();
            this.Close();
        }
    }
}
