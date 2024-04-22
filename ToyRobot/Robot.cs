using System;

namespace ToyRobot
{
    public class Robot
    {
        public void Move()
        {
            switch (this.direction)
            {
                case "east":
                    this.east += 1;
                    break;
                case "west":
                    this.east -= 1;
                    break;
                case "north":
                    this.north += 1;
                    break;
                case "south":
                    this.north -= 1;
                    break;
            }
        }

        public String Report()
        {
            return this.east + "," + this.north + "," + this.direction.ToUpper();
        }

        public void TurnLeft()
        {
            switch (this.direction)
            {
                case "east":
                    this.direction = "north";
                    break;
                case "west":
                    this.direction = "south";
                    break;
                case "north":
                    this.direction = "west";
                    break;
                case "south":
                    this.direction = "east";
                    break;
            }
        }

        public void TurnRight()
        {
            switch (this.direction)
            {
                case "east":
                    this.direction = "south";
                    break;
                case "west":
                    this.direction = "north";
                    break;
                case "north":
                    this.direction = "east";
                    break;
                case "south":
                    this.direction = "west";
                    break;
            }
        }

        public String direction;
        public Int32 east;
        public Int32 north;
    }
}