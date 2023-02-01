using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    enum Difficulty
    {
        EASY,
        MEDIUM,
        HARD
    };

    internal class GameState
    {
        public Difficulty difficulty;
        private AIPlayer ai;
        public GridSquare[][] player1Square = new GridSquare[7][];
        public GridSquare[][] playerAISquare = new GridSquare[7][];

        public GameState(Difficulty difficulty)
        {
            for (int i = 0; i < 7; i++)
            {
                ai = new AIPlayer(difficulty);
                player1Square[i] = new GridSquare[7];
                playerAISquare[i] = new GridSquare[7];
                for (int j = 0; j < 7; j++)
                {
                    player1Square[i][j] = new GridSquare();
                    playerAISquare[i][j] = new GridSquare();
                }
            }
            this.difficulty = difficulty;
        }
        public GameState(String gameFile)
        {
        }

        public bool aiPlayerFillGrid()
        {
            return true;
        }

        public bool aiPlayerHitSquare()
        {
            return true;
        }

        public bool placePieceOnGrid(GridSquare[][] square, Ship ship, int x, int y, int dx, int dy)
        {
            for(int i = 0; i < ship.getSize(); i += 1)
            {
                square[x + (i * dx)][y + (i * dy)].setShip(new Ship(ship, i));
            }
            return true;
        }

        public Tuple<bool, bool> hitAISquare(int x, int y) /* Tuple -> first item whether the square was hit, second is whether the square was a ship */
        {
            if (playerAISquare[x][y].isHit() == true)
            {
                return new Tuple<bool, bool>(false, false);
            }
            
            playerAISquare[x][y].setHit(true);

            if (playerAISquare[x][y].getShip() == Ships.NONE)
            {
                return new Tuple<bool, bool>(true, false);
            }

            return new Tuple<bool, bool>(true, true);
        }

    }
}
