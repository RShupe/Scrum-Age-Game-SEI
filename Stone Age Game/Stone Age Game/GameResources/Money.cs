//////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      Money.cs
//	Description:                    Holds attributes this object will have when used
//	Author:                         Team 1
//  Last Modified By:               Markis Dearstone
//	Created:                        Monday, October 22nd, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone_Age_Game
{
    public class Money : Resource
    {
        #region Properties
        /// <summary>
        /// get/set the amount of money
        /// </summary>
        public int amount { get; set; }
        /// <summary>
        /// get/set the divisor to divide dice by
        /// </summary>
        public int divisor { get; set; } = 2;
        /// <summary>
        /// get/set the number of developers allowed on position
        /// </summary>
        public int maxDevelopers { get; set; } = int.MaxValue;
        #endregion

        DiceRoller roller = new DiceRoller();

        #region Gather
        /// <summary>
        /// returns amount of resources to give player
        /// </summary>
        /// <param name="developers"></param>
        /// <returns></returns>
        public int Gather(int developers)
        {
            int resourceQuantity = roller.RollDice(developers);
            return (resourceQuantity / divisor);
        }
        #endregion
    }
}
