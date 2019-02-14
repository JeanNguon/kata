namespace MarsRobot
{
    internal class EastDirection : IDirection
    {
        public IDirection RotateLeft() => new NorthDirection();

        public IDirection RotateRight() => new SouthDirection();

        public Position MoveForward(Position position)
        {
            return new Position(position.X + 1, position.Y);
        }

        public override string ToString() => "E";
    }
}