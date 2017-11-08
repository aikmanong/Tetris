using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; 

namespace Tetris
{
    class TetrisGrid
    {
        const int width = 9;
        const int length = 17;
        int[,] gameGrid = new int [width,length]; //9x17 Tetris Grid 

        /// <summary>
        /// Purpose of this method is to reset the game board to all zeros.
        /// </summary>
        public void NewGame()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j =0; j <length; j++)
                {
                    gameGrid[i, j] = 0;
                }
            }
        }
    }
}
