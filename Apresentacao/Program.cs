using Infra.NLogger;
using System;
using System.Windows.Forms;

namespace WindowsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RunProgram();
        }

        private static void RunProgram()
        {
            NLogger.Logger.Aqui().Info("Programa Iniciado");

            new Login().Show();

            Infra.ES.WorkerEnvioEmail.Program.Main(Array.Empty<string>());

            Application.Run();
        }
    }
}
