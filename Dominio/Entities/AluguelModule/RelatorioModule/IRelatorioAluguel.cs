using System.IO;

namespace Dominio.AluguelModule
{
    public interface IRelatorioAluguel
    {
        RelatorioAluguel GerarRelatorio(Aluguel aluguel);
    }
}
