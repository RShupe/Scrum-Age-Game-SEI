//////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      Phase1Comp.cs
//	Description:                    Lets user know phase one has ended and phase two is commencing 
//	Author:                         Team 1
//  Last Modified By:               Markis Dearstone
//	Created:                        Monday, October 24th, 2020
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
    public partial class Phase1Comp : Form
    {
        public Phase1Comp()
        {
            InitializeComponent();
        }

        #region Phase 1 Continue Btn Click
        /// <summary>
        /// Phase 1 Continue Btn Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p1Cont_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
