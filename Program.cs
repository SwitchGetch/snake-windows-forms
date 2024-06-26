namespace snake
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
        }
    }

    public static class Config
    {
        public static int WindowWidth = 800;
        public static int WindowHeight = 800;

        public static int FieldWidth = 20;
        public static int FieldHeight = 20;

        public static int SnakeSpeed = 900;
    }
}
