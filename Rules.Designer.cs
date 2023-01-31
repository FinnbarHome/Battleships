using System.Drawing;

namespace Battleships
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.lblReturnToMainMenu = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReturnToMainMenu
            // 
            this.lblReturnToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblReturnToMainMenu.Location = new System.Drawing.Point(115, 440);
            this.lblReturnToMainMenu.Name = "lblReturnToMainMenu";
            this.lblReturnToMainMenu.Size = new System.Drawing.Size(270, 60);
            this.lblReturnToMainMenu.TabIndex = 0;
            this.lblReturnToMainMenu.Text = "Return To Main Menu";
            this.lblReturnToMainMenu.UseVisualStyleBackColor = true;
            this.lblReturnToMainMenu.Click += new System.EventHandler(this.lblReturnToMainMenu_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblWelcome.Location = new System.Drawing.Point(32, 43);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(416, 44);
            this.lblWelcome.TabIndex = 14;
            this.lblWelcome.Text = "The rules of Battleships";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRules.Location = new System.Drawing.Point(37, 129);
            this.lblRules.MaximumSize = new System.Drawing.Size(416, 0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(416, 136);
            this.lblRules.TabIndex = 15;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblReturnToMainMenu);
            this.Name = "Rules";
            this.Size = new System.Drawing.Size(500, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblReturnToMainMenu;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRules;
    }
}
