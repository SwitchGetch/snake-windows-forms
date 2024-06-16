namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeSnake();
        }

        public List<List<Panel>> Field = new List<List<Panel>>();

        public Block Head = new Block();
        public List<Block> Tail = new List<Block>();

        public Block Fruit = new Block();

        public Direction MovingDirection = Direction.None;

        Random random = new Random();

        public void InitializeSnake()
        {
            Head.X = random.Next(0, 19);
            Head.Y = random.Next(0, 19);
            Head.FillColor = Color.Green;

            Fruit.X = random.Next(0, 19);
            Fruit.Y = random.Next(0, 19);
            Fruit.FillColor = Color.Red;

            while (Fruit.X == Head.X && Fruit.Y == Head.Y)
            {
                Fruit.X = random.Next(0, 19);
                Fruit.Y = random.Next(0, 19);
            }

            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                List<Panel> Line = new List<Panel>();

                for (int j = 0; j < tableLayoutPanel1.RowCount; j++)
                {
                    Panel panel = new Panel();
                    panel.Dock = DockStyle.Fill;

                    tableLayoutPanel1.Controls.Add(panel, i, j);
                    Line.Add(panel);
                }

                Field.Add(Line);
            }
        }

        public void OutputSnake()
        {
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                tableLayoutPanel1.Controls[i].BackColor = Color.White;
            }

            Field[Head.X][Head.Y].BackColor = Head.FillColor;
            Field[Fruit.X][Fruit.Y].BackColor = Fruit.FillColor;

            for (int i = 0; i < Tail.Count; i++)
            {
                Field[Tail[i].X][Tail[i].Y].BackColor = Tail[i].FillColor;
            }
        }

        public void MoveSnake()
        {
            switch (MovingDirection)
            {
                case Direction.Up:

                    Head.Y--;

                    break;

                case Direction.Down:

                    Head.Y++;

                    break;

                case Direction.Left:

                    Head.X--;

                    break;

                case Direction.Right:

                    Head.X++;

                    break;
            }
        }

        public bool CheckForCollision()
        {
            return false;
        }

        public void ChooseDirection(object sender, EventArgs e)
        {
            if (CheckForCollision() == false)
            {
                MoveSnake();

                OutputSnake();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            switch (e.KeyCode)
            {
                case Keys.Up:

                    MovingDirection = Direction.Up;

                    break;

                case Keys.Down:

                    MovingDirection = Direction.Down;

                    break;

                case Keys.Left:

                    MovingDirection = Direction.Left;

                    break;

                case Keys.Right:

                    MovingDirection = Direction.Right;

                    break;
            }
        }

        public enum Direction
        {
            Up, Down, Left, Right, None
        }
    }


    public class Block
    {
        public int X;
        public int Y;

        public Color FillColor;
    }
}
