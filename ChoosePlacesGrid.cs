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
    public partial class ChoosePlacesGrid : UserControl
    {
        GameState gameState = null;
        private Button[][] buttonGrid = null;
        private Button[] selectionGrid = new Button[Ships.shipList.Length];
        private PictureBox selectedBox = null;
        private int[] shipDirection = new int[2];
        public ChoosePlacesGrid(GameState gameState)
        {
            this.gameState = gameState;
            InitializeComponent();
        }

        private void updateGrid()
        {
            for (int x = 0; x < this.PlacementGrid.RowCount; x += 1)
            {
                for (int y = 0; y < this.PlacementGrid.ColumnCount; y += 1)
                {
                    Button gridBtn = new Button();
                    gridBtn.Margin = new System.Windows.Forms.Padding(0);
                    gridBtn.FlatStyle = FlatStyle.Flat;
                    gridBtn.FlatAppearance.BorderSize = 0;
                    gridBtn.Dock = DockStyle.Fill;
                    gridBtn.BackgroundImage = gameState.getPlayer1Square(x,y).getShip().getImage();
                    gridBtn.Tag = new int[2] { x, y };
                    if (gameState.getPlayer1Square(x, y).getShip() != Ships.NONE) {
                        gridBtn.Text = " ";
                    }
                    gridBtn.MouseMove += ChoosePlacesGrid_MouseMove;
                    gridBtn.Click += gridBtn_Click;

                    if (buttonGrid[x][y] == null || (gameState.getPlayer1Square(x, y).getShip() != Ships.NONE && buttonGrid[x][y].Text != " ") || (gameState.getPlayer1Square(x, y).getShip() == Ships.NONE && buttonGrid[x][y].Text == " "))
                    {
                        if (buttonGrid[x][y] != null)
                        {
                            this.PlacementGrid.Controls.Remove(buttonGrid[x][y]);
                        }
                        buttonGrid[x][y] = gridBtn;
                        this.PlacementGrid.Controls.Add(gridBtn, x, y);
                    }
                }
            }

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
                shipBtn.Tag = new Tuple<Ship, int>(ship, i);
                shipBtn.Click += ShipBtn_Click;
                shipBtn.MouseMove += ChoosePlacesGrid_MouseMove;
                this.SelectableShips.Controls.Add(shipBtn, i, 0);
                selectionGrid[i] = shipBtn;
            }
            buttonGrid = new Button[this.PlacementGrid.ColumnCount][];
            for(int x = 0; x < this.PlacementGrid.RowCount; x += 1)
            {
                buttonGrid[x] = new Button[this.PlacementGrid.RowCount];
            }
            updateGrid();
        }
        private void gridBtn_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            int[] tag = (int[])clickedBtn.Tag;

            if (selectedBox == null && gameState.getPlayer1Square(tag[0], tag[1]).getShip() == Ships.NONE)
            {
                return;
            }

            if (gameState.getPlayer1Square(tag[0], tag[1]).getShip() != Ships.NONE)
            {
                Ship ship = gameState.getPlayer1Square(tag[0], tag[1]).getShip();
                shipDirection = ship.getDirection();
                int startX = tag[0] - shipDirection[0] * ship.getShipPiece();
                int startY = tag[1] - shipDirection[1] * ship.getShipPiece();

                /* Check if the whole ship is hit */
                for (int i = 0; i < ship.getSize(); i += 1)
                {
                    gameState.getPlayer1Square(startX + (i * shipDirection[0]), startY + (i * shipDirection[1])).setShip(Ships.NONE);

                }
                PictureBox newBox = new PictureBox();

                newBox.Tag = new Tuple<Ship, int>(ship, -1);
                newBox.Image = ship.getThumbnailImage();

                newBox.Width = ((shipDirection[0] * (ship.getSize() - 1)) + 1) * (this.PlacementGrid.Width / this.PlacementGrid.ColumnCount);
                newBox.Height = ((shipDirection[1] * (ship.getSize() - 1)) + 1) * (this.PlacementGrid.Height / this.PlacementGrid.RowCount);
                newBox.SizeMode = PictureBoxSizeMode.StretchImage;
                Point p1 = MousePosition;
                Point p2 = PointToClient(p1);
                newBox.Location = new Point(p2.X, p2.Y);
                selectedBox = newBox;
                this.Controls.Add(selectedBox);
                selectedBox.BringToFront();

                updateGrid();
                return;
            }
            Tuple<Ship, int>  selectedBoxTag = (Tuple<Ship, int>)selectedBox.Tag;

            if(!gameState.placePieceOnPlayerOneGrid(selectedBoxTag.Item1, tag[0], tag[1], shipDirection[0], shipDirection[1]))
            {
                return;
            }
            if(selectedBoxTag.Item2 != -1)
            {
                int numShipsLeft = selectionGrid[selectedBoxTag.Item2].Text[0] - '0';
                numShipsLeft -= 1;
                selectionGrid[selectedBoxTag.Item2].Text = numShipsLeft + "x";
            }
            updateGrid();
            this.Controls.Remove(selectedBox);
            selectedBox = null;
        }
        private void ShipBtn_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            Tuple<Ship, int> tag = (Tuple<Ship, int>)clickedBtn.Tag;
            if (clickedBtn.Text[0] == '0')
            {
                return;
            }
            PictureBox newBox = new PictureBox();
            newBox.Tag = tag;
            newBox.Image = tag.Item1.getThumbnailImage();
            shipDirection = new int[2] { 1, 0 };
            newBox.Width = tag.Item1.getSize() * (this.PlacementGrid.Width / this.PlacementGrid.ColumnCount);
            newBox.Height = this.PlacementGrid.Height / this.PlacementGrid.RowCount;
            newBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Point p1 = MousePosition;
            Point p2 = PointToClient(p1);
            newBox.Location = new Point(p2.X, p2.Y);
            selectedBox = newBox;
            this.Controls.Add(selectedBox);
            selectedBox.BringToFront();
        }

        private void ChoosePlacesGrid_MouseMove(object sender, MouseEventArgs e)
        {
            if(selectedBox == null)
            {
                return;
            }
            /* https://stackoverflow.com/a/60368567 */
            Point p1 = MousePosition;
            Point p2 = PointToClient(p1);
            selectedBox.Location = new Point(p2.X+1, p2.Y+1); // +1 means we don't click on the picturebox
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (selectedBox == null)
            {
                return;
            }
            Tuple<Ship, int> tag = (Tuple<Ship, int>)selectedBox.Tag;
            if (shipDirection[0] == 1)
            {
                shipDirection = new int[2] { 0, 1 };
                selectedBox.Width /= tag.Item1.getSize();
                selectedBox.Height *= tag.Item1.getSize();

            }
            else
            {
                shipDirection = new int[2] { 1, 0 };
                selectedBox.Width *= tag.Item1.getSize();
                selectedBox.Height /= tag.Item1.getSize();
            }

        }
    }
}
