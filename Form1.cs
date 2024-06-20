namespace snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeSnake();
        }

        public List<List<Panel>> Field = new List<List<Panel>>();

        public Point Head = new Point();
        public Point Fruit = new Point();
        public Point Clear = new Point();
        public int Length = -1;

        public Direction MovingDirection = Direction.None;
        public Direction NextDirection = Direction.None;
        public List<Direction> MovingLog = new List<Direction>();

        public Color FieldColor = Color.White;
        public Color SnakeColor = Color.Green;
        public Color FruitColor = Color.Red;
        public Color ClearColor = Color.White;

        public void InitializeSnake()
        {
            Random random = new Random();

            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                List<Panel> Line = new List<Panel>();

                for (int j = 0; j < tableLayoutPanel1.RowCount; j++)
                {
                    Panel panel = new Panel();
                    panel.BackColor = FieldColor;
                    panel.Dock = DockStyle.Fill;

                    tableLayoutPanel1.Controls.Add(panel, i, j);
                    Line.Add(panel);
                }

                Field.Add(Line);
            }

            Head.X = random.Next(0, tableLayoutPanel1.ColumnCount);
            Head.Y = random.Next(0, tableLayoutPanel1.RowCount);
            Field[Head.X][Head.Y].BackColor = SnakeColor;

            Clear.X = Head.X;
            Clear.Y = Head.Y;

            NewFruit();
        }

        public void EndGame()
        {
            timer1.Enabled = false;
            MessageBox.Show("score: " + Length.ToString());
        }

        public void NewFruit()
        {
            Random random = new Random();
            List<Point> Empty = new List<Point>();

            Length++;

            for (int i = 0; i < Field.Count; i++)
            {
                for (int j = 0; j < Field[i].Count; j++)
                {
                    if (Field[i][j].BackColor != SnakeColor)
                    {
                        Empty.Add(new Point(i, j));
                    }
                }
            }

            if (Empty.Count > 0)
            {
                Fruit = Empty[random.Next(Empty.Count)];

                Field[Fruit.X][Fruit.Y].BackColor = FruitColor;
            }
            else EndGame();
        }

        public void MoveSnake()
        {
            MovingDirection = NextDirection;

            Head += MovingDirection;

            MovingLog.Add(MovingDirection);
        }

        public void MoveClear()
        {
            Clear += MovingLog[0];

            MovingLog.RemoveAt(0);

            if (Clear != Head)
            {
                Field[Clear.X][Clear.Y].BackColor = ClearColor;
            }
        }

        public bool CheckForCollision()
        {
            if (Head.X < 0 || Head.Y < 0 || Head.X >= tableLayoutPanel1.ColumnCount || Head.Y >= tableLayoutPanel1.RowCount) return true;

            if (Head.X == Clear.X && Head.Y == Clear.Y) return false;

            return Field[Head.X][Head.Y].BackColor == SnakeColor && Head != Clear + MovingLog[0];
        }

        public void NextFrame(object sender, EventArgs e)
        {
            MoveSnake();

            if (CheckForCollision()) EndGame();
            else
            {
                Field[Head.X][Head.Y].BackColor = SnakeColor;

                if (Head == Fruit) NewFruit();
                else MoveClear();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: NextDirection = MovingDirection != Direction.Down ? Direction.Up : Direction.Down; break;
                case Keys.Down: NextDirection = MovingDirection != Direction.Up ? Direction.Down : Direction.Up; break;
                case Keys.Left: NextDirection = MovingDirection != Direction.Right ? Direction.Left : Direction.Right; break;
                case Keys.Right: NextDirection = MovingDirection != Direction.Left ? Direction.Right : Direction.Left; break;
            }

            if (timer1.Enabled == false)
            {
                Clear -= NextDirection;

                MovingLog.Add(NextDirection);

                timer1.Enabled = true;
            }
        }
    }

    public enum Direction { Up, Down, Left, Right, None };

    public class Point
    {
        public int X = 0;
        public int Y = 0;

        public Point() { }

        public Point(int x, int y) { X = x; Y = y; }

        public static Point operator +(Point B, Direction D)
        {
            switch (D)
            {
                case Direction.Up: return new Point(B.X, B.Y - 1);
                case Direction.Down: return new Point(B.X, B.Y + 1);
                case Direction.Left: return new Point(B.X - 1, B.Y);
                case Direction.Right: return new Point(B.X + 1, B.Y);
                default: return B;
            }
        }

        public static Point operator -(Point B, Direction D)
        {
            switch (D)
            {
                case Direction.Up: return new Point(B.X, B.Y + 1);
                case Direction.Down: return new Point(B.X, B.Y - 1);
                case Direction.Left: return new Point(B.X + 1, B.Y);
                case Direction.Right: return new Point(B.X - 1, B.Y);
                default: return B;
            }
        }

        public static bool operator !=(Point A, Point B) => A.X != B.X || A.Y != B.Y;

        public static bool operator == (Point A, Point B) => A.X == B.X && A.Y == B.Y;

        public override bool Equals(object? obj) => base.Equals(obj);

        public override int GetHashCode() => base.GetHashCode();
    }
}
