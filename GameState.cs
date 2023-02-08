using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Battleships
{
    [Serializable]
    public enum Difficulty
    {
        EASY,
        MEDIUM,
        HARD,
        TWOPLAYER // If two player game
    };

    [Serializable]
    public class GameState
    {
        public Difficulty difficulty;
        public AIPlayer player2;
        public GridSquare[][] player1Square = new GridSquare[10][];
        public GridSquare[][] player2Square = new GridSquare[10][];
        int player1Hits = 0;
        int player2Hits = 0;

        public GameState(Difficulty difficulty)
        {
            /* Initialise Variables */
            player2 = new AIPlayer(this, difficulty);
            this.difficulty = difficulty;
            this.player1Hits = 0;
            this.player2Hits = 0;

            for (int i = 0; i < player1Square.Length; i++)
            {
                
                player1Square[i] = new GridSquare[10];
                player2Square[i] = new GridSquare[10];
                for (int j = 0; j < player1Square[i].Length; j++)
                {
                    player1Square[i][j] = new GridSquare();
                    player2Square[i][j] = new GridSquare();
                }
                
            }
            if(difficulty == Difficulty.TWOPLAYER)
            {
                player2.generatePlayer1Grid();
            }
            /* Create the Second Players Grid */
            player2.generatePlayer2Grid();
        }

        public bool saveToFile(String filename)
        {
            /* https://www.c-sharpcorner.com/article/serializing-objects-in-C-Sharp/ */
            bool retVal = false;
            FileStream f = null;
            try
            {
                f = File.Open(filename, FileMode.Create);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(f, this);
                retVal = true;
            }
            catch(Exception)
            {
            }
            finally
            {
                if(f != null)
                {
                    f.Close();
                }
            }
            return retVal;
        }

        public static GameState loadFromFile(String filename)
        {
            /* https://www.c-sharpcorner.com/article/serializing-objects-in-C-Sharp/ */
            FileStream f = null;
            GameState newGamestate = null;
            try
            {
                f = File.Open(filename, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                newGamestate = (GameState)b.Deserialize(f);
            }
            catch (Exception)
            {
            }
            finally
            {
                if (f != null)
                {
                    f.Close();
                }
            }
            return newGamestate;
        } 

        /* Get a specific Square from the Player 1 Grid */
            public GridSquare getPlayer1Square(int x, int y)
        {
            return player1Square[x][y];
        }
        /* Get a specific Square from the Player 2 Grid */
        public GridSquare getPlayer2Square(int x, int y)
        {
            return player2Square[x][y];
        }

        public bool placePieceOnPlayerTwoGrid(Ship ship, int x, int y, int dx, int dy)
        {
            return placePieceOnGrid(player2Square, ship, x, y, dx, dy);
        }
        public bool placePieceOnPlayerOneGrid(Ship ship, int x, int y, int dx, int dy)
        {
            return placePieceOnGrid(player1Square, ship, x, y, dx, dy);
        }

        private bool placePieceOnGrid(GridSquare[][] square, Ship ship, int x, int y, int dx, int dy)
        {
            /* Verify the piece will stay within the grid */

            /* Note dx = 0 if the ship is vertical, dy = 0 if ship is horizontal */
            if((x + ship.getSize()*dx > 10) || (y + ship.getSize() * dy > 10))
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
            /* Set the ship on the given pieces to our new ship */
            for(int i = 0; i < ship.getSize(); i += 1)
            {
                square[x + (i * dx)][y + (i * dy)].setShip(new Ship(ship, i, new int[2] {dx, dy}));
            }
            return true;
        }

        public bool sankPlayer1Battleship(int x, int y)
        {
            return sankBattleship(player1Square, x, y);
        }

        public bool sankPlayer2Battleship(int x, int y)
        {
            return sankBattleship(player2Square, x, y);
        }

        public bool sankBattleship(GridSquare[][] board, int x, int y)
        {
            /* If we hit a square with no ship we've sank nothing. */
            Ship ship = board[x][y].getShip();
            if (ship == Ships.NONE)
            {
                return false;
            }
            int[] shipDirection = ship.getDirection();

            /* Use the ship direction and the piece of the ship we have to find the start of the ship */
           
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

        public bool hitPlayer1Square(int x, int y)
        {
            Tuple<bool, int> hitRet = hitSquare(player1Square, x, y);
            player1Hits += hitRet.Item2;
            /* Return whether or not the hit was successful */
            return hitRet.Item1;
        }


        public bool hitPlayer2Square(int x, int y)
        {
            Tuple<bool, int> hitRet = hitSquare(player2Square, x, y);
            player2Hits += hitRet.Item2;
            /* Return whether or not the hit was successful */
            return hitRet.Item1;
        }

        private Tuple<bool, int> hitSquare(GridSquare[][] board, int x, int y)
        {
            /* Don't hit a already hit square */
            if (board[x][y].isHit() == true)
            {
                return new Tuple<bool, int>(false, 0);
            }
            /* Hit the square */
            board[x][y].setHit(true);

            /* If the square has a ship then we've hit one of the players pieces, so return this, along with the fact our hit was successful */
            if (board[x][y].getShip() != Ships.NONE)
            {
                return new Tuple<bool, int>(true, 1);
            }
            /* Otherwise we've got rid of 0 pieces */
            return new Tuple<bool, int>(true, 0);

            
        }


        public int checkWin()
        {
            /* Count up how many pieces we need to hit in order to win */
            int numSquaresToHit = 0;
            for(int i = 0; i < Ships.shipList.Length; i += 1)
            {
                numSquaresToHit += Ships.shipList[i].getSize() * Ships.shipList[i].getNumShips();
            }
            /* If player 1 has had all his ships hit return -1 */
            if(player1Hits == numSquaresToHit)
            {
                return -1;
            }
            /* If player 2 has had all his ships hit return 1 */
            if (player2Hits == numSquaresToHit)
            {
                return 1;
            }
            /* If the game is unfinished return 0 */
            return 0;
        }

        //Prints board, for debugging purposes
        public void printBoard(GridSquare[][] board)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //Stores the particular square on the board we want to target
                    GridSquare gridValue = board[j][i];

                    //Stores the ship value at this square
                    Ship ship = gridValue.getShip();

                    //If is has a hit ship
                    if (gridValue.isHit() == true && ship != Ships.NONE)
                    {
                        Console.Write("F");
                    }

                    //If tile is empty
                    else if (gridValue.isHit() == false && ship == Ships.NONE)
                    {
                        Console.Write("0");
                    }

                    //If tile has an empty ship on it bu has not been hit
                    else if (gridValue.isHit() == false && ship != Ships.NONE)
                    {
                        Console.Write("S");
                    }

                    //If tile is empty but has been shot at
                    else if (gridValue.isHit() == true && ship == Ships.NONE)
                    {
                        Console.Write("X");
                    }

                    else
                    {
                        Console.Write("ERROR");
                    }

                    Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
}
