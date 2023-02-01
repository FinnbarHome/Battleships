using System;

namespace Battleships
{
    internal class AIPlayer
    {
        private Difficulty difficulty;

        public AIPlayer(Difficulty difficulty)
        {
            this.difficulty = difficulty;
        }

        public void generateGrid(GameState gameState, GridSquare[][] playerAISquare)
        {
            Random rnd = new Random();
            /* Entirely Random */
            for (int i = 0; i < Ships.shipList.Length; i += 1)
            {
                Ship ship = Ships.shipList[i];
                for(int j = 0; j < ship.getNumShips(); j += 1)
                {
                    bool success = false;
                    while (!success)
                    {
                        int x = rnd.Next(0, 7);
                        int y = rnd.Next(0, 7);
                        success = gameState.placePieceOnGrid(playerAISquare, ship, x, y, 1 * (j % 2), 1 * ((j + 1) % 2));
                    }
                }
            }
        }
    }
}