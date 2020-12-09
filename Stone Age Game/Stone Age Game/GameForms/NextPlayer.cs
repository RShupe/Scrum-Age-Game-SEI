using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      Next Player.cs
//	Description:                    Form to tell the users that it is the next players turn
//	Author:                         Ryan Shupe
//  Last Modified By:               Ryan Shupe
//	Created:                        Thursday December 3, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Stone_Age_Game.GameForms
{
    public partial class NextPlayer : Form
    {
        public NextPlayer(int playerNum)
            : this()
        {
            
            InitializeComponent();
            label3.Text = playerNum.ToString();
        }

        public NextPlayer()
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
