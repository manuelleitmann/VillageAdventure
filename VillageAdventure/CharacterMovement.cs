using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageAdventure
{
    class CharacterMovement : frm_main
    {
        //#region Variables
        //public bool left;
        //public bool right;
        //public bool up;
        //public bool down;
        //public int x;
        //public int y;
        //#endregion

        #region Move
        public void MoveUp(int x, int y)
        {
            x = pbx_mainCharacter.Location.X;
            y = pbx_mainCharacter.Location.X;
            //.Top -= 5;
        }

        public void MoveDown()
        {
            pbx_mainCharacter.Top += 5;
        }

        public void MoveLeft()
        {
            pbx_mainCharacter.Top -= 5;
        }

        public void MoveRight()
        {
            pbx_mainCharacter.Top += 5;
        }
        #endregion
    }
}
