namespace Battleships
{
    partial class form
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
            this.buttonGrid = new System.Windows.Forms.TableLayoutPanel();
            this.playerShips = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGrid
            // 
            this.buttonGrid.ColumnCount = 10;
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonGrid.Location = new System.Drawing.Point(794, 405);
            this.buttonGrid.Name = "buttonGrid";
            this.buttonGrid.RowCount = 10;
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonGrid.Size = new System.Drawing.Size(450, 450);
            this.buttonGrid.TabIndex = 0;
            // 
            // playerShips
            // 
            this.playerShips.ColumnCount = 10;
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.playerShips.Location = new System.Drawing.Point(418, 35);
            this.playerShips.Name = "playerShips";
            this.playerShips.RowCount = 10;
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerShips.Size = new System.Drawing.Size(376, 364);
            this.playerShips.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 712);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 842);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ENEMY SHIPS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(829, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "YOUR SHIPS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGrid);
            this.Controls.Add(this.playerShips);
            this.Name = "form";
            this.Text = "Battleships";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buttonGrid;
        private System.Windows.Forms.TableLayoutPanel playerShips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

