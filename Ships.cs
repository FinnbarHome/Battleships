using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    internal class Ships
    {
        public static Ship NONE = new Ship(0, 0, null, null, "No ship");
        public static Ship AIRCRAFT_CARRIER = new Ship(1, 5, null, null, "Aircraft Carrier");
        public static Ship BATTLESHIP = new Ship(1, 4, null, null, "Battleship");
        public static Ship CRUISER = new Ship(1, 3, null, null, "Cruiser");
        public static Ship DESTROYER = new Ship(2, 2, null, null, "Destroyer");
        public static Ship SUBMARINE = new Ship(2, 1, null, null, "Submarine");
    }
}
