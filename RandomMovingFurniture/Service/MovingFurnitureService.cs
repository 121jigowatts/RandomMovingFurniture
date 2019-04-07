using RandomMovingFurniture.Furnitures;
using RandomMovingFurniture.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMovingFurniture.Service
{
    class MovingFurnitureService
    {
        private readonly IDisplayable viewer;
        Random random = new Random();

        public MovingFurnitureService(IDisplayable viewer)
        {
            this.viewer = viewer;
        }

        public void Move(List<Furniture> furnitures)
        {
            foreach (var furniture in furnitures)
            {
                var furnitureName = furniture.Name;
                var beforeLocation = furniture.Location.ToString();
                furniture.Move(random.Next(1, 10), random.Next(1, 10));
                var afterLocation = furniture.Location.ToString();

                var content = String.Format($"{furnitureName}: {beforeLocation} -> {afterLocation}");
                viewer.Display(content);
            }
        }
    }
}
