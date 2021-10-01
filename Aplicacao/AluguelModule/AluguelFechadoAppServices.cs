using Aplicacao.Shared;
using Dominio.AluguelModule;
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
        public AluguelFechadoAppServices(IRepository<AluguelFechado> repositorio, IServicoRepository servicoRepository, IVeiculoRepository repositorioVeiculo)
        {
            RepositorioVeiculo = repositorioVeiculo;
            Repositorio = repositorio;
            ServicoRepository = servicoRepository;
        }
        public override ResultadoOperacao Editar(int id, AluguelFechado aluguel)
        {
            var edicao = base.Editar(id, aluguel);
            if (edicao.Resultado == EnumResultado.Falha)
                return edicao;

            ServicoRepository.DesalugarServicosAlugados(id);
            RepositorioVeiculo.AdicionarQuilometragem(aluguel.Veiculo, aluguel.KmRodados);

            NLogger.Logger.Aqui().Info("Devolvendo {aluguel} | ID: {idAluguel}", aluguel, aluguel.Id);
            return edicao;
        }
    }
}
