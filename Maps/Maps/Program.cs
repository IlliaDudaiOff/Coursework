namespace Maps {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            DataBase db = new DataBase();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //Registration reg = new Registration();
            ApplicationConfiguration.Initialize();
            db.openConnection();
            Application.Run(new Authorization(db));
            
        }
    }
}