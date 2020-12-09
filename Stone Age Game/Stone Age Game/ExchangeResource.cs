///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      ExchangeResource.cs
//	Description:                    
//	Author:                         David Hopland, East Tennessee State University
//  Email:                          hoplandd@etsu.edu
//  Last Modified By:               Ryan Shupe
//	Created:                        Monday, October 21th, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections;
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
    public partial class ExchangeResource : Form
    {
        Player player = new Player(1, 3, 2, 1, 1, 1, 1, 1); //player object initialized for testing

        public ExchangeResource()
        {
            InitializeComponent();
        }

        public ExchangeResource(Player player)
        {
            this.player = player;
            InitializeComponent();
        }

        
        #region Event Handlers
        /// <summary>
        /// This event handler will be triggered when the exchange button is clicked 
        /// and take 1 of the selected resource from the player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int exchangesLeft = Int32.Parse(textBox2.Text);
            textBox2.Text = exchangesLeft.ToString();
            if (player.NumPrototypes + player.NumUseCases + player.NumUserStories == 0)
            {
                player.VictoryPoints -= 10;
                exchangesLeft--;
                if (exchangesLeft <= 0)
                    Close();
                textBox2.Text = exchangesLeft.ToString();
            }
            if ((string)comboBox1.SelectedItem == "User Stories" && player.NumUserStories != 0)
            {
                player.NumUserStories--;
                textBox1.Text = player.NumUserStories.ToString();
                exchangesLeft--;
                if (exchangesLeft <= 0)
                    Close();
                textBox2.Text = exchangesLeft.ToString();
            }
            if ((string)comboBox1.SelectedItem == "Use Cases" && player.NumUseCases != 0)
            {
                player.NumUseCases--;
                textBox1.Text = player.NumUseCases.ToString();
                exchangesLeft--;
                if (exchangesLeft <= 0)
                    Close();
                textBox2.Text = exchangesLeft.ToString();
            }
            if ((string)comboBox1.SelectedItem == "Prototypes" && player.NumPrototypes != 0)
            {
                player.NumPrototypes--;
                textBox1.Text = player.NumPrototypes.ToString();
                exchangesLeft--;
                if (exchangesLeft <= 0)
                    Close();
                textBox2.Text = exchangesLeft.ToString();
            }
        }
        /// <summary>
        /// Event handler will be triggered when the user selects an option from the combo box
        /// then the current player amount of resources is displayed to a read only text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "User Stories")
            {
                textBox1.Text = player.NumUserStories.ToString();
            }
            if ((string)comboBox1.SelectedItem == "Use Cases")
            {
                textBox1.Text = player.NumUseCases.ToString();
            }
            if ((string)comboBox1.SelectedItem == "Prototypes")
            {
                textBox1.Text = player.NumPrototypes.ToString();
            }
        }

        private void ExchangeResource_Load(object sender, EventArgs e)
        {
            textBox2.Text = (player.NumDevelopers - player.Money).ToString();
        }
        #endregion

    }
}
