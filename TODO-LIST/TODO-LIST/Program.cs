namespace TODO_LIST
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Model model = new Model();
            Controller controller = new Controller();
            Form3 view = new Form3();

            model.Controller = controller;
            view.Controller = controller;
            controller.Model = model;
            controller.Form3 = view;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.Run(new Form1());
        }
    }
}