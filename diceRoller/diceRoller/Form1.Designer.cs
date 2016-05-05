namespace diceRoller
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerOneRollBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rollPlayer1 = new System.Windows.Forms.Button();
            this.playerOneLoss = new System.Windows.Forms.TextBox();
            this.playerOneWins = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.playerTwoRollBox = new System.Windows.Forms.TextBox();
            this.rollPlayer2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.playerTwoLoss = new System.Windows.Forms.TextBox();
            this.playerTwoWins = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.currentWinner = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playerOneRollBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rollPlayer1);
            this.groupBox1.Controls.Add(this.playerOneLoss);
            this.groupBox1.Controls.Add(this.playerOneWins);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1";
            // 
            // playerOneRollBox
            // 
            this.playerOneRollBox.Location = new System.Drawing.Point(9, 36);
            this.playerOneRollBox.Name = "playerOneRollBox";
            this.playerOneRollBox.Size = new System.Drawing.Size(100, 20);
            this.playerOneRollBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Roll";
            // 
            // rollPlayer1
            // 
            this.rollPlayer1.Location = new System.Drawing.Point(7, 67);
            this.rollPlayer1.Name = "rollPlayer1";
            this.rollPlayer1.Size = new System.Drawing.Size(75, 23);
            this.rollPlayer1.TabIndex = 6;
            this.rollPlayer1.Text = "Roll";
            this.rollPlayer1.UseVisualStyleBackColor = true;
            this.rollPlayer1.Click += new System.EventHandler(this.rollPlayer1_Click);
            // 
            // playerOneLoss
            // 
            this.playerOneLoss.Enabled = false;
            this.playerOneLoss.Location = new System.Drawing.Point(208, 51);
            this.playerOneLoss.Name = "playerOneLoss";
            this.playerOneLoss.Size = new System.Drawing.Size(100, 20);
            this.playerOneLoss.TabIndex = 5;
            // 
            // playerOneWins
            // 
            this.playerOneWins.Enabled = false;
            this.playerOneWins.Location = new System.Drawing.Point(208, 17);
            this.playerOneWins.Name = "playerOneWins";
            this.playerOneWins.Size = new System.Drawing.Size(100, 20);
            this.playerOneWins.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Losses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Wins";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.playerTwoRollBox);
            this.groupBox2.Controls.Add(this.rollPlayer2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.playerTwoLoss);
            this.groupBox2.Controls.Add(this.playerTwoWins);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 2";
            // 
            // playerTwoRollBox
            // 
            this.playerTwoRollBox.Location = new System.Drawing.Point(9, 35);
            this.playerTwoRollBox.Name = "playerTwoRollBox";
            this.playerTwoRollBox.Size = new System.Drawing.Size(100, 20);
            this.playerTwoRollBox.TabIndex = 10;
            // 
            // rollPlayer2
            // 
            this.rollPlayer2.Location = new System.Drawing.Point(7, 66);
            this.rollPlayer2.Name = "rollPlayer2";
            this.rollPlayer2.Size = new System.Drawing.Size(75, 23);
            this.rollPlayer2.TabIndex = 10;
            this.rollPlayer2.Text = "Roll";
            this.rollPlayer2.UseVisualStyleBackColor = true;
            this.rollPlayer2.Click += new System.EventHandler(this.rollPlayer2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Current Roll";
            // 
            // playerTwoLoss
            // 
            this.playerTwoLoss.Enabled = false;
            this.playerTwoLoss.Location = new System.Drawing.Point(208, 53);
            this.playerTwoLoss.Name = "playerTwoLoss";
            this.playerTwoLoss.Size = new System.Drawing.Size(100, 20);
            this.playerTwoLoss.TabIndex = 9;
            // 
            // playerTwoWins
            // 
            this.playerTwoWins.Enabled = false;
            this.playerTwoWins.Location = new System.Drawing.Point(208, 19);
            this.playerTwoWins.Name = "playerTwoWins";
            this.playerTwoWins.Size = new System.Drawing.Size(100, 20);
            this.playerTwoWins.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Losses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wins";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.currentWinner);
            this.groupBox3.Location = new System.Drawing.Point(353, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 50);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Winner";
            // 
            // currentWinner
            // 
            this.currentWinner.Location = new System.Drawing.Point(6, 20);
            this.currentWinner.Name = "currentWinner";
            this.currentWinner.Size = new System.Drawing.Size(188, 20);
            this.currentWinner.TabIndex = 0;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(353, 132);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(210, 77);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.Location = new System.Drawing.Point(356, 70);
            this.result.MaximumSize = new System.Drawing.Size(500, 500);
            this.result.MinimumSize = new System.Drawing.Size(190, 50);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(190, 50);
            this.result.TabIndex = 5;
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(488, 215);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 23);
            this.help.TabIndex = 6;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 314);
            this.Controls.Add(this.help);
            this.Controls.Add(this.result);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Dice War!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox playerOneLoss;
        private System.Windows.Forms.TextBox playerOneWins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox playerTwoLoss;
        private System.Windows.Forms.TextBox playerTwoWins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox currentWinner;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button rollPlayer1;
        private System.Windows.Forms.Button rollPlayer2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox playerOneRollBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerTwoRollBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button help;
    }
}

