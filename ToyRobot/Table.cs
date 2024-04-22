using System;

namespace ToyRobot
{
    public class Table
    {
        public Table(Int32 width, Int32 length)
        {
            this.width = width;
            this.length = length;
        }

        public Boolean IsValidLocation(Int32 east, Int32 north)
        {
            return east >= 0 && east < this.width && north >= 0 && north < this.length;
        }

        public Int32 length;
        public Int32 width;
    }
}