using System;

namespace Battleships
{
    internal class AIPlayer
    {
        private Difficulty difficulty;
        private GameState gameState;

        public AIPlayer(GameState gameState, Difficulty difficulty)
        {
            this.difficulty = difficulty;
            this.gameState = gameState;
        }

        public void generateGrid()
        {
            /* TODO add some actual AI to the ai... */
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
                        success = gameState.placePieceOnAIGrid(ship, x, y, 1 * (j % 2), 1 * ((j + 1) % 2));
                    }
                }
            }
        }
    }
}