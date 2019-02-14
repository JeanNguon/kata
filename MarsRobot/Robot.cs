using System;

namespace MarsRobot
{
    internal class Robot
    {
        private IDirection direction;
        private Position position;

        public Robot(IDirection direction, Position position)
        {
            this.direction = direction;
            this.position = position;
        }

        public string Execute(string instructions)
        {
            foreach (char instruction in instructions)
            {
                if (instruction == 'L')
                {
                    this.direction = this.direction.RotateLeft();
                }

                if (instruction == 'R')
                {
                    this.direction = this.direction.RotateRight();
                }

                if (instruction == 'F')
                {
                    this.position = this.direction.MoveForward(this.position);
                }
            }

            return $"{this.position}:{this.direction}";
        }
    }
}