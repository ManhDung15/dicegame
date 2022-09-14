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

    public partial class gameDice3 : Form
    {

        int dice1, dice3, dice2;

        int roll = 0;// will have 3 turn in each round
        int round = 1; // declair round
        int result = 0;

        int[] ListBonus = { Globals.Point };
        int[] ListScore = { Globals.Score };
        public gameDice3()
        {
            InitializeComponent();
        }
        class Globals
        {
            public static int Score, Score2;
            public static int Point, Point2;
        }

        private void gameDice3_Load(object sender, EventArgs e)
        {
            lblRound.Text = "Round: 1";
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
                    System.Windows.Forms.MainMenu menuGame = new System.Windows.Forms.MainMenu();
                    //menuGame.Show();
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
            cBx1.Enabled = false;
            cBx1.Enabled = false;
        }

        private void reStart()
        {
            lblRound.Text = "Round: " + round.ToString();
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
            if (dice1 == round && cBx1.Checked == true)
            {
                Globals.Score = Globals.Score + dice1;
            }
            if (dice1 == round && cBx1.Checked == false)
            {
                Globals.Score = Globals.Score - dice1;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            diceRoll();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (dice2 == round && cBx2.Checked == true)
            {
                Globals.Score = Globals.Score + dice2;
            }
            if (dice2 == round && cBx2.Checked == false)
            {
                Globals.Score = Globals.Score - dice2;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (dice3 == round && cBx3.Checked == true)
            {
                Globals.Score = Globals.Score + dice3;
            }

            if (dice3 == round && cBx3.Checked == false)
            {
                Globals.Score = Globals.Score - dice3;
            }
        }

        private void CPUMode()
        {
            for(int i =0; i<4; i++)
            {
               while(roll<4 )
                { 
                    diceRoll();
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(10);
                    break;
                }
                reStart();
                ShowResult();
                
            }
        }
        private void ShowResult()
        {
            //show Result of player1
            txbxLR1.AppendText(round + "\r\n");
            txbxLB1.AppendText("\r\n");
            txbxTS1.AppendText(Globals.Score + "\r\n");

            //show Result of player2
            // txbxLR2.AppendText(round + "\r\n");
            // txbxLB2.AppendText("\r\n");
            //  txbxTS2.AppendText(Globals.Score + "\r\n");
        }

        private void bonus()
        {

            //test bonus
            if ((round == dice1 && round == dice2 && round == dice3))
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

            else if ((dice1 == dice2 - 1) && (dice1 == dice3 - 2) || (dice1 == dice2 - 2) && (dice1 == dice3 - 1) || (dice1 == dice2 - 1) && (dice1 == dice3 + 1) ||
             (dice1 == dice2 + 1) && (dice1 == dice3 - 1) || (dice1 == dice2 + 1) && (dice1 == dice3 + 2) || (dice1 == dice2 + 2) && (dice1 == dice3 + 1))
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


        private void diceRoll()
        {
            // Data must be initialized before use
            Random rand = new Random();
            dice1 = rand.Next(1, 4);
            
            //Ramdon dice1
            // If the check box unchecked, will show the dice face
            if (cBx1.Checked == false)
            {

                if (dice1 == 1)
                    picBx1.Image = imageList.Images[0];
                else if (dice1 == 2)
                    picBx1.Image = imageList.Images[1];
                else if (dice1 == 3)
                    picBx1.Image = imageList.Images[2];
                else if (dice1 == 4)
                    picBx1.Image = imageList.Images[3];
                else if (dice1 == 5)
                    picBx1.Image = imageList.Images[4];
                else if (dice1 == 6)
                    picBx1.Image = imageList.Images[5];

                cBx1.Enabled = true;
            }//if

            //same as dice 1
            dice2 = rand.Next(1, 4);
            //Ramdon dice2
            // If the check box unchecked, will show the dice face
            if (cBx2.Checked == false)
            {
                if (dice2 == 1)
                    picBx2.Image = imageList.Images[0];
                else if (dice2 == 2)
                    picBx2.Image = imageList.Images[1];
                else if (dice2 == 3)
                    picBx2.Image = imageList.Images[2];
                else if (dice2 == 4)
                    picBx2.Image = imageList.Images[3];
                else if (dice2 == 5)
                    picBx2.Image = imageList.Images[4];
                else if (dice2 == 6)
                    picBx2.Image = imageList.Images[5];

                cBx2.Enabled = true;
            }//if


            //same as dice 1
            dice3 = rand.Next(1, 4);
            //Ramdon dice2
            // If the check box unchecked, will show the dice face
            if (cBx3.Checked == false)
            {
                if (dice3 == 1)
                    picBx3.Image = imageList.Images[0];
                else if (dice3 == 2)
                    picBx3.Image = imageList.Images[1];
                else if (dice3 == 3)
                    picBx3.Image = imageList.Images[2];
                else if (dice3 == 4)
                    picBx3.Image = imageList.Images[3];
                else if (dice3 == 5)
                    picBx3.Image = imageList.Images[4];
                else if (dice3 == 6)
                    picBx3.Image = imageList.Images[5];

                cBx3.Enabled = true;
            }//if

            //the turn will +1 when user click the button
            //when reach 3, round automatically +1 and then show on the screen, turn back to 0

            pgrBar1.Increment(10);
            if (pgrBar1.Value != pgrBar1.Maximum)
            {
                btnRoll.Enabled = false;
                cBx1.Enabled = false;
                cBx2.Enabled = false;
                cBx3.Enabled = false;
            }
            else if (pgrBar1.Value == pgrBar1.Maximum)
            {

                timer.Stop();
                pgrBar1.Value = 0;
                btnRoll.Enabled = true;
                roll++;
                lblRoll.Text = "Roll: " + roll.ToString();
                // when roll = 4, the console with show a signal to help users know that they have go to another rounds.    
                if (roll > 3)
                {
                    reStart();
                    checkBox();
                    ShowResult();
                    round++;
                    if (round % 2 == 0)
                    { 
                        CPUMode();
                        reStart();
                        checkBox();
                        ShowResult();
                        round++;
                    }

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
