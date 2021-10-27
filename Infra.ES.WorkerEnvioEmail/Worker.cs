using Infra.NLogger;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Infra.ES.WorkerEnvioEmail
{
    public class Worker : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            NLogger.NLogger.Logger.Aqui().Debug("Serviço de Envio de Emails Iniciado");
            while (!stoppingToken.IsCancellationRequested)
                try
                {
                    EnvioEmail.TentaEnviarRelatorioEmail();
                }
                catch (FilaEmailVazia)
                {
                    NLogger.NLogger.Logger.Aqui().Warn("Sem emails para envio, esperando 5 minutos para tentar novamente");
                    await Task.Delay(TimeSpan.FromMinutes(5));
                }
        }
    }
}
