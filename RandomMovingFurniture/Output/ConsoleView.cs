using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMovingFurniture.Output
{
    class ConsoleView : IDisplayable
    {
        public void Display(string content)
        {
            Console.WriteLine(content);
        }
    }
}
