using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pluto.UnitTests
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void ExecuteOrder_Forward_0_1()
        {
            Rover rover = new Rover(0, 0, 'N');

            rover.ExecuteOrder("F");

            Assert.AreEqual(rover.GetX(), 0);
            Assert.AreEqual(rover.GetY(), 1);
        }

        [TestMethod]
        public void ExecuteOrder_Backward_0_1()
        {
            Rover rover = new Rover(5, 5, 'N');

            rover.ExecuteOrder("B");

            Assert.AreEqual(rover.GetX(), 5);
            Assert.AreEqual(rover.GetY(), 4);
        }
    }
}
