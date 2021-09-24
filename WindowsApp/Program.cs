using Infra.NLogger;
using System;
using System.Threading.Tasks;
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

            NLogger.Logger.Info("Eu amo fazer sexo!");

            new ConfigServices(ConfigRepositories.SQL, ConfigRelatorio.PDF);
            new Login().Show();

            Task.Run(() => ConfigServices.Services.AluguelServices.IniciaLoopEnvioEmails());

            Application.Run();
        }
    }
}
