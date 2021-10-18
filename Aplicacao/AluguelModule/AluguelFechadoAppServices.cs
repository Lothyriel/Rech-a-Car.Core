using Aplicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.AluguelModule;
using Dominio.Repositories;
using Dominio.ServicoModule;
using Dominio.Shared;
using Dominio.VeiculoModule;
using Infra.NLogger;

namespace Aplicacao.AluguelModule
{
    public class AluguelFechadoAppServices : EntidadeAppServices<AluguelFechado>
    {
        protected override IRepository<AluguelFechado> Repositorio { get; }
        public IServicoRepository ServicoRepository { get; }
        public IVeiculoRepository RepositorioVeiculo { get; }
        public AluguelFechadoAppServices()
        {
            var dependencyResolver = DependencyInjection.Container;

            Repositorio = dependencyResolver.Resolve<IAluguelFechadoRepository>();
            ServicoRepository = dependencyResolver.Resolve<IServicoRepository>();

            RepositorioVeiculo = dependencyResolver.Resolve<IVeiculoRepository>();

        }
        public override ResultadoOperacao Editar(int id, AluguelFechado aluguel)
        {
            NLogger.Logger.Aqui().Debug("Devolvendo {aluguel} | ID: {idAluguel}", aluguel, aluguel.Id);
            var edicao = base.Editar(id, aluguel);
            if (edicao.Resultado == EnumResultado.Falha)
                return edicao;

            ServicoRepository.DesalugarServicosAlugados(id);
            RepositorioVeiculo.AdicionarQuilometragem(aluguel.Veiculo, aluguel.KmRodados);
            NLogger.Logger.Aqui().Info("Devolução completa {aluguel} | ID: {idAluguel}", aluguel, aluguel.Id);
            return edicao;
        }
    }
}
