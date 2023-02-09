using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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


        public AIPlayer(GameState gameState, Difficulty difficulty)
        {
            this.difficulty = difficulty;
            this.gameState = gameState;

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

        public List<Tuple<int, int>> generateCheckerboardCoordinates()
        {
            List<Tuple<int, int>> checkerboardCoordinates = new List<Tuple<int, int>>();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        checkerboardCoordinates.Add(new Tuple<int, int>(i, j));
                    }
                }
            }
            return checkerboardCoordinates;
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
        public void randHittingAIMed(GridSquare[][] board)
        {
            bool finished = false;
            while (!finished)
            {
                int x = rnd.Next(0, gameState.player1Square.Length);
                int y = rnd.Next(0, gameState.player1Square.Length);

                checkShipAtTile(board[x][y]);
                if (checkShipAtTile(board[x][y]))
                {
                    successX = x;
                    successY = y;
                }

                finished = gameState.hitPlayer1Square(x, y);
            }

            
        }

        //This is the Medium AI, it shoots in a checkered pattern and hunts 
        public void checkeredHuntAI()
        {
            GridSquare[][] board = gameState.player1Square;
            GridSquare gridValue;
            Ship ship;
            int tryingDirX = 0;
            int tryingDirY = 0;


            if (foundShip)
            {
                foundShipLastTurn = true;
            }

            bool finished = false;
            while (!finished)
            {
                
                //Generates initial random shot
                int x = rnd.Next(0, gameState.player1Square.Length);
                int y = rnd.Next(0, gameState.player1Square.Length);

                List<Tuple<int, int>> checkerboard = generateCheckerboardCoordinates();
                


                //Is shooting in the checkered pattern until it finds a ship
                if (!foundShipLastTurn)
                {
                    int length = checkerboard.Count;
                    if(length > 0)
                    {
                        //Generates a random index to pick from the checkboard list
                        Random rand = new Random();
                        int randomIndex = rand.Next(0, checkerboard.Count);

                        //Puts this coordinate into randomCoordinate field then removes it from the checkboard
                        Tuple<int, int> randomCoordinate = checkerboard[randomIndex];
                        checkerboard.RemoveAt(randomIndex);

                        //Get the x and y co-ordinates into separate fields
                        x = randomCoordinate.Item1;
                        y = randomCoordinate.Item2;

                        //Sets bool if a ship is going to be hit at this tile
                        checkShipAtTile(board[x][y]);
                        if (checkShipAtTile(board[x][y]))
                        {
                            successX = x;
                            successY = y;
                        }

                        //Try hitting this co-ord
                    }
                    else
                    {
                        finished = false;
                        while (!finished)
                        {
                            randHittingAIMed(board);
                        }
                    }
                    
                }
                else
                {

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

                            x = tryingDirX;
                            y = tryingDirY;
                            ship = gridValue.getShip();

                            if (ship != Ships.NONE)
                            {
                                //Has found another ship
                                successX = tryingDirX;
                                successY = tryingDirY;
                            }
                            else
                            {
                                dirTries++;
                            }
                            break;

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

                            x = tryingDirX;
                            y = tryingDirY;
                            ship = gridValue.getShip();

                            if (ship != Ships.NONE)
                            {
                                //Has found another ship
                                successX = tryingDirX;
                                successY = tryingDirY;
                            }
                            else
                            {
                                dirTries++;
                            }
                            break;
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

                            x = tryingDirX;
                            y = tryingDirY;
                            ship = gridValue.getShip();

                            if (ship != Ships.NONE)
                            {
                                //Has found another ship
                                successX = tryingDirX;
                                successY = tryingDirY;
                            }
                            else
                            {
                                dirTries++;
                                //Has not found another ship
                            }
                            break;
                        case 4:
                            //Is trying the square on top of it
                            tryingDirX = successX;
                            tryingDirY = successY + 1;
                            

                            //If the y is beyond the grid
                            if (tryingDirY >= 10)
                            {
                                goto case 4;
                            }
                            gridValue = board[tryingDirX][tryingDirY];
                            if (gridValue.isHit())
                            {
                                goto case 4;
                            }

                            x = tryingDirX;
                            y = tryingDirY;
                            ship = gridValue.getShip();

                            if (ship != Ships.NONE)
                            {
                                //Has found another ship
                                successX = tryingDirX;
                                successY = tryingDirY;
                            }
                            else
                            {
                                dirTries++;
                                //Has not found another ship
                            }
                            break;
                        default:
                            foundShip = false;
                            dirTries = 1;
                            randHittingAIMed(board);
                            break;
                    }
                }
                finished = gameState.hitPlayer1Square(x, y);
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