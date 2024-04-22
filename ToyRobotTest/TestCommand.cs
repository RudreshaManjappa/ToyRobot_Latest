using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot;

namespace ToyRobotTest
{
    [TestClass]
    public class TestCommand
    {
        [TestMethod]
        public void ProcessInvalidCommand()
        {
            var testSetup = new Command();
            var table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("GIBBERISH");

            var expected = testSetup.ErrorInputs;

            Assert.AreEqual(expected, testSetup.Message);
        }

        [TestMethod]
        public void ProcessInvalidPlaceCommand()
        {
            var testSetup = new Command();
            var table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 6,3,EAST");

            Assert.AreSame(testSetup.ErrorInputs, testSetup.Message);
        }

        [TestMethod]
        public void ProcessLeftCommand()
        {
            var testSetup = new Command();
            var table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");
            testSetup.ProcessCommand("LEFT");

            var expected = new Robot { east = 2, north = 3, direction = "north" };

            Assert.AreEqual(expected.direction, testSetup.Simulation.Toy.direction);
        }

        [TestMethod]
        public void ProcessMoveCommand()
        {
            var testSetup = new Command();
            var table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");
            testSetup.ProcessCommand("MOVE");

            var expected = new Robot { east = 3, north = 3, direction = "east" };

            Assert.AreEqual(expected.east, testSetup.Simulation.Toy.east);
        }

        [TestMethod]
        public void ProcessMoveWallCommand()
        {
            var testSetup = new Command();
            var table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 4,4,EAST");
            testSetup.ProcessCommand("MOVE");

            var expected = new Robot { east = 4, north = 4, direction = "east" };

            Assert.AreEqual(expected.east, testSetup.Simulation.Toy.east);
        }

        [TestMethod]
        public void ProcessPlaceCommand()
        {
            var testSetup = new Command();
            var table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");

            Assert.IsNotNull(testSetup.Simulation.Toy);
        }

        [TestMethod]
        public void ProcessReportCommand()
        {
            var testSetup = new Command();
            var table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");
            testSetup.ProcessCommand("REPORT");

            var expected = "2,3,EAST";

            Assert.AreEqual(expected, testSetup.Message);
        }

        [TestMethod]
        public void ProcessRightCommand()
        {
            var testSetup = new Command();
            var table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");
            testSetup.ProcessCommand("RIGHT");

            var expected = new Robot { east = 2, north = 3, direction = "south" };

            Assert.AreEqual(expected.direction, testSetup.Simulation.Toy.direction);
        }
    }
}