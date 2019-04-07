using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomMovingFurniture.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMovingFurniture.Furnitures.Tests
{
    [TestClass()]
    public class LocationTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            int x = 1;
            int y = 1;
            var target = new Location(x , y);
            var expected = "(1,1)";
            var actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}