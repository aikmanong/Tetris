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
        const int width = 10;
        const int length = 20; 
        int[,] gameGrid = new int [width,length]; 


        //Starts new game empties tetris grid to zero. 
        public void NewGame()
        {
            for(int i = 0; i<width;i++)
            {
                for(int j = 0; j<length; i++)
                {
                    gameGrid[i, j] = 0; 
                }
            }
        }
    }
}
