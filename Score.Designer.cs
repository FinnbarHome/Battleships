namespace Battleships
{
    partial class Score
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
            this.SuspendLayout();
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(50, 500);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(400, 60);
            this.btnReturnToMainMenu.TabIndex = 1;
            this.btnReturnToMainMenu.Text = "Return To Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.btnReturnToMainMenu_Click);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Name = "Score";
            this.Size = new System.Drawing.Size(500, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturnToMainMenu;
    }
}
