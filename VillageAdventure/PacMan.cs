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
    public partial class PacMan : Form
    {
        public PacMan()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void PacMan_Load(object sender, EventArgs e)
        {

        }

        private void PacMan_KeyDown(object sender, KeyEventArgs e)
        {
            CharacterMovement movePacMan = new CharacterMovement();
            movePacMan.x = pbx_pacMan.Location.X;
            movePacMan.y = pbx_pacMan.Location.Y;


            if (e.KeyCode == Keys.W)
            {
                movePacMan.MoveUp();
                //to refresh the location of the picture box
                pbx_pacMan.Location = new Point(movePacMan.x, movePacMan.y);
            }
            else if (e.KeyCode == Keys.S)
            {
                movePacMan.MoveDown();
                pbx_pacMan.Location = new Point(movePacMan.x, movePacMan.y);
               
            }
            else if (e.KeyCode == Keys.A)
            {
                movePacMan.MoveLeft();
                pbx_pacMan.Location = new Point(movePacMan.x, movePacMan.y);             
            }
            else if (e.KeyCode == Keys.D)
            {
                movePacMan.MoveRight();
                pbx_pacMan.Location = new Point(movePacMan.x, movePacMan.y);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Menu pacManMenu = new Menu();
                this.Hide();
                pacManMenu.ShowDialog();
                this.Close();
            }
        }
    }
}
