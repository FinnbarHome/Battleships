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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.lblScores = new System.Windows.Forms.Label();
            this.TxtEnterName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.scoreDataTable = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Font = new System.Drawing.Font("Cascadia Code", 12.5F);
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(50, 500);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(400, 60);
            this.btnReturnToMainMenu.TabIndex = 1;
            this.btnReturnToMainMenu.Text = "Return To Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.btnReturnToMainMenu_Click);
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Font = new System.Drawing.Font("Cascadia Code", 28F);
            this.lblScores.Location = new System.Drawing.Point(82, 13);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(352, 50);
            this.lblScores.TabIndex = 14;
            this.lblScores.Text = "Our Top Scores!";
            // 
            // TxtEnterName
            // 
            this.TxtEnterName.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.TxtEnterName.Location = new System.Drawing.Point(165, 163);
            this.TxtEnterName.Name = "TxtEnterName";
            this.TxtEnterName.Size = new System.Drawing.Size(130, 20);
            this.TxtEnterName.TabIndex = 15;
            this.TxtEnterName.Visible = false;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.lblEnterName.Location = new System.Drawing.Point(56, 165);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(103, 15);
            this.lblEnterName.TabIndex = 16;
            this.lblEnterName.Text = "Enter Your name:";
            this.lblEnterName.Visible = false;
            // 
            // lblYourScore
            // 
            this.lblYourScore.AutoSize = true;
            this.lblYourScore.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.lblYourScore.Location = new System.Drawing.Point(88, 107);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(79, 15);
            this.lblYourScore.TabIndex = 17;
            this.lblYourScore.Text = "Your Score: ";
            this.lblYourScore.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.btnSubmit.Location = new System.Drawing.Point(324, 163);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // scoreDataTable
            // 
            this.scoreDataTable.AllowUserToAddRows = false;
            this.scoreDataTable.AllowUserToDeleteRows = false;
            this.scoreDataTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scoreDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.scoreDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.colScore});
            this.scoreDataTable.Location = new System.Drawing.Point(59, 266);
            this.scoreDataTable.Name = "scoreDataTable";
            this.scoreDataTable.ReadOnly = true;
            this.scoreDataTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.scoreDataTable.ShowEditingIcon = false;
            this.scoreDataTable.Size = new System.Drawing.Size(391, 228);
            this.scoreDataTable.TabIndex = 19;
            // 
            // ColName
            // 
            this.ColName.FillWeight = 195F;
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 195;
            // 
            // colScore
            // 
            this.colScore.FillWeight = 195F;
            this.colScore.HeaderText = "Score";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.Width = 195;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(163, 216);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(236, 23);
            this.btnPlayAgain.TabIndex = 21;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.scoreDataTable);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblYourScore);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.TxtEnterName);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Name = "Score";
            this.Size = new System.Drawing.Size(500, 600);
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.TextBox TxtEnterName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView scoreDataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}
