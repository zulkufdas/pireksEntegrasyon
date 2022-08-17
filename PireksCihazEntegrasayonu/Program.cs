using System;
using System.Linq;
using System.Windows.Forms;

namespace PireksCihazEntegrasyonu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.ThreadException += Application_ThreadException;

            ArgumansWrapper(args);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void ArgumansWrapper(string[] args)
        {
            var argumans = Tools.ArgumansWrap(args.FirstOrDefault());
            ApplicationParams.Instance.SetArgumans(argumans);
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Logger.WriteError(e.Exception);
            MessageBox.Show(e.Exception.Message, "Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
