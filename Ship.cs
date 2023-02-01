using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    internal class Ship
    {
        int numShips = 0;
        int size = 0;
        int shipPiece = 0;
        Image[] shipImage = null;
        Image thumbnailImage = null;
        String shipName = "";
        public Ship(int numShips, int size, Image[] shipImage, Image thumbnailImage, string shipName)
        {
            this.numShips = numShips;
            this.size = size;
            this.shipImage = shipImage;
            this.shipName = shipName;
            this.thumbnailImage = thumbnailImage;
            this.shipPiece = 0;
        }

        public Ship (Ship baseShip, int shipPiece)
        {
            this.numShips = baseShip.numShips;
            this.size = baseShip.size;
            this.shipImage = baseShip.shipImage;
            this.shipName = baseShip.shipName;
            this.shipPiece = shipPiece;
        }

        public Image getImage()
        {
            return shipImage[shipPiece];
        }

        public Image getThumbnailImage()
        {
            return thumbnailImage;
        }

        public int getSize()
        {
            return this.size;
        }

        public int getNumShips()
        {
            return this.numShips;
        }

        public static bool operator ==(Ship ship1, Ship ship2)
        {
            /* This allows ships with different shipPiece variables to be equal */
            return (ship1.shipName == ship2.shipName);
        }


        public static bool operator !=(Ship ship1, Ship ship2)
        {
            return !(ship1 == ship2);
        }

    }
}
