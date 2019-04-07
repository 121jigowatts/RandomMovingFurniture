using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMovingFurniture.Furnitures
{
    public class Location
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return String.Format($"({X},{Y})");
        }
    }
}
