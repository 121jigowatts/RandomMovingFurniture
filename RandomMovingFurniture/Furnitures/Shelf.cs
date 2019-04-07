using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMovingFurniture.Furnitures
{
    public class Shelf : Furniture, IMovable
    {
        public Shelf(string name, int x, int y) 
            : base(name, x, y)
        {
        }
    }
}
