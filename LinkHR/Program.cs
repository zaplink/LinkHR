using DotNetEnv;

namespace LinkHR
{
    
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // load .env files
            DotNetEnv.Env.Load();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();
            // Show the LoginForm without making it the main form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // Run the application without a main form
            Application.Run();
        }
    }
}