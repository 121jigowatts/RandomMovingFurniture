using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMovingFurniture.Furnitures
{
    public class Television : Furniture, IMovable

    {
        public Power Power { get; private set; }

        public Television(string name, int x, int y) 
            : base(name, x, y)
        {
            Power = Power.On;
        }

        public override void BeforeMoveing()
        {
            base.BeforeMoveing();
            Power = Power.Off;
        }
    }
}
