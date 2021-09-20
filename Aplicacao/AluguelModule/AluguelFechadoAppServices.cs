using Aplicacao.Shared;
using Dominio.AluguelModule;
using Dominio.ServicoModule;
using Dominio.Shared;
using Dominio.VeiculoModule;

namespace Aplicacao.AluguelModule
{
    public class AluguelFechadoAppServices : EntidadeAppServices<AluguelFechado>
    {
        public override IRepository<AluguelFechado> Repositorio { get; }
        public IServicoRepository ServicoRepository { get; }
        public IVeiculoRepository RepositorioVeiculo { get; }
        public AluguelFechadoAppServices(IRepository<AluguelFechado> repositorio, IServicoRepository servicoRepository, IVeiculoRepository repositorioVeiculo)
        {
            RepositorioVeiculo = repositorioVeiculo;
            Repositorio = repositorio;
            ServicoRepository = servicoRepository;
        }
        public override ResultadoOperacao Editar(int id, AluguelFechado entidade)
        {
            var edicao = base.Editar(id, entidade);
            if (edicao.Resultado == EnumResultado.Falha)
                return edicao;

            ServicoRepository.DesalugarServicosAlugados(id);
            return edicao;
        }
    }
}
