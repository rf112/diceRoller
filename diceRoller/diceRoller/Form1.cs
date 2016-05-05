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
        Dice die = new Dice();

        public Form1()
        {
            InitializeComponent();
        }

        private void rollPlayer1_Click(object sender, EventArgs e)
        {
            if (playerTwoRolled == true)
            {
                playerOne.CurrentRoll = die.diceRoll();
                playerOneRollBox.Text = playerOne.CurrentRoll.ToString();
                playerOneRolled = false;
                playerTwoRolled = false;
                rollPlayer1.Enabled = true;
                rollPlayer2.Enabled = true;
                if (playerOne.CurrentRoll > playerTwo.CurrentRoll)
                {
                    playerOne.CurrentWins++;
                    playerTwo.CurrentLosses++;
                    result.Text = "Player One Wins The Round";
                }
                else if(playerOne.CurrentRoll < playerTwo.CurrentRoll)
                {
                    playerTwo.CurrentWins++;
                    playerOne.CurrentLosses++;
                    result.Text = "Player Two Wins The Round";
                }
                else
                {
                    result.Text = "It Was A Tie";
                }

                playerOneWins.Text = playerOne.CurrentWins.ToString();
                playerOneLoss.Text = playerOne.CurrentLosses.ToString();
                playerTwoWins.Text = playerTwo.CurrentWins.ToString();
                playerTwoLoss.Text = playerTwo.CurrentLosses.ToString();

                if(playerOne.CurrentWins > playerTwo.CurrentWins)
                {
                    currentWinner.Text = "Player One Is Winning";
                }
                else if(playerOne.CurrentWins < playerTwo.CurrentWins)
                {
                    currentWinner.Text = "Player Two Is Winning";
                }
                else
                {
                    currentWinner.Text = "It is all tied up";
                }


            }
            else
            {
                playerOne.CurrentRoll = die.diceRoll();
                playerTwoRollBox.Text = "";
                playerOneRollBox.Text = playerOne.CurrentRoll.ToString();
                playerOneRolled = true;
                rollPlayer1.Enabled = false;
            }

        }

        private void rollPlayer2_Click(object sender, EventArgs e)
        {
            if(playerOneRolled == true)
            {
                playerTwo.CurrentRoll = die.diceRoll();
                playerTwoRollBox.Text = playerTwo.CurrentRoll.ToString();
                playerOneRolled = false;
                playerTwoRolled = false;
                rollPlayer1.Enabled = true;
                rollPlayer2.Enabled = true;
                if (playerOne.CurrentRoll > playerTwo.CurrentRoll)
                {
                    playerOne.CurrentWins++;
                    playerTwo.CurrentLosses++;
                    result.Text = "Player One Wins The Round";
                }
                else if (playerOne.CurrentRoll < playerTwo.CurrentRoll)
                {
                    playerTwo.CurrentWins++;
                    playerOne.CurrentLosses++;
                    result.Text = "Player Two Wins The Round";
                }
                else
                {
                    result.Text = "It Was A Tie";
                }

                playerOneWins.Text = playerOne.CurrentWins.ToString();
                playerOneLoss.Text = playerOne.CurrentLosses.ToString();
                playerTwoWins.Text = playerTwo.CurrentWins.ToString();
                playerTwoLoss.Text = playerTwo.CurrentLosses.ToString();

                if (playerOne.CurrentWins > playerTwo.CurrentWins)
                {
                    currentWinner.Text = "Player One Is Winning";
                }
                else if (playerOne.CurrentWins < playerTwo.CurrentWins)
                {
                    currentWinner.Text = "Player Two Is Winning";
                }
                else
                {
                    currentWinner.Text = "It is all tied up";
                }


            }
            else
            {
                playerTwo.CurrentRoll = die.diceRoll();
                playerOneRollBox.Text = "";
                playerTwoRollBox.Text = playerTwo.CurrentRoll.ToString();
                playerTwoRolled = true;
                rollPlayer2.Enabled = false;
            }
           
        }


        private void reset_Click(object sender, EventArgs e)
        {
            playerOne = new Player();
            playerTwo = new Player();
            playerOneRolled = false;
            playerTwoRolled = false;

            playerOneRollBox.Text = "";
            playerTwoRollBox.Text = "";
            result.Text = "";
            playerOneLoss.Text = "";
            playerOneWins.Text = "";
            playerTwoLoss.Text = "";
            playerTwoWins.Text = "";
            currentWinner.Text = "";

        }
    }
}
