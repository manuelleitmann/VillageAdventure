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
    public partial class frm_doodlejump : Form
    {
        #region Variablen
        int gravity = 1;
        int pbx_y = 5;
        int force = -1;
        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();
        PictureBox pbx_test = new PictureBox();
        #endregion

        public frm_doodlejump()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public void CheckBounds()
        {
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

            pbx_test.Height = 30;
            pbx_test.Width = 55;
            pbx_test.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_test.Image = Properties.Resources.DoodleJumpPlatformtransparent;

            int x = rand.Next(0, 275);
            int y = rand.Next(0, 350);

            pbx_test.Location = new Point(x, y);

            items.Add(pbx_test);
            this.Controls.Add(pbx_test);

        }


        public void GravityDown()
        {
            pbx_y += gravity;
            pbx_character.Location = new Point(pbx_character.Location.X, pbx_y);
        }

        private void tmr_gravity_Tick_1(object sender, EventArgs e)
        {

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
            if (pbx_character.Bounds.IntersectsWith(pbx_test.Bounds))
            {
                gravity = force;
            }
        }

        private void frm_doodlejump_KeyDown_1(object sender, KeyEventArgs e)
        {
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

        private void frm_doodlejump_Load_1(object sender, EventArgs e)
        {
            MakePlatform();
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
