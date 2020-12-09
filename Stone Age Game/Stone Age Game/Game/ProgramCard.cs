///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                       ProgramCard.cs
//	Description:                     This class will create the Program Cards that are needed to score points and set the condition to end the game
//	Author:                          David Hopland, East Tennessee State University
//  Email:                           hoplandd@etsu.edu
//  Last Modified By:                Ryan Shupe
//	Created:                         Friday, October 23rd, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone_Age_Game
{
    class ProgramCard
    {
        #region Attributes
        /// <summary>
        /// declare the attributes for the program card class
        /// </summary>
        public int victoryPoints, userStoryCost, useCaseCost, prototypeCost, cardNum;
        public Image image;
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor for the ProgramCard class
        /// </summary>
        public ProgramCard()
        {
            victoryPoints = 0;
            userStoryCost = 1;  
            useCaseCost = 1;
            prototypeCost = 1;
            cardNum = 0;
            GenerateCard();
        }

        /// <summary>
        /// specific card constructor for the ProgramCard class
        /// </summary>
        public ProgramCard(int temp)
        {
            if (temp == 1)
            {

                this.victoryPoints = 12;
                this.cardNum = 12;

                this.prototypeCost = 1;
                this.useCaseCost = 1;
                this.userStoryCost = 1;

                this.image = Properties.Resources._12;
            }
            else if (temp == 2)
            {
                this.victoryPoints = 13;
                this.cardNum = 13;

                this.prototypeCost = 2;
                this.useCaseCost = 2;
                this.userStoryCost = 1;

                this.image = Properties.Resources._13;
            }
            else if (temp == 3)
            {
                this.victoryPoints = 14;
                this.cardNum = 14;

                this.prototypeCost = 2;
                this.useCaseCost = 2;
                this.userStoryCost = 2;

                this.image = Properties.Resources._14;
            }
            else if (temp == 4)
            {
                this.victoryPoints = 15;
                this.cardNum = 15;

                this.prototypeCost = 3;
                this.useCaseCost = 2;
                this.userStoryCost = 3;

                this.image = Properties.Resources._15;
            }
            else if (temp == 5)
            {
                this.victoryPoints = 16;
                this.cardNum = 16;

                this.prototypeCost = 3;
                this.useCaseCost = 3;
                this.userStoryCost = 3;

                this.image = Properties.Resources._16;
            }
        }

        public void Refresh()
        {
            victoryPoints = 0;
            userStoryCost = 1;
            useCaseCost = 1;
            prototypeCost = 1;
            cardNum = 0;
            GenerateCard();
        }

        private void GenerateCard()
        {
            DiceRoller dice = new DiceRoller(5); //5 different program cards
            int temp = dice.Roll1Die();

            if (temp == 1)
            {

                this.victoryPoints = 12;
                this.cardNum = 12;

                this.prototypeCost = 1;
                this.useCaseCost = 1;
                this.userStoryCost = 1;

                this.image = Properties.Resources._12;
            }
            else if (temp == 2)
            {
                this.victoryPoints = 13;
                this.cardNum = 13;

                this.prototypeCost = 2;
                this.useCaseCost = 2;
                this.userStoryCost = 1;

                this.image = Properties.Resources._13;
            }
            else if (temp == 3)
            {
                this.victoryPoints = 14;
                this.cardNum = 14;

                this.prototypeCost = 2;
                this.useCaseCost = 2;
                this.userStoryCost = 2;

                this.image = Properties.Resources._14;
            }
            else if (temp == 4)
            {
                this.victoryPoints = 15;
                this.cardNum = 15;

                this.prototypeCost = 3;
                this.useCaseCost = 2;
                this.userStoryCost = 3;

                this.image = Properties.Resources._15;
            }
            else if (temp == 5)
            {
                this.victoryPoints = 16;
                this.cardNum = 16;

                this.prototypeCost = 3;
                this.useCaseCost = 3;
                this.userStoryCost = 3;

                this.image = Properties.Resources._16;
            }
        }

        /// <summary>
        /// Parametric constructor for the ProgramCard class
        /// </summary>
        /// <param name="vic">number of victory points the card is worth</param>
        /// <param name="stories">how many user stories does the card cost</param>
        /// <param name="cases">how many use cases does this card cost</param>
        /// <param name="prototypes">how many prototypes does this card cost</param>
        /// <param name="card">the card number identifier</param>
        public ProgramCard(int vic, int stories, int cases, int prototypes, int card, Image image)
        {
            victoryPoints = vic;
            userStoryCost = stories;
            useCaseCost = cases;
            prototypeCost = prototypes;
            cardNum = card;
            this.image = image;
        }
        /// <summary>
        /// Copy constructor for the ProgramCard class
        /// </summary>
        /// <param name="old">the ProgramCard object to be copied</param>
        public ProgramCard(ProgramCard old)
        {
            this.victoryPoints = old.victoryPoints;
            this.userStoryCost = old.userStoryCost;
            this.useCaseCost = old.useCaseCost;
            this.prototypeCost = old.prototypeCost;
            this.cardNum = old.cardNum;
            this.image = old.image;
        }
        #endregion

        #region ToString
        /// <summary>
        /// this is the override toString for the ProgramCard class to convert the information into a string for output
        /// </summary>
        /// <returns>string output of the ProgramCard</returns>
        public override string ToString()
        {
            string msg = $"Program Card number: {this.cardNum}\r\n" +
                         $"Number of Victory Points: {this.victoryPoints}\r\n" +
                         $"User Story price: {this.userStoryCost}\r\n" +
                         $"Use Case price: {this.useCaseCost}\r\n" +
                         $"Prototype price: {this.prototypeCost}\r\n";
            return msg;
        }
        #endregion


    }
}
