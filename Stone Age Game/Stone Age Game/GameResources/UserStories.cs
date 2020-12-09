//////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      UserStories.cs
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
    public class UserStories : Resource
    {
        #region Properties
        /// <summary>
        /// get/set the amount of User stories
        /// </summary>
        public int amount { get; set; }
        /// <summary>
        /// get/set the divisor to divide dice by
        /// </summary>
        public int divisor { get; set; } = 2;
        /// <summary>
        /// get/set the amount of devs allowed on this location
        /// </summary>
        public int maxDevelopers { get; set; } = 7;
        #endregion

        DiceRoller roller = new DiceRoller();

        #region Gather
        /// <summary>
        /// Returns amount of resources to give player
        /// </summary>
        /// <param name="developers"></param>
        /// <returns></returns>
        public int Gather(int developers)
        {
            if (developers <= maxDevelopers)
            {
                int resourceQuantity = roller.RollDice(developers);
                return (resourceQuantity / divisor);
            }
            else
            {
                int resourceQuantity = roller.RollDice(maxDevelopers);
                return (resourceQuantity / divisor);
            }
        }
        #endregion
    }
}
