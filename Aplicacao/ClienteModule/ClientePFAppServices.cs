using Aplicacao.Shared;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using Dominio.Shared;

namespace Aplicacao.ClienteModule
{
    public class ClientePFAppServices : EntidadeAppServices<ClientePF>
    {
        public ICnhRepository CnhRepository { get; }

        public ClientePFAppServices(IRepository<ClientePF> repositorio, ICnhRepository cnhRepositorio)
        {
            Repositorio = repositorio;
            CnhRepository = cnhRepositorio;
        }
        public override IRepository<ClientePF> Repositorio { get; }

        public override ResultadoOperacao Editar(int id, ClientePF entidade)
        {
            var edicao = base.Editar(id, entidade);
            if (edicao.Resultado == EnumResultado.Falha)
                return edicao;

            CnhRepository.Editar(id, entidade.Cnh);

            return edicao;
        }

        public override ResultadoOperacao Inserir(ClientePF entidade)
        {
            CnhRepository.Inserir(entidade.Cnh);
            var inserir = base.Inserir(entidade);
            if (inserir.Resultado == EnumResultado.Falha)
                return inserir;

            return inserir;
        }
    }
}
