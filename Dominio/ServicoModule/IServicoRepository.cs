using Dominio.Shared;
using System.Collections.Generic;

namespace Dominio.ServicoModule
{
    public interface IServicoRepository : IEntidadeRepository<Servico>
    {
        void AlugarServicos(int id, List<Servico> servicos);
        void DesalugarServicosAlugados(int id);
        List<Servico> ServicosDisponiveis();
    }
}
