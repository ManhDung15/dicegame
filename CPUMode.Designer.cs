namespace DiceGameLast
{
    partial class gameDice3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameDice3));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pgrBar1 = new System.Windows.Forms.ProgressBar();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.cBx3 = new System.Windows.Forms.CheckBox();
            this.cBx2 = new System.Windows.Forms.CheckBox();
            this.cBx1 = new System.Windows.Forms.CheckBox();
            this.txbxLB1 = new System.Windows.Forms.TextBox();
            this.txbxTS1 = new System.Windows.Forms.TextBox();
            this.txbxLR2 = new System.Windows.Forms.TextBox();
            this.txbxLB2 = new System.Windows.Forms.TextBox();
            this.txbxTS2 = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txbxLR1 = new System.Windows.Forms.TextBox();
            this.picBx2 = new System.Windows.Forms.PictureBox();
            this.picBx3 = new System.Windows.Forms.PictureBox();
            this.picBx1 = new System.Windows.Forms.PictureBox();
            this.lblBonusShow2 = new System.Windows.Forms.Label();
            this.lblTotalScore3 = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblRoundShow = new System.Windows.Forms.Label();
            this.lblBonusShow = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblRoundShow2 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "image1.png");
            this.imageList.Images.SetKeyName(1, "image2.png");
            this.imageList.Images.SetKeyName(2, "image3.png");
            this.imageList.Images.SetKeyName(3, "image4.png");
            this.imageList.Images.SetKeyName(4, "image5.png");
            this.imageList.Images.SetKeyName(5, "image6.png");
            this.imageList.Images.SetKeyName(6, "dice.png");
            // 
            // pgrBar1
            // 
            this.pgrBar1.Location = new System.Drawing.Point(653, 455);
            this.pgrBar1.Name = "pgrBar1";
            this.pgrBar1.Size = new System.Drawing.Size(100, 23);
            this.pgrBar1.TabIndex = 50;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(598, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(197, 23);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back to main menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(598, 272);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(197, 92);
            this.btnRoll.TabIndex = 48;
            this.btnRoll.Text = "Click to Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // cBx3
            // 
            this.cBx3.AutoSize = true;
            this.cBx3.Location = new System.Drawing.Point(881, 212);
            this.cBx3.Name = "cBx3";
            this.cBx3.Size = new System.Drawing.Size(18, 17);
            this.cBx3.TabIndex = 47;
            this.cBx3.UseVisualStyleBackColor = true;
            // 
            // cBx2
            // 
            this.cBx2.AutoSize = true;
            this.cBx2.Location = new System.Drawing.Point(686, 212);
            this.cBx2.Name = "cBx2";
            this.cBx2.Size = new System.Drawing.Size(18, 17);
            this.cBx2.TabIndex = 46;
            this.cBx2.UseVisualStyleBackColor = true;
            // 
            // cBx1
            // 
            this.cBx1.AutoSize = true;
            this.cBx1.Location = new System.Drawing.Point(501, 212);
            this.cBx1.Name = "cBx1";
            this.cBx1.Size = new System.Drawing.Size(18, 17);
            this.cBx1.TabIndex = 45;
            this.cBx1.UseVisualStyleBackColor = true;
            // 
            // txbxLB1
            // 
            this.txbxLB1.Location = new System.Drawing.Point(144, 144);
            this.txbxLB1.Multiline = true;
            this.txbxLB1.Name = "txbxLB1";
            this.txbxLB1.Size = new System.Drawing.Size(102, 125);
            this.txbxLB1.TabIndex = 44;
            // 
            // txbxTS1
            // 
            this.txbxTS1.Location = new System.Drawing.Point(281, 144);
            this.txbxTS1.Multiline = true;
            this.txbxTS1.Name = "txbxTS1";
            this.txbxTS1.Size = new System.Drawing.Size(102, 125);
            this.txbxTS1.TabIndex = 43;
            // 
            // txbxLR2
            // 
            this.txbxLR2.Location = new System.Drawing.Point(1032, 144);
            this.txbxLR2.Multiline = true;
            this.txbxLR2.Name = "txbxLR2";
            this.txbxLR2.Size = new System.Drawing.Size(102, 125);
            this.txbxLR2.TabIndex = 42;
            // 
            // txbxLB2
            // 
            this.txbxLB2.Location = new System.Drawing.Point(1176, 144);
            this.txbxLB2.Multiline = true;
            this.txbxLB2.Name = "txbxLB2";
            this.txbxLB2.Size = new System.Drawing.Size(102, 125);
            this.txbxLB2.TabIndex = 41;
            // 
            // txbxTS2
            // 
            this.txbxTS2.Location = new System.Drawing.Point(1321, 144);
            this.txbxTS2.Multiline = true;
            this.txbxTS2.Name = "txbxTS2";
            this.txbxTS2.Size = new System.Drawing.Size(102, 125);
            this.txbxTS2.TabIndex = 40;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txbxLR1
            // 
            this.txbxLR1.Location = new System.Drawing.Point(15, 144);
            this.txbxLR1.Multiline = true;
            this.txbxLR1.Name = "txbxLR1";
            this.txbxLR1.Size = new System.Drawing.Size(102, 125);
            this.txbxLR1.TabIndex = 39;
            // 
            // picBx2
            // 
            this.picBx2.Location = new System.Drawing.Point(629, 60);
            this.picBx2.Name = "picBx2";
            this.picBx2.Size = new System.Drawing.Size(133, 146);
            this.picBx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBx2.TabIndex = 38;
            this.picBx2.TabStop = false;
            // 
            // picBx3
            // 
            this.picBx3.Location = new System.Drawing.Point(819, 60);
            this.picBx3.Name = "picBx3";
            this.picBx3.Size = new System.Drawing.Size(133, 146);
            this.picBx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBx3.TabIndex = 37;
            this.picBx3.TabStop = false;
            // 
            // picBx1
            // 
            this.picBx1.Location = new System.Drawing.Point(442, 60);
            this.picBx1.Name = "picBx1";
            this.picBx1.Size = new System.Drawing.Size(133, 146);
            this.picBx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBx1.TabIndex = 36;
            this.picBx1.TabStop = false;
            // 
            // lblBonusShow2
            // 
            this.lblBonusShow2.AutoSize = true;
            this.lblBonusShow2.Location = new System.Drawing.Point(1188, 113);
            this.lblBonusShow2.Name = "lblBonusShow2";
            this.lblBonusShow2.Size = new System.Drawing.Size(84, 17);
            this.lblBonusShow2.TabIndex = 35;
            this.lblBonusShow2.Text = "Bonus Point";
            // 
            // lblTotalScore3
            // 
            this.lblTotalScore3.AutoSize = true;
            this.lblTotalScore3.Location = new System.Drawing.Point(1318, 113);
            this.lblTotalScore3.Name = "lblTotalScore3";
            this.lblTotalScore3.Size = new System.Drawing.Size(81, 17);
            this.lblTotalScore3.TabIndex = 34;
            this.lblTotalScore3.Text = "Total Score";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Location = new System.Drawing.Point(635, 9);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(46, 17);
            this.lblRoll.TabIndex = 33;
            this.lblRoll.Text = "label8";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(1188, 35);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(46, 17);
            this.lblName2.TabIndex = 32;
            this.lblName2.Text = "label7";
            // 
            // lblRoundShow
            // 
            this.lblRoundShow.AutoSize = true;
            this.lblRoundShow.Location = new System.Drawing.Point(43, 113);
            this.lblRoundShow.Name = "lblRoundShow";
            this.lblRoundShow.Size = new System.Drawing.Size(50, 17);
            this.lblRoundShow.TabIndex = 31;
            this.lblRoundShow.Text = "Round";
            // 
            // lblBonusShow
            // 
            this.lblBonusShow.AutoSize = true;
            this.lblBonusShow.Location = new System.Drawing.Point(155, 113);
            this.lblBonusShow.Name = "lblBonusShow";
            this.lblBonusShow.Size = new System.Drawing.Size(84, 17);
            this.lblBonusShow.TabIndex = 30;
            this.lblBonusShow.Text = "Bonus Point";
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Location = new System.Drawing.Point(293, 113);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(81, 17);
            this.lblTotalScore.TabIndex = 29;
            this.lblTotalScore.Text = "Total Score";
            // 
            // lblRoundShow2
            // 
            this.lblRoundShow2.AutoSize = true;
            this.lblRoundShow2.Location = new System.Drawing.Point(1056, 113);
            this.lblRoundShow2.Name = "lblRoundShow2";
            this.lblRoundShow2.Size = new System.Drawing.Size(50, 17);
            this.lblRoundShow2.TabIndex = 28;
            this.lblRoundShow2.Text = "Round";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(428, 9);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(46, 17);
            this.lblRound.TabIndex = 27;
            this.lblRound.Text = "label2";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(103, 35);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(46, 17);
            this.lblName1.TabIndex = 26;
            this.lblName1.Text = "label1";
            // 
            // gameDice3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 589);
            this.Controls.Add(this.pgrBar1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.cBx3);
            this.Controls.Add(this.cBx2);
            this.Controls.Add(this.cBx1);
            this.Controls.Add(this.txbxLB1);
            this.Controls.Add(this.txbxTS1);
            this.Controls.Add(this.txbxLR2);
            this.Controls.Add(this.txbxLB2);
            this.Controls.Add(this.txbxTS2);
            this.Controls.Add(this.txbxLR1);
            this.Controls.Add(this.picBx2);
            this.Controls.Add(this.picBx3);
            this.Controls.Add(this.picBx1);
            this.Controls.Add(this.lblBonusShow2);
            this.Controls.Add(this.lblTotalScore3);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblRoundShow);
            this.Controls.Add(this.lblBonusShow);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.lblRoundShow2);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblName1);
            this.Name = "gameDice3";
            this.Text = "Roll a Dice";
            this.Load += new System.EventHandler(this.gameDice3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ProgressBar pgrBar1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.CheckBox cBx3;
        private System.Windows.Forms.CheckBox cBx2;
        private System.Windows.Forms.CheckBox cBx1;
        private System.Windows.Forms.TextBox txbxLB1;
        private System.Windows.Forms.TextBox txbxTS1;
        private System.Windows.Forms.TextBox txbxLR2;
        private System.Windows.Forms.TextBox txbxLB2;
        private System.Windows.Forms.TextBox txbxTS2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txbxLR1;
        private System.Windows.Forms.PictureBox picBx2;
        private System.Windows.Forms.PictureBox picBx3;
        private System.Windows.Forms.PictureBox picBx1;
        private System.Windows.Forms.Label lblBonusShow2;
        private System.Windows.Forms.Label lblTotalScore3;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblRoundShow;
        private System.Windows.Forms.Label lblBonusShow;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblRoundShow2;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblName1;
    }
}