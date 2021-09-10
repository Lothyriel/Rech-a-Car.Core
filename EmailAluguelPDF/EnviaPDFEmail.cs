using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;

namespace EmailAluguelPDF
{
    public class EnviaPDFEmail
    {
        private const string email = "rech.a.car.alugueldeveiculos@gmail.com";

        private static ControladorEmail controladorEmail = new ControladorEmail();
        private static SmtpClient client = new SmtpClient("smtp.gmail.com", 587) 
        {
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(email, "rech#admin"),
            EnableSsl = true
        };

        public EnviaPDFEmail()
        {
            var proxEnvio = controladorEmail.GetProxEnvio();

            if (proxEnvio == null)
                throw new FilaEmailVazia();

            var emailUsuario = proxEnvio.Aluguel.Cliente.Email;
            var message = new MailMessage(email, emailUsuario, "Resumo Aluguel Rech-a-car", "Confira o resumo do seu mais novo aluguel: ");

            var stream = new MemoryStream();
            proxEnvio.Pdf.Save(stream);

            var data = new Attachment(stream, "Pdf Resumo Aluguel.pdf");
            message.Attachments.Add(data);

            client.Send(message);
            controladorEmail.AlterarEnviado(proxEnvio.Id);
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