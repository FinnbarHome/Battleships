using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    internal class Ships
    {
        public static Ship NONE = new Ship(0, 1, new Image[1] { Properties.Resources.EmptySquare }, Properties.Resources.EmptySquare, "No ship");
        public static Ship AIRCRAFT_CARRIER = new Ship(1, 5, new Image[5] { Properties.Resources.ShipSquare, Properties.Resources.ShipSquare, Properties.Resources.ShipSquare, Properties.Resources.ShipSquare, Properties.Resources.ShipSquare }, Properties.Resources.ShipSquare, "Aircraft Carrier");
        public static Ship BATTLESHIP = new Ship(1, 4, new Image[4] { Properties.Resources.ShipSquare, Properties.Resources.ShipSquare, Properties.Resources.ShipSquare, Properties.Resources.ShipSquare }, Properties.Resources.ShipSquare, "Battleship");
        public static Ship CRUISER = new Ship(1, 3, new Image[3] { Properties.Resources.ShipSquare, Properties.Resources.ShipSquare, Properties.Resources.ShipSquare }, Properties.Resources.ShipSquare, "Cruiser");
        public static Ship DESTROYER = new Ship(2, 2, new Image[2] { Properties.Resources.ShipSquare, Properties.Resources.ShipSquare }, Properties.Resources.ShipSquare, "Destroyer");
        public static Ship SUBMARINE = new Ship(2, 1, new Image[1] { Properties.Resources.EmptySquare }, Properties.Resources.ShipSquare, "Submarine");
        public static Ship[] shipList = new Ship[5] {AIRCRAFT_CARRIER, BATTLESHIP, CRUISER, DESTROYER, SUBMARINE};
    }
}
