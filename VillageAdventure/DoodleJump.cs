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

            if(e.KeyCode == Keys.Right)
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
            //int x = pbx_character.Location.X;
            //int y = pbx_character.Location.Y;

            //int width = this.ClientRectangle.Width;
            //width = 350;

            //if (pbx_character.Right > 0 || pbx_character.Width + pbx_character.Right > width)
            //{
            //    pbx_character.Location = new Point(this.ClientRectangle.Right, y);   
            //}
            //else if (pbx_character.Left > 350 || pbx_character.Width + pbx_character.Right > width)
            //{
            //    pbx_character.Location = new Point(this.ClientRectangle.Left, y);
            //}
        }

        private void frm_doodlejump_Load(object sender, EventArgs e)
        {
            pbx_character.Location = new Point(136, 380);
            

            
        }

        public void Gravity()
        {
            pbx_y += gravity;
            pbx_character.Location = new Point(pbx_character.Location.X, pbx_y);
        }

        private void tmr_gravity_Tick(object sender, EventArgs e)
        {
            Gravity();

            CheckBounds();
        }
    }
}
