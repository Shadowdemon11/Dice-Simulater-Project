using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Simulater
{
    // Michael Hanson	
    //10/8/13
    //Homework 4
    //Programming Fundamentals
    //Brian Trager
    public partial class diceSimulator : Form
    {
        public diceSimulator()
        {
            InitializeComponent();
        }

        private void roll_Click(object sender, EventArgs e)
        {
            // my value
            int roll;
            // the random number maker
            Random rand = new Random();
            roll = rand.Next(6);
            // my if , else if , else statement
            if (roll == 0)
            {
                dice1.Visible = true;
                dice2.Visible = false;
                dice3.Visible = false;
                dice4.Visible = false;
                dice5.Visible = false;
                dice6.Visible = false;
            }
            else if (roll == 1)
            {
                dice1.Visible = false;
                dice2.Visible = true;
                dice3.Visible = false;
                dice4.Visible = false;
                dice5.Visible = false;
                dice6.Visible = false;
            }
             else if (roll == 2)
            {
                dice1.Visible = false;
                dice2.Visible = false;
                dice3.Visible = true;
                dice4.Visible = false;
                dice5.Visible = false;
                dice6.Visible = false;
            }
             else if (roll == 3)
            {
                dice1.Visible = false;
                dice2.Visible = false;
                dice3.Visible = false;
                dice4.Visible = true;
                dice5.Visible = false;
                dice6.Visible = false;
            }
             else if (roll == 4)
            {
                dice1.Visible = false;
                dice2.Visible = false;
                dice3.Visible = false;
                dice4.Visible = false;
                dice5.Visible = true;
                dice6.Visible = false;
            }
            else
            {
                dice1.Visible = false;
                dice2.Visible = false;
                dice3.Visible = false;
                dice4.Visible = false;
                dice5.Visible = false;
                dice6.Visible = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
