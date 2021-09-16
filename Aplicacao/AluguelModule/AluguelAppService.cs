using Aplicacao.AluguelModule.EmailAluguel;
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
    public class AluguelAppService : EntidadeAppService<Aluguel>
    {
        public static async void IniciaLoopEnvioEmails()
        {
            while (true)
            {
                try
                {
                    TentaEnviarEmail();
                }
                catch (FilaEmailVazia)
                {
                    await Task.Delay(new TimeSpan(0, 5, 0));
                }
            }
        }
        private static void TentaEnviarEmail()
        {
            var proxEnvio = new ControladorEmailAluguel().GetProxEnvio();

            if (proxEnvio == null)
                throw new FilaEmailVazia();

            Stream ms = proxEnvio.StreamAttachment;
            var attachment = new Attachment(ms, "Pdf Resumo Aluguel.pdf");

            var corpoEmail = "Confira o resumo do seu mais novo aluguel: ";
            var titulo = "Resumo Aluguel Rech-a-car";
            var emailUsuario = proxEnvio.Aluguel.Cliente.Email;

            Email.Envia(emailUsuario, titulo, corpoEmail, new List<Attachment>() { attachment });
        }

        public override void Editar(int id, Aluguel entidade)
        {
            throw new System.NotImplementedException();
        }

        public override void Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public override bool Existe(int id)
        {
            throw new System.NotImplementedException();
        }

        public override List<Aluguel> FiltroGenerico(string filtro)
        {
            throw new System.NotImplementedException();
        }

        public override Aluguel GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public override void Inserir(Aluguel entidade)
        {
            throw new System.NotImplementedException();
        }

        public override List<Aluguel> TodosRegistros()
        {
            throw new System.NotImplementedException();
        }
    }
}
