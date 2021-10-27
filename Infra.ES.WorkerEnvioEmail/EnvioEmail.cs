using Autofac;
using DependencyInjector;
using Dominio.AluguelModule;
using Infra.NLogger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Infra.ES.WorkerEnvioEmail
{
    public class EnvioEmail
    {
        private static IRelatorioRepository RelatorioRepositorio { get; }

        private const string email = "rech.a.car.alugueldeveiculos@gmail.com";

        private static SmtpClient client = new("smtp.gmail.com", 587)
        {
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(email, "rech#admin"),
            EnableSsl = true
        };

        static EnvioEmail()
        {
            var dependencyResolver = DependencyInjection.Container;
            RelatorioRepositorio = dependencyResolver.Resolve<IRelatorioRepository>();
        }

        public static void Envia(string EmailDestinatario, string titulo, string corpoEmail, List<Attachment> attachments)
        {
            var message = new MailMessage(email, EmailDestinatario, titulo, corpoEmail);

            attachments.ForEach(a => message.Attachments.Add(a));

            client.Send(message);
        }
        public static void TentaEnviarRelatorioEmail()
        {
            var proxEnvio = RelatorioRepositorio.GetProxEnvio();

            if (proxEnvio == null)
                throw new FilaEmailVazia();

            Stream ms = proxEnvio.StreamAttachment;
            var attachment = new Attachment(ms, "Pdf Resumo Aluguel.pdf");

            var corpoEmail = "Confira o resumo do seu mais novo aluguel: ";
            var titulo = "Resumo Aluguel Rech-a-car";
            var emailUsuario = proxEnvio.Aluguel.Cliente.Email;

            Envia(emailUsuario, titulo, corpoEmail, new List<Attachment>() { attachment });
            RelatorioRepositorio.MarcarEnviado(proxEnvio.Id);

            NLogger.NLogger.Logger.Aqui().Info("Email {email.id} Enviado", proxEnvio.Id);
        }
    }
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
