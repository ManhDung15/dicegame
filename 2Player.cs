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
    public partial class gameDice2 : Form
    {
        int dice1, dice3, dice2;

        int roll = 0;// will have 3 turn in each round
        int round = 1; // declair round
        int result = 0;
        int result1, result2, result3;
        int[] ListBonus = { Globals.Point };
        int[] ListScore = { Globals.Score };
        Label[] playerName = new Label[5];
        static int player = 1;
        Player player1 = new Player();
        Player player2 = new Player();
        bool playerRegister = true;
        static String playername1, playername2; //this for player name 

        //Điểm của 2 thằng sẽ đc lưu dô int này
        int Scoreplayer1 = Globals.Score;
        int Scoreplayer2 = Globals.Score;
        class Player //Player class
        {
            int score = 0; //integer used for holding the player's score
            public int Score //public accessor for the player's score
            {
                get //returns the value of score variable
                {
                    return score;
                }
                set //sets the value of the score variable
                {
                    score = value;
                }
            }
            public string sName
            {
                get
                {
                    return sName;
                }
            }
        }//end of Player class
        public gameDice2()
        {
            InitializeComponent();
        }
        public static void setName(String n1, String n2)
        {
            playername1 = n1;
            playername2 = n2;
        }

        class Globals
        {
            public static int Score, Score2;
            public static int Point, Point2;
        }
        private void gameDice2_Load(object sender, EventArgs e)
        {
            EnterName ENform = new EnterName();
            ENform.ShowDialog();
            lblRound.Text = "Round: " + round.ToString();
            lblRoll.Text = "Roll: ";
            picBx1.Image = imageList.Images[6];
            picBx2.Image = imageList.Images[6];
            picBx3.Image = imageList.Images[6];
            cBx1.Enabled = false;
            cBx2.Enabled = false;
            cBx3.Enabled = false;
            pgrBar1.Visible = false;
            lblName1.Text = playername1;
            lblName2.Text = playername2;

        }
        private void Checkend()
        {
            //Dùng để check if player = 3 thì kết thúc, chỗ này hơi rối vì lúc round ==7 cũng là lúc player = 3
            if (player == 3)
            {
                Scoreplayer1 = Globals.Score;
                Scoreplayer2 = Globals.Score2;
                //ktra thắng thua
                if (Scoreplayer1 > Scoreplayer2)
                {
                    MessageBox.Show("Player 1 win, Player 2 lose !!!");
                }
                else if (Scoreplayer1 < Scoreplayer2)
                {
                    MessageBox.Show("Player 2 win, Player 1 lose !!!");
                }
                else
                {
                    MessageBox.Show("Draw !!!");
                }
                //Show a message for the player if they want to exit or restart the game
                DialogResult finishWarning = MessageBox.Show
               (" Do you want to Exit??? ", "Warning", MessageBoxButtons.YesNo);
                if (finishWarning == DialogResult.Yes)
                {
                    this.Hide();
                    MainMenu menuGame = new MainMenu();
                    menuGame.Show();
                }
                else
                {
                    DialogResult gameReStart = MessageBox.Show("Game restarted", "Notification", MessageBoxButtons.OK);
                    if (gameReStart == DialogResult.OK)
                    {
                        /* round = 1;
                         reStart();
                         checkBox();
                         Globals.Score = 0;
                         Globals.Score2 = 0;
                         txbxLB1.Clear();
                         txbxLR1.Clear();
                         txbxTS1.Clear();
                         txbxLB2.Clear();
                         txbxLR2.Clear();
                         txbxTS2.Clear();*/
                        Application.Restart();

                    }

                }//else bracket
            }
        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            timer.Start();
            diceRoll();

            //if round = 7 thì nó bắt đầu reset lại
            if (round == 2)
            {
                Scoreplayer1 = Globals.Score;
                player++; //player ++
                if (player == 2)
                    MessageBox.Show("the game will be start for: " + lblName2.Text); // show player turn
                reStart();

                round = 1;
                lblRound.Text = "Round: " + round.ToString();
                Checkend();
            }
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
            lblRound.Text = "Round: " + round.ToString();
            roll = 0;
            lblRoll.Text = "Roll: ";
            picBx1.Image = imageList.Images[6];
            picBx2.Image = imageList.Images[6];
            picBx3.Image = imageList.Images[6];
            dice1 = 0;
            dice1 = 0;
            dice1 = 0;

        }


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

        private void ShowResult()
        {
            //show Result of player1
            if (player == 1)
            {
                txbxLR1.AppendText(round + "\r\n");
                txbxLB1.AppendText("\r\n");
                txbxTS1.AppendText(Globals.Score + "\r\n");

            }

            //show Result of player2
            if (player == 2)
            {
                txbxLR2.AppendText(round + "\r\n");
                txbxLB2.AppendText("\r\n");
                txbxTS2.AppendText(Globals.Score2 + "\r\n");
            }

        }

        private void cBx1_CheckedChanged(object sender, EventArgs e)
        {
            if (player == 1)
            {
                if (result1 == round && cBx1.Checked == true)
                {
                    Globals.Score = Globals.Score + result1;
                }
                if (result1 == round && cBx1.Checked == false)
                {
                    Globals.Score = Globals.Score - result1;
                }
            }

            else if (player == 2)
            {
                if (result1 == round && cBx1.Checked == true)
                {
                    Globals.Score2 = Globals.Score2 + result1;
                }
                if (result1 == round && cBx1.Checked == false)
                {
                    Globals.Score2 = Globals.Score2 - result1;
                }
            }
          
        }

        private void cBx2_CheckedChanged(object sender, EventArgs e)
        {
            if (player == 1)
            {
                if (result2 == round && cBx2.Checked == true)
                {
                    Globals.Score = Globals.Score + result2;
                }
                if (result2 == round && cBx2.Checked == false)
                {
                    Globals.Score = Globals.Score - result2;
                }
            }

            else if (player == 2)
            {
                if (result2 == round && cBx2.Checked == true)
                {
                    Globals.Score2 = Globals.Score2 + result2;
                }
                if (result2 == round && cBx2.Checked == false)
                {
                    Globals.Score2 = Globals.Score2 - result2;
                }
            }
           
        }

        private void cBx3_CheckedChanged(object sender, EventArgs e)
        {
            if (player == 1)
            {
                if (result3 == round && cBx3.Checked == true)
                {
                    Globals.Score = Globals.Score + result3;
                    
                }
                if (result3 == round && cBx3.Checked == false)
                {
                    Globals.Score = Globals.Score - result3;
                    
                }
                
            }

            else if (player == 2)
            {
                if (result3 == round && cBx3.Checked == true)
                {
                    Globals.Score2 = Globals.Score2 + result3;
                }
                if (result3 == round && cBx3.Checked == false)
                {
                    Globals.Score2 = Globals.Score2 - result3;
                }
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            diceRoll();
        }

        private void bonus()
        {
            //test bonus
            if ((round == result1 && round == result2 && round == result3))
            {
                DialogResult showResult = MessageBox.Show("You got a WhooHoo point", "Notification");
                if (player == 1)
                {
                    Globals.Score = Globals.Score + 20;
                    {
                        Globals.Point = 20;
                        txbxLB1.AppendText(Globals.Point + " ");
                    }
                }
                else if (player == 2)
                {
                    Globals.Score2 = Globals.Score2 + 20;
                    {
                        Globals.Point2 = 20;
                        txbxLB2.AppendText(Globals.Point2 + " ");
                    }
                }
                //compare 3 number to make sure it is a sequence number
            }
                if ((result1 == result2 - 1) && (result1 == result3 - 2) || (result1 == result2 - 2) && (result1 == result3 - 1) || (result1 == result2 - 1) && (result1 == result3 + 1) ||
                 (result1 == result2 + 1) && (result1 == result3 - 1) || (result1 == result2 + 1) && (result1 == result3 + 2) || (result1 == result2 + 2) && (result1 == result3 + 1))
                {
                    DialogResult showResult2 = MessageBox.Show("You got a Bonus point", "Notification");
                    if (player == 1)
                    {
                        Globals.Score = Globals.Score + 10;
                        {
                            Globals.Point = 10;
                            txbxLB1.AppendText(Globals.Point + " ");
                        }
                    }
 
                    if (player == 2)
                    {
                        Globals.Score2 = Globals.Score2 + 10;
                        {
                            Globals.Point2 = 10;
                            txbxLB2.AppendText(Globals.Point2 + " ");
                        }
                    }
                }
            

        }//bonus
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
            Random rand = new Random();
            dice1 = rand.Next(1, 4);
            dice2 = rand.Next(1, 4);
            dice3 = rand.Next(1, 4);
            // If the check box unchecked, will show the dice face
            if (cBx1.Checked == false)
            { result1 = dice(dice1, picBx1); }
             if (cBx2.Checked == false) 
            { result2= dice(dice2, picBx2);}
            if (cBx3.Checked == false)
            { result3= dice(dice3, picBx3); }

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
                if (cBx1.Checked == true)
                { result1 = 0; }
                if (cBx2.Checked == true)
                { result2 = 0; }
                if (cBx3.Checked == true)
                { result3 = 0; }


                timer.Stop();
                pgrBar1.Value = 0;
                btnRoll.Enabled = true;
                cBx1.Enabled = true;
                cBx2.Enabled = true;
                cBx3.Enabled = true;
                roll++;
                lblRoll.Text = "Roll: " + roll.ToString();
                
                // when roll = 4, the console with show a signal to help users know that they have go to another rounds.    
                if (roll > 3)
                {
                    if (player == 1)
                    {
                        timer.Enabled = false;
                        pgrBar1.Value = 0;
                        reStart();
                        checkBox();
                        ShowResult();
                        round++;
                    }
                    else if (player == 2)
                    {
                        timer.Enabled = false;
                        pgrBar1.Value = 0;
                        reStart();
                        checkBox();
                        ShowResult();
                        round++;
                    }

                }//if quotes
                 //if 3 checkBox have been checked, its mean the players want to end the round soon.
                else if (cBx1.Checked == true && cBx2.Checked == true && cBx3.Checked == true)
                {
                    timer.Enabled = false;
                    pgrBar1.Value = 0;
                    reStart();
                    checkBox();
                    ShowResult();
                    round++;
                    bonus();
                }//else if quotes
                bonus();
            }//else if progressbar
        }


    }
}
