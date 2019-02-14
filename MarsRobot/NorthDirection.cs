namespace MarsRobot
{
    internal class NorthDirection : IDirection
    {
        public IDirection RotateLeft() => new WestDirection();

        public IDirection RotateRight() => new EastDirection();

        public Position MoveForward(Position position)
        {
            return new Position(position.X, position.Y + 1);
        }

        public override string ToString() => "N";
    }
}