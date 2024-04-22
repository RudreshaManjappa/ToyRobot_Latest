using System;
using System.Text.RegularExpressions;

namespace ToyRobot
{
    public class Command
    {
        public void ProcessCommand(String command)
        {
            if (Regex.IsMatch(command, "^PLACE"))
            {
                var coordinates = command.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (coordinates.Length == 4)
                {
                    Int32 east;
                    Int32 north;
                    var eastTest = Int32.TryParse(coordinates[1], out east);
                    var northTest = Int32.TryParse(coordinates[2], out north);
                    if (eastTest && northTest)
                    {
                        this.Simulation.Place(east, north, coordinates[3]);
                    }
                }

                if (this.Simulation.Toy == null)
                {
                    this.Message = this.ErrorInputs;
                }
            }
            else if (Regex.IsMatch(command, "^MOVE") || Regex.IsMatch(command, "^RIGHT") || Regex.IsMatch(command, "^LEFT"))
            {
                this.Simulation.RobotMoves(command.ToLower());
            }
            else if (Regex.IsMatch(command, "^REPORT"))
            {
                this.Message = this.Simulation.Report();
            }
            else
            {
                this.Message = this.ErrorInputs;
            }
        }

        public String Start(String[] commands)
        {
            this.Simulation = new Simulator(this.Table);
            foreach (var command in commands)
            {
                if (this.Placed)
                {
                    ProcessCommand(command);
                }
                else if (Regex.IsMatch(command, "[PLACE]"))
                {
                    this.Placed = true;
                    ProcessCommand(command);
                }

                if (this.Message == this.ErrorInputs)
                {
                    break;
                }

                if (this.Message.Length > 1)
                {
                    Console.WriteLine(this.Message);
                    this.Message = "";
                }
            }

            return this.Message;
        }

        public String ErrorInputs = "The inputs in the file are not correctly formatted.";
        public String Message = String.Empty;
        public Boolean Placed;
        public Simulator Simulation;
        public Table Table = new Table(5, 5);
    }
}