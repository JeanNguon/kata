using System;

namespace MarsRobot
{
    internal class Robot
    {
        private IDirection direction;

        public Robot()
        {
            this.direction = new NorthDirection();
        }

        public string Execute(string instructions)
        {
            foreach(char instruction in instructions)
            {
                if (instruction == 'L')
                {
                    this.direction = this.direction.RotateLeft();
                }

                if (instruction == 'R')
                {
                    this.direction = this.direction.RotateRight();
                }
            }

            return "0:0:" + this.direction;
        }
    }

    internal interface IDirection
    {
        IDirection RotateLeft();
        IDirection RotateRight();
    }

    internal class NorthDirection : IDirection
    {
        public IDirection RotateLeft() => new WestDirection();

        public IDirection RotateRight() => new EastDirection();

        public override string ToString() => "N";
    }

    internal class WestDirection : IDirection
    {
        public IDirection RotateLeft() => new SouthDirection();

        public IDirection RotateRight() => new NorthDirection();

        public override string ToString() => "W";

    }

    internal class EastDirection : IDirection
    {
        public IDirection RotateLeft() => new NorthDirection();

        public IDirection RotateRight() => new SouthDirection();

        public override string ToString() => "E";

    }

    internal class SouthDirection : IDirection
    {
        public IDirection RotateLeft() => new EastDirection();

        public IDirection RotateRight() => new WestDirection();

        public override string ToString() => "S";

    }
}