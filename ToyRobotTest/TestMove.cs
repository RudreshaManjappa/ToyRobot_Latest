using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot;

namespace ToyRobotTest
{
    [TestClass]
    public class TestMove
    {
        [TestMethod]
        public void MoveFourTimesEast()
        {
            var toy = new Robot { direction = "east" };

            toy.Move();
            toy.Move();
            toy.Move();
            toy.Move();

            Assert.AreEqual(4, toy.east);
        }

        [TestMethod]
        public void MoveFourTimesNorth()
        {
            var toy = new Robot { direction = "north" };

            toy.Move();
            toy.Move();
            toy.Move();
            toy.Move();

            Assert.AreEqual(4, toy.north);
        }

        [TestMethod]
        public void MoveFourTimesSouth()
        {
            var toy = new Robot { direction = "south" };

            toy.Move();
            toy.Move();
            toy.Move();
            toy.Move();

            Assert.AreEqual(-4, toy.north);
        }

        [TestMethod]
        public void MoveFourTimesWest()
        {
            var toy = new Robot { direction = "west" };

            toy.Move();
            toy.Move();
            toy.Move();
            toy.Move();

            Assert.AreEqual(-4, toy.east);
        }

        [TestMethod]
        public void MoveThreeTimesEast()
        {
            var toy = new Robot { direction = "east" };

            toy.Move();
            toy.Move();
            toy.Move();

            Assert.AreEqual(3, toy.east);
        }

        [TestMethod]
        public void MoveThreeTimesNorth()
        {
            var toy = new Robot { direction = "north" };

            toy.Move();
            toy.Move();
            toy.Move();

            Assert.AreEqual(3, toy.north);
        }

        [TestMethod]
        public void MoveThreeTimesSouth()
        {
            var toy = new Robot { direction = "south" };

            toy.Move();
            toy.Move();
            toy.Move();

            Assert.AreEqual(-3, toy.north);
        }

        [TestMethod]
        public void MoveThreeTimesWest()
        {
            var toy = new Robot { direction = "west" };

            toy.Move();
            toy.Move();
            toy.Move();

            Assert.AreEqual(-3, toy.east);
        }

        [TestMethod]
        public void WhenFacingEastTurnLeft()
        {
            var toy = new Robot { direction = "east" };

            toy.TurnLeft();

            Assert.AreEqual("north", toy.direction);
        }

        [TestMethod]
        public void WhenFacingEastTurnRight()
        {
            var toy = new Robot { direction = "east" };

            toy.TurnRight();

            Assert.AreEqual("south", toy.direction);
        }

        [TestMethod]
        public void WhenFacingNorthTurnLeft()
        {
            var toy = new Robot { direction = "north" };

            toy.TurnLeft();

            Assert.AreEqual("west", toy.direction);
        }

        [TestMethod]
        public void WhenFacingNorthTurnRight()
        {
            var toy = new Robot { direction = "north" };

            toy.TurnRight();

            Assert.AreEqual("east", toy.direction);
        }

        [TestMethod]
        public void WhenFacingSouthTurnLeft()
        {
            var toy = new Robot { direction = "south" };

            toy.TurnLeft();

            Assert.AreEqual("east", toy.direction);
        }

        [TestMethod]
        public void WhenFacingSouthTurnRight()
        {
            var toy = new Robot { direction = "south" };

            toy.TurnRight();

            Assert.AreEqual("west", toy.direction);
        }

        [TestMethod]
        public void WhenFacingWestTurnLeft()
        {
            var toy = new Robot { direction = "west" };

            toy.TurnLeft();

            Assert.AreEqual("south", toy.direction);
        }

        [TestMethod]
        public void WhenFacingWestTurnRight()
        {
            var toy = new Robot { direction = "west" };

            toy.TurnRight();

            Assert.AreEqual("north", toy.direction);
        }
    }
}