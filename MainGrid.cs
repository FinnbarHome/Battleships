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

        private Button createButtonAttributes()
        {
            Button button = new Button();
            button.Margin = new System.Windows.Forms.Padding(0);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Dock = DockStyle.Fill;
            return button;
        }


        private void updateGrid()
        {
            for (int x = 0; x < this.enemyGrid.RowCount; x++)
            {
                for (int y = 0; y < this.enemyGrid.ColumnCount; y++)
                {
                    /* Enemy grid, doesn't show ship unless ship hit */
                    Button enemyGridBtn = createButtonAttributes();
                    enemyGridBtn.BackgroundImage = Ships.NONE.getImage();
                    if (gameState.getAISquare(x, y).isHit())
                    {
                        enemyGridBtn.Text = "X";
                        enemyGridBtn.ForeColor = Color.Red;
                        enemyGridBtn.Font = new Font(enemyGridBtn.Font.FontFamily, 28);
                        if (gameState.getAISquare(x, y).getShip() != Ships.NONE)
                        {
                            /* Don't show the exact ship, this will give the game away. */
                            enemyGridBtn.BackgroundImage = Properties.Resources.ShipSquare;
                        }
                    }
                        
                    enemyGridBtn.Tag = new int[2] { x, y };
                    enemyGridBtn.Click += enemyBtn_Click;

                    /* Verify the grid needs updated to improve efficiency */
                    if (enemyGridLayout[x][y] == null || enemyGridLayout[x][y].Text != enemyGridBtn.Text)
                    {
                        if(enemyGridLayout[x][y] != null)
                        {
                            this.enemyGrid.Controls.Remove(enemyGridLayout[x][y]);
                        }
                        enemyGridLayout[x][y] = enemyGridBtn;
                        this.enemyGrid.Controls.Add(enemyGridBtn, x, y);
                    }

                    /* playerShips */
                    Button playerShipBtn = createButtonAttributes();
                    playerShipBtn.BackgroundImage = gameState.getPlayer1Square(x, y).getShip().getImage();
                    if (gameState.getPlayer1Square(x, y).isHit())
                    {
                        playerShipBtn.Text = "X";
                        playerShipBtn.ForeColor = Color.Red;
                    }
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
            if (gameState.hitAISquare(coordinates[0], coordinates[1]))
            {
                updateGrid();
                if (gameState.sankAIBattleship(coordinates[0], coordinates[1]))
                {
                    MessageBox.Show("You sank my battleship", "You sank my battleship!!");

                    int winState = gameState.checkWin();
                    if (winState > 0)
                    {
                        MessageBox.Show("You win!", "You win!");
                    }
                    else if (winState < 0)
                    {
                        MessageBox.Show("You lose!", "You lose!");
                    }
                }
            }

        }

    }
}
