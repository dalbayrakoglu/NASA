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

            Assert.Equals(rover.GetX(), 0);
            Assert.Equals(rover.GetY(), 1);
        }
    }
}
