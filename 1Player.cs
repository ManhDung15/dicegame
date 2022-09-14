using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGameLast
{
    public partial class gameDice : Form
    {
        int dice1, dice3, dice2;

        int roll = 0;// will have 3 turn in each round
        int round = 1; // declair round
        int result = 0;
        int result1, result2, result3;
        int[] ListBonus = { Globals.Point };
        int[] ListScore = { Globals.Score };
        public gameDice()
        {
            InitializeComponent();
        }
        class Globals
        {
            public static int Score;
            public static int Point;
        }
        private void gameDice_Load(object sender, EventArgs e)
        {
            lblRound.Text = "Round: " + round.ToString();
            lblRoll.Text = "Roll: ";
            picBx1.Image = imageList.Images[6];
            picBx2.Image = imageList.Images[6];
            picBx3.Image = imageList.Images[6];
            cBx1.Enabled = false;
            cBx2.Enabled = false;
            cBx3.Enabled = false;
            pgrBar1.Visible = false;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            timer.Start();
            diceRoll();
            
            if (round == 7)
            {
                DialogResult finishWarning = MessageBox.Show
                ("You have finish the game. You got " + Globals.Score + " points. Do you want to Exit??? ", "Warning", MessageBoxButtons.YesNo);
                if (finishWarning == DialogResult.Yes)
                {
                    MainMenu menuGame = new MainMenu();
                    menuGame.Show();
                }
                else
                {
                    DialogResult gameReStart = MessageBox.Show("Game restarted", "Notification", MessageBoxButtons.OK);
                    if (gameReStart == DialogResult.OK)
                        round = 1;
                    reStart();
                    checkBox();
                }//else bracket
               
            }//if round bracket
        }

        private void checkBox()
        {
            cBx1.Checked = false;
            cBx2.Checked = false;
            cBx3.Checked = false;
            cBx1.Enabled = false;
            cBx2.Enabled = false;
            cBx3.Enabled = false;
        }

        private void reStart()
        {
            
            lblRound.Text ="Round: " + round.ToString();
            roll = 0;
            lblRoll.Text = "Roll: ";
            picBx1.Image = imageList.Images[6];
            picBx2.Image = imageList.Images[6];
            picBx3.Image = imageList.Images[6];
            dice1 = 0;
            dice1 = 0;
            dice1 = 0;
            timer.Enabled = false;
            pgrBar1.Value = 0;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (result1 == round && cBx1.Checked == true)
            {
                Globals.Score = Globals.Score + result1;
            }
            if (result1 == round && cBx1.Checked == false)
            {
                Globals.Score = Globals.Score - result1;
            }
            result1 = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            diceRoll();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (result2 == round && cBx2.Checked == true)
            {
                Globals.Score = Globals.Score + result2;
            }
            if (result2 == round && cBx2.Checked == false)
            {
                Globals.Score = Globals.Score - result2;
            }
            result2 = 0;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (result3 == round && cBx3.Checked == true)
            {
                Globals.Score = Globals.Score + result3;
            }

            if (result3 == round && cBx3.Checked == false)
            {
                Globals.Score = Globals.Score - result3;
            }
            result3 = 0;
        }

        private void ShowResult()
        {   
            //show Result of player1
            txbxLR1.AppendText(round + "\r\n");
            txbxLB1.AppendText("\r\n");
            txbxTS1.AppendText(Globals.Score + "\r\n");
            
        }

        private void bonus()
        {

            //test bonus
            if ((round == result1 && round == result2 && round == result3))
            {
                Globals.Score = Globals.Score + 20;
                DialogResult showResult = MessageBox.Show("You got a WhooHoo point", "Notification", MessageBoxButtons.OK);
                if (showResult == DialogResult.OK)
                {
                    Globals.Point = 20;
                    txbxLB1.AppendText(Globals.Point + " ");
                }
            }

            //compare 3 number to make sure it is a sequence number
            else if ((result1 == result2 - 1) && (result1 == result3 - 2) || (result1 == result2 - 2) && (result1 == result3 - 1) || (result1 == result2 - 1) && (result1 == result3 + 1) ||
             (result1 == result2 + 1) && (result1 == result3 - 1) || (result1 == result2 + 1) && (result1 == result3 + 2) || (result1 == result2 + 2) && (result1 == result3 + 1))
            {
                Globals.Score = Globals.Score + 10;

                DialogResult showResult = MessageBox.Show("You got a Bonus point", "Notification", MessageBoxButtons.OK);
                if (showResult == DialogResult.OK)
                {
                    Globals.Point = 10;
                    txbxLB1.AppendText(Globals.Point + " ");
                }
            }
        }//bonus

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this one will allow the system to hide the play section and show the menuGame
            DialogResult exitButton = MessageBox.Show
            ("Do you want to go back to the Menu?", "Warning", MessageBoxButtons.OKCancel);
            if (exitButton == DialogResult.OK)
            {
                this.Hide();
                MainMenu menuGame = new MainMenu();
                menuGame.Show();
            }
        }

        private int dice(int d, PictureBox p)
        {
            int result = 0;
            if (d == 1) { p.Image = imageList.Images[0]; result = 1; }
            if (d == 2) { p.Image = imageList.Images[1]; result = 2; }
            if (d == 3) { p.Image = imageList.Images[2]; result = 3; }
            if (d == 4) { p.Image = imageList.Images[3]; result = 4; }
            if (d == 5) { p.Image = imageList.Images[4]; result = 5; }
            if (d == 6) { p.Image = imageList.Images[5]; result = 6; }
            return result;
        }

        private void diceRoll()
        {
            //random value for dice from 1 to 6

            // If the check box unchecked, will show the dice face
            if (cBx1.Checked == false)
            { result1 = dice(dice1, picBx1);}
            if (cBx2.Checked == false)
            { result2 = dice(dice2, picBx2); }
            if (cBx3.Checked == false)
            { result3 = dice(dice3, picBx3);}
            //the turn will +1 when user click the button
            //when reach 3, round automatically +1 and then show on the screen, turn back to 0

            pgrBar1.Increment(10);
            if (pgrBar1.Value != pgrBar1.Maximum)
            {
                btnRoll.Enabled = false;
                cBx1.Enabled = false;
                cBx2.Enabled = false;
                cBx3.Enabled = false;
                Random rand = new Random();
                dice1 = rand.Next(1, 4);
                dice2 = rand.Next(1, 4);
                dice3 = rand.Next(1, 4);
            }
            else if (pgrBar1.Value == pgrBar1.Maximum)
            {

                if (cBx1.Checked == true)
                { result1 = 0; }
                if (cBx2.Checked == true)
                { result2 = 0; }
                if (cBx3.Checked == true)
                { result3 = 0; }

                timer.Stop();
                pgrBar1.Value = 0;
                btnRoll.Enabled = true;
                roll++;
                lblRoll.Text = "Roll: " + roll.ToString();
                cBx1.Enabled = true;
                cBx2.Enabled = true;
                cBx3.Enabled = true;

                // when roll = 4, the console with show a signal to help users know that they have go to another rounds.    
                if (roll >3)
                {
                    reStart();
                    checkBox();
                    ShowResult();
                    round++;

                }//if quotes
                 //if 3 checkBox have been checked, its mean the players want to end the round soon.
                else if (cBx1.Checked == true && cBx2.Checked == true && cBx3.Checked == true)
                {
                    ShowResult();
                    bonus();
                    round++;
                    reStart();
                    checkBox();

                }//else if quotes
                bonus();
            }//else if progressbar
        }//diceRoll



    }
}
