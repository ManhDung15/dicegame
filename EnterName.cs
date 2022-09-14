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
    public partial class EnterName : Form
    {
        public EnterName()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            gameDice2.setName(txbxPName1.Text, txbxPName2.Text);
            if(txbxPName1.Text == "" || txbxPName2.Text == "")
            {
                MessageBox.Show("Please enter name", "Notification");
            }
            else
            {
                this.Close();
            }
            
        }

        private void EnterName_Load(object sender, EventArgs e)
        {
            //btnPlay.Enabled = false;
        }
    }
}
