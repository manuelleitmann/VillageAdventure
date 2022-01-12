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
        int gravity = 1;
        
        
        int pbx_x, pbx_y, pbx_w, pbx_h;
        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();

        public frm_doodlejump()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_doodlejump_KeyDown(object sender, KeyEventArgs e)
        {
            CharacterMovement locations = new CharacterMovement();
            locations.x = pbx_character.Location.X;
            locations.y = pbx_character.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                locations.MoveRight();
                pbx_character.Location = new Point(locations.x, locations.y);
            }
            else if(e.KeyCode == Keys.Left)
            {
                locations.MoveLeft();
                pbx_character.Location = new Point(locations.x, locations.y);
            }

            
        }

        public void CheckBounds()
        {
            if (pbx_character.Width + pbx_character.Left > this.ClientRectangle.Width)
            {
                pbx_character.Location = new Point(1, pbx_character.Location.Y);
            }
            if (pbx_character.Left + pbx_character.Width < 1)
            {
                pbx_character.Location = new Point(400, pbx_character.Location.Y);
            }


            //try check with picture box
            if (pbx_character.Top < 0 || pbx_character.Height + pbx_character.Top > this.ClientRectangle.Height)
            {
                MessageBox.Show("You Lost!");

                gravity = 0;
                pbx_character.Location = new Point(1, 231);
            }
        }

        private void frm_doodlejump_Load(object sender, EventArgs e)
        {
            pbx_character.Location = new Point(136, 100);

            MakePlatform();
        }

        PictureBox pbx_test = new PictureBox();

        private void MakePlatform()
        {            
            pbx_test.Height = 30;
            pbx_test.Width = 55;
            pbx_test.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_test.Image = Properties.Resources.DoodleJumpPlatformtransparent;

            int x = rand.Next(0, 275);
            int y = rand.Next(10, 350);

            pbx_test.Location = new Point(x, y);

            items.Add(pbx_test);
            this.Controls.Add(pbx_test);
        }

        private void tmr_falldown_Tick(object sender, EventArgs e)
        {
            GravityDown();
        }

        private void tmr_checkbounds_Tick(object sender, EventArgs e)
        {
            CheckBounds();
        }

        private void pbx_platform_Click(object sender, EventArgs e)
        {

        }

        public void GravityDown()
        {
            pbx_y += gravity;
            pbx_character.Location = new Point(pbx_character.Location.X, pbx_y); 
        }

        

        private void tmr_gravity_Tick(object sender, EventArgs e)
        {
            if (pbx_character.Bounds.IntersectsWith(pbx_test.Bounds))
            {
                gravity = -1;
            } 
        }
    }
}
