using System.IO;

namespace Dominio.AluguelModule
{
    public interface IRelatorioAluguel
    {
        MemoryStream GerarRelatorio(Aluguel aluguel);
    }
}
