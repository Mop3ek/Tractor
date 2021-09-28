using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring.Tests
{
    /// <summary>
    /// Обшие тесты
    /// </summary>
    [TestClass]
    public class CommonTest
    {
        [TestMethod]
        public void TestCommonMove()
        {
            Stone stone = new Stone();
            List<object> objects = new List<object> { new Wind(), new Stone(), new Tractor()};
            
            foreach (IVehicle item in objects.OfType<IVehicle>())
            {
                item.Move("T");
                item.Move("F");
                Assert.AreEqual(1, item.GetPositionX());
                Assert.AreEqual(0, item.GetPositionY());

                item.Move("T");
                item.Move("F");
                Assert.AreEqual(1, item.GetPositionX());
                Assert.AreEqual(-1, item.GetPositionY());

                item.Move("T");
                item.Move("F");
                Assert.AreEqual(0, item.GetPositionX());
                Assert.AreEqual(-1, item.GetPositionY());

                item.Move("T");
                item.Move("F");
                Assert.AreEqual(0, item.GetPositionX());
                Assert.AreEqual(0, item.GetPositionY());
            }
        }

        [TestMethod]
        public void TestCommonTurn()
        {
            List<object> objects = new List<object> { new Wind(), new Stone(), new Tractor() };
            foreach (IRotatable item in objects.OfType<IRotatable>())
            {
                item.TurnClockwise();
                Assert.AreEqual(Orientation.East, item.Orientation);
                
                item.TurnClockwise();
                Assert.AreEqual(Orientation.South, item.Orientation);

                item.TurnClockwise();
                Assert.AreEqual(Orientation.West, item.Orientation);

                item.TurnClockwise();
                Assert.AreEqual(Orientation.North, item.Orientation);
            }
        }
    }
}
