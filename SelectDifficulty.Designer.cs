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
            this.lblReturnToMainMenu = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReturnToMainMenu
            // 
            this.lblReturnToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblReturnToMainMenu.Location = new System.Drawing.Point(106, 461);
            this.lblReturnToMainMenu.Name = "lblReturnToMainMenu";
            this.lblReturnToMainMenu.Size = new System.Drawing.Size(297, 60);
            this.lblReturnToMainMenu.TabIndex = 1;
            this.lblReturnToMainMenu.Text = "Return To Main Menu";
            this.lblReturnToMainMenu.UseVisualStyleBackColor = true;
            this.lblReturnToMainMenu.Click += new System.EventHandler(this.lblReturnToMainMenu_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblWelcome.Location = new System.Drawing.Point(98, 43);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(305, 44);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Choose Difficulty";
            // 
            // btnHard
            // 
            this.btnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.btnHard.Location = new System.Drawing.Point(106, 330);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(297, 60);
            this.btnHard.TabIndex = 16;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            // 
            // btnMedium
            // 
            this.btnMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.btnMedium.Location = new System.Drawing.Point(106, 230);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(297, 60);
            this.btnMedium.TabIndex = 17;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            // 
            // btnEasy
            // 
            this.btnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.btnEasy.Location = new System.Drawing.Point(106, 130);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(297, 60);
            this.btnEasy.TabIndex = 18;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // SelectDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblReturnToMainMenu);
            this.Name = "SelectDifficulty";
            this.Size = new System.Drawing.Size(500, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblReturnToMainMenu;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnEasy;
    }
}
