using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pluto.UnitTests
{
    [TestClass]
    public class CompassTests
    {
        [TestMethod]
        public void GetDirection_InitWithNorth_N()
        {
            Compass compass = new Compass('N');

            Assert.AreEqual(compass.GetDirection(), 'N');
        }

        [TestMethod]
        public void TurnRight_InitWithNorth_E()
        {
            Compass compass = new Compass('N');

            compass.Turn('R');

            Assert.AreEqual(compass.GetDirection(), 'E');
        }


        [TestMethod]
        public void TurnLeft_InitWithEast_N()
        {
            Compass compass = new Compass('E');

            compass.Turn('L');

            Assert.AreEqual(compass.GetDirection(), 'N');
        }
    }
}
