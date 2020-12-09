///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      Player.cs
//	Description:                    This class will represent the player object in the stone age game. This will hold each players resources, completed projects, and scrum master level 
//	Author:                         David Hopland, East Tennessee State University
//  Email:                          hoplandd@etsu.edu
//  Last Modified By:               Ryan Shupe
//	Created:                        Monday, October 21th, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stone_Age_Game
{
    /// <summary>
    ///  The player object in the stone age game. This will hold each players resources, completed projects, and scrum master level 
    /// </summary>
    public class Player
    {

        #region Attributes
        /// <summary>
        /// Declare the variables for the Player object
        /// </summary>
        private int satisfactionPoints, numDevelopers, money, numUseCases, numUserStories,
                          numPrototypes, completedPrograms, scrumLevel;
        
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor for Player object
        /// </summary>
        public Player()
        {
            satisfactionPoints = 0;
            numDevelopers = 5;
            money = 7;
            numUserStories = 0;
            numUseCases = 0;
            numPrototypes = 0;
            completedPrograms = 0;
            scrumLevel = 1;
        }

        /// <summary>
        /// Parametric constructor
        /// </summary>
        /// <param name="vicPoints">the number of victory points</param>
        /// <param name="devs">the number of developers the player has</param>
        /// <param name="money">the players current amount of money</param>
        /// <param name="userStories">the players current amount of user stories</param>
        /// <param name="useCases">the players current amount of useCases</param>
        /// <param name="prototype">the players current number of prototypes</param>
        /// <param name="programs">the players current number of completed programs</param>
        /// <param name="scrum">the scrum Level</param>
        public Player(int vicPoints, int devs, int money, int userStories, int useCases, int prototype, int programs, int scrum)
        {
            satisfactionPoints = vicPoints;
            numDevelopers = devs;
            this.money = money;
            numUserStories = userStories;
            numUseCases = useCases;
            numPrototypes = prototype;
            completedPrograms = programs;
            scrumLevel = scrum;
        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="player">a previously made Player object</param>
        public Player(Player player)
        {
            this.satisfactionPoints = player.VictoryPoints;
            this.numDevelopers = player.NumDevelopers;
            this.money = player.Money;
            this.numUserStories = player.numUserStories;
            this.numUseCases = player.NumUseCases;
            this.numPrototypes = player.NumPrototypes;
            this.completedPrograms = player.CompletedPrograms;
            this.scrumLevel = player.scrumLevel;
        }
        #endregion

        #region Properties
        /// <summary>
        /// get/set the satisfactionPoints attribute 
        /// </summary>
        public int VictoryPoints
        {
            get { return satisfactionPoints; }
            set { satisfactionPoints = value; }
        }
        /// <summary>
        /// get/set the numDevelopers attribute 
        /// </summary>
        public int NumDevelopers
        {
            get { return numDevelopers; }
            set { numDevelopers = value; }
        }
        /// <summary>
        /// get/set the money attribute 
        /// </summary>
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        /// <summary>
        /// get\set the userStories attribute
        /// </summary>
        public int NumUserStories
        {
            get { return numUserStories; }
            set { numUserStories = value; }
        }

        /// <summary>
        /// get/set the numUseCases attribute 
        /// </summary>
        public int NumUseCases
        {
            get { return numUseCases; }
            set { numUseCases = value; }
        }
        /// <summary>
        /// get/set the numPrototypes attribute 
        /// </summary>
        public int NumPrototypes
        {
            get { return numPrototypes; }
            set { numPrototypes = value; }
        }
        /// <summary>
        /// get/set the completedPrograms attribute 
        /// </summary>
        public int CompletedPrograms
        {
            get { return completedPrograms; }
            set { completedPrograms = value; }
        }
        /// <summary>
        /// get/set the scrumLevel attribute 
        /// </summary>
        public int ScrumLevel
        {
            get { return scrumLevel; }
            set { scrumLevel = value; }
        }


        #endregion

        #region Upkeep
        /// <summary>
        /// This method will charge the player money equal to the number of developers 
        /// if the player does not have enough money then they are asked what resource 
        /// they would like to lose in place of the money they do not have 
        /// </summary>
        public void Upkeep()
        {
            int missingMoney = 0;
            if (this.NumDevelopers <= this.Money)
            {
                this.Money = this.Money - this.NumDevelopers;
            }
            else
            {
                missingMoney = this.NumDevelopers - this.Money;
                ExchangeResource();
            }
        }
        #endregion

        #region ExchangeResource
        /// <summary>
        /// this method will exchange 1 resource of the players choosing to compensate 
        /// for not having enough money to pay the developers at the end of the players turn
        /// </summary>
        public void ExchangeResource()
        {
            ExchangeResource exchangeResource = new ExchangeResource(this);
            exchangeResource.ShowDialog();
        }
        #endregion



        #region ToString
        /// <summary>
        /// ToString method that gives an output for the player in an easy to read format
        /// </summary>
        /// <param name="player">the player object to display the information about</param>
        /// <returns>msg that contains the string</returns>
        public override string ToString()
        {

            string msg = $"Player" + MainForm.CurrentPlayer + " Resource List:\r\n" + "\r\n" +
                                     $"           Victory Points: {this.VictoryPoints.ToString()}\r\n" +
                                     $"              Developers: {this.NumDevelopers.ToString()}\r\n" +
                                     $"                     Money: {this.Money.ToString()}\r\n" +
                                     $"             User Stories: {this.NumUserStories.ToString()}\r\n" +
                                     $"               Use Cases: {this.NumUseCases.ToString()}\r\n" +
                                     $"               Prototypes: {this.NumPrototypes.ToString()}\r\n" +
                                     $" Completed Projects: {this.CompletedPrograms.ToString()}\r\n" +
                                     $"Scrum Master Level: {this.ScrumLevel.ToString()}\r\n";
   
            return msg;
        }
        #endregion

    }
}
