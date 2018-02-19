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
            Rover rover = new Rover(0, 0, new Compass('N'));

            rover.ExecuteOrder("F");

            Assert.AreEqual(rover.GetX(), 0);
            Assert.AreEqual(rover.GetY(), 1);
        }

        [TestMethod]
        public void ExecuteOrder_Backward_5_4()
        {
            Rover rover = new Rover(5, 5, new Compass('N'));

            rover.ExecuteOrder("B");

            Assert.AreEqual(rover.GetX(), 5);
            Assert.AreEqual(rover.GetY(), 4);
        }

        [TestMethod]
        public void ExecuteOrder_MultipleBackForward_5_6()
        {
            Rover rover = new Rover(5, 5, new Compass('N'));

            rover.ExecuteOrder("BBFFF");

            Assert.AreEqual(rover.GetX(), 5);
            Assert.AreEqual(rover.GetY(), 6);
        }

        [TestMethod]
        public void ExecuteOrder_MultipleBackForwardFacingSouth_5_4()
        {
            Rover rover = new Rover(5, 5, new Compass('S'));

            rover.ExecuteOrder("BBFFF");

            Assert.AreEqual(rover.GetX(), 5);
            Assert.AreEqual(rover.GetY(), 4);
        }

        [TestMethod]
        public void ExecuteOrder_MultipleBackForwardFacingEast_6_5()
        {
            Rover rover = new Rover(5, 5, new Compass('E'));

            rover.ExecuteOrder("BBFFF");

            Assert.AreEqual(rover.GetX(), 6);
            Assert.AreEqual(rover.GetY(), 5);
        }
        [TestMethod]
        public void ExecuteOrder_MultipleBackForwardFacingWest_4_5()
        {
            Rover rover = new Rover(5, 5, new Compass('W'));

            rover.ExecuteOrder("BBFFF");

            Assert.AreEqual(rover.GetX(), 4);
            Assert.AreEqual(rover.GetY(), 5);
        }

        [TestMethod]
        public void ExecuteOrder_TurnRight_East()
        {
            Rover rover = new Rover(5, 5, new Compass('N'));

            rover.ExecuteOrder("R");

            Assert.AreEqual(rover.GetDirection(), 'E');
        }

        [TestMethod]
        public void ExecuteOrder_TurnRight2_South()
        {
            Rover rover = new Rover(5, 5, new Compass('N'));

            rover.ExecuteOrder("RR");

            Assert.AreEqual(rover.GetDirection(), 'S');
        }

        [TestMethod]
        public void ExecuteOrder_TurnRight3_North()
        {
            Rover rover = new Rover(5, 5, new Compass('E'));

            rover.ExecuteOrder("RRR");

            Assert.AreEqual(rover.GetDirection(), 'N');
        }

        [TestMethod]
        public void ExecuteOrder_TurnLeft5_South()
        {
            Rover rover = new Rover(5, 5, new Compass('W'));

            rover.ExecuteOrder("LLLLL");

            Assert.AreEqual(rover.GetDirection(), 'S');
        }

        [TestMethod]
        public void ExecuteOrder_Mixed_South()
        {
            Rover rover = new Rover(5, 5, new Compass('W'));

            rover.ExecuteOrder("LLLLL");

            Assert.AreEqual(rover.GetDirection(), 'S');
        }



        [TestMethod]
        public void ExecuteOrder_InterviewExample_2_2_E()
        {
            Rover rover = new Rover(0, 0, new Compass('N'));

            rover.ExecuteOrder("FFRFF");

            Assert.AreEqual(rover.GetX(), 2);
            Assert.AreEqual(rover.GetY(), 2);
            Assert.AreEqual(rover.GetDirection(), 'E');
        }
    }
}
