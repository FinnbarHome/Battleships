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
        private GameState gameState = null;
        private Button[][] enemyGridLayout = new Button[7][];
        private Button[][] playerGridLayout = new Button[7][];


        public MainGrid()
        {
            for(int i = 0; i < 7; i += 1)
            {
                enemyGridLayout[i] = new Button[7];
                playerGridLayout[i] = new Button[7];
            }
            InitializeComponent();
            /* In Truth, this will be passed in from somewhere else, but for testing.. */
            gameState = new GameState(Difficulty.EASY);
        }


        private void updateGrid()
        {
            for (int x = 0; x < this.enemyGrid.RowCount; x++)
            {
                for (int y = 0; y < this.enemyGrid.ColumnCount; y++)
                {
                    /* Enemy grid, doesn't show ship unless ship hit */
                    var enemyGridBtn = new Button();
                    enemyGridBtn.BackgroundImage = Ships.NONE.getImage();
                    if (gameState.getAISquare(x, y).isHit())
                    {
                        enemyGridBtn.Text = "X";
                        enemyGridBtn.ForeColor = Color.Red;
                        enemyGridBtn.Font = new Font(enemyGridBtn.Font.FontFamily, 28);
                        enemyGridBtn.BackgroundImage = gameState.getAISquare(x, y).getShip().getImage();
                    }
                    enemyGridBtn.Margin = new System.Windows.Forms.Padding(0);
                    enemyGridBtn.FlatStyle = FlatStyle.Flat;
                    enemyGridBtn.FlatAppearance.BorderSize = 0;
                    enemyGridBtn.Dock = DockStyle.Fill;
                    enemyGridBtn.Tag = new int[2] { x, y };
                    enemyGridBtn.Click += enemyBtn_Click;

                    if (enemyGridLayout[x][y] == null || enemyGridLayout[x][y].Text != enemyGridBtn.Text || enemyGridLayout[x][y].BackgroundImage != enemyGridBtn.BackgroundImage)
                    {
                        if(enemyGridLayout[x][y] != null)
                        {
                            this.enemyGrid.Controls.Remove(enemyGridLayout[x][y]);
                        }
                        enemyGridLayout[x][y] = enemyGridBtn;
                        this.enemyGrid.Controls.Add(enemyGridBtn, x, y);
                    }

                    /* playerShips */
                    var playerShipBtn = new Button();
                    playerShipBtn.BackgroundImage = gameState.getPlayer1Square(x, y).getShip().getImage();
                    if (gameState.getPlayer1Square(x, y).isHit())
                    {
                        playerShipBtn.Text = "X";
                        playerShipBtn.ForeColor = Color.Red;
                    }
                    playerShipBtn.Margin = new System.Windows.Forms.Padding(0);
                    playerShipBtn.FlatStyle = FlatStyle.Flat;
                    playerShipBtn.FlatAppearance.BorderSize = 0;
                    playerShipBtn.Dock = DockStyle.Fill;
                    playerShipBtn.Enabled = false;

                    if (playerGridLayout[x][y] == null || playerGridLayout[x][y].Text != playerShipBtn.Text || playerGridLayout[x][y].BackgroundImage != playerShipBtn.BackgroundImage)
                    {
                        if (playerGridLayout[x][y] != null)
                        {
                            this.playerShips.Controls.Remove(playerGridLayout[x][y]);
                        }
                        playerGridLayout[x][y] = playerShipBtn;
                        this.playerShips.Controls.Add(playerShipBtn, x, y);
                    }

                }
            }
        }

        private void MainGrid_Load(object sender, EventArgs e)
        {

            updateGrid();

        }

        private void enemyBtn_Click(object sender, EventArgs e)
        {
            Button sentButton = (Button)sender;
            int[] coordinates = (int[])sentButton.Tag;
            if (gameState.hitAISquare(coordinates[0], coordinates[1])) {
                updateGrid();
            }


        }

    }
}
