namespace Battleships
{
    partial class ChoosePlacesGrid
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
            this.PlacementGrid = new System.Windows.Forms.TableLayoutPanel();
            this.SelectableShips = new System.Windows.Forms.TableLayoutPanel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.rotateLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlacementGrid
            // 
            this.PlacementGrid.ColumnCount = 10;
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.Location = new System.Drawing.Point(100, 150);
            this.PlacementGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PlacementGrid.Name = "PlacementGrid";
            this.PlacementGrid.RowCount = 10;
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PlacementGrid.Size = new System.Drawing.Size(300, 300);
            this.PlacementGrid.TabIndex = 1;
            this.PlacementGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.PlacementGrid_Paint);
            this.PlacementGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_MouseMove);
            this.PlacementGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_RightClick);
            // 
            // SelectableShips
            // 
            this.SelectableShips.ColumnCount = 5;
            this.SelectableShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.Location = new System.Drawing.Point(100, 500);
            this.SelectableShips.Margin = new System.Windows.Forms.Padding(0);
            this.SelectableShips.Name = "SelectableShips";
            this.SelectableShips.RowCount = 1;
            this.SelectableShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.SelectableShips.Size = new System.Drawing.Size(300, 50);
            this.SelectableShips.TabIndex = 2;
            this.SelectableShips.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectableShips_Paint);
            this.SelectableShips.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_MouseMove);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Cascadia Code", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(100, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(300, 50);
            this.lblWelcome.TabIndex = 16;
            this.lblWelcome.Text = "Place Ships";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_MouseMove);
            this.lblWelcome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_RightClick);
            // 
            // btnRotate
            // 
            this.btnRotate.Enabled = false;
            this.btnRotate.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.btnRotate.Location = new System.Drawing.Point(315, 112);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(75, 23);
            this.btnRotate.TabIndex = 17;
            this.btnRotate.Text = "Rotate Ship";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.EnabledChanged += new System.EventHandler(this.btnRotate_Enabled);
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            this.btnRotate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_MouseMove);
            this.btnRotate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_RightClick);
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.btnContinue.Location = new System.Drawing.Point(109, 112);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 18;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // rotateLbl
            // 
            this.rotateLbl.AutoSize = true;
            this.rotateLbl.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.rotateLbl.Location = new System.Drawing.Point(106, 93);
            this.rotateLbl.Name = "rotateLbl";
            this.rotateLbl.Size = new System.Drawing.Size(0, 15);
            this.rotateLbl.TabIndex = 19;
            this.rotateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rotateLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_MouseMove);
            this.rotateLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_RightClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_MouseMove);
            this.optionsToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_RightClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            this.helpToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_MouseMove);
            this.helpToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_RightClick);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            this.quitToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_MouseMove);
            this.quitToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_RightClick);
            // 
            // ChoosePlacesGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rotateLbl);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.SelectableShips);
            this.Controls.Add(this.PlacementGrid);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ChoosePlacesGrid";
            this.Size = new System.Drawing.Size(500, 600);
            this.Load += new System.EventHandler(this.ChoosePlacesGrid_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_RightClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PlacementGrid;
        private System.Windows.Forms.TableLayoutPanel SelectableShips;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label rotateLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}
