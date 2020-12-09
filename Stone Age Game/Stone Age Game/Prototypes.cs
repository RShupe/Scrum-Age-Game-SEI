//////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      Prototypes.cs
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
    class Prototypes : Resource
    {
        #region Properties
        /// <summary>
        /// get/set the amount of prototypes
        /// </summary>
        public int amount { get; set; }
        /// <summary>
        /// get/set the divisor to divide dice by
        /// </summary>
        public int divisor { get; set; } = 4;
        /// <summary>
        /// get/set the amount of devs allowed on area
        /// </summary>
        public int maxDevelopers { get; set; } = 4;
        #endregion

        DiceRoller roller = new DiceRoller();

        #region Gather
        /// <summary>
        /// returns amount of resources to five player
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
