using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        int numShipsToCreate = 0;
        public ChoosePlacesGrid(GameState gameState)
        {
            this.gameState = gameState;
            /* Calculate how many ships we need to place in order to continue */
            for (int i = 0; i < Ships.shipList.Length; i += 1)
            {
                numShipsToCreate += Ships.shipList[i].getNumShips();
            }
            InitializeComponent();
        }

        private void ChoosePlacesGrid_Load(object sender, EventArgs e)
        {
            /* Create a button for each of our ships */
            for(int i = 0; i < Ships.shipList.Length; i += 1)
            {
                /* Create a button for our ship and style it */
                Ship ship = Ships.shipList[i];
                Button shipBtn = new Button();
                shipBtn.FlatStyle = FlatStyle.Flat;
                shipBtn.FlatAppearance.BorderSize = 2;
                shipBtn.Dock = DockStyle.Fill;

                /* Set our buttons image to the image for our ship */
                shipBtn.BackgroundImage = ship.getThumbnailImage();

                /* Set the text of our button equal to the number of ships to place + x, e.g: 2x */
                shipBtn.Text = ship.getNumShips() + "x";

                /* Tag our button with the type of ship it is and its location in the array of buttons */
                shipBtn.Tag = new Tuple<Ship, int>(ship, i);

                /* Add our event handlers */
                shipBtn.Click += ShipBtn_Click;
                shipBtn.MouseMove += ChoosePlacesGrid_MouseMove;

                /* Add our button to the screen and our display */
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
        
        private Button createGridButton()
        {
            /* All the styling required for a basic grid button */
            Button gridBtn = new Button();
            gridBtn.Margin = new System.Windows.Forms.Padding(0);
            gridBtn.FlatStyle = FlatStyle.Flat;
            gridBtn.FlatAppearance.BorderSize = 0;
            gridBtn.Dock = DockStyle.Fill;
            gridBtn.MouseMove += ChoosePlacesGrid_MouseMove;
            gridBtn.Click += gridBtn_Click;
            return gridBtn;
        }

        private void updateGrid()
        {
            for (int x = 0; x < this.PlacementGrid.RowCount; x += 1)
            {
                for (int y = 0; y < this.PlacementGrid.ColumnCount; y += 1)
                {
                    Button gridBtn = null;
                    if (buttonGrid[x][y] != null)
                    {
                        /* If a button has been created don't recreate it */
                        gridBtn = buttonGrid[x][y];
                    }
                    else
                    {
                        gridBtn = createGridButton();

                        /* Tag our button with its x and y co ordinaties */
                        gridBtn.Tag = new int[2] { x, y };
                    }

                    /* Set our buttons background image based on what part of a ship it is */
                    gridBtn.BackgroundImage = gameState.getPlayer1Square(x, y).getShip().getImage();


                    /* If the button hasn't been added yet add it */
                    if (buttonGrid[x][y] == null) {
                        this.PlacementGrid.Controls.Add(gridBtn, x, y);
                        buttonGrid[x][y] = gridBtn;
                    }
                }
            }

        }
        private void gridBtn_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            int[] squareCoordinates = (int[])clickedBtn.Tag;
            int numShipsLeft = 0;

            /* If we've not picked up a Ship and there's not a ship in the square clicked or if we try to pick up a ship whilst holding one exit */
            if (selectedBox == null && gameState.getPlayer1Square(squareCoordinates[0], squareCoordinates[1]).getShip() == Ships.NONE  || (selectedBox != null && gameState.getPlayer1Square(squareCoordinates[0], squareCoordinates[1]).getShip() != Ships.NONE))
            {
                return;
            }

            /* If we're trying to pickup a ship */
            if (gameState.getPlayer1Square(squareCoordinates[0], squareCoordinates[1]).getShip() != Ships.NONE)
            {
                /* Get the ship we're trying to pickup */
                Ship ship = gameState.getPlayer1Square(squareCoordinates[0], squareCoordinates[1]).getShip();

                /* Find the direction that our ship is facing in and calculate the X and Y coordinate of the start of the ship */
                shipDirection = ship.getDirection();
                int startX = squareCoordinates[0] - shipDirection[0] * ship.getShipPiece();
                int startY = squareCoordinates[1] - shipDirection[1] * ship.getShipPiece();

                /* Remove the ship from the grid */
                for (int i = 0; i < ship.getSize(); i += 1)
                {
                    gameState.getPlayer1Square(startX + (i * shipDirection[0]), startY + (i * shipDirection[1])).setShip(Ships.NONE);

                }

                /* Get the index of our ship in the ShipList */
                int shipIndex = Array.IndexOf(Ships.shipList, ship);

                /* Use this index to find the button linked to our Ship, we subtract '0' from our character, this is a trick */
                /* ASCII places all the numbers 0,1,2,...,9 next to eachother, so subtracting the '0' character means that the 0 character moves to the 0 integer, as do the other integers */
                numShipsLeft = selectionGrid[shipIndex].Text[0] - '0';

                /* Add to the number of remaining ships and the amount of ships we still need to place to continue */
                numShipsLeft += 1;
                numShipsToCreate += 1;
                
                /* Disable the continue button */
                btnContinue.Enabled = false;

                /* Write the number of remaining ships back to our button */
                selectionGrid[shipIndex].Text = numShipsLeft + "x";

                /* Create a picture box for our ship to follow the mouse */
                createPictureBox(new Tuple<Ship, int>(ship, shipIndex));

                /* Update our Grid to show our removed ship */
                updateGrid();
                return;
            }

            /* Get the tag for our box */
            Tuple<Ship, int>  selectedBoxTag = (Tuple<Ship, int>)selectedBox.Tag;

            /* Place our ship on the relevent grid position */
            if(!gameState.placePieceOnPlayerOneGrid(selectedBoxTag.Item1, squareCoordinates[0], squareCoordinates[1], shipDirection[0], shipDirection[1]))
            {
                return;
            }

            /* Using the index of our button, we subtract '0' from our character, this is a trick */
            /* ASCII places all the numbers 0,1,2,...,9 next to eachother, so subtracting the '0' character means that the 0 character moves to the 0 integer, as do the other integers */

            numShipsLeft = selectionGrid[selectedBoxTag.Item2].Text[0] - '0';

            /* Subtract the number of remaining ships and the amount of ships we still need to place to continue */

            numShipsLeft -= 1;
            numShipsToCreate -= 1;

            /* If we've placed all our ships enable the continue button */
            if(numShipsToCreate == 0)
            {
                btnContinue.Enabled = true;
            }

            /* Write the number of remaining ships back to our button */
            selectionGrid[selectedBoxTag.Item2].Text = numShipsLeft + "x";

            /* Update our Grid to show our Added ship */
            updateGrid();

            /* Remove our picture box from the screen, disable the rotate button and clear the selectedBox */
            this.Controls.Remove(selectedBox);
            btnRotate.Enabled = false;
            selectedBox = null;
        }
        private void ShipBtn_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            Tuple<Ship, int> tag = (Tuple<Ship, int>)clickedBtn.Tag;

            /* If our button was clicked and has 0 ships left, exit */
            if (clickedBtn.Text[0] == '0')
            {
                return;
            }

            /* Otherwise create our picture box */
            createPictureBox(tag);
        }

        private void createPictureBox(Tuple<Ship, int> tag)
        {
            /* Create a new PictureBox */
            PictureBox newBox = new PictureBox();

            /* Assign our Tag so that we know what ship to add */
            newBox.Tag = tag;

            /* Set our picture to the image of our ship */
            newBox.Image = tag.Item1.getThumbnailImage();

            /* Assign our ship a horizontal direction */
            shipDirection = new int[2] { 1, 0 };

            /* Calculate the width and height based on the direction, and make sure our image stretches across the whole pictureBox */
            newBox.Width = tag.Item1.getSize() * (this.PlacementGrid.Width / this.PlacementGrid.ColumnCount);
            newBox.Height = this.PlacementGrid.Height / this.PlacementGrid.RowCount;
            newBox.SizeMode = PictureBoxSizeMode.StretchImage;

            /* https://stackoverflow.com/a/60368567 */
            Point p1 = MousePosition;
            Point p2 = PointToClient(p1);
            newBox.Location = new Point(p2.X, p2.Y);

            /* Add the picture box to the screen */
            selectedBox = newBox;
            this.Controls.Add(selectedBox);
            btnRotate.Enabled = true;
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

            /* If our ship is horizontal currently */
            if (shipDirection[0] == 1)
            {
                shipDirection = new int[2] { 0, 1 };
                /* Calculate the width and height based on the direction */
                selectedBox.Width /= tag.Item1.getSize();
                selectedBox.Height *= tag.Item1.getSize();

            }
            else
            {
                shipDirection = new int[2] { 1, 0 };
                /* Calculate the width and height based on the direction */
                selectedBox.Width *= tag.Item1.getSize();
                selectedBox.Height /= tag.Item1.getSize();
            }

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            /* When you continue, pass gameState to the main grid and switch the view */
            MainGrid mainGridView = new MainGrid(gameState);
            this.ParentForm.Controls.Add(mainGridView);
            this.ParentForm.Controls.Remove(this);
            this.Dispose();
        }
    }
}
