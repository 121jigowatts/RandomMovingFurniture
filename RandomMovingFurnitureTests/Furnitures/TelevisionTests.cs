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
    public class TelevisionTests
    {
        [TestMethod]
        public void TelevisionNameTest()
        {
            var target = new Television("TV", 1, 1);
            var expected = "TV";
            var actual = target.Name;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TelevisionLocationTest()
        {
            var target = new Television("TV", 1, 1);
            var expected = "(1,1)";
            var actual = target.Location.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TelevisionPowerTest()
        {
            var target = new Television("TV", 1, 1);
            var expected = Power.On;
            var actual = target.Power;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BeforeMoveingTest()
        {
            var target = new Television("TV", 1, 1);
            var expected = Power.Off;
            target.BeforeMoveing();
            var actual = target.Power;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MoveTest()
        {
            var target = new Television("TV", 1, 1);
            var expected = new Location(2, 2).ToString();
            target.Move(2, 2);
            var actual = target.Location.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}