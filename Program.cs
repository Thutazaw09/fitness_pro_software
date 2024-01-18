using fitness_pro_software.models;

namespace fitness_pro_software
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            DBHelper.InitializeDatabase();
            Application.Run(new frmLogin());

        }
    }
}