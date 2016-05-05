using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diceRoller
{
    public partial class Form1 : Form
    {
        bool playerOneRolled = false;
        bool playerTwoRolled = false;
        Player playerOne = new Player();
        Player playerTwo = new Player();

        public Form1()
        {
            InitializeComponent();
        }

        private void rollPlayer1_Click(object sender, EventArgs e)
        {
            if (playerTwoRolled == true)
            {

            }
            else
            {

            }

        }
    }
}
