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
            ai.generateGrid(this, playerAISquare);
            this.difficulty = difficulty;
        }
        public GameState(String gameFile)
        {
        }

        public GridSquare getPlayer1Square(int x, int y)
        {
            return player1Square[x][y];
        }

        public GridSquare getAISquare(int x, int y)
        {
            return playerAISquare[x][y];
        }

        public bool aiPlayerHitSquare()
        {
            return true;
        }

        public bool placePieceOnGrid(GridSquare[][] square, Ship ship, int x, int y, int dx, int dy)
        {
            for(int i = 0; i < ship.getSize(); i += 1)
            {
                if(square[x + (i * dx)][y + (i * dy)].getShip() != Ships.NONE)
                {
                    return false;
                }
            }
            for(int i = 0; i < ship.getSize(); i += 1)
            {
                square[x + (i * dx)][y + (i * dy)].setShip(new Ship(ship, i));
            }
            return true;
        }

        public bool hitAISquare(int x, int y) /* Tuple -> first item whether the square was hit, second is whether the square was a ship */
        {
            if (playerAISquare[x][y].isHit() == true)
            {
                return false;
            }
            
            playerAISquare[x][y].setHit(true);

            return true;
        }

    }
}
