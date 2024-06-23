namespace snake
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            numericUpDown1.Value = Config.FieldWidth;
            numericUpDown2.Value = Config.FieldHeight;
            numericUpDown3.Value = Config.SnakeSpeed;
            numericUpDown4.Value = Config.WindowWidth;
            numericUpDown5.Value = Config.WindowHeight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Config.WindowWidth = (int)numericUpDown4.Value;
            Config.WindowHeight = (int)numericUpDown5.Value;

            Config.FieldWidth = (int)numericUpDown1.Value;
            Config.FieldHeight = (int)numericUpDown2.Value;

            Config.SnakeSpeed = (int)numericUpDown3.Value;

            Hide();
            var game = new Game();
            game.Closed += (s, args) => Close();
            game.Show();
        }
    }
}
