using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMovingFurniture.Furnitures
{
    public abstract class Furniture : IMovable
    {
        public String Name { get; private set; }
        public Location Location { get; private set; }

        private Location SetLocation(int x, int y)
        {
            return new Location(x, y);
        }

        public Furniture(string name, int x, int y)
        {
            this.Name = name;
            this.Location = SetLocation(x, y);
        }

        //hook
        public virtual void BeforeMoveing() { }

        public virtual void Move(int x, int y)
        {
            this.BeforeMoveing();

            this.Location = SetLocation(x, y);

            this.AfterMoveing();
        }

        //hook
        public virtual void AfterMoveing() { }

    }
}
