using System;

namespace ToyRobot
{
    public class Simulator
    {
        public Simulator(Table table)
        {
            this.Surface = table;
        }

        public void Place(Int32 east, Int32 north, String direction)
        {
            if (this.Surface.IsValidLocation(east, north))
            {
                this.Toy = new Robot
                {
                    direction = direction.ToLower(),
                    east = east,
                    north = north
                };
            }
        }

        public String Report()
        {
            return this.Toy.Report();
        }

        public void RobotMoves(String movement)
        {
            switch (movement)
            {
                case "move":
                    if (this.Surface.IsValidLocation(this.Toy.east + 1, this.Toy.north + 1)
                        && this.Surface.IsValidLocation(this.Toy.east - 1, this.Toy.north - 1))
                    {
                        this.Toy.Move();
                    }

                    break;
                case "right":
                    this.Toy.TurnRight();
                    break;
                case "left":
                    this.Toy.TurnLeft();
                    break;
            }
        }

        public Table Surface;
        public Robot Toy;
    }
}