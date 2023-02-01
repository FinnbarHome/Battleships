namespace Battleships
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblExit = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblLoadGame = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.lblStartNewGane = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblExit.Location = new System.Drawing.Point(329, 455);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(83, 20);
            this.lblExit.TabIndex = 23;
            this.lblExit.Text = "Exit game";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblHighScore.Location = new System.Drawing.Point(329, 375);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(130, 20);
            this.lblHighScore.TabIndex = 22;
            this.lblHighScore.Text = "See high scores";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblRules.Location = new System.Drawing.Point(329, 295);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(133, 20);
            this.lblRules.TabIndex = 21;
            this.lblRules.Text = "View game rules";
            // 
            // lblLoadGame
            // 
            this.lblLoadGame.AutoSize = true;
            this.lblLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblLoadGame.Location = new System.Drawing.Point(329, 215);
            this.lblLoadGame.Name = "lblLoadGame";
            this.lblLoadGame.Size = new System.Drawing.Size(133, 20);
            this.lblLoadGame.TabIndex = 20;
            this.lblLoadGame.Text = "Load a game file";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.btnExit.Location = new System.Drawing.Point(32, 435);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(270, 60);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnScore
            // 
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.btnScore.Location = new System.Drawing.Point(32, 355);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(270, 60);
            this.btnScore.TabIndex = 18;
            this.btnScore.Text = "High Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnRules
            // 
            this.btnRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.btnRules.Location = new System.Drawing.Point(32, 275);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(270, 60);
            this.btnRules.TabIndex = 17;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.btnLoadGame.Location = new System.Drawing.Point(32, 195);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(270, 60);
            this.btnLoadGame.TabIndex = 16;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // lblStartNewGane
            // 
            this.lblStartNewGane.AutoSize = true;
            this.lblStartNewGane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblStartNewGane.Location = new System.Drawing.Point(329, 135);
            this.lblStartNewGane.Name = "lblStartNewGane";
            this.lblStartNewGane.Size = new System.Drawing.Size(140, 20);
            this.lblStartNewGane.TabIndex = 15;
            this.lblStartNewGane.Text = "Start a new game";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.btnNewGame.Location = new System.Drawing.Point(32, 115);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(270, 60);
            this.btnNewGame.TabIndex = 14;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblWelcome.Location = new System.Drawing.Point(32, 43);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(429, 44);
            this.lblWelcome.TabIndex = 13;
            this.lblWelcome.Text = "Welcome to Battleships!";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblLoadGame);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.lblStartNewGane);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblWelcome);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(500, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblLoadGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Label lblStartNewGane;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblWelcome;
    }
}
