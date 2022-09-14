namespace DiceGameLast
{
    partial class EnterName
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
            this.lblEName1 = new System.Windows.Forms.Label();
            this.lblEName2 = new System.Windows.Forms.Label();
            this.txbxPName1 = new System.Windows.Forms.TextBox();
            this.txbxPName2 = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEName1
            // 
            this.lblEName1.AutoSize = true;
            this.lblEName1.Location = new System.Drawing.Point(11, 40);
            this.lblEName1.Name = "lblEName1";
            this.lblEName1.Size = new System.Drawing.Size(95, 17);
            this.lblEName1.TabIndex = 0;
            this.lblEName1.Text = "Enter Name 1";
            // 
            // lblEName2
            // 
            this.lblEName2.AutoSize = true;
            this.lblEName2.Location = new System.Drawing.Point(11, 106);
            this.lblEName2.Name = "lblEName2";
            this.lblEName2.Size = new System.Drawing.Size(95, 17);
            this.lblEName2.TabIndex = 1;
            this.lblEName2.Text = "Enter Name 2";
            // 
            // txbxPName1
            // 
            this.txbxPName1.Location = new System.Drawing.Point(147, 38);
            this.txbxPName1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbxPName1.Multiline = true;
            this.txbxPName1.Name = "txbxPName1";
            this.txbxPName1.Size = new System.Drawing.Size(247, 33);
            this.txbxPName1.TabIndex = 2;
            // 
            // txbxPName2
            // 
            this.txbxPName2.Location = new System.Drawing.Point(147, 103);
            this.txbxPName2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbxPName2.Multiline = true;
            this.txbxPName2.Name = "txbxPName2";
            this.txbxPName2.Size = new System.Drawing.Size(247, 33);
            this.txbxPName2.TabIndex = 3;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(199, 178);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(121, 36);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // EnterName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 290);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txbxPName2);
            this.Controls.Add(this.txbxPName1);
            this.Controls.Add(this.lblEName2);
            this.Controls.Add(this.lblEName1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EnterName";
            this.Text = "EnterName";
            this.Load += new System.EventHandler(this.EnterName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEName1;
        private System.Windows.Forms.Label lblEName2;
        private System.Windows.Forms.TextBox txbxPName1;
        private System.Windows.Forms.TextBox txbxPName2;
        private System.Windows.Forms.Button btnPlay;
    }
}