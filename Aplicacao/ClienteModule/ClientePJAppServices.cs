using Aplicacao.Shared;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;

namespace Aplicacao.ClienteModule
{
    public class ClientePJAppServices : EntidadeAppServices<ClientePJ>
    {
        public ICnhRepository CnhRepository { get; }

        public ClientePJAppServices(IClientePJRepository repositorio)
        {
            Repositorio = repositorio;
        }
        protected override IClientePJRepository Repositorio { get; }
        public override ResultadoOperacao Inserir(ClientePJ clientePJ)
        {
            var inserir = base.Inserir(clientePJ);

            if (Repositorio.ExisteDocumento(clientePJ.Documento, clientePJ.GetType()))
                return new ResultadoOperacao("Já existe um cliente com este Documento", EnumResultado.Falha);

            return inserir;
        }
    }
}
