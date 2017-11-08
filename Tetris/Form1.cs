using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Aikman Ong
/// 816056118
/// ---------
/// Giancarlo Escolano
/// 813215631
/// ---------
/// Tetris
/// </summary>
namespace Tetris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Integer to represent in game score
        private int gameScore { get; set; }

        /// <summary>
        /// Property to modify and get value of gameScore
        /// </summary>
        public int GameScore
        {
            get { return gameScore; }
            set { gameScore = value; }
        }

        /// <summary>
        /// Score of the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Score_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Responsible for "Level" label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Picture box label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Grid in middle of table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// To represent the score of the current game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = gameScore.ToString(); //Put gameScore integer into the Score textbox
            textBox1.TextAlign = HorizontalAlignment.Right; //Align the text right in the game score box
        }
    }
}
