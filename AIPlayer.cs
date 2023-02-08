using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Battleships
{
    [Serializable]
    public class AIPlayer
    {
        private Difficulty difficulty;
        private GameState gameState;

        private Random rnd = new Random();


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
            GridSquare[][] board = gameState.player2Square;

            bool finished = false;
            while (!finished)
            {
                int x = rnd.Next(0, gameState.player1Square.Length);
                int y = rnd.Next(0, gameState.player1Square.Length);
                GridSquare gridValue = board[x][y];
                Ship ship = gridValue.getShip();


                if (ship != Ships.NONE)
                {
                    Console.WriteLine("THERE IS A SHIP HERE");
                }
                finished = gameState.hitPlayer1Square(x, y);
            }
        }

        //This is the Medium AI, it shoots in a checkered pattern and hunts 
        public void checkeredHuntAI()
        {
            bool finished = false;
            while (!finished)
            {
                //Bool to define whether the AI is searching for a ship
                bool searching = true;

                //Generates initial random shot
                int x = rnd.Next(0, gameState.player1Square.Length);
                int y = rnd.Next(0, gameState.player1Square.Length);

                List<Tuple<int, int>> checkerboard = generateCheckerboardCoordinates();

                //Is shooting in the checkered pattern until it finds a ship
                if (searching)
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

                        //Try hitting this co-ord
                        finished = gameState.hitPlayer1Square(x, y);
                    }
                    else
                    {
                        randHittingAI();
                    }
                    
                }
                else
                {
                    //Has found a ship, now will search for the rest of the ship
                }

                //If it returns a valid hit it will register it, if not it will keep looping
                finished = gameState.hitPlayer1Square(x, y);
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