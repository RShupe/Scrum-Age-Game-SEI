using System;
using Xunit;
using Stone_Age_Game;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      DiceRollerTests.cs
//	Description:                    This class is used to do unit testing on the DiceRoller class 
//	Author:                         Ryan Shupe, East Tennessee State University
//  Email:                          shuper@etsu.edu
//  Last Modified By:               Ryan Shupe
//	Created:                        Saturday November 15, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace StoneAge.Tests
{
    public class DiceRollerTests
    {
        private readonly DiceRoller roller;

        public DiceRollerTests()
        {
            roller = new DiceRoller();
        }

        //check boundaries
        [Fact]
        public void TestRollneg1Dice()
        {
            int result = roller.RollDice(-1);
            Assert.True(RangeTest(result, -1));
        }

        //check if rolling 0 dice returns 0
        [Fact]
        public void TestRoll0Dice()
        {
            int result = roller.RollDice(0);
            Assert.True(RangeTest(result, 0));
        }

        //checks to see if we get a number 1-6 by rolling one die.
        [Fact]
        public void TestRoll1Dice()
        {
            int result = roller.Roll1Die();
            Assert.True(RangeTest(result, 1));
        }

        //rolls 2 dice to see if the method is working correctly
        [Fact]
        public void TestRoll2Dice()
        {
            int result = roller.RollDice(2);
            Assert.True(RangeTest(result, 2));
        }

        //rolls 2 dice to see if the method is working correctly
        [Fact]
        public void TestRoll6Dice()
        {
            int result = roller.RollDice(6);
            Assert.True(RangeTest(result, 6));
        }

        //method to specify the range to check for
        public bool RangeTest(int input, int numDice)
        {
            if (numDice == 1)
            {
                if (input < 7)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (numDice == 0 || numDice == -1)
            {
                if (input == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (numDice == 2)
            {
                if (input < 13)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (numDice ==6)
            {
                if (input < 37)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}