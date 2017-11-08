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
        int[,] gameGrid = new int [9,17]; //9x17 Tetris Grid 
        int[,] block = new int[4, 4]; //Pieces

        /// <summary>
        /// Purpose of this method is to reset the game board to all zeros.
        /// </summary>
        public void NewGame()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j =0; j <17; j++)
                {
                    gameGrid[i, j] = 0;
                }
            }
        }
    }
}
