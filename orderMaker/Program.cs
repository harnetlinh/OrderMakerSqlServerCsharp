namespace orderMaker
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
            Login formLogin = new Login();
            Application.Run(formLogin);
            if (AppData.isLogin == true)
            {
                if (AppData.isAdmin == 1)
                {
                    Application.Run(new Form1());
                }
                else
                {
                    Application.Run(new Staff());
                }
            }
                
        }
    }
}