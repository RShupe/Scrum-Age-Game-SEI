//////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      Resource.cs
//	Description:                    Allows for resource classes to implement these attributes
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
    public interface Resource
    {
        #region Properties
        /// <summary>
        /// get/set the amount 
        /// </summary>
        public int amount { get; set; }
        /// <summary>
        /// get/set the divisor to divide dice by
        /// </summary>
        public int divisor { get; set; }
        /// <summary>
        /// get/set the amount of devs allowed on a location
        /// </summary>
        public int maxDevelopers { get; set; }
        /// <summary>
        /// returns amount of resources to give player
        /// </summary>
        public int Gather(int developer);
        #endregion
    }
}
