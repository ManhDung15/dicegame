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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
           /* DialogResult play = MessageBox.Show
           ("Please read Tutorial before play or click Exit to receive our goodbye", "Warning", MessageBoxButtons.OK);
            if (play == DialogResult.OK)
            {
                btnTutorial.Enabled = true;
                btnExit.Enabled = true;
            }*/
        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            gameDice frmGame = new gameDice();
            frmGame.Show();
            MainMenu menuGame = new MainMenu();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exitButton = MessageBox.Show
           ("Do you want to exit? ", "Warning", MessageBoxButtons.OKCancel);
            if (exitButton == DialogResult.OK)
                    Application.Exit();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            DialogResult tutorialButton = MessageBox.Show
            ("Here is something you MUST read before playgame.\n" +
            "1. You must\n" +
            "2. If you want to end the round soon, check all 3 boxes\n" +
            "3. When you have sequences number\n" +
            "Please press 1 player to play game alone\n" +
            "Please press 2 player to play with your friend\n" +
            "Please press CPU MODE to play with our exelent AI player", "Warning", MessageBoxButtons.OK);
            if (tutorialButton == DialogResult.OK)
            {

            }
        }

        private void btn2Players_Click(object sender, EventArgs e)
        {
            gameDice2 frmGame2 = new gameDice2();
            frmGame2.Show();
            MainMenu menuGame = new MainMenu();
            this.Hide();
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            gameDice3 frmGame3 = new gameDice3();
            frmGame3.Show();
            MainMenu menuGame = new MainMenu();
            this.Hide();
        }
    }
}
