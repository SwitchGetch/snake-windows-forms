namespace snake
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
