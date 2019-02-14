namespace MarsRobot
{
    public class Position
    {
        public static Position Origin = new Position(0, 0);

        public int X { get; }

        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{this.X}:{this.Y}";
        }
    }
}