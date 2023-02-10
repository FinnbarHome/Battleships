namespace Battleships
{
    partial class SelectDifficulty
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
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Font = new System.Drawing.Font("Cascadia Code", 12.5F);
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(106, 461);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(297, 60);
            this.btnReturnToMainMenu.TabIndex = 1;
            this.btnReturnToMainMenu.Text = "Return To Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.btnReturnToMainMenu_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Cascadia Code", 22F);
            this.lblWelcome.Location = new System.Drawing.Point(98, 43);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(323, 40);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Choose Difficulty";
            // 
            // btnHard
            // 
            this.btnHard.Font = new System.Drawing.Font("Cascadia Code", 12.5F);
            this.btnHard.Location = new System.Drawing.Point(106, 330);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(297, 60);
            this.btnHard.TabIndex = 16;
            this.btnHard.Tag = Battleships.Difficulty.HARD;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Font = new System.Drawing.Font("Cascadia Code", 12.5F);
            this.btnMedium.Location = new System.Drawing.Point(106, 230);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(297, 60);
            this.btnMedium.TabIndex = 17;
            this.btnMedium.Tag = Battleships.Difficulty.MEDIUM;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Font = new System.Drawing.Font("Cascadia Code", 12.5F);
            this.btnEasy.Location = new System.Drawing.Point(106, 130);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(297, 60);
            this.btnEasy.TabIndex = 18;
            this.btnEasy.Tag = Battleships.Difficulty.EASY;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btn_Click);
            // 
            // SelectDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Name = "SelectDifficulty";
            this.Size = new System.Drawing.Size(500, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnEasy;
    }
}
