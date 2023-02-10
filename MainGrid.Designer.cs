using System.Windows.Forms;

namespace Battleships
{
    partial class MainGrid
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
            this.components = new System.ComponentModel.Container();
            this.enemyGrid = new System.Windows.Forms.TableLayoutPanel();
            this.playerShips = new System.Windows.Forms.TableLayoutPanel();
            this.lblYourShips = new System.Windows.Forms.Label();
            this.lblEnemyShips = new System.Windows.Forms.Label();
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.timerScore = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // enemyGrid
            // 
            this.enemyGrid.ColumnCount = 10;
            this.enemyGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.Location = new System.Drawing.Point(150, 250);
            this.enemyGrid.Margin = new System.Windows.Forms.Padding(0);
            this.enemyGrid.Name = "enemyGrid";
            this.enemyGrid.RowCount = 10;
            this.enemyGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.enemyGrid.Size = new System.Drawing.Size(300, 300);
            this.enemyGrid.TabIndex = 0;
            // 
            // playerShips
            // 
            this.playerShips.ColumnCount = 10;
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.Location = new System.Drawing.Point(15, 15);
            this.playerShips.Name = "playerShips";
            this.playerShips.RowCount = 10;
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playerShips.Size = new System.Drawing.Size(220, 220);
            this.playerShips.TabIndex = 1;
            // 
            // lblYourShips
            // 
            this.lblYourShips.AutoSize = true;
            this.lblYourShips.Location = new System.Drawing.Point(251, 25);
            this.lblYourShips.Name = "lblYourShips";
            this.lblYourShips.Size = new System.Drawing.Size(73, 13);
            this.lblYourShips.TabIndex = 5;
            this.lblYourShips.Text = "YOUR SHIPS";
            // 
            // lblEnemyShips
            // 
            this.lblEnemyShips.AutoSize = true;
            this.lblEnemyShips.Location = new System.Drawing.Point(64, 250);
            this.lblEnemyShips.Name = "lblEnemyShips";
            this.lblEnemyShips.Size = new System.Drawing.Size(80, 13);
            this.lblEnemyShips.TabIndex = 6;
            this.lblEnemyShips.Text = "ENEMY SHIPS";
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.Location = new System.Drawing.Point(375, 25);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGame.TabIndex = 7;
            this.btnSaveGame.Text = "Save Game";
            this.btnSaveGame.UseVisualStyleBackColor = true;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(254, 58);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 8;
            // 
            // timerScore
            // 
            this.timerScore.Interval = 1000;
            // 
            // MainGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.lblEnemyShips);
            this.Controls.Add(this.lblYourShips);
            this.Controls.Add(this.playerShips);
            this.Controls.Add(this.enemyGrid);
            this.Name = "MainGrid";
            this.Size = new System.Drawing.Size(500, 600);
            this.Load += new System.EventHandler(this.MainGrid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TableLayoutPanel enemyGrid;
        private System.Windows.Forms.TableLayoutPanel playerShips;
        private System.Windows.Forms.Label lblYourShips;

        #endregion

        private System.Windows.Forms.Label lblEnemyShips;
        private Button btnSaveGame;
        private Label lblScore;
        private Timer timerScore;
    }
}
