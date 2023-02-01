using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int colNum = 10;
            int rowNum = 10;

            //For enemy ships grid
            this.buttonGrid.ColumnCount = colNum;
            this.buttonGrid.RowCount = rowNum;
            this.buttonGrid.ColumnStyles.Clear();
            this.buttonGrid.RowStyles.Clear();

            for (int i = 0; i < colNum; i++)
            {
                this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / colNum));
            }
            for (int i = 0; i < rowNum; i++)
            {
                this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / rowNum));
            }

            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    var button = new Button();
                    button.Text = string.Format(Convert.ToString(i) + "," + Convert.ToString(j));
                    button.Name = string.Format(Convert.ToString(i) + Convert.ToString(j));
                    button.Dock = DockStyle.Fill;
                    this.buttonGrid.Controls.Add(button, j, i);
                }
            }


            //For player ships grid
            this.playerShips.ColumnCount = colNum;
            this.playerShips.RowCount = rowNum;
            this.playerShips.ColumnStyles.Clear();
            this.playerShips.RowStyles.Clear();

            for (int i = 0; i < colNum; i++)
            {
                this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / colNum));
            }
            for (int i = 0; i < rowNum; i++)
            {
                this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / rowNum));
            }

            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    var label = new Label();
                    label.Text = string.Format(Convert.ToString(i) + "," + Convert.ToString(j));
                    label.Name = string.Format(Convert.ToString(i) + Convert.ToString(j));
                    label.Dock = DockStyle.Fill;
                    this.playerShips.Controls.Add(label, j, i);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
