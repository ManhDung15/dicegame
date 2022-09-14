namespace DiceGameLast
{
    partial class MainMenu
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
            this.picBxBackGround = new System.Windows.Forms.PictureBox();
            this.btn1Player = new System.Windows.Forms.Button();
            this.btn2Players = new System.Windows.Forms.Button();
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // picBxBackGround
            // 
            this.picBxBackGround.Image = global::DiceGameLast.Properties.Resources.cube_2031512_1280;
            this.picBxBackGround.Location = new System.Drawing.Point(0, -77);
            this.picBxBackGround.Name = "picBxBackGround";
            this.picBxBackGround.Size = new System.Drawing.Size(942, 698);
            this.picBxBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxBackGround.TabIndex = 0;
            this.picBxBackGround.TabStop = false;
            // 
            // btn1Player
            // 
            this.btn1Player.Location = new System.Drawing.Point(366, 315);
            this.btn1Player.Name = "btn1Player";
            this.btn1Player.Size = new System.Drawing.Size(200, 36);
            this.btn1Player.TabIndex = 1;
            this.btn1Player.Text = "1 Player";
            this.btn1Player.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn1Player.UseVisualStyleBackColor = true;
            this.btn1Player.Click += new System.EventHandler(this.btn1Player_Click);
            // 
            // btn2Players
            // 
            this.btn2Players.Location = new System.Drawing.Point(366, 370);
            this.btn2Players.Name = "btn2Players";
            this.btn2Players.Size = new System.Drawing.Size(200, 36);
            this.btn2Players.TabIndex = 2;
            this.btn2Players.Text = "2 Player";
            this.btn2Players.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn2Players.UseVisualStyleBackColor = true;
            this.btn2Players.Click += new System.EventHandler(this.btn2Players_Click);
            // 
            // btnCPU
            // 
            this.btnCPU.Location = new System.Drawing.Point(366, 424);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(200, 36);
            this.btnCPU.TabIndex = 3;
            this.btnCPU.Text = "CPU Mode";
            this.btnCPU.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCPU.UseVisualStyleBackColor = true;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // btnTutorial
            // 
            this.btnTutorial.Location = new System.Drawing.Point(366, 479);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(200, 36);
            this.btnTutorial.TabIndex = 4;
            this.btnTutorial.Text = "Tutorial";
            this.btnTutorial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTutorial.UseVisualStyleBackColor = true;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(366, 537);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 36);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit Game";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 610);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.btnCPU);
            this.Controls.Add(this.btn2Players);
            this.Controls.Add(this.btn1Player);
            this.Controls.Add(this.picBxBackGround);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxBackGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBxBackGround;
        private System.Windows.Forms.Button btn1Player;
        private System.Windows.Forms.Button btn2Players;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.Button btnExit;
    }
}