using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Drawing.Printing;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Battleships
{
    [Serializable]
    public class AIPlayer
    {
        private Difficulty difficulty;
        private GameState gameState;
        private bool foundShipLastTurn = false;
        private bool foundShip = false;
        private Random rnd = new Random();
        private int successX;
        private int successY;
        private int dirTries = 1;
        private List<Coordinate> checkerboard;


        public AIPlayer(GameState gameState, Difficulty difficulty)
        {
            this.difficulty = difficulty;
            this.gameState = gameState;
            checkerboard = GetCheckerboardCoordinates();

        }

        public void hitSquare()
        {
            //Converts difficulty var to a string
            string diff = difficulty.ToString();

            //For easy difficulty
            if (diff == "EASY")
            {
                Console.WriteLine("Player 1:");
                gameState.printBoard(gameState.player1Square);
                Console.WriteLine("Player 2:");
                gameState.printBoard(gameState.player2Square);

                randHittingAI();
            }
            //For med difficulty
            else if (diff == "MEDIUM")
            {
                checkeredHuntAI();
            }
            //For hard difficulty
            else if (diff == "HARD")
            {

            }
            else
            {
                Console.WriteLine("ERROR: THERE IS NO AI FOR THIS DIFFICULTY");
            }
        }

        private List<Coordinate> GetCheckerboardCoordinates()
        {
            List<Coordinate> coordinates = new List<Coordinate>();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.WriteLine(i.ToString() + j.ToString());
                        coordinates.Add(new Coordinate(i,j));
                    }
                }
            }
            return coordinates;
        }


        //This is the Easy AI, it hits squares completely randomly
        public void randHittingAI()
        {

            bool finished = false;
            while (!finished)
            {
                int x = rnd.Next(0, gameState.player1Square.Length);
                int y = rnd.Next(0, gameState.player1Square.Length);
                finished = gameState.hitPlayer1Square(x, y);
            }
        }

        //Rand but for medium so it sets sucess shots
        public Coordinate randHittingAIMed(GridSquare[][] board)
        {
            Console.WriteLine("AI STATUS: No checkered shots left to fire, doing random shots");
            int x = rnd.Next(0, gameState.player1Square.Length);
            int y = rnd.Next(0, gameState.player1Square.Length);

            if (checkShipAtTile(board[x][y]))
            {
                successX = x;
                successY = y;
                Console.WriteLine("");
                Console.WriteLine("AI STATUS: Has hit a ship, success x:" + successX.ToString() + " y:" + successY.ToString());
            }

            Coordinate coordinate = new Coordinate(x, y);

            return coordinate;
        }

        public Coordinate CheckeredShoot(GridSquare[][] board)
        {
            Console.WriteLine("AI STATUS: Trying checkered shot");
            Coordinate selectedCoordinate = new Coordinate(-1,-1);


            int length = checkerboard.Count;

            if (length > 0)
            {
                Console.WriteLine("AI STATUS: Doing checkered shot");

                //Generates a random index to pick from the checkboard list
                Random rand = new Random();
                int randomIndex = rand.Next(0, length);

                //Puts this coordinate into randomCoordinate field
                selectedCoordinate = checkerboard[randomIndex];
                checkerboard.RemoveAt(randomIndex);

                //Sets bool if a ship is going to be hit at this tile
                if (checkShipAtTile(board[selectedCoordinate.X][selectedCoordinate.Y]))
                {
                    successX = selectedCoordinate.X;
                    successY = selectedCoordinate.Y;
                    Console.WriteLine("");
                    Console.WriteLine("AI STATUS: Has hit a ship, success x:" + successX.ToString() + " y:" + successY.ToString());
                }
                return selectedCoordinate;
            }
            else
            {
                Console.WriteLine("AI STATUS: No checkered shots left to fire, doing random shots instead");
                //If there's no checkered shots left, fire randomly
                selectedCoordinate = randHittingAIMed(board);
                return selectedCoordinate;
            }

        }

        //This is the Medium AI, it shoots in a checkered pattern and hunts 
        public void checkeredHuntAI()
        {
            Console.WriteLine("AI STATUS: Starting checkered hunt AI");
            GridSquare[][] board = gameState.player1Square;

            if (foundShip)
            {
                Console.WriteLine("AI STATUS: Found a ship turn so will search this turn");
                foundShipLastTurn = true;
            }

            bool finished = false;
            int counter = 0;

            while (!finished)
            {
                //Stores the coordinate we're gonna try fire at
                Coordinate coordinates = new Coordinate(-1, -1);

                //Is shooting in the checkered pattern until it finds a ship
                if (!foundShipLastTurn)
                {
                    coordinates = CheckeredShoot(board);
                }
                else
                {
                    coordinates = searchForShip(board);
                }
                
                counter++;
                Console.WriteLine("AI STATUS: Has looped through trying to shoot this many times: " + counter.ToString());
                Console.WriteLine("AI STATUS: firing at X:" + coordinates.X.ToString() + " Y:" + coordinates.Y.ToString());
                finished = gameState.hitPlayer1Square(coordinates.X, coordinates.Y);
            }


        }

        public Coordinate searchForShip(GridSquare[][] board)
        {
            Coordinate coordinates = new Coordinate(-1, -1);
            int tryingDirX = -1;
            int tryingDirY = -1;
            GridSquare gridValue;
            Ship ship;

            Console.WriteLine("AI STATUS: Trying search");
            switch (dirTries)
            {

                case 1:
                    //Is trying the square left of it
                    tryingDirX = successX - 1;
                    tryingDirY = successY;

                    //If the x is beyond the grid
                    if (tryingDirX < 0)
                    {
                        goto case 2;
                    }
                    gridValue = board[tryingDirX][tryingDirY];
                    if (gridValue.isHit())
                    {
                        goto case 2;
                    }

                    ship = gridValue.getShip();
                    if (ship != Ships.NONE)
                    {
                        //Has found another ship
                        successX = tryingDirX;
                        successY = tryingDirY;
                        Console.WriteLine("");
                        Console.WriteLine("AI STATUS: Has hit a ship, success x:" + successX.ToString() + " y:" + successY.ToString());
                    }
                    else
                    {
                        dirTries++;
                    }

                    coordinates.X = tryingDirX;
                    coordinates.Y = tryingDirY;
                    return coordinates;

                case 2:
                    //Is trying the square right of it
                    tryingDirX = successX + 1;
                    tryingDirY = successY;

                    //If the x is beyond the grid
                    if (tryingDirX >= 10)
                    {
                        goto case 3;
                    }
                    gridValue = board[tryingDirX][tryingDirY];
                    if (gridValue.isHit())
                    {
                        goto case 3;
                    }

                    ship = gridValue.getShip();
                    if (ship != Ships.NONE)
                    {
                        //Has found another ship
                        successX = tryingDirX;
                        successY = tryingDirY;
                        Console.WriteLine("");
                        Console.WriteLine("AI STATUS: Has hit a ship, success x:" + successX.ToString() + " y:" + successY.ToString());
                    }
                    else
                    {
                        dirTries++;
                    }

                    coordinates.X = tryingDirX;
                    coordinates.Y = tryingDirY;
                    return coordinates;

                case 3:
                    //Is trying the square on the bottom of it
                    tryingDirX = successX;
                    tryingDirY = successY - 1;

                    //If the y is beyond the grid
                    if (tryingDirY < 0)
                    {
                        goto case 4;
                    }
                    gridValue = board[tryingDirX][tryingDirY];
                    if (gridValue.isHit())
                    {
                        goto case 4;
                    }

                    ship = gridValue.getShip();
                    if (ship != Ships.NONE)
                    {
                        //Has found another ship
                        successX = tryingDirX;
                        successY = tryingDirY;
                        Console.WriteLine("");
                        Console.WriteLine("AI STATUS: Has hit a ship, success x:" + successX.ToString() + " y:" + successY.ToString());
                    }
                    else
                    {
                        dirTries++;
                    }

                    coordinates.X = tryingDirX;
                    coordinates.Y = tryingDirY;
                    return coordinates;

                case 4:
                    //Is trying the square on top of it
                    tryingDirX = successX;
                    tryingDirY = successY + 1;


                    //If the y is beyond the grid
                    if (tryingDirY >= 10)
                    {
                        goto default;
                    }
                    gridValue = board[tryingDirX][tryingDirY];
                    if (gridValue.isHit())
                    {
                        goto default;
                    }

                    ship = gridValue.getShip();
                    if (ship != Ships.NONE)
                    {
                        //Has found another ship
                        successX = tryingDirX;
                        successY = tryingDirY;
                        Console.WriteLine("");
                        Console.WriteLine("AI STATUS: Has hit a ship, success x:" + successX.ToString() + " y:" + successY.ToString());
                    }
                    else
                    {
                        dirTries++;
                    }

                    coordinates.X = tryingDirX;
                    coordinates.Y = tryingDirY;
                    return coordinates;

                default:
                    foundShip = false;
                    dirTries = 1;
                    return coordinates = randHittingAIMed(board);
            }
        }

        public bool checkShipAtTile(GridSquare gridValue)
        {
            Ship ship = gridValue.getShip();

            if (ship != Ships.NONE && !gridValue.isHit())
            {
                foundShip = true;
                return foundShip;
            }
            else
            {
                foundShip = false;
                return foundShip;
            }
        }

        public void generatePlayer2Grid()
        {
            /* TODO add some actual AI to the ai... */

            /* Entirely Random */
            for (int i = 0; i < Ships.shipList.Length; i += 1)
            {
                Ship ship = Ships.shipList[i];
                for (int j = 0; j < ship.getNumShips(); j += 1)
                {
                    bool success = false;
                    while (!success)
                    {
                        int x = rnd.Next(0, gameState.player1Square.Length);
                        int y = rnd.Next(0, gameState.player1Square.Length);
                        success = gameState.placePieceOnPlayerTwoGrid(ship, x, y, 1 * (j % 2), 1 * ((j + 1) % 2));
                    }
                }
            }
        }
        public void generatePlayer1Grid()
        {
            /* TODO add some actual AI to the ai... */

            /* Entirely Random */
            for (int i = 0; i < Ships.shipList.Length; i += 1)
            {
                Ship ship = Ships.shipList[i];
                for (int j = 0; j < ship.getNumShips(); j += 1)
                {
                    bool success = false;
                    while (!success)
                    {
                        int x = rnd.Next(0, gameState.player1Square.Length);
                        int y = rnd.Next(0, gameState.player1Square.Length);
                        success = gameState.placePieceOnPlayerOneGrid(ship, x, y, 1 * (j % 2), 1 * ((j + 1) % 2));
                    }
                }
            }
        }
    }
}