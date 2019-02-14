namespace MarsRobot
{
    internal class SouthDirection : IDirection
    {
        public IDirection RotateLeft() => new EastDirection();

        public IDirection RotateRight() => new WestDirection();

        public Position MoveForward(Position position)
        {
            return new Position(position.X, position.Y - 1);
        }

        public override string ToString() => "S";
    }
}