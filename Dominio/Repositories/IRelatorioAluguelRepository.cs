using System.IO;

namespace Dominio.AluguelModule
{
    public interface IRelatorioAluguelRepository
    {
        RelatorioAluguel GerarRelatorio(Aluguel aluguel);
    }
}
