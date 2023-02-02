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
    public partial class ChoosePlacesGrid : UserControl
    {
        GameState gameState = null;
        public ChoosePlacesGrid(GameState gameState)
        {
            this.gameState = gameState;
            InitializeComponent();
        }

        private void ChoosePlacesGrid_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Ships.shipList.Length; i += 1)
            {
                Ship ship = Ships.shipList[i];
                Button shipBtn = new Button();
                shipBtn.BackgroundImage = ship.getThumbnailImage();
                shipBtn.Text = ship.getNumShips() + "x";
                shipBtn.FlatStyle = FlatStyle.Flat;
                shipBtn.FlatAppearance.BorderSize = 2;
                shipBtn.Dock = DockStyle.Fill;
                this.SelectableShips.Controls.Add(shipBtn, i, 0);
            }

            for(int x = 0; x < this.PlacementGrid.RowCount; x += 1)
            {
                for (int y = 0; y < this.PlacementGrid.ColumnCount; y += 1)
                {
                    Button gridBtn = new Button();
                    gridBtn.Margin = new System.Windows.Forms.Padding(0);
                    gridBtn.FlatStyle = FlatStyle.Flat;
                    gridBtn.FlatAppearance.BorderSize = 0;
                    gridBtn.Dock = DockStyle.Fill;
                    
                }
            }
        }
    }
}
