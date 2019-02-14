namespace MarsRobot
{
    internal interface IDirection
    {
        IDirection RotateLeft();

        IDirection RotateRight();

        Position MoveForward(Position position);
    }
}