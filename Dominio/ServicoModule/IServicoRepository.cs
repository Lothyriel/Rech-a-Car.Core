using Dominio.Shared;
using System.Collections.Generic;

namespace Dominio.ServicoModule
{
    public interface IServicoRepository : IRepository<Servico>
    {
        void AlugarServicos(int id, List<Servico> servicos);
        void DesalugarServicosAlugados(int id);
        List<Servico> ServicosDisponiveis();
    }
}
