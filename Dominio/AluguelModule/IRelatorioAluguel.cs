using System.IO;

namespace Dominio.AluguelModule
{
    public interface IRelatorioAluguel //pode depois herdar de um IRelatorioEntidade
    {
        MemoryStream GerarRelatorio(Aluguel aluguel);
    }
}
