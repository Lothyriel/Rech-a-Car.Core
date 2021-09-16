using Aplicacao.Shared;
using Dominio.AluguelModule;
using EnviaEmail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Aplicacao.AluguelModule
{
    public class AluguelAppServices : EntidadeAppServices<Aluguel>
    {
        public IRelatorioAluguel Relatorio;
        public override IAluguelRepository Repositorio { get; }

        public AluguelAppServices(IAluguelRepository repositorio, IRelatorioAluguel relatorio)
        {
            Relatorio = relatorio;
            Repositorio = repositorio;
        }

        public async void IniciaLoopEnvioEmails()
        {
            while (true)
            {
                try
                {
                    var envioId = TentaEnviarRelatorioEmail();
                    Repositorio.MarcarEnviado(envioId);
                }
                catch (FilaEmailVazia)
                {
                    await Task.Delay(new TimeSpan(0, 5, 0));
                }
            }
        }
        private int TentaEnviarRelatorioEmail()
        {
            var proxEnvio = Repositorio.GetProxEnvio();

            if (proxEnvio == null)
                throw new FilaEmailVazia();

            Stream ms = proxEnvio.StreamAttachment;
            var attachment = new Attachment(ms, "Pdf Resumo Aluguel.pdf");

            var corpoEmail = "Confira o resumo do seu mais novo aluguel: ";
            var titulo = "Resumo Aluguel Rech-a-car";
            var emailUsuario = proxEnvio.Aluguel.Cliente.Email;

            Email.Envia(emailUsuario, titulo, corpoEmail, new List<Attachment>() { attachment });
            return proxEnvio.Id;
        }
        public override ResultadoOperacao Inserir(Aluguel aluguel)
        {
            var insercao = base.Inserir(aluguel);
            if (insercao.Resultado == EnumResultado.Falha)
                return insercao;

            var relatorio = Relatorio.GerarRelatorio(aluguel);

            Repositorio.SalvarRelatorio(new EnvioResumoAluguel(aluguel, relatorio));
            return insercao;
        }
    }
    [Serializable]
    public class FilaEmailVazia : Exception
    {
        public FilaEmailVazia()
        {
        }

        public FilaEmailVazia(string message) : base(message)
        {
        }
    }
}
