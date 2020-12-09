using System;
using Xunit;
using Stone_Age_Game;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      PlayerTests.cs
//	Description:                    This class is used to do unit testing on the player class 
//	Author:                         Ryan Shupe, East Tennessee State University
//  Email:                          shuper@etsu.edu
//  Last Modified By:               Ricky Keller
//	Created:                        Saturday November 15, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace StoneAge.Tests
{
    public class PlayerTests
    {
        private readonly Player player;

        public PlayerTests()
        {
            player = new Player();
        }

        [Theory]
        [InlineData(1, 6)]
        [InlineData (-1, 4)]
        public void TestAddDevelopers(int num, int expected)
        {
            player.NumDevelopers += num;
            int result = player.NumDevelopers;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData (1, 4)]
        [InlineData (-1, 6)]
        [InlineData (99995, -99990)]
        public void TestSubtractDevelopers (int num, int expected)
        {
            player.NumDevelopers -= num;
            int result = player.NumDevelopers;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData (1, 8)]
        [InlineData (-1, 6)]
        [InlineData (5000, 5007)]
        public void TestAddMoney (int num, int expected)
        {
            player.Money += num;
            int result = player.Money;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData (1, 6)]
        [InlineData (-1, 8)]
        [InlineData (-5000, 5007)]
        public void TestSubtractMoney(int num, int expected)
        {
            player.Money -= num;
            int result = player.Money;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData (1,1)]
        [InlineData (100, 100)]
        [InlineData (-1, -1)]
        public void TestAddSatisfactionPoints (int num, int expected)
        {
            player.VictoryPoints += num;
            int result = player.VictoryPoints;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData (1, -1)]
        [InlineData (-1, 1)]
        public void TestSubtractSatisfactionPoints(int num, int expected)
        {
            player.VictoryPoints -= num;
            int result = player.VictoryPoints;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData (1, 1)]
        public void TestAddUseCases (int num, int expected)
        {
            player.NumUseCases += num;
            int result = player.NumUseCases;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData (1, -1)]
        public void TestSubtractUseCases (int num, int expected)
        {
            player.NumUseCases -= num;
            int result = player.NumUseCases;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData (1, 1)]
        public void TestAddUserStories (int num, int expected)
        {
            player.NumUserStories += num;
            int result = player.NumUserStories;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData (1, -1)]
        public void TestSubtractUserStories (int num, int expected)
        {
            player.NumUserStories -= num;
            int result = player.NumUserStories;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData (1, 1)]
        public void TestAddPrototypes (int num, int expected)
        {
            player.NumPrototypes += num;
            int result = player.NumPrototypes;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData (1, -1)]
        public void TestSubtractPrototypes (int num, int expected)
        {
            player.NumPrototypes -= num;
            int result = player.NumPrototypes;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 1)]
        public void TestAddCompletedPrograms(int num, int expected)
        {
            player.CompletedPrograms += num;
            int result = player.CompletedPrograms;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, -1)]
        public void TestSubtractCompletedPrograms(int num, int expected)
        {
            player.CompletedPrograms -= num;
            int result = player.CompletedPrograms;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 2)]
        public void TestAddScrumLevel(int num, int expected)
        {
            player.ScrumLevel += num;
            int result = player.ScrumLevel;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, -1)]
        public void TestSubtractScrumLevel(int num, int expected)
        {
            player.ScrumLevel -= num;
            int result = player.ScrumLevel;
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// To test if upkeep method is working as intended
        /// </summary>
        /// <param name="expected"></param>
        [Theory]
        [InlineData (2)]
        public void upkeeptest (int expected)
        {
            player.Upkeep();
            Assert.Equal(player.Money, expected);
        }
    }
}