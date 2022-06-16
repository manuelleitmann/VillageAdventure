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
    public partial class AvoidGame : Form
    {

        public int enemy;
        public int xRnd;

        public AvoidGame()
        {
            InitializeComponent();
        }

        private void lbl_info_Click(object sender, EventArgs e)
        {
            
        }

        private void AvoidGame_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            enemy = rnd.Next(0, 2);
            xRnd = rnd.Next(0,458);
        }

        private void tmr_main_Tick(object sender, EventArgs e)
        {
            if(enemy == 0)
            {
                PictureBox enemypic = new PictureBox();
                enemypic.Width = 10;
                enemypic.Height = 10;
                enemypic.BackColor = Color.Red;
                Controls.Add(enemypic);

                MessageBox.Show(enemy.ToString());
            }
        }
    }
}
