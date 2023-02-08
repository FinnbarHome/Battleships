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
        GameState gameState = null;
        private Button[][] enemyGridLayout = null;
        private Button[][] playerGridLayout = null;


        public MainGrid(GameState gameState)
        {
            /* Setup our Starting Variables */
            this.gameState = gameState;
            enemyGridLayout = new Button[gameState.player1Square.Length][];
            playerGridLayout = new Button[gameState.player1Square.Length][];
            for (int i = 0; i < gameState.player1Square.Length; i += 1)
            {
                enemyGridLayout[i] = new Button[gameState.player1Square[i].Length];
                playerGridLayout[i] = new Button[gameState.player1Square[i].Length];
            }
            InitializeComponent();
        }

        private void MainGrid_Load(object sender, EventArgs e)
        {
            /* Setup our Grid to start */
            updateGrid();
        }

        private Button createButtonAttributes()
        {
            /* Create a button and style it appropriately */
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

                    Button enemyGridBtn = null;
                    if (enemyGridLayout[x][y] != null)
                    {
                        /* If a button has been created don't recreate it */
                        enemyGridBtn = enemyGridLayout[x][y];
                    }
                    else
                    {
                        enemyGridBtn = createButtonAttributes();

                        /* Set the default background image */
                        enemyGridBtn.BackgroundImage = Ships.NONE.getImage();

                        /* Tag our button with its x and y co ordinaties */

                        enemyGridBtn.Tag = new int[2] { x, y };

                        /* Add our Click handler */
                        enemyGridBtn.Click += enemyBtn_Click;

                        /* Add our hover handlers */

                        enemyGridBtn.MouseEnter += EnemyGridBtn_MouseEnter;
                        enemyGridBtn.MouseLeave += EnemyGridBtn_MouseLeave;

                    }

                    /* Check if the square was hit */
                    if (gameState.getPlayer2Square(x, y).isHit())
                    {
                        /* Add a marker the square was hit */
                        enemyGridBtn.Text = "X";
                        enemyGridBtn.ForeColor = Color.Red;
                        enemyGridBtn.Font = new Font(enemyGridBtn.Font.FontFamily, 16);

                        /* Check if the hit square has a ship */
                        if (gameState.getPlayer2Square(x, y).getShip() != Ships.NONE)
                        {
                            /* Don't show the exact ship, this will give the game away. */
                            enemyGridBtn.BackgroundImage = Properties.Resources.ShipSquare;
                        }
                    }

                    /* Add the square to the grid if it didn't exist */
                    if (enemyGridLayout[x][y] == null)
                    {
                        enemyGridLayout[x][y] = enemyGridBtn;
                        this.enemyGrid.Controls.Add(enemyGridBtn, x, y);
                    }

                    Button playerShipBtn = null;
                    if (playerGridLayout[x][y] != null)
                    {
                        /* If a button has been created don't recreate it */
                        playerShipBtn = playerGridLayout[x][y];
                    }
                    else
                    {
                        playerShipBtn = createButtonAttributes();
                        /* Disable the button */
                        playerShipBtn.Enabled = false;
                    }

                    /* Set the background of our image based on the ship that it has */
                    playerShipBtn.BackgroundImage = gameState.getPlayer1Square(x, y).getShip().getImage();


                    /* Check if the square was hit */
                    if (gameState.getPlayer1Square(x, y).isHit())
                    {
                        /* Add a marker the square was hit */
                        playerShipBtn.Text = "X";
                        playerShipBtn.ForeColor = Color.Red;
                        playerShipBtn.Font = new Font(playerShipBtn.Font.FontFamily, 10);

                    }

                    /* Add the square to the grid if it didn't exist */
                    if (playerGridLayout[x][y] == null)
                    {
                        playerGridLayout[x][y] = playerShipBtn;
                        this.playerShips.Controls.Add(playerShipBtn, x, y);
                    }

                }
            }
        }

        private void EnemyGridBtn_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int[] coordinates = (int[])button.Tag;
            if (gameState.getPlayer2Square(coordinates[0], coordinates[1]).isHit())
            {
                return;
            }
            button.BackgroundImage = Properties.Resources.EmptySquare;
        }

        private void EnemyGridBtn_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int[] coordinates = (int[])button.Tag;
            if (gameState.getPlayer2Square(coordinates[0], coordinates[1]).isHit())
            {
                return;
            }
            button.BackgroundImage = Properties.Resources.SquareHover;
        }

        private void enemyBtn_Click(object sender, EventArgs e)
        {
            /* Get the button we've clicked and its co ordinates */
            Button sentButton = (Button)sender;
            int[] coordinates = (int[])sentButton.Tag;

            /* Check if the square selected was hit */
            if (gameState.hitPlayer2Square(coordinates[0], coordinates[1]))
            {
                /* Fix our image */
                sentButton.BackgroundImage = Ships.NONE.getImage();
                /* Update the grid */
                updateGrid();

                /* Check if we've sank a battleship */
                if (gameState.sankPlayer2Battleship(coordinates[0], coordinates[1]))
                {

                    /* Check if we've won, and announce it if so. */
                    if (gameState.checkWin() > 0)
                    {
                        MessageBox.Show("You win!", "You win!");

                        /* Send the user to the score screen */
                        Score scoreView = new Score();
                        this.ParentForm.Controls.Add(scoreView);
                        this.ParentForm.Controls.Remove(this);
                        this.Dispose();
                    }
                    else
                    {
                        /* If we have hit a ship but not won send a message to the user */
                        MessageBox.Show("You sank my battleship", "You sank my battleship!!");
                    }

                }

                /* Allow the AI to hit a square and update the grid */
                gameState.player2.hitSquare();
                updateGrid();

                /* Check if the AI has won the game */
                if (gameState.checkWin() < 0)
                {
                    MessageBox.Show("You lose!", "You lose!");

                    /* Send the user to the score screen */
                    Score scoreView = new Score();
                    this.ParentForm.Controls.Add(scoreView);
                    this.ParentForm.Controls.Remove(this);
                    this.Dispose();
                }

            }

        }

    }
}
