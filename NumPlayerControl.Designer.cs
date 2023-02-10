namespace Battleships
{
    partial class NumPlayerControl
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
            this.lbl2Player = new System.Windows.Forms.Label();
            this.btnTwoPlayers = new System.Windows.Forms.Button();
            this.lblOnePlayer = new System.Windows.Forms.Label();
            this.btn1Player = new System.Windows.Forms.Button();
            this.lblHowManyPlayers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl2Player
            // 
            this.lbl2Player.AutoSize = true;
            this.lbl2Player.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lbl2Player.Location = new System.Drawing.Point(293, 218);
            this.lbl2Player.Name = "lbl2Player";
            this.lbl2Player.Size = new System.Drawing.Size(176, 18);
            this.lbl2Player.TabIndex = 25;
            this.lbl2Player.Text = "Start a 2 player game";
            // 
            // btnTwoPlayers
            // 
            this.btnTwoPlayers.Font = new System.Drawing.Font("Cascadia Code", 12.5F);
            this.btnTwoPlayers.Location = new System.Drawing.Point(17, 195);
            this.btnTwoPlayers.Name = "btnTwoPlayers";
            this.btnTwoPlayers.Size = new System.Drawing.Size(270, 60);
            this.btnTwoPlayers.TabIndex = 24;
            this.btnTwoPlayers.Text = "Two Players";
            this.btnTwoPlayers.UseVisualStyleBackColor = true;
            this.btnTwoPlayers.Click += new System.EventHandler(this.btnTwoPlayers_Click);
            // 
            // lblOnePlayer
            // 
            this.lblOnePlayer.AutoSize = true;
            this.lblOnePlayer.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lblOnePlayer.Location = new System.Drawing.Point(293, 138);
            this.lblOnePlayer.Name = "lblOnePlayer";
            this.lblOnePlayer.Size = new System.Drawing.Size(192, 18);
            this.lblOnePlayer.TabIndex = 23;
            this.lblOnePlayer.Text = "Start a game against AI";
            // 
            // btn1Player
            // 
            this.btn1Player.Font = new System.Drawing.Font("Cascadia Code", 12.5F);
            this.btn1Player.Location = new System.Drawing.Point(17, 115);
            this.btn1Player.Name = "btn1Player";
            this.btn1Player.Size = new System.Drawing.Size(270, 60);
            this.btn1Player.TabIndex = 22;
            this.btn1Player.Text = "One Player";
            this.btn1Player.UseVisualStyleBackColor = true;
            this.btn1Player.Click += new System.EventHandler(this.btn1Player_Click);
            // 
            // lblHowManyPlayers
            // 
            this.lblHowManyPlayers.AutoSize = true;
            this.lblHowManyPlayers.Font = new System.Drawing.Font("Cascadia Code", 28F);
            this.lblHowManyPlayers.Location = new System.Drawing.Point(41, 32);
            this.lblHowManyPlayers.Name = "lblHowManyPlayers";
            this.lblHowManyPlayers.Size = new System.Drawing.Size(396, 50);
            this.lblHowManyPlayers.TabIndex = 21;
            this.lblHowManyPlayers.Text = "How Many Players?";
            // 
            // NumPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl2Player);
            this.Controls.Add(this.btnTwoPlayers);
            this.Controls.Add(this.lblOnePlayer);
            this.Controls.Add(this.btn1Player);
            this.Controls.Add(this.lblHowManyPlayers);
            this.Name = "NumPlayerControl";
            this.Size = new System.Drawing.Size(500, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2Player;
        private System.Windows.Forms.Button btnTwoPlayers;
        private System.Windows.Forms.Label lblOnePlayer;
        private System.Windows.Forms.Button btn1Player;
        private System.Windows.Forms.Label lblHowManyPlayers;
    }
}
