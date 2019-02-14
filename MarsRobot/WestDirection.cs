namespace MarsRobot
{
    internal class WestDirection : IDirection
    {
        public IDirection RotateLeft() => new SouthDirection();

        public IDirection RotateRight() => new NorthDirection();

        public Position MoveForward(Position position)
        {
            return new Position(position.X - 1, position.Y);
        }

        public override string ToString() => "W";
    }
}