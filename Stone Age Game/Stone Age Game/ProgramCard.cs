///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                     ProgramCard.cs
//	Description:                  This class will create the Program Cards that are needed to score points and set the condition to end the game
//	Author:                          David Hopland, East Tennessee State University
// Email:                            hoplandd@etsu.edu
//  Last Modified By:        David Hopland
//	Created:                         Friday, October 23th, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
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
        int victoryPoints, userStoryCost, useCaseCost, prototypeCost, cardNum;
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor for the ProgramCard class
        /// </summary>
        public ProgramCard()
        {
            victoryPoints = 0;
            userStoryCost = 0; // identifier 
            useCaseCost = 0;
            prototypeCost = 0;
            cardNum = 0;
        }
        /// <summary>
        /// Parametric constructor for the ProgramCard class
        /// </summary>
        /// <param name="vic">number of victory points the card is worth</param>
        /// <param name="stories">how many user stories does the card cost</param>
        /// <param name="cases">how many use cases does this card cost</param>
        /// <param name="prototypes">how many prototypes does this card cost</param>
        /// <param name="card">the card number identifier</param>
        public ProgramCard(int vic, int stories, int cases, int prototypes, int card)
        {
            victoryPoints = vic;
            userStoryCost = stories;
            useCaseCost = cases;
            prototypeCost = prototypes;
            cardNum = card;
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
