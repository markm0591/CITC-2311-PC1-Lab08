namespace CITC2311_PC1_Lab08
{
    public enum Direction
    {
        North,
        South,
        East,
        West
    }

    public class Robot
    {
        private int x;
        private int y;

        public Direction Direction { get; set; }

        public Point Position
        {
            get { return new Point(x, y); }
        }

        public event EventHandler? OutOfRange;

        public Robot()
        {
            x = 0;
            y = 0;
            Direction = Direction.North;
        }

        public void Move(int units)
        {
            int newX = x;
            int newY = y;

            if (Direction == Direction.North)
            {
                newY = y + units;
            }
            else if (Direction == Direction.South)
            {
                newY = y - units;
            }
            else if (Direction == Direction.East)
            {
                newX = x + units;
            }
            else if (Direction == Direction.West)
            {
                newX = x - units;
            }

            if (newX < -100 || newX > 100 || newY < -100 || newY > 100)
            {
                OutOfRange?.Invoke(this, EventArgs.Empty);
                return;
            }

            x = newX;
            y = newY;
        }
    }
}
