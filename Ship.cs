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
        Image shipImage = null;
        String shipName = "";
        public Ship(int numShips, int size, Image shipImage, string shipName)
        {
            this.numShips = numShips;
            this.size = size;
            this.shipImage = shipImage;
            this.shipName = shipName;
        }
    }
}
