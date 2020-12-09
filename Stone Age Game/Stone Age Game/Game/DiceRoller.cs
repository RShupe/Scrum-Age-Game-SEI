///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Dice Roller.cs
//	Description:       This class handles the creation of the forms for the user to see.
//
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//  Last Modified By:  Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, October 19th, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone_Age_Game
{

    public class DiceRoller
    {
        private Random rnd;
        private int sides;

        /// <summary>
        /// DiceRoller - initializes a basic 6 sided die
        /// </summary>
        public DiceRoller()
        {
            rnd = new Random();
            sides = 6;
        }

        /// <summary>
        /// DiceRoller - initializes a die with a custom amount of sides
        /// </summary>
        /// <param name="sides">< /param>
        public DiceRoller(int sides)
        {
            rnd = new Random();
            this.sides = sides;
        }

        /// <summary>
        /// RollDice - Rolls n dice for how many n passed in
        /// </summary>
        /// <return name="result">< /param>
        public int RollDice(int developers)
        {
            int result = 0;

            for (int i = 0; i < developers; i++)
            {
                result += rnd.Next(sides) + 1;
            }

            return result;
        }

        /// <summary>
        /// Rol1lDie- Rolls 1 die and returns the result
        /// </summary>
        /// <return name="result">< /param>
        public int Roll1Die()
        {
            return rnd.Next(sides) + 1;
        }
    }
}
