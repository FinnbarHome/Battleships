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
            this.SuspendLayout();
            // 
            // PlacementGrid
            // 
            this.PlacementGrid.ColumnCount = 7;
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.Location = new System.Drawing.Point(100, 150);
            this.PlacementGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PlacementGrid.Name = "PlacementGrid";
            this.PlacementGrid.RowCount = 7;
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PlacementGrid.Size = new System.Drawing.Size(300, 300);
            this.PlacementGrid.TabIndex = 1;
            this.PlacementGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_MouseMove);
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
            this.SelectableShips.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_MouseMove);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblWelcome.Location = new System.Drawing.Point(100, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(300, 50);
            this.lblWelcome.TabIndex = 16;
            this.lblWelcome.Text = "Place Ships";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_MouseMove);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(325, 112);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(75, 23);
            this.btnRotate.TabIndex = 17;
            this.btnRotate.Text = "Rotate Ship";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // ChoosePlacesGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.SelectableShips);
            this.Controls.Add(this.PlacementGrid);
            this.Name = "ChoosePlacesGrid";
            this.Size = new System.Drawing.Size(500, 600);
            this.Load += new System.EventHandler(this.ChoosePlacesGrid_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePlacesGrid_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PlacementGrid;
        private System.Windows.Forms.TableLayoutPanel SelectableShips;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRotate;
    }
}
