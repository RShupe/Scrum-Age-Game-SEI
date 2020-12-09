using System;
using System.Collections.Generic;
using System.Windows.Forms;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      EndGame.cs
//	Description:                    Form that displays the score of the game and determines the winner
//	Author:                         Ryan Shupe
//  Last Modified By:               Ryan Shupe
//	Created:                        Tuesday December 1st, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Stone_Age_Game.GameForms
{
    public partial class EndGame : Form
    {
        public EndGame(List<Player> playerList)
            : this()
        {
            InitializeComponent();

            //count the final points that each player has
            for(int i = 0; i < playerList.Count; i++)
            {
                playerList[i].CalcPoints();
            }

            if (playerList.Count == 1)
            {
                Player1ResultLabel.Visible = true;
                Player1Results.Visible = true;
                Player1Results.Text = playerList[0].VictoryPoints.ToString();
            }
            else if (playerList.Count == 2)
            {
                Player1ResultLabel.Visible = true;
                Player1Results.Visible = true;
                Player1Results.Text = playerList[0].VictoryPoints.ToString();
                Player2ResultLabel.Visible = true;
                Player2Results.Visible = true;
                Player2Results.Text = playerList[1].VictoryPoints.ToString();

            }
            else if (playerList.Count == 3)
            {
                Player1ResultLabel.Visible = true;
                Player1Results.Visible = true;
                Player1Results.Text = playerList[0].VictoryPoints.ToString();
                Player2ResultLabel.Visible = true;
                Player2Results.Visible = true;
                Player2Results.Text = playerList[1].VictoryPoints.ToString();
                Player3ResultLabel.Visible = true;
                Player3Results.Visible = true;
                Player3Results.Text = playerList[2].VictoryPoints.ToString();
            }
            else if (playerList.Count == 4)
            {
                Player1ResultLabel.Visible = true;
                Player1Results.Visible = true;
                Player1Results.Text = playerList[0].VictoryPoints.ToString();
                Player2ResultLabel.Visible = true;
                Player2Results.Visible = true;
                Player2Results.Text = playerList[1].VictoryPoints.ToString();
                Player3ResultLabel.Visible = true;
                Player3Results.Visible = true;
                Player3Results.Text = playerList[2].VictoryPoints.ToString();
                Player4ResultLabel.Visible = true;
                Player4Results.Visible = true;
                Player4Results.Text = playerList[3].VictoryPoints.ToString();
            }

            //get the winner of the game and display the check mark
            int winner = GetWinner(playerList);

            if(winner == 1)
            {
                pictureBox1.Visible = true;
            }
            else if (winner == 2)
            {
                pictureBox2.Visible = true;
            }
            else if (winner == 3)
            {
                pictureBox3.Visible = true;
            }
            else if (winner == 4)
            {
                pictureBox4.Visible = true;
            }

        }

        public EndGame()
        {
        }

        private int GetWinner(List<Player> playerList)
        {
            int result = 0;
            if(playerList.Count == 1)
            {
                result = 1;
            }
            else if (playerList.Count == 2)
            {
                if (playerList[0].VictoryPoints > playerList[1].VictoryPoints)
                {
                    result = 1;
                }
                else
                {
                    result = 2;
                }
            }
            else if (playerList.Count == 3)
            {
                if (playerList[0].VictoryPoints > playerList[1].VictoryPoints &&
                    playerList[0].VictoryPoints > playerList[2].VictoryPoints)
                {
                    result = 1;
                }
                else if (playerList[1].VictoryPoints > playerList[0].VictoryPoints &&
                         playerList[1].VictoryPoints > playerList[2].VictoryPoints)
                {
                    result = 2;
                }
                else
                {
                    result = 3;
                }
            }
            else if (playerList.Count == 4)
            {
                if (playerList[0].VictoryPoints > playerList[1].VictoryPoints &&
                    playerList[0].VictoryPoints > playerList[2].VictoryPoints &&
                    playerList[0].VictoryPoints > playerList[3].VictoryPoints)
                {
                    result = 1;
                }
                else if (playerList[1].VictoryPoints > playerList[0].VictoryPoints &&
                         playerList[1].VictoryPoints > playerList[2].VictoryPoints &&
                         playerList[1].VictoryPoints > playerList[3].VictoryPoints)
                {
                    result = 2;
                }
                else if (playerList[2].VictoryPoints > playerList[0].VictoryPoints &&
                         playerList[2].VictoryPoints > playerList[1].VictoryPoints &&
                         playerList[2].VictoryPoints > playerList[3].VictoryPoints)
                {
                    result = 3;
                }
                else
                {
                    result = 4;
                }
            }

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void EndGame_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}