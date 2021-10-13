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
            pbx_background.Controls.Add(pbx_fire);
            pbx_fire.BackColor = Color.Transparent;
        }

        private void pbx_fire_Click(object sender, EventArgs e)
        {

        }
    }
}
