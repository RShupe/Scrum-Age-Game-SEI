///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      Form1.cs
//	Description:                    Main Form where game will be played on
//	Author:                         Team 1
//  Last Modified By:               Markis Dearstone/Ryan Shupe
//	Created:                        Monday, October 21st, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using Stone_Age_Game.GameForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

namespace Stone_Age_Game
{
    public partial class MainForm : Form
    {
        //max number of spots on the map
        private const int MONEY_SPOTS = 10;
        private const int USERSTORY_SPOTS = 7;
        private const int USECASE_SPOTS = 6;
        private const int PROTOTYPE_SPOTS = 4;
        private const int HR_SPOTS = 2;
        private const int SM_SPOTS = 3;

        #region Initialize

        //will be used to keep track of how many current positions are available for a given spot on map
        //init the board
        private int MoneyPos = MONEY_SPOTS;

        private int UserStoryPos = USERSTORY_SPOTS;
        private int UseCasePos = USECASE_SPOTS;
        private int PrototypePos = PROTOTYPE_SPOTS;
        private int HRDeptPos = HR_SPOTS;
        private int SMPos = SM_SPOTS;

        private int currentSpot = 0;

        public static int CurrentPlayer = 1;  //keeps track of current player, beginning of the game, set to 1

        //various list made to keep track of player data
        public List<Player> playerList = new List<Player>();

        private List<string> areaList = new List<string>();
        private List<int> countList = new List<int>();
        private List<List<string>> playerAreas = new List<List<string>>();
        private List<List<string>> areasList = new List<List<string>>();
        private List<List<int>> areaCountList = new List<List<int>>();
        private List<List<string>> uniqueList = new List<List<string>>();
        private List<ProgramCard> cardDeck = new List<ProgramCard>();

        #endregion Initialize

        #region Create Cards

        /// <summary>
        /// Creates program cards to be used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public MainForm()
        {
            InitializeComponent();

            //INIT PROGRAM CARDS
            DiceRoller cardDie = new DiceRoller(5);
            int temp;
            for (int i = 0; i < 5; i++)
            {
                temp = cardDie.Roll1Die();
                cardDeck.Add(new ProgramCard(temp));
            }

            ProgramCardPanel1.BackgroundImage = cardDeck[0].image;
            ProgramCardPanel2.BackgroundImage = cardDeck[1].image;
            ProgramCardPanel3.BackgroundImage = cardDeck[2].image;
            ProgramCardPanel4.BackgroundImage = cardDeck[3].image;
            ProgramCardPanel5.BackgroundImage = cardDeck[4].image;
            //END PROGRAM CARD INIT

            playerDataBox.Visible = false;
            programsBox.Visible = false;
            devPlacementBox.Visible = false;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.inventoryButton, "Player Inventory");
            ToolTip1.SetToolTip(this.DiceButton, "Phase 2 Dashboard");
            ToolTip1.SetToolTip(this.programsButton, "View Program Cards");
            ToolTip1.SetToolTip(this.rollDiceButton, "Roll Dice");
        }

        #endregion Create Cards

        #region Form1 Load

        /// <summary>
        /// Handles what happens when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageForm messageForm = new MessageForm(); //start form to get the number of players
            messageForm.ShowDialog();

            //gets number of players for the game
            int numPlayers = 1;
            try
            {
                numPlayers = (int)Int32.Parse((string)messageForm.comboBox1.SelectedItem);
            }
            catch (Exception)
            {
                Application.Exit();
            }

            //creates all lists' to be used to track everything for phase 2
            for (int i = 1; i < numPlayers + 1; i++)
            {
                playerList.Add(new Player());
                playerAreas.Add(new List<string>());
                areasList.Add(new List<string>());
                areaCountList.Add(new List<int>());
                uniqueList.Add(new List<string>());
            }

            //gs.ShowDialog();

            //shows visible cards based on how many players are in the game to set stacks
            numPlayersBox.Text = numPlayers.ToString();
            if (numPlayersBox.Text == "1")
            {
                PlayerCardCountLbl1.Visible = true;
                CardCount1.Visible = true;
            }
            else if (numPlayersBox.Text == "2")
            {
                PlayerCardCountLbl1.Visible = true;
                PlayerCardCountLbl2.Visible = true;
                CardCount1.Visible = true;
                CardCount2.Visible = true;
            }
            else if (numPlayersBox.Text == "3")
            {
                PlayerCardCountLbl1.Visible = true;
                PlayerCardCountLbl2.Visible = true;
                PlayerCardCountLbl3.Visible = true;
                CardCount1.Visible = true;
                CardCount2.Visible = true;
                CardCount3.Visible = true;
            }
            else if (numPlayersBox.Text == "4")
            {
                PlayerCardCountLbl1.Visible = true;
                PlayerCardCountLbl2.Visible = true;
                PlayerCardCountLbl3.Visible = true;
                PlayerCardCountLbl4.Visible = true;
                CardCount1.Visible = true;
                CardCount2.Visible = true;
                CardCount3.Visible = true;
                CardCount4.Visible = true;
            }

            checkCards();

            //displays users inventory
            
            playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
            //displays current player for user
            currentPlayerBox.Text = CurrentPlayer.ToString();
        }

        #endregion Form1 Load

        #region Dice Roller Button Click

        /// <summary>
        /// Rolls dice and adds to players inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiceButton_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(200));
            if (phase2box.Visible != true)
            {
                if (playerDataBox.Visible)
                {
                    Point point = new Point(885, 286);
                    phase2box.Location = point;
                }
                else
                {
                    t.add(phase2box, "Left", 885);
                    t.add(phase2box, "Top", 13);
                }
                t.add(inventoryButton, "Left", 1230);
                t.add(inventoryButton, "Top", 32);

                t.add(DiceButton, "Left", 1230);
                t.add(DiceButton, "Top", 147);

                t.add(endTurn1Btn, "Left", 927);
                t.add(endTurn1Btn, "Top", 29);

                t.add(endTurn2Btn, "Left", 1070);
                t.add(endTurn2Btn, "Top", 29);

                t.add(endTurn3Btn, "Left", 1213);
                t.add(endTurn3Btn, "Top", 29);

                t.run();

                this.Size = new Size(1373, this.Size.Height);
                this.DiceButton.Location = new System.Drawing.Point(1230, 147);
                this.inventoryButton.Location = new System.Drawing.Point(1230, 32);

                phase2box.Visible = true;
            }
            else
            {
                if (phase2box.Visible)
                {
                    t.add(phase2box, "Left", 885);
                    t.add(phase2box, "Top", 286);
                }
                else
                {
                    t.add(phase2box, "Left", 885);
                    t.add(phase2box, "Top", 13);
                }
                phase2box.Visible = false;

                if (playerDataBox.Visible)
                {
                    t.add(phase2box, "Left", 885);
                    t.add(phase2box, "Top", 13);
                }
                else
                {
                    t.add(inventoryButton, "Left", 891);
                    t.add(inventoryButton, "Top", 32);

                    t.add(DiceButton, "Left", 893);
                    t.add(DiceButton, "Top", 147);

                    t.add(endTurn1Btn, "Left", 588);
                    t.add(endTurn1Btn, "Top", 29);

                    t.add(endTurn2Btn, "Left", 731);
                    t.add(endTurn2Btn, "Top", 29);

                    t.add(endTurn3Btn, "Left", 874);
                    t.add(endTurn3Btn, "Top", 29);

                    this.Size = new Size(1030, this.Size.Height);
                    this.inventoryButton.Location = new System.Drawing.Point(891, 32);
                    this.DiceButton.Location = new System.Drawing.Point(893, 147);
                }
                t.run();
            }

            playerDataBox.Text = playerList[0].ToString();
            //devLabel.Text = playerList[0].NumDevelopers.ToString();
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSpot < areaList.Count)
                {
                    rollDiceButton.Enabled = true;
                    DiceRoller dice = new DiceRoller();
                    
                    int numDiceToRoll = Convert.ToInt32(diceToRoll.Text);
                    double diceResult = Convert.ToInt32(dice.RollDice(numDiceToRoll));

                    string divisor = currentArea.Text.ToString();
                    divisorBox.Text = getDivisor(divisor).ToString();

                    int div = Convert.ToInt32(divisorBox.Text);

                    int result = 0;
                    if (areaList[currentSpot] == "HR")
                    {
                        //possibly temp?
                        //if 1 dev is on HR, the player gets one new dev, if 2 devs are on it, the player gets 2 new devs
                        if (countList[currentSpot] == 1)
                        {
                            diceResultBox.Text = "1";
                            result = 1;
                        }
                        else
                        {
                            diceResultBox.Text = "2";
                            result = 2;
                        }
                    }
                    else if(areaList[currentSpot] == "Scrum Master")
                    {
                        //possibly temp?
                        //if 1 dev is on SM, the player gets +1 sm point, if 2 devs are on it, the player gets +2, 3 is +3
                        if (countList[currentSpot] == 1)
                        {
                            diceResultBox.Text = "1";
                            result = 1;
                        }
                        else if (countList[currentSpot] == 2)
                        {
                            diceResultBox.Text = "2";
                            result = 2;
                        }
                        else
                        {
                            diceResultBox.Text = "3";
                            result = 3;
                        }
                    }
                    else
                    {
                        diceTotalBox.Text = diceResult.ToString();
                        result = Convert.ToInt32(Math.Floor(diceResult / div));

                        dividedResultsBox.Text = result.ToString();

                        //MAYBE TEMP BUT THIS IS WHERE THE SCRUM LEVEL IS GOING TO EFFECT THE RESULT
                        double multiplier = 0;
                        for(int i = 1; i < playerList[CurrentPlayer-1].ScrumLevel; i++) //this is skipped when the SM level is 1.
                        {
                            multiplier += 0.1; //each level increases resource by 10%???? needs to be balanced.
                        }
                        double smresult = result * multiplier;
                        result += Convert.ToInt32(Math.Round(smresult));
                        //


                        diceResultBox.Text = result.ToString();
                    }

                    int iresult = result;

                    AddResource(areaList[currentSpot], iresult);
                    smLevelBox.Text = playerList[CurrentPlayer - 1].ScrumLevel.ToString();
                    currentSpot++;

                    //set the boxes to the next space, if exception, that means the player has no more devs placed to roll for 
                    try
                    {
                        currentArea.Text = areaList[currentSpot];

                        //int numDiceToRoll = Convert.ToInt32(countList[currentSpot]);
                        numDiceToRoll = countList[currentSpot];
                        diceToRoll.Text = numDiceToRoll.ToString();

                        if (diceToRoll.Text == "0")
                        {
                            rollDiceButton.Enabled = false;
                        }

                        divisor = currentArea.Text.ToString();
                        divisorBox.Text = getDivisor(divisor).ToString();
                    }
                    catch
                    {
                        rollDiceButton.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
            }
            playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
            checkCards();
        }

        #endregion Dice Roller Button Click

        #region Bank Box Click

        /// <summary>
        /// BankBoxClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bankBox_Click(object sender, EventArgs e)
        {
            placingOnBox.Text = "Bank";
            devsLeftBox.Text = playerList[CurrentPlayer - 1].NumDevelopers.ToString();
            availPosBox.Text = MoneyPos.ToString();

            if (devPlacementBox.Enabled == true)
            {
                Point pos = new Point(30, 50);
                devPlacementBox.Location = (pos);
                devPlacementBox.Visible = true;
            }
            if (diceToRoll.Enabled)
            {
                diceToRoll.Text = "Bank";
            }
        }

        #endregion Bank Box Click

        #region User Story Box Click

        /// <summary>
        /// User Story Box Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userStoryBox_Click(object sender, EventArgs e)
        {
            placingOnBox.Text = "User Story";
            devsLeftBox.Text = playerList[CurrentPlayer - 1].NumDevelopers.ToString();
            availPosBox.Text = UserStoryPos.ToString();

            if (devPlacementBox.Enabled == true)
            {
                Point pos = new Point(610, 20);
                devPlacementBox.Location = (pos);
                devPlacementBox.Visible = true;
            }
            if (diceToRoll.Enabled)
            {
                diceToRoll.Text = "User Story";
            }
        }

        #endregion User Story Box Click

        #region Use Case Box Click

        /// <summary>
        /// Use Case Box Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useCaseBox_Click(object sender, EventArgs e)
        {
            placingOnBox.Text = "Use Case";
            devsLeftBox.Text = playerList[CurrentPlayer - 1].NumDevelopers.ToString();
            availPosBox.Text = UseCasePos.ToString();

            if (devPlacementBox.Enabled == true)
            {
                Point pos = new Point(640, 270);
                devPlacementBox.Location = (pos);
                devPlacementBox.Visible = true;
            }
            if (diceToRoll.Enabled)
            {
                diceToRoll.Text = "Use Case";
            }
        }

        #endregion Use Case Box Click

        #region Scrum Master Box Click

        /// <summary>
        /// Scrum Master Box Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SMBox_Click(object sender, EventArgs e)
        {
            placingOnBox.Text = "Scrum Master";
            devsLeftBox.Text = playerList[CurrentPlayer - 1].NumDevelopers.ToString();
            availPosBox.Text = SMPos.ToString();

            if (devPlacementBox.Enabled == true)
            {
                Point pos = new Point(30, 220);
                devPlacementBox.Location = (pos);
                devPlacementBox.Visible = true;
            }

            if (diceToRoll.Enabled)
            {
                diceToRoll.Text = "Scrum Master";
            }
        }

        #endregion Scrum Master Box Click

        #region HR Dept Box Click

        /// <summary>
        /// HR Dept Box Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hrDeptBox_Click(object sender, EventArgs e)
        {
            placingOnBox.Text = "HR";
            devsLeftBox.Text = playerList[CurrentPlayer - 1].NumDevelopers.ToString();
            availPosBox.Text = HRDeptPos.ToString();

            if (devPlacementBox.Enabled == true)
            {
                Point cursor = this.PointToClient(Cursor.Position);
                cursor.Y -= 100;
                devPlacementBox.Location = (cursor);
                devPlacementBox.Visible = true;
            }

            if (diceToRoll.Enabled)
            {
                diceToRoll.Text = "HR";
            }
        }

        #endregion HR Dept Box Click

        #region Prototype Box Click

        /// <summary>
        /// Prototype Box Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void protoBox_Click(object sender, EventArgs e)
        {
            placingOnBox.Text = "Prototype";
            devsLeftBox.Text = playerList[CurrentPlayer - 1].NumDevelopers.ToString();
            availPosBox.Text = PrototypePos.ToString();

            if (devPlacementBox.Enabled == true)
            {
                Point pos = new Point(300, 390);
                devPlacementBox.Location = (pos);
                devPlacementBox.Visible = true;
            }

            if (diceToRoll.Enabled)
            {
                diceToRoll.Text = "Prototype";
            }
        }

        #endregion Prototype Box Click

        #region Confirm Developers Placed

        /// <summary>
        /// Confirm Developers placed button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmDevsBtn_Click(object sender, EventArgs e)
        {
            int numToExchange = 0;
            try
            {
                if (devsLeftBox.Text == "0")
                {
                    throw new Exception();
                }

                if (availPosBox.Text == "0")
                {
                    throw new Exception();
                }
                numToExchange = Int32.Parse(devsPlacedBox.Text);
            }
            catch (Exception)
            {
            }

            if (numToExchange - playerList[CurrentPlayer - 1].NumDevelopers <= 0)
            {
                doPhase1(numToExchange);
            }
            else
                devsLeftBox.Text = "ERROR";

            devsPlacedBox.Text = "";
            devPlacementBox.Visible = false;

            refreshDeveloperImages();
        }

        #endregion Confirm Developers Placed

        #region Resource Positions Left

        /// <summary>
        /// Resource Positions left
        /// </summary>
        /// <param name="parm"></param>
        /// <param name="numDevs"></param>
        /// <returns></returns>
        private string ResourcePositionsLeft(string parm, int numDevs)
        {
            string result = "";
            if (parm == "User Story")
            {
                if (UserStoryPos - numDevs < 0)
                {
                    result = "ERROR";
                }
                else
                {
                    UserStoryPos = UserStoryPos - numDevs;
                    result = UserStoryPos.ToString();
                }
            }
            else if (parm == "Use Case")
            {
                if (UseCasePos - numDevs < 0)
                {
                    result = "ERROR";
                }
                else
                {
                    UseCasePos = UseCasePos - numDevs; ;
                    result = UseCasePos.ToString();
                }
            }
            else if (parm == "Prototype")
            {
                if (PrototypePos - numDevs < 0)
                {
                    result = "ERROR";
                }
                else
                {
                    PrototypePos = PrototypePos - numDevs;
                    result = PrototypePos.ToString();
                }
            }
            else if (parm == "Bank")
            {
                if (MoneyPos - numDevs < 0)
                {
                    result = "ERROR";
                }
                else
                {
                    MoneyPos = MoneyPos - numDevs;
                    result = MoneyPos.ToString();
                }
            }
            else if (parm == "HR")
            {
                if (HRDeptPos - numDevs < 0)
                {
                    result = "ERROR";
                }
                else
                {
                    HRDeptPos = HRDeptPos - numDevs;
                    result = HRDeptPos.ToString();
                }
            }
            else if (parm == "Scrum Master")
            {
                if (SMPos - numDevs < 0)
                {
                    result = "ERROR";
                }
                else
                {
                    SMPos = SMPos - numDevs;
                    result = SMPos.ToString();
                }
            }
            return result;
        }

        #endregion Resource Positions Left

        #region End Turn 1 Button Click

        /// <summary>
        /// End Turn 1 button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endTurnBtn_Click(object sender, EventArgs e)
        {
            devPlacementBox.Visible = false;
            phase2box.Enabled = true;
            rollDiceButton.Enabled = true;
            checkCards();

            if (CurrentPlayer == Int32.Parse(numPlayersBox.Text))//moves onto next phase of game
            {
                diceToRoll.Text = "";

                //enables and disables game control to transition player to next phase
                devPlacementBox.Enabled = false;
                endTurn1Btn.Enabled = false;
                endTurn2Btn.Enabled = true;
                DiceButton.Enabled = true;
                rollDiceButton.Enabled = true;

                CurrentPlayer = 1;
                instTeller.Text = "Open the phase 2 dashboard using \r\nthe dice button on the right.\r\nThen roll amount of dice equal to amount of \r\ndevelopers there.";
                currentPlayerBox.Text = CurrentPlayer.ToString();

                if (playerList.Count > 1)
                {
                    NextPlayer nxtPlayer = new NextPlayer(1); //reset to player 1
                    nxtPlayer.ShowDialog();
                }

                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();

                doPhase2(areaCountList, uniqueList);
            }
            else if (CurrentPlayer < Int32.Parse(numPlayersBox.Text))//moves onto next players' turn
            {
                CurrentPlayer += 1;

                NextPlayer nxtPlayer = new NextPlayer(CurrentPlayer); //next player
                nxtPlayer.ShowDialog();

                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
                currentPlayerBox.Text = CurrentPlayer.ToString();
                devsLeftBox.Text = playerList[CurrentPlayer - 1].NumDevelopers.ToString();
            }

            checkCards();
        }

        #endregion End Turn 1 Button Click

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
                if (phase2box.Visible)
                {
                    if (playerDataBox.Visible == false)
                    {
                        Transition t = new Transition(new TransitionType_EaseInEaseOut(200));

                        t.add(inventoryButton, "Left", 891);
                        t.add(inventoryButton, "Top", 32);

                        t.add(DiceButton, "Left", 893);
                        t.add(DiceButton, "Top", 147);

                        t.add(endTurn1Btn, "Left", 588);
                        t.add(endTurn1Btn, "Top", 29);

                        t.add(endTurn2Btn, "Left", 731);
                        t.add(endTurn2Btn, "Top", 29);

                        t.add(endTurn3Btn, "Left", 874);
                        t.add(endTurn3Btn, "Top", 29);

                        this.Size = new Size(1030, this.Size.Height);
                        this.inventoryButton.Location = new System.Drawing.Point(891, 32);
                        this.DiceButton.Location = new System.Drawing.Point(893, 147);

                        t.run();
                    }

                    phase2box.Visible = false;
                }

                //enables and disables game control to transition player to next phase
                rollDiceButton.Enabled = false;
                endTurn2Btn.Enabled = false;
                endTurn3Btn.Enabled = true;
                CurrentPlayer = 1;

                if (playerList.Count > 1)
                {
                    NextPlayer nxtPlayer = new NextPlayer(1);
                    nxtPlayer.ShowDialog();
                }

                instTeller.Text = "You may now purchase Program Cards \nif you have the resources. \n" +
                                  "Remember you must pay your developers\n" +
                                  "at the end of this round!";

                diceTotalBox.Text = "";
                dividedResultsBox.Text = "";
                smLevelBox.Text = "";
                diceResultBox.Text = "";

                currentPlayerBox.Text = CurrentPlayer.ToString();
                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
                phase2box.Enabled = false;
                devPlacementBox.Enabled = false;
            }
            else if (CurrentPlayer < Int32.Parse(numPlayersBox.Text))//moves onto next players' turn
            {
                rollDiceButton.Enabled = true;
                CurrentPlayer += 1;
                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
                currentPlayerBox.Text = CurrentPlayer.ToString();
                smLevelBox.Text = playerList[CurrentPlayer - 1].ScrumLevel.ToString();
                doPhase2(areaCountList, uniqueList);

                diceTotalBox.Text = "";
                dividedResultsBox.Text = "";
                smLevelBox.Text = "";
                diceResultBox.Text = "";

                NextPlayer nxtPlayer = new NextPlayer(CurrentPlayer);
                nxtPlayer.ShowDialog();
            }
            checkCards();
        }

        #endregion End Turn 2 Button Click

        #region End Turn 3 Button Click

        /// <summary>
        /// End Turn 3 button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endTurn3Btn_Click(object sender, EventArgs e)
        {
            diceTotalBox.Text = "0";
            checkCards();

            if (CurrentPlayer == Int32.Parse(numPlayersBox.Text))//moves onto next round of game
            {
                if (phase2box.Visible)
                {
                    if (playerDataBox.Visible == false)
                    {
                        Transition t = new Transition(new TransitionType_EaseInEaseOut(200));

                        t.add(inventoryButton, "Left", 891);
                        t.add(inventoryButton, "Top", 32);

                        t.add(DiceButton, "Left", 893);
                        t.add(DiceButton, "Top", 147);

                        t.add(endTurn1Btn, "Left", 588);
                        t.add(endTurn1Btn, "Top", 29);

                        t.add(endTurn2Btn, "Left", 731);
                        t.add(endTurn2Btn, "Top", 29);

                        t.add(endTurn3Btn, "Left", 874);
                        t.add(endTurn3Btn, "Top", 29);

                        this.Size = new Size(1030, this.Size.Height);
                        this.inventoryButton.Location = new System.Drawing.Point(891, 32);
                        this.DiceButton.Location = new System.Drawing.Point(893, 147);

                        t.run();
                    }

                    phase2box.Visible = false;
                }

                playerList[CurrentPlayer - 1].Upkeep();
                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();

                //reset the board
                for (int i = 0; i < playerList.Count; i++)
                {
                    playerList[i].NumDevelopers += playerList[i].NumDevelopersPlaced;
                    playerList[i].NumDevelopersPlaced = 0;
                }

                MoneyPos = MONEY_SPOTS;
                UserStoryPos = USERSTORY_SPOTS;
                UseCasePos = USECASE_SPOTS;
                PrototypePos = PROTOTYPE_SPOTS;
                HRDeptPos = HR_SPOTS;
                SMPos = SM_SPOTS;

                areaList.Clear();
                areasList.Clear();
                countList.Clear();
                areaCountList.Clear();
                playerAreas.Clear();
                uniqueList.Clear();

                for (int i = 0; i < playerList.Count; i++)
                {
                    areasList.Add(new List<string>());
                    areaCountList.Add(new List<int>());
                    playerAreas.Add(new List<string>());
                    uniqueList.Add(new List<string>());
                }

                ResetImages();

                //enables and disables game control to transition player to next phase
                endTurn3Btn.Enabled = false;
                endTurn1Btn.Enabled = true;

                DiceButton.Enabled = false;
                devPlacementBox.Enabled = true;
                diceResultBox.Text = "";

                CurrentPlayer = 1;

                if (playerList.Count > 1)
                {
                    NextPlayer nxtPlayer = new NextPlayer(1);
                    nxtPlayer.ShowDialog();
                }

                instTeller.Text = "Select where to place your developers.";
                currentPlayerBox.Text = CurrentPlayer.ToString();
                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
            }
            else if (CurrentPlayer < Int32.Parse(numPlayersBox.Text))//moves onto next players' turn
            {
                CurrentPlayer += 1;
                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
                currentPlayerBox.Text = CurrentPlayer.ToString();

                NextPlayer nxtPlayer = new NextPlayer(CurrentPlayer);
                nxtPlayer.ShowDialog();
            }

            checkCards();
        }

        #endregion End Turn 3 Button Click

        #region Inventory Button Click

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(200));
            if (playerDataBox.Visible != true)
            {
                if (phase2box.Visible)
                {
                    t.add(phase2box, "Left", 885);
                    t.add(phase2box, "Top", 286);
                }
                else
                {
                    t.add(phase2box, "Left", 885);
                    t.add(phase2box, "Top", 13);
                }
                t.add(inventoryButton, "Left", 1230);
                t.add(inventoryButton, "Top", 32);

                t.add(DiceButton, "Left", 1230);
                t.add(DiceButton, "Top", 147);

                t.add(endTurn1Btn, "Left", 927);
                t.add(endTurn1Btn, "Top", 29);

                t.add(endTurn2Btn, "Left", 1070);
                t.add(endTurn2Btn, "Top", 29);

                t.add(endTurn3Btn, "Left", 1213);
                t.add(endTurn3Btn, "Top", 29);

                t.run();

                this.Size = new Size(1373, this.Size.Height);
                this.DiceButton.Location = new System.Drawing.Point(1230, 147);
                this.inventoryButton.Location = new System.Drawing.Point(1230, 32);

                playerDataBox.Visible = true;
            }
            else
            {
                if (playerDataBox.Visible)
                {
                    t.add(phase2box, "Left", 885);
                    t.add(phase2box, "Top", 286);
                }
                else
                {
                    t.add(phase2box, "Left", 885);
                    t.add(phase2box, "Top", 13);
                }
                playerDataBox.Visible = false;

                if (phase2box.Visible)
                {
                    t.add(phase2box, "Left", 885);
                    t.add(phase2box, "Top", 13);
                }
                else
                {
                    t.add(inventoryButton, "Left", 891);
                    t.add(inventoryButton, "Top", 32);

                    t.add(DiceButton, "Left", 893);
                    t.add(DiceButton, "Top", 147);

                    t.add(endTurn1Btn, "Left", 588);
                    t.add(endTurn1Btn, "Top", 29);

                    t.add(endTurn2Btn, "Left", 731);
                    t.add(endTurn2Btn, "Top", 29);

                    t.add(endTurn3Btn, "Left", 874);
                    t.add(endTurn3Btn, "Top", 29);

                    this.Size = new Size(1030, this.Size.Height);
                    this.inventoryButton.Location = new System.Drawing.Point(891, 32);
                    this.DiceButton.Location = new System.Drawing.Point(893, 147);
                }
                t.run();
            }

            playerDataBox.Text = playerList[0].ToString();
            //devLabel.Text = playerList[0].NumDevelopers.ToString();
        }

        #endregion Inventory Button Click

        #region Programs Button Click

        private void programsButton_Click(object sender, EventArgs e)
        {
            if (programsBox.Visible != true)
            {
                this.Size = new Size(this.Size.Width, 927);
                programsBox.Visible = true;
            }
            else
            {
                this.Size = new Size(this.Size.Width, 727);
                programsBox.Visible = false;
            }
        }

        #endregion Programs Button Click

        #region About Button Click

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm formabout = new AboutForm();
            formabout.Show();
        }

        #endregion About Button Click

        #region Developer Images

        private void refreshDeveloperImages()
        {
            #region User Stories

            if (placingOnBox.Text == "User Story")
            {
                if (availPosBox.Text == "6")
                {
                    devUS1.Visible = true;
                }
                else if (availPosBox.Text == "5")
                {
                    devUS1.Visible = true;
                    devUS2.Visible = true;
                }
                else if (availPosBox.Text == "4")
                {
                    devUS1.Visible = true;
                    devUS2.Visible = true;
                    devUS3.Visible = true;
                }
                else if (availPosBox.Text == "3")
                {
                    devUS1.Visible = true;
                    devUS2.Visible = true;
                    devUS3.Visible = true;
                    devUS4.Visible = true;
                }
                else if (availPosBox.Text == "2")
                {
                    devUS1.Visible = true;
                    devUS2.Visible = true;
                    devUS3.Visible = true;
                    devUS4.Visible = true;
                    devUS5.Visible = true;
                }
                else if (availPosBox.Text == "1")
                {
                    devUS1.Visible = true;
                    devUS2.Visible = true;
                    devUS3.Visible = true;
                    devUS4.Visible = true;
                    devUS5.Visible = true;
                    devUS6.Visible = true;
                }
                else if (availPosBox.Text == "0")
                {
                    devUS1.Visible = true;
                    devUS2.Visible = true;
                    devUS3.Visible = true;
                    devUS4.Visible = true;
                    devUS5.Visible = true;
                    devUS6.Visible = true;
                    devUS7.Visible = true;
                }
            }

            #endregion User Stories

            #region Bank

            if (placingOnBox.Text == "Bank")
            {
                if (availPosBox.Text == "9")
                {
                    BankDev1.Visible = true;
                }
                else if (availPosBox.Text == "8")
                {
                    BankDev1.Visible = true;
                    BankDev2.Visible = true;
                }
                else if (availPosBox.Text == "7")
                {
                    BankDev1.Visible = true;
                    BankDev2.Visible = true;
                    BankDev3.Visible = true;
                }
                else if (availPosBox.Text == "6")
                {
                    BankDev1.Visible = true;
                    BankDev2.Visible = true;
                    BankDev3.Visible = true;
                    BankDev4.Visible = true;
                }
                else if (availPosBox.Text == "5")
                {
                    BankDev1.Visible = true;
                    BankDev2.Visible = true;
                    BankDev3.Visible = true;
                    BankDev4.Visible = true;
                    BankDev5.Visible = true;
                }
                else if (availPosBox.Text == "4")
                {
                    BankDev1.Visible = true;
                    BankDev2.Visible = true;
                    BankDev3.Visible = true;
                    BankDev4.Visible = true;
                    BankDev5.Visible = true;
                    BankDev6.Visible = true;
                }
                else if (availPosBox.Text == "3")
                {
                    BankDev1.Visible = true;
                    BankDev2.Visible = true;
                    BankDev3.Visible = true;
                    BankDev4.Visible = true;
                    BankDev5.Visible = true;
                    BankDev6.Visible = true;
                    BankDev7.Visible = true;
                }
                else if (availPosBox.Text == "2")
                {
                    BankDev1.Visible = true;
                    BankDev2.Visible = true;
                    BankDev3.Visible = true;
                    BankDev4.Visible = true;
                    BankDev5.Visible = true;
                    BankDev6.Visible = true;
                    BankDev7.Visible = true;
                    BankDev8.Visible = true;
                }
                else if (availPosBox.Text == "1")
                {
                    BankDev1.Visible = true;
                    BankDev2.Visible = true;
                    BankDev3.Visible = true;
                    BankDev4.Visible = true;
                    BankDev5.Visible = true;
                    BankDev6.Visible = true;
                    BankDev7.Visible = true;
                    BankDev8.Visible = true;
                    BankDev9.Visible = true;
                }
                else if (availPosBox.Text == "0")
                {
                    BankDev1.Visible = true;
                    BankDev2.Visible = true;
                    BankDev3.Visible = true;
                    BankDev4.Visible = true;
                    BankDev5.Visible = true;
                    BankDev6.Visible = true;
                    BankDev7.Visible = true;
                    BankDev8.Visible = true;
                    BankDev9.Visible = true;
                    BankDev10.Visible = true;
                }
            }

            #endregion Bank

            #region Use Cases

            if (placingOnBox.Text == "Use Case")
            {
                if (availPosBox.Text == "5")
                {
                    UCDev1.Visible = true;
                }
                else if (availPosBox.Text == "4")
                {
                    UCDev1.Visible = true;
                    UCDev2.Visible = true;
                }
                else if (availPosBox.Text == "3")
                {
                    UCDev1.Visible = true;
                    UCDev2.Visible = true;
                    UCDev3.Visible = true;
                }
                else if (availPosBox.Text == "2")
                {
                    UCDev1.Visible = true;
                    UCDev2.Visible = true;
                    UCDev3.Visible = true;
                    UCDev4.Visible = true;
                }
                else if (availPosBox.Text == "1")
                {
                    UCDev1.Visible = true;
                    UCDev2.Visible = true;
                    UCDev3.Visible = true;
                    UCDev4.Visible = true;
                    UCDev5.Visible = true;
                }
                else if (availPosBox.Text == "0")
                {
                    UCDev1.Visible = true;
                    UCDev2.Visible = true;
                    UCDev3.Visible = true;
                    UCDev4.Visible = true;
                    UCDev5.Visible = true;
                    UCDev6.Visible = true;
                }
            }

            #endregion Use Cases

            #region HR

            if (placingOnBox.Text == "HR")
            {
                if (availPosBox.Text == "1")
                {
                    HRDev1.Visible = true;
                }
                else if (availPosBox.Text == "0")
                {
                    HRDev1.Visible = true;
                    HRDev2.Visible = true;
                }
            }

            #endregion HR

            #region Scrum Master

            if (placingOnBox.Text == "Scrum Master")
            {
                if (availPosBox.Text == "2")
                {
                    SDev1.Visible = true;
                }
                else if (availPosBox.Text == "1")
                {
                    SDev1.Visible = true;
                    SDev2.Visible = true;
                }
                else if (availPosBox.Text == "0")
                {
                    SDev1.Visible = true;
                    SDev2.Visible = true;
                    SDev3.Visible = true;
                }
            }

            #endregion Scrum Master

            #region Prototypes

            if (placingOnBox.Text == "Prototype")
            {
                if (availPosBox.Text == "3")
                {
                    ProtoDev1.Visible = true;
                }
                else if (availPosBox.Text == "2")
                {
                    ProtoDev1.Visible = true;
                    ProtoDev2.Visible = true;
                }
                else if (availPosBox.Text == "1")
                {
                    ProtoDev1.Visible = true;
                    ProtoDev2.Visible = true;
                    ProtoDev3.Visible = true;
                }
                else if (availPosBox.Text == "0")
                {
                    ProtoDev1.Visible = true;
                    ProtoDev2.Visible = true;
                    ProtoDev3.Visible = true;
                    ProtoDev4.Visible = true;
                }
            }

            #endregion Prototypes
        }

        private void ResetImages()
        {
            devUS1.Visible = false;
            devUS2.Visible = false;
            devUS3.Visible = false;
            devUS4.Visible = false;
            devUS5.Visible = false;
            devUS6.Visible = false;
            devUS7.Visible = false;
            BankDev1.Visible = false;
            BankDev2.Visible = false;
            BankDev3.Visible = false;
            BankDev4.Visible = false;
            BankDev5.Visible = false;
            BankDev6.Visible = false;
            BankDev7.Visible = false;
            BankDev8.Visible = false;
            BankDev9.Visible = false;
            BankDev10.Visible = false;
            UCDev1.Visible = false;
            UCDev2.Visible = false;
            UCDev3.Visible = false;
            UCDev4.Visible = false;
            UCDev5.Visible = false;
            UCDev6.Visible = false;
            HRDev1.Visible = false;
            HRDev2.Visible = false;
            SDev1.Visible = false;
            SDev2.Visible = false;
            SDev3.Visible = false;
            ProtoDev1.Visible = false;
            ProtoDev2.Visible = false;
            ProtoDev3.Visible = false;
            ProtoDev4.Visible = false;
        }

        #endregion Developer Images

        #region Program Cards

        private void cardPurchase1_Click(object sender, EventArgs e)
        {
            purchaseCard(1);
        }

        private void cardPurchase2_Click(object sender, EventArgs e)
        {
            purchaseCard(2);
        }

        private void cardPurchase3_Click(object sender, EventArgs e)
        {
            purchaseCard(3);
        }

        private void cardPurchase4_Click(object sender, EventArgs e)
        {
            purchaseCard(4);
        }

        private void cardPurchase5_Click(object sender, EventArgs e)
        {
            purchaseCard(5);
        }

        private void purchaseCard(int cardNum)
        {
            if (cardNum == 1)
            {
                playerList[CurrentPlayer - 1].NumPrototypes -= cardDeck[0].prototypeCost;
                playerList[CurrentPlayer - 1].NumUseCases -= cardDeck[0].useCaseCost;
                playerList[CurrentPlayer - 1].NumUserStories -= cardDeck[0].userStoryCost;
                playerList[CurrentPlayer - 1].CompletedPrograms++;
                playerList[CurrentPlayer - 1].VictoryPoints += cardDeck[0].cardNum;

                cardDeck[0].Refresh();
                ProgramCardPanel1.BackgroundImage = cardDeck[0].image;
            }
            else if (cardNum == 2)
            {
                playerList[CurrentPlayer - 1].NumPrototypes -= cardDeck[1].prototypeCost;
                playerList[CurrentPlayer - 1].NumUseCases -= cardDeck[1].useCaseCost;
                playerList[CurrentPlayer - 1].NumUserStories -= cardDeck[1].userStoryCost;
                playerList[CurrentPlayer - 1].CompletedPrograms++;
                playerList[CurrentPlayer - 1].VictoryPoints += cardDeck[1].cardNum;

                cardDeck[1].Refresh();
                ProgramCardPanel2.BackgroundImage = cardDeck[1].image;
            }
            else if (cardNum == 3)
            {
                playerList[CurrentPlayer - 1].NumPrototypes -= cardDeck[2].prototypeCost;
                playerList[CurrentPlayer - 1].NumUseCases -= cardDeck[2].useCaseCost;
                playerList[CurrentPlayer - 1].NumUserStories -= cardDeck[2].userStoryCost;
                playerList[CurrentPlayer - 1].CompletedPrograms++;
                playerList[CurrentPlayer - 1].VictoryPoints += cardDeck[2].cardNum;

                cardDeck[2].Refresh();
                ProgramCardPanel3.BackgroundImage = cardDeck[2].image;
            }
            else if (cardNum == 4)
            {
                playerList[CurrentPlayer - 1].NumPrototypes -= cardDeck[3].prototypeCost;
                playerList[CurrentPlayer - 1].NumUseCases -= cardDeck[3].useCaseCost;
                playerList[CurrentPlayer - 1].NumUserStories -= cardDeck[3].userStoryCost;
                playerList[CurrentPlayer - 1].VictoryPoints += cardDeck[3].cardNum;
                playerList[CurrentPlayer - 1].CompletedPrograms++;

                cardDeck[3].Refresh();
                ProgramCardPanel4.BackgroundImage = cardDeck[3].image;
            }
            else if (cardNum == 5)
            {
                playerList[CurrentPlayer - 1].NumPrototypes -= cardDeck[4].prototypeCost;
                playerList[CurrentPlayer - 1].NumUseCases -= cardDeck[4].useCaseCost;
                playerList[CurrentPlayer - 1].NumUserStories -= cardDeck[4].userStoryCost;
                playerList[CurrentPlayer - 1].CompletedPrograms++;
                playerList[CurrentPlayer - 1].VictoryPoints += cardDeck[4].cardNum;

                cardDeck[4].Refresh();
                ProgramCardPanel5.BackgroundImage = cardDeck[4].image;
            }

            try
            {
                CardCount1.Text = playerList[0].CompletedPrograms.ToString();
                CardCount2.Text = playerList[1].CompletedPrograms.ToString();
                CardCount3.Text = playerList[2].CompletedPrograms.ToString();
                CardCount4.Text = playerList[3].CompletedPrograms.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("");
            }

            playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();
            checkCards();
        }

        //method to check and see if the player can purchase a card
        private void checkCards()
        {
            if ((playerList[CurrentPlayer - 1].NumPrototypes >= cardDeck[0].prototypeCost) &&
                (playerList[CurrentPlayer - 1].NumUseCases >= cardDeck[0].useCaseCost) &&
                (playerList[CurrentPlayer - 1].NumUserStories >= cardDeck[0].userStoryCost))
            {
                cardPurchase1.Enabled = true;
            }
            else
            {
                cardPurchase1.Enabled = false;
            }

            if ((playerList[CurrentPlayer - 1].NumPrototypes >= cardDeck[1].prototypeCost) &&
                (playerList[CurrentPlayer - 1].NumUseCases >= cardDeck[1].useCaseCost) &&
                (playerList[CurrentPlayer - 1].NumUserStories >= cardDeck[1].userStoryCost))
            {
                cardPurchase2.Enabled = true;
            }
            else
            {
                cardPurchase2.Enabled = false;
            }

            if ((playerList[CurrentPlayer - 1].NumPrototypes >= cardDeck[2].prototypeCost) &&
                (playerList[CurrentPlayer - 1].NumUseCases >= cardDeck[2].useCaseCost) &&
                (playerList[CurrentPlayer - 1].NumUserStories >= cardDeck[2].userStoryCost))
            {
                cardPurchase3.Enabled = true;
            }
            else
            {
                cardPurchase3.Enabled = false;
            }

            if ((playerList[CurrentPlayer - 1].NumPrototypes >= cardDeck[3].prototypeCost) &&
                (playerList[CurrentPlayer - 1].NumUseCases >= cardDeck[3].useCaseCost) &&
                (playerList[CurrentPlayer - 1].NumUserStories >= cardDeck[3].userStoryCost))
            {
                cardPurchase4.Enabled = true;
            }
            else
            {
                cardPurchase4.Enabled = false;
            }

            if ((playerList[CurrentPlayer - 1].NumPrototypes >= cardDeck[4].prototypeCost) &&
                (playerList[CurrentPlayer - 1].NumUseCases >= cardDeck[4].useCaseCost) &&
                (playerList[CurrentPlayer - 1].NumUserStories >= cardDeck[4].userStoryCost))
            {
                cardPurchase5.Enabled = true;
            }
            else
            {
                cardPurchase5.Enabled = false;
            }

            //check for end game

            for (int i = 0; i < playerList.Count; i++)
            {
                if (playerList[i].CompletedPrograms == 5)
                {
                    EndGame endgame = new EndGame(playerList);
                    endgame.Show();

                    this.Hide();
                }
            }
        }

        #endregion Program Cards

        #region Do Phase 1

        /// <summary>
        /// Handles phase one activities
        /// </summary>
        public void doPhase1(int numToExchange)
        {
            //devsPlacedBox.Text = "";
            //devsPlacedBox.Visible = false;
            string parm = placingOnBox.Text;
            availPosBox.Text = ResourcePositionsLeft(parm, numToExchange).ToString();
            if (availPosBox.Text != "ERROR")
            {
                //adds areas visited to list to be counted
                for (int i = 1; i <= numToExchange; i++)
                {
                    areasList[CurrentPlayer - 1].Add(parm);
                }

                //USED FOR DEBUGGING
                areaLBox.DataSource = null;
                areaLBox.DataSource = areasList[CurrentPlayer - 1];

                devsLeftBox.Text = (playerList[CurrentPlayer - 1].NumDevelopers - numToExchange).ToString();

                //increases the number of active developers that are on the board for the current player.
                for (int i = 0; i < numToExchange; i++)
                {
                    playerList[CurrentPlayer - 1].NumDevelopersPlaced++;
                }

                playerList[CurrentPlayer - 1].NumDevelopers = playerList[CurrentPlayer - 1].NumDevelopers - numToExchange;
                //devPlacementBox.Enabled = false;
                playerDataBox.Text = playerList[CurrentPlayer - 1].ToString();

                //USED FOR DEBUGGING
                uniqueList[CurrentPlayer - 1].Add(parm);
                uAreaLBox.DataSource = null;
                uAreaLBox.DataSource = uniqueList[CurrentPlayer - 1];
                //keeps track of dev count to determine how many dice to roll
                int countChocula = 0;
                for (int i = 1; i <= areasList[CurrentPlayer - 1].Count; i++)
                {
                    if (areasList[CurrentPlayer - 1][i - 1].Equals(parm))
                    {
                        countChocula++;
                    }
                }
                areaCountList[CurrentPlayer - 1].Add(countChocula);
                countLBox.DataSource = null;
                countLBox.DataSource = areaCountList[CurrentPlayer - 1];
            }
        }

        #endregion Do Phase 1

        #region Do Phase 2

        /// <summary>
        /// Handles Phase 2 activities
        /// </summary>
        /// <param name="counterList"></param>
        /// <param name="uniList"></param>
        public void doPhase2(List<List<int>> counterList, List<List<string>> uniList)
        {
            string parm2 = "";

            areaList = uniList[CurrentPlayer - 1];
            countList = counterList[CurrentPlayer - 1];
            currentSpot = 0;
            try
            {
                parm2 = areaList[currentSpot];
                int divisor = getDivisor(parm2);
                divisorBox.Text = divisor.ToString();
                currentArea.Text = parm2;
                diceToRoll.Text = countList[currentSpot].ToString();

                smLevelBox.Text = playerList[CurrentPlayer - 1].ScrumLevel.ToString();

                if (diceToRoll.Text == "0")
                {
                    rollDiceButton.Enabled = false;
                }
            }
            catch
            {
            }
        }

        #endregion Do Phase 2

        #region Get Divisor

        /// <summary>
        /// Gets divisor to divide dice roll by
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int getDivisor(string input)
        {
            int div = 0;

            if (input == "User Story")
            {
                UserStories usr = new UserStories();
                div = usr.divisor;
            }
            else if (input == "Use Case")
            {
                UseCases uc = new UseCases();
                div = uc.divisor;
            }
            else if (input == "Prototype")
            {
                Prototypes proto = new Prototypes();
                div = proto.divisor;
            }
            else if (input == "Bank")
            {
                Money mon = new Money();
                div = mon.divisor;
            }
            else if (input == "HR")
            {
                div = 1;
            }
            else if (input == "Scrum Master")
            {
                div = 1;
            }
            else
            {
                return div;
            }
            return div;
        }

        #endregion Get Divisor

        #region Add resource

        /// <summary>
        /// Adds resource for what player rolled for
        /// </summary>
        /// <param name="parm"></param>
        private void AddResource(string parm, int add)
        {
            if (parm == "User Story")
            {
                playerList[CurrentPlayer - 1].NumUserStories += add;
            }
            else if (parm == "Use Case")
            {
                playerList[CurrentPlayer - 1].NumUseCases += add;
            }
            else if (parm == "Prototype")
            {
                playerList[CurrentPlayer - 1].NumPrototypes += add;
            }
            else if (parm == "Bank")
            {
                playerList[CurrentPlayer - 1].Money += add;
            }
            else if (parm == "HR")
            {
                playerList[CurrentPlayer - 1].NumDevelopers += add;
            }
            else if (parm == "Scrum Master")
            {
                playerList[CurrentPlayer - 1].ScrumLevel += add;
            }
        }

        #endregion Add resource

        #region HowToPlayClick

        private void howToPlay_Click(object sender, EventArgs e)
        {
            HowToPlay htp = new HowToPlay();
            htp.Show();
        }

        #endregion HowToPlayClick

    }
}