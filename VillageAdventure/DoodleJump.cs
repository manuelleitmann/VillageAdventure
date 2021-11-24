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
            int x = pbx_character.Location.X;
            int y = pbx_character.Location.Y;


            if (pbx_character.Left < 0 || pbx_character.Width + pbx_character.Left > this.ClientRectangle.Width)
            {
                pbx_character.Location = new Point(this.ClientRectangle.Left, y);   
            }
            else if (pbx_character.Right > 345 || pbx_character.Width + pbx_character.Right > this.ClientRectangle.Width)
            {
                pbx_character.Location = new Point(this.ClientRectangle.Right, y);
            }
        }

        private void frm_doodlejump_Load(object sender, EventArgs e)
        {

        }

        private void tmr_gravity_Tick(object sender, EventArgs e)
        {
            CheckBounds();
        }
    }
}
