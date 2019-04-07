using RandomMovingFurniture.Furnitures;
using RandomMovingFurniture.Output;
using RandomMovingFurniture.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMovingFurniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new MovingFurnitureService(new ConsoleView());

            var furnitures = new List<Furniture>() {
                new Television("TV", 1, 1),
                new Shelf("Shelf", 2, 2),
                new Table("Table", 3, 3),
            };

            service.Move(furnitures);
            Console.ReadLine();

        }
    }
}
