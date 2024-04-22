using System;
using System.IO;

namespace ToyRobot
{
    public class MainProgram
    {
        public String Commander(String[] commands)
        {
            var message = "";
            var obj = new Command();
            message = obj.Start(commands);
            return message;
        }

        private static void Main(String[] args)
        {
            // Automatically executes when application is started.
            var path = @"C:\Toytest\ToyRobottest.txt";
            if (File.Exists(path))
            {
                var commands = File.ReadAllLines(path);
                var main = new MainProgram();
                Console.WriteLine(main.Commander(commands));
                Console.Read();
            }
            else
            {
                Console.WriteLine("Not a .txt file. Please try again.");
                Console.Write(@"The correct command formats are as follows:
                PLACE X,Y,DIRECTION
                MOVE
                RIGHT
                LEFT
                REPORT
                -------------
                Please review your input file and try again.");
            }
        }
    }
}