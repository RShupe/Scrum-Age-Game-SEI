///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      GameStart.cs
//	Description:                    Lets user know the game has begun
//	Author:                         Team 1
//  Last Modified By:               Markis Dearstone
//	Created:                        Monday, October 23th, 2020
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
    public partial class GameStart : Form
    {
        public GameStart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Continue Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
