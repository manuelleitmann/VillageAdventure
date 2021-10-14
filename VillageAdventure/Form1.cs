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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();

            #region Transparent
            pbx_background.Controls.Add(pbx_fire);
            pbx_fire.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_fir1);
            pbx_fir1.BackColor = Color.Transparent;
            
            pbx_background.Controls.Add(pbx_fir2);
            pbx_fir2.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_fir3);
            pbx_fir3.BackColor = Color.Transparent;
            
            pbx_background.Controls.Add(pbx_tree1);
            pbx_tree1.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_tree2);
            pbx_tree2.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_tent1);
            pbx_tent1.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_tent2);
            pbx_tent2.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_tent3);
            pbx_tent3.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_tent4);
            pbx_tent4.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_bush1);
            pbx_bush1.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_bush2);
            pbx_bush2.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_bush3);
            pbx_bush3.BackColor = Color.Transparent;

            pbx_background.Controls.Add(pbx_bush4);
            pbx_bush4.BackColor = Color.Transparent;
            #endregion
        }

        private void pbx_fire_Click(object sender, EventArgs e)
        {
            CharacterMovement giveUp = new CharacterMovement();
           // int x = pbx_mainCharacter.Location.X;
           // int y = pbx_mainCharacter.Location.Y;


            giveUp.MoveUp();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }
    }
}
