///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      Form1.cs
//	Description:                    Main Form where game will be played on
//	Author:                         Team 1
//  Last Modified By:               Ricky Keller
//	Created:                        Monday, October 21th, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stone_Age_Game
{
    public partial class MainForm : Form
    {
        public static int CurrentPlayer = 1;//keeps track of current player
        //will be used to keep track of how many positions are available for a given spot on map
        public static int MoneyPos = 10;
        public static int UserStoryPos = 7;
        public static int UseCasePos = 6;
        public static int PrototypePos = 4;
        public static int HRDeptPos = 4;
        public static int SMPos = 3;
        public MainForm()
        {
            InitializeComponent();
        }

        List<Player> playerList = new List<Player>();
        List<List<string>> playerAreas = new List<List<string>>();

        #region Form1 Load
        /// <summary>
        /// Handles what happens when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageForm messageForm = new MessageForm();
            //GameStart gs = new GameStart();
            messageForm.ShowDialog();
            int numPlayers = (int)Int32.Parse((string)messageForm.comboBox1.SelectedItem);
            for (int i = 1; i < numPlayers + 1; i++)
            {
                playerList.Add(new Player());

                playerAreas.Add(new List<string>());

            }


            //gs.ShowDialog();
            numPlayersBox.Text = numPlayers.ToString();

            playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
            currentPlayerBox.Text = CurrentPlayer.ToString();

        }
        #endregion

        #region Dice Roller Button Click
        /// <summary>
        /// Rolls dice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DiceRoller dice = new DiceRoller();

            diceResultBox.Text = dice.RollDice(2).ToString();
           
        }
        #endregion

        #region UpKeepBtn Click
        /// <summary>
        /// upkeep button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            playerList[0].Upkeep();

            playerDataBox.Text = playerList[0].ToString();
        }
        #endregion

        #region RefreshBtn Click
        /// <summary>
        /// refresh button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            playerDataBox.Text = playerList[0].ToString();
        }
        #endregion

        #region BankBoxClick
        /// <summary>
        /// BankBoxClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bankBox_Click(object sender, EventArgs e)
        {
            placingOnBox.Text = "Bank";
            devPlacementBox.Enabled = true;
            devsLeftBox.Text = playerList[0].NumDevelopers.ToString();
            availPosBox.Text = MoneyPos.ToString();
        }
        #endregion

        #region User Story Box Click
        /// <summary>
        /// User Story Box Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userStoryBox_Click(object sender, EventArgs e)
        {
            placingOnBox.Text = "User Story";
            devPlacementBox.Enabled = true;
            devsLeftBox.Text = playerList[0].NumDevelopers.ToString();
            availPosBox.Text = UserStoryPos.ToString();
        }
        #endregion

        #region Use Case Box Click
        /// <summary>
        /// Use Case Box Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useCaseBox_Click(object sender, EventArgs e)
        {
            placingOnBox.Text = "Use Case";
            devPlacementBox.Enabled = true;
            devsLeftBox.Text = playerList[0].NumDevelopers.ToString();
            availPosBox.Text = UseCasePos.ToString();
        }
        #endregion

        #region Scrum Master Box Click
        /// <summary>
        /// Scrum Master Box Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SMBox_Click(object sender, EventArgs e)
        {
            placingOnBox.Text = "Scrum Master";
            devPlacementBox.Enabled = true;
            devsLeftBox.Text = playerList[0].NumDevelopers.ToString();
            availPosBox.Text = SMPos.ToString();
        }
        #endregion

        #region HR Dept Box Click
        /// <summary>
        /// HR Dept Box Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hrDeptBox_Click(object sender, EventArgs e)
        {
            placingOnBox.Text = "Human Resources";
            devPlacementBox.Enabled = true;
            devsLeftBox.Text = playerList[0].NumDevelopers.ToString();
            availPosBox.Text = HRDeptPos.ToString();
        }
        #endregion

        #region Prototype Box Click
        /// <summary>
        /// Prototype Box Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void protoBox_Click(object sender, EventArgs e)
        {
            placingOnBox.Text = "Prototype";
            devPlacementBox.Enabled = true;
            devsLeftBox.Text = playerList[0].NumDevelopers.ToString();
            availPosBox.Text = PrototypePos.ToString();
        }
        #endregion

        #region Confirm Developers Placed 
        /// <summary>
        /// Confirm Developers placed button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmDevsBtn_Click(object sender, EventArgs e)
        {

            int numToExchange = Int32.Parse(devsPlacedBox.Text);
            if (numToExchange - playerList[CurrentPlayer - 1].NumDevelopers <= 0)
            {
                devsAfterBox.Text = (playerList[CurrentPlayer - 1].NumDevelopers - numToExchange).ToString();
                playerList[CurrentPlayer - 1].NumDevelopers = playerList[CurrentPlayer - 1].NumDevelopers - numToExchange;
                devPlacementBox.Enabled = false;
                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
                string parm = placingOnBox.Text;
                availPosBox.Text = ResourcePositionsLeft(parm, numToExchange).ToString();
            }
            else
                devsAfterBox.Text = "ERROR";

        }
        #endregion

        #region Resource Positions Left
        /// <summary>
        /// Resource Positions left
        /// </summary>
        /// <param name="parm"></param>
        /// <param name="numDevs"></param>
        /// <returns></returns>
        private int ResourcePositionsLeft(string parm, int numDevs)
        {
            int result = 0;
            if (parm == "User Story")
            {
                UserStoryPos = UserStoryPos - numDevs;
                result = UserStoryPos;
            }
            else if (parm == "Use Case")
            {
                UseCasePos = UseCasePos - numDevs; ;
                result = UseCasePos;
            }
            else if (parm == "Prototype")
            {
                PrototypePos = PrototypePos - numDevs;
                result = PrototypePos;
            }
            else if (parm == "Bank")
            {
                MoneyPos = MoneyPos - numDevs;
                result = MoneyPos;
            }
            else if (parm == "Human Resources")
            {
                HRDeptPos = HRDeptPos - numDevs;
                result = HRDeptPos;
            }
            else if (parm == "Scrum Master")
            {
                SMPos = SMPos - numDevs;
                result = SMPos;
            }
            return result;
        }
        #endregion

        #region End Turn 1 Button Click
        /// <summary>
        /// End Turn 1 button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endTurnBtn_Click(object sender, EventArgs e)
        {
           
            if (CurrentPlayer == Int32.Parse(numPlayersBox.Text))//moves onto next phase of game
            {
                //enables and disables game control to transition player to next phase
                boardBox.Enabled = false;
                endTurn1Btn.Enabled = false;
                endTurn2Btn.Enabled = true;
                CurrentPlayer = 1;
                instTeller.Text = "Select area where developers were placed, and roll amount of \r\n dice equal to amount of developers there.";
                currentPlayerBox.Text = CurrentPlayer.ToString();
                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
                Phase1Comp phase1End = new Phase1Comp();
                phase1End.ShowDialog();
               
            }
            else if(CurrentPlayer < Int32.Parse(numPlayersBox.Text))//moves onto next players' turn
            {
                CurrentPlayer += 1;
                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
                currentPlayerBox.Text = CurrentPlayer.ToString();
            }
                
        }
        #endregion

        #region End Turn 2 Button Click
        /// <summary>
        /// End Turn 2 button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endTurn2Btn_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer == Int32.Parse(numPlayersBox.Text))//moves onto next phase of game
            {
                //enables and disables game control to transition player to next phase
                endTurn2Btn.Enabled = false;
                endTurn3Btn.Enabled = true;
                CurrentPlayer = 1;
                instTeller.Text = "Wait...";
                currentPlayerBox.Text = CurrentPlayer.ToString();
                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
            }
            else if (CurrentPlayer < Int32.Parse(numPlayersBox.Text))//moves onto next players' turn
            {
                CurrentPlayer += 1;
                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
                currentPlayerBox.Text = CurrentPlayer.ToString();
            }
        }
        #endregion

        #region End Turn 3 Button Click
        /// <summary>
        /// End Turn 3 button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endTurn3Btn_Click(object sender, EventArgs e)
        {

            playerList[CurrentPlayer - 1].Upkeep();
            if (CurrentPlayer == Int32.Parse(numPlayersBox.Text))//moves onto next round of game
            {
                //enables and disables game control to transition player to next phase
                endTurn3Btn.Enabled = false;
                endTurn1Btn.Enabled = true;
                boardBox.Enabled = true;
                CurrentPlayer = 1;
                instTeller.Text = "Select where to place your developers.";
                currentPlayerBox.Text = CurrentPlayer.ToString();
                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
            }
            else if (CurrentPlayer < Int32.Parse(numPlayersBox.Text))//moves onto next players' turn
            {
                playerList[CurrentPlayer - 1].Upkeep();
                CurrentPlayer += 1;
                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
                currentPlayerBox.Text = CurrentPlayer.ToString();
            }
        }
        #endregion
    }
}
