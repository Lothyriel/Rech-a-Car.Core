using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace EnviaEmail
{
    public class Email
    {
        private const string email = "rech.a.car.alugueldeveiculos@gmail.com";

        private static SmtpClient client = new("smtp.gmail.com", 587)
        {
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(email, "rech#admin"),
            EnableSsl = true
        };

        public static void Envia(string EmailDestinatario, string titulo, string corpoEmail, List<Attachment> attachments)
        {
            var message = new MailMessage(email, EmailDestinatario, titulo, corpoEmail);

            attachments.ForEach(a => message.Attachments.Add(a));

            client.Send(message);
        }
    }
}