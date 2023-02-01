using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    public partial class MainGrid : UserControl
    {
        public MainGrid()
        {
            InitializeComponent();
        }

        private void MainGrid_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < this.buttonGrid.RowCount; i++)
            {
                for (int j = 0; j < this.buttonGrid.ColumnCount; j++)
                {
                    var button = new Button();
                    button.Text = string.Format(Convert.ToString(i) + "," + Convert.ToString(j));
                    button.Name = string.Format(Convert.ToString(i) + Convert.ToString(j));
                    button.Dock = DockStyle.Fill;
                    this.buttonGrid.Controls.Add(button, j, i);
                }
            }

            for (int i = 0; i < this.playerShips.RowCount; i++)
            {
                for (int j = 0; j < this.playerShips.ColumnCount; j++)
                {
                    var label = new Label();
                    label.Text = string.Format(Convert.ToString(i) + "," + Convert.ToString(j));
                    label.Name = string.Format(Convert.ToString(i) + Convert.ToString(j));
                    label.Dock = DockStyle.Fill;
                    this.playerShips.Controls.Add(label, j, i);
                }
            }

        }
    }
}
