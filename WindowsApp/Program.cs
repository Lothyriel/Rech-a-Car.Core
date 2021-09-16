using EmailAluguelPDF;
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

            new Login().Show();

            Task.Run(async () =>
            {
                while (true)
                {
                    try
                    {
                        EnviaEmail.EnviaPDFEmail();
                    }
                    catch (FilaEmailVazia)
                    {
                        await Task.Delay(new TimeSpan(0, 5, 0));
                    }
                }
            });

            Application.Run();
        }
    }
}
