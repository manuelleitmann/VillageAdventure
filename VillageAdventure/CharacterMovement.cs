using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageAdventure
{
    class CharacterMovement
    {
        #region Variables
        //variables for movement
        public int x;
        public int y;
        #endregion

        #region Move
        //methods for movement
        public void MoveUp()
        {
            y -= 5;
        }

        public void MoveDown()
        {
            y += 5;
        }

        public void MoveLeft()
        {
            x -= 10;
        }

        public void MoveRight()
        {
            x += 10;
        }
        #endregion
    }
}