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
    }
}
