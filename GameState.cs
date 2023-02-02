using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public enum Difficulty
    {
        EASY,
        MEDIUM,
        HARD
    };

    public class GameState
    {
        public Difficulty difficulty;
        private AIPlayer ai;
        public GridSquare[][] player1Square = new GridSquare[7][];
        public GridSquare[][] playerAISquare = new GridSquare[7][];

        int player1Hits = 0;
        int playerAIHits = 0;

        public GameState(Difficulty difficulty)
        {
            /* Initialise Variables */
            ai = new AIPlayer(this, difficulty);
            this.difficulty = difficulty;
            this.player1Hits = 0;
            this.playerAIHits = 0;

            for (int i = 0; i < 7; i++)
            {
                
                player1Square[i] = new GridSquare[7];
                playerAISquare[i] = new GridSquare[7];
                for (int j = 0; j < 7; j++)
                {
                    player1Square[i][j] = new GridSquare();
                    playerAISquare[i][j] = new GridSquare();
                }
                
            }
            /* Create the AI Grid */
            ai.generateGrid();
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

        public bool placePieceOnAIGrid(Ship ship, int x, int y, int dx, int dy)
        {
            return placePieceOnGrid(playerAISquare, ship, x, y, dx, dy);
        }
        public bool placePieceOnPlayerOneGrid(Ship ship, int x, int y, int dx, int dy)
        {
            return placePieceOnGrid(player1Square, ship, x, y, dx, dy);
        }

        private bool placePieceOnGrid(GridSquare[][] square, Ship ship, int x, int y, int dx, int dy)
        {
            /* Verify the piece will stay within the grid */
            if((x + ship.getSize()*dx > 7) || (y + ship.getSize() * dy > 7))
            {
                return false;
            }

            /* verify the piece doesn't overlap others */
            for(int i = 0; i < ship.getSize(); i += 1)
            {
                if(square[x + (i * dx)][y + (i * dy)].getShip() != Ships.NONE)
                {
                    return false;
                }
            }
            for(int i = 0; i < ship.getSize(); i += 1)
            {
                square[x + (i * dx)][y + (i * dy)].setShip(new Ship(ship, i, new int[2] {dx, dy}));
            }
            return true;
        }

        public bool sankAIBattleship(int x, int y)
        {
            return sankBattleship(playerAISquare, x, y);
        }

        public bool sankBattleship(GridSquare[][] board, int x, int y)
        {
            Ship ship = board[x][y].getShip();
            if (ship == Ships.NONE)
            {
                return false;
            }
            int[] shipDirection = ship.getDirection();
            int startX = x - shipDirection[0] * ship.getShipPiece();
            int startY = y - shipDirection[1] * ship.getShipPiece();

            /* Check if the whole ship is hit */
            for(int i = 0; i < ship.getSize(); i += 1)
            {
                if(!board[startX + (i * shipDirection[0])][startY + (i * shipDirection[1])].isHit())
                {
                    return false;
                }
            }
            return true;
        }

        public bool hitAISquare(int x, int y)
        {
            Tuple<bool, int> hitRet = hitSquare(playerAISquare, x, y);
            playerAIHits += hitRet.Item2;
            return hitRet.Item1;
        }

        private Tuple<bool, int> hitSquare(GridSquare[][] board, int x, int y)
        {
            if (playerAISquare[x][y].isHit() == true)
            {
                return new Tuple<bool, int>(false, 0);
            }

            playerAISquare[x][y].setHit(true);
            if (playerAISquare[x][y].getShip() != Ships.NONE)
            {
                return new Tuple<bool, int>(true, 1);
            }
            return new Tuple<bool, int>(true, 0);

            
        }


        public int checkWin()
        {
            int numSquaresToHit = 0;
            for(int i = 0; i < Ships.shipList.Length; i += 1)
            {
                numSquaresToHit += Ships.shipList[i].getSize() * Ships.shipList[i].getNumShips();
            }
            if(player1Hits == numSquaresToHit)
            {
                return -1;
            }
            if (playerAIHits == numSquaresToHit)
            {
                return 1;
            }
            return 0;
        }

    }
}
