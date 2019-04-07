using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMovingFurniture.Furnitures
{
    public class Table : Furniture, IMovable
    {
        public Table(string name, int x, int y) 
            : base(name, x, y)
        {
        }
    }
}
