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
     public Block Fruit = new Block();
     public Block Clear = new Block();
     public int Length = 0;

     public Direction MovingDirection = Direction.None;
     public Direction NextDirection = Direction.None;
     public List<Direction> MovingLog = new List<Direction>();

     public Color FieldColor = Color.White;
     public Color SnakeColor = Color.Green;
     public Color FruitColor = Color.Red;

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

         Field[0][0].BackColor = FieldColor;

         Head.X = random.Next(0, tableLayoutPanel1.ColumnCount - 1);
         Head.Y = random.Next(0, tableLayoutPanel1.RowCount - 1);
         Head.FillColor = SnakeColor;
         Field[Head.X][Head.Y].BackColor = Head.FillColor;

         Clear.X = Head.X;
         Clear.Y = Head.Y;
         Clear.FillColor = FieldColor;
         
         Fruit.FillColor = FruitColor;
         NewFruit();
     }

     public void EndGame()
     {
         timer1.Enabled = false;
         MessageBox.Show("score: " + (Length - 1).ToString());
     }

     public void NewFruit()
     {
         Random random = new Random();

         List<Block> Empty = new List<Block>();
         Block Temp = new Block();

         for (int i = 0; i < Field.Count; i++)
         {
             for (int j = 0; j < Field[i].Count; j++)
             {
                 if (Field[i][j].BackColor == FieldColor || i == Clear.X && j == Clear.Y)
                 {
                     Empty.Add(new Block() { X = i, Y = j });
                 }
             }
         }

         if (Empty.Count > 0)
         {
             Temp = Empty[random.Next(Empty.Count)];

             Fruit.X = Temp.X;
             Fruit.Y = Temp.Y;

             Field[Fruit.X][Fruit.Y].BackColor = Fruit.FillColor;

             Length++;
         }
     }

     public void OutputSnake()
     {
         Field[Clear.X][Clear.Y].BackColor = Clear.FillColor;

         Field[Fruit.X][Fruit.Y].BackColor = Fruit.FillColor;

         Field[Head.X][Head.Y].BackColor = Head.FillColor;
     }

     public void MoveSnake()
     {
         MovingDirection = NextDirection;

         switch (MovingDirection)
         {
             case Direction.Up:

                 MovingLog.Add(Direction.Up);
                 Head.Y--;

                 break;

             case Direction.Down:

                 MovingLog.Add(Direction.Down);
                 Head.Y++;

                 break;

             case Direction.Left:

                 MovingLog.Add(Direction.Left);
                 Head.X--;

                 break;

             case Direction.Right:

                 MovingLog.Add(Direction.Right);
                 Head.X++;

                 break;
         }
     }

     public void MoveClear()
     {
         if (MovingLog.Count > Length)
         {
             switch (MovingLog[0])
             {
                 case Direction.Up:

                     Clear.Y--;

                     break;

                 case Direction.Down:

                     Clear.Y++;

                     break;

                 case Direction.Left:

                     Clear.X--;

                     break;

                 case Direction.Right:

                     Clear.X++;

                     break;
             }

             MovingLog.RemoveAt(0);
         }
     }

     public bool CheckForCollisionWithWalls()
     {
         if (Head.X < 0 || Head.Y < 0 || Head.X >= tableLayoutPanel1.ColumnCount || Head.Y >= tableLayoutPanel1.RowCount)
         {
             return true;
         }

         return Field[Head.X][Head.Y].BackColor == Head.FillColor;
     }

     public void CheckForCollisionWithFruit()
     {
         if (Head.X == Fruit.X && Head.Y == Fruit.Y)
         {
             NewFruit();
         }
     }

     public void NextFrame(object sender, EventArgs e)
     {
         MoveSnake();

         if (CheckForCollisionWithWalls() == false)
         {
             CheckForCollisionWithFruit();

             MoveClear();

             OutputSnake();
         }
         else
         {
             EndGame();
         }
     }

     private void Form1_KeyDown(object sender, KeyEventArgs e)
     {
         switch (e.KeyCode)
         {
             case Keys.Up:

                 if (MovingDirection != Direction.Down)
                 {
                     NextDirection = Direction.Up;
                 }

                 break;

             case Keys.Down:

                 if (MovingDirection != Direction.Up)
                 {
                     NextDirection = Direction.Down;
                 }

                 break;

             case Keys.Left:

                 if (MovingDirection != Direction.Right)
                 {
                     NextDirection = Direction.Left;
                 }

                 break;

             case Keys.Right:

                 if (MovingDirection != Direction.Left)
                 {
                     NextDirection = Direction.Right;
                 }

                 break;
         }

         if (timer1.Enabled == false)
         {
             switch (NextDirection)
             {
                 case Direction.Up:

                     MovingLog.Add(Direction.Up);
                     Clear.Y++;

                     break;

                 case Direction.Down:

                     MovingLog.Add(Direction.Down);
                     Clear.Y--;

                     break;

                 case Direction.Left:

                     MovingLog.Add(Direction.Left);
                     Clear.X++;

                     break;

                 case Direction.Right:

                     MovingLog.Add(Direction.Right);
                     Clear.X--;

                     break;
             }

             timer1.Enabled = true;
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
