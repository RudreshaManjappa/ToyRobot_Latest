using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot;

namespace ToyRobotTest
{
    [TestClass]
    public class TestReport
    {
        [TestMethod]
        public void ReportLocation()
        {
            var Toy = new Robot
            {
                direction = "north",
                east = 5,
                north = 4
            };

            var expected = "5,4,NORTH";

            var position = Toy.Report();

            Assert.AreEqual(expected, position);
        }
    }
}