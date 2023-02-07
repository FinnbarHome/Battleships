using System;

namespace Battleships
{
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
                randHittingAI();
            }
            //For med difficulty
            else if (diff == "MEDIUM")
            {
                randHittingAI();
            }
            //For hard difficulty
            else if (diff == "HARD")
            {
                randHittingAI();
            }

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

        public void generateGrid()
        {
            /* TODO add some actual AI to the ai... */

            /* Entirely Random */
            for (int i = 0; i < Ships.shipList.Length; i += 1)
            {
                Ship ship = Ships.shipList[i];
                for(int j = 0; j < ship.getNumShips(); j += 1)
                {
                    bool success = false;
                    while (!success)
                    {
                        int x = rnd.Next(0, gameState.player1Square.Length);
                        int y = rnd.Next(0, gameState.player1Square.Length);
                        success = gameState.placePieceOnPlayer2Grid(ship, x, y, 1 * (j % 2), 1 * ((j + 1) % 2));
                    }
                }
            }
        }
    }
}