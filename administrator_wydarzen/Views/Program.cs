using System;

using System.Windows.Forms;

namespace administrator_wydarzen
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new Views.Form1();
            var model = new Models.EventList();
            var presenter = new Presenters.MainPresenter(view, model);
            Application.Run(view);
        }
    }
}
