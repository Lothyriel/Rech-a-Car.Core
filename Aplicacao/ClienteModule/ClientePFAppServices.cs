using Aplicacao.Shared;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using Dominio.Shared;
using Infra.NLogger;

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
            var tipo = entidade.GetType().Name;

            NLogger.Logger.Info($"Editando {{tipo}} {{entidade}} | ID: {{id{char.ToUpper(tipo[0]) + tipo.Substring(1)}}}", tipo, entidade, id);

            var edicao = base.Editar(id, entidade);
            if (edicao.Resultado == EnumResultado.Falha)
                return edicao;

            CnhRepository.Editar(id, entidade.Cnh);
            NLogger.Logger.Aqui().Info("Editado com sucesso");

            return edicao;
        }

        public override ResultadoOperacao Inserir(ClientePF clientePF)
        {
            CnhRepository.Inserir(clientePF.Cnh);
            var inserir = base.Inserir(clientePF);
            if (inserir.Resultado == EnumResultado.Falha)
                CnhRepository.Excluir(clientePF.Cnh.Id);

            return inserir;
        }
    }
}
