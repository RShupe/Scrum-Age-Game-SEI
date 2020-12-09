using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      HowToPlay.cs
//	Description:                    Form to show the players the instructions on how to play the game
//	Author:                         Team 1
//  Last Modified By:               Markis Dearstone/Ryan Shupe
//	Created:                        Friday December 4, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Stone_Age_Game.GameForms
{
    public partial class HowToPlay : Form
    {
        readonly string intro = "Hello and welcome to Scrum Age! \n\n" +
            "If you're seeing this screen, you are probably looking for some pointers in the game. \n\n" +
            "This guide will walk you through each step of the game as well as give in-depth explanation for the game's mechanics. \n\n" +
            "Grab some developers, and get ready to put them to work!\n\n" +
            "You can still play the game with this window open.";

        readonly string page1Text = "OVERVIEW\n" + "-----------------------------------------" + "\n" +
            "Each player starts the game with 5 developers and 7 money. \n\n" +
            "-----------------------------------------" +
            "Each player takes turns placing their developers into different sections of the map. After a player places their developers, the 'End Phase 1' button is clicked and the game transfers to the next player or phase.\n\n"+
            "Once every player has placed their developers, phase 2 begins. Each player takes a turn rolling dice to gain resources. (See page 2-3 for details)\n\nAfter a player finishes rolling for resources, the 'End Phase 2' button is clicked and the game moves to the next player or phase." +
            "\n\nDuring the final phase, each player will have an opportunity to purchase Program Cards and evaluate their situation.\n\nAfter every player clicks the 'End Turn' button, the players must pay money corresponding to the amount of developers used during the turn.\n\n" +
            "If a player does not have the correct amount of money required to pay for all of their used developers, an exchange of resources will be required instead.\n\n" +
            "This process is repeated until a player has acquired 5 Program Cards (Page 4). After this happens the game ends and calculates a winner (Page 5)";

        readonly string page2Text = "RESOURCES\n" + "----------------------------------------- \n\n" +
            "The different types of resources that the players can gather are as follows:\n\n" +
            "Bank (Money): \nPlacing developers on this spot will increase the amount of money in the players inventory.\n\n" +
            "User Stories: \nPlacing developers on this spot will increase the amount of user stories in the players inventory.\n\n" +
            "Use Cases: \nPlacing developers on this spot will increase the amount of user cases in the players inventory.\n\n" +
            "Prototypes: \nPlacing developers on this spot will increase the amount of prototypes in the players inventory.\n\n" +
            "Human Resources (HR): \nPlacing developers on this spot will add 1 new developer per how many developers are placed to the players inventory.\n\n" +
            "Scrum Master: \nPlacing develoers on this spot will increase the Scrum Master Level. This spot will add 1 level per developer placed. The Scrum Master level will effect the amount of resources that the player receives during phase 2 of the game. (Page 3)";

        readonly string page3Text = "RESOURCE GATHERING\n" + "----------------------------------------- \n\n" +
            "During Phase 2 of the game players can use the Phase 2 dashboard to obtain resources. The game detects which position the player placed their developers. A certain number of dice is rolled for how many of the players developers that are occupying that spot. For example, if a player placed two developers on the bank, two dice would be rolled.\n\n" +
            "The result from the dice roll is then divided by the appropriate spots divisor. The following is a list of each divisor for each spot:\n\n" +
            "        Bank: 2\n" +
            "User Stories: 2\n" +
            "   Use Cases: 3\n" +
            "  Prototypes: 4\n\n" +
            "There are no divisors for the Human Resources and Scrum Master spot. This is because the resources are obtained differently. (Page 2) \n\n" +
            "After the results from the dice is divided by its appropriate divisor, extra resources can be added due to the players Scrum Master Level. The resource result after incorporating the scrum master level will be added to the players inventory.\n\n" +
            "SCRUM MASTER LEVEL\n" + "----------------------------------------- \n\n" +
            "The Scrum Master Level affects the amount of resources that a player receives whenever they roll the dice. Depending on the dice roll and a player Scrum Master Level they may receive a large amount of extra resources.\n\n" +
            "At the beginning of the game the players scrum master level is 1. This level has no effect on the extra resources obtained. \n\n" +
            "Once a player reaches the Scrum Master Level 2 the amount of extra resources is amplified by 10%. Each additional level amplifies the amount of extra resources 10% as well. So a Scrum Master Level 4 would result in 30% extra resources.\n\n" +
            "The amount of additional resources is calculated after the dice roll is divided by the appropriate divisor. After the additional Scrum Master Level percent is added to the result, the new result is rounded. This new result is the amount of resources obtained with effect to Scrum Master Level.\n\n" +
            "The amount of extra resources can vary greatly depending on the number of dice rolled, the outcome of those dice, and the total Scrum Master Level.";

        readonly string page4Text = "PROGRAM CARDS\n" + "----------------------------------------- \n\n" +
            "There are a total of 5 different types of Program Cards. Each type of card requires a different amount of resources to be able to purchase.\n\n" +
            "To view the available Program Cards to purchase, the player must click on the 'View Program Cards' button." +
            "To purchase a Program Card and complete a program, the player must have the sufficient amount of resources in their inventory.\n\n" +
            "When a card is purchased, the required resources are deducted from the players inventory and a new card appears in the tile." +
            "\n\nThe smallest valued Program Card is worth 12 Satisfaction Points.\n\n" +
            "The highest valued Program Card is worth 16 Satisfaction Points.\n\n" +
            "When a player reaches 5 total purchased cards, the game ends.";

        readonly string page5Text = "END OF GAME\n" + "----------------------------------------- \n\n" +
            "After a player has purchased 5 Program Cards, the end of the game has been reached.\n\n" +
            "The final score is calculated by taking the total number of Satisfaction Points gained from purchasing Program Cards and additional resources in the players inventory.\n\n" +
            "Each additional resource that is in each players inventory is converted to Satisfaction Points 1:1.\n\n" +
            "The additional Satisfaction Points is added to the players total points.\n\n" +
            "After all of the points have been calculated, the game over screen will appear showing all of the players scores.\n\n" +
            "The player with the highest amount of Satisfaction Points wins the game.\n\n" +
            "The winner is declared with a checkmark next to the winning player and their points.";

        public HowToPlay()
        {
            InitializeComponent();
            InstructionTextBox.Text = intro;
            introPage.Enabled = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void page1_Click(object sender, EventArgs e)
        {
            InstructionTextBox.Clear();
            InstructionTextBox.Text = page1Text;
            InstructionTextBox.Refresh();
            
            page1.Enabled = false;

            introPage.Enabled = true;
            page2.Enabled = true;
            page3.Enabled = true;
            page4.Enabled = true;
            page5.Enabled = true;
        }

        private void page2_Click(object sender, EventArgs e)
        {
            InstructionTextBox.Clear();
            InstructionTextBox.Text = page2Text;
            InstructionTextBox.Refresh();
            page2.Enabled = false;

            introPage.Enabled = true;
            page1.Enabled = true;
            page3.Enabled = true;
            page4.Enabled = true;
            page5.Enabled = true;
        }

        private void page3_Click(object sender, EventArgs e)
        {
            InstructionTextBox.Clear();
            InstructionTextBox.Text = page3Text;
            InstructionTextBox.Refresh();
            page3.Enabled = false;

            introPage.Enabled = true;
            page1.Enabled = true;
            page2.Enabled = true;
            page4.Enabled = true;
            page5.Enabled = true;
        }

        private void introPage_Click(object sender, EventArgs e)
        {
            InstructionTextBox.Clear();
            InstructionTextBox.Text = intro;
            InstructionTextBox.Refresh();
            introPage.Enabled = false;

            page3.Enabled = true;
            page1.Enabled = true;
            page2.Enabled = true;
            page4.Enabled = true;
            page5.Enabled = true;
        }

        private void page4_Click(object sender, EventArgs e)
        {
            InstructionTextBox.Clear();
            InstructionTextBox.Text = page4Text;
            InstructionTextBox.Refresh();
            page4.Enabled = false;

            introPage.Enabled = true;
            page3.Enabled = true;
            page1.Enabled = true;
            page2.Enabled = true;
            page5.Enabled = true;
        }

        private void page5_Click(object sender, EventArgs e)
        {
            InstructionTextBox.Clear();
            InstructionTextBox.Text = page5Text;
            InstructionTextBox.Refresh();
            page5.Enabled = false;

            introPage.Enabled = true;
            page3.Enabled = true;
            page1.Enabled = true;
            page2.Enabled = true;
            page4.Enabled = true;
        }
    }
}
