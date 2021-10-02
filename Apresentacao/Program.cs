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

            RunProgram();
        }

        private static void RunProgram()
        {
            try
            {
                NLogger.Logger.Aqui().Info("Programa Iniciado");

                new ConfigServices(ConfigRepositories.SQL, ConfigRelatorio.PDF);

                new Login().Show();

                Task.Run(() => ConfigServices.Services.AluguelServices.IniciaLoopEnvioEmails());

                Application.Run();
            }
            catch (Exception e)
            {
                NLogger.Logger.Aqui().Fatal(e, "Erro muito fatal e catastrófico meu deus do céu");
                RunProgram();
            }
        }
    }
}
