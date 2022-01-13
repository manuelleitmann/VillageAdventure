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
        int pbx_y = 270;
        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();
        PictureBox pbx_test = new PictureBox();
        #endregion

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
            if (pbx_character.Bounds.IntersectsWith(pbx_left.Bounds))
            {
                pbx_character.Location = new Point(288, pbx_character.Location.Y);
            }
        }

        private void frm_doodlejump_Load(object sender, EventArgs e)
        {
            MakePlatform();
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
        
        
       

        private void tmr_falldown_Tick(object sender, EventArgs e)
        {
            GravityDown();
        }

        private void tmr_checkbounds_Tick(object sender, EventArgs e)
        {
            CheckBounds();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void tmr_spawnplatform_Tick(object sender, EventArgs e)
        {
            //MakePlatform();
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
            if (pbx_character.Bounds.IntersectsWith(pbx_test.Bounds) && pbx_test.Top + pbx_test.Height >= pbx_test.Top)
            {
                gravity = -1;
            } 

            if(pbx_character.Bounds.IntersectsWith(pbx_down.Bounds))
            {
                pbx_down.Location = new Point(800, 800);
                DialogResult message = MessageBox.Show("You Lost!", "You was too slow to hit a platform!", MessageBoxButtons.YesNo);

                if(message == DialogResult.Yes)
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
    }

    
}
