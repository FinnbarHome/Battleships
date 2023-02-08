using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    [Serializable]
    public class GridSquare
    {
        Ship ship = Ships.NONE;
        bool hit = false;

        public GridSquare()
        {
            ship = Ships.NONE;
            hit = false;
        }

        public void setShip(Ship ship)
        {
            this.ship = ship;
        }
        public Ship getShip()
        {
            return this.ship;
        }

        public void setHit(bool hit)
        {
            this.hit = hit;
        }
        public bool isHit()
        {
            return this.hit;
        }
    }
}
