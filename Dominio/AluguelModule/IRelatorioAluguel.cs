using System.IO;

namespace Dominio.AluguelModule
{
    public interface IRelatorioAluguel //pode depois de herdar de um IRelatorioEntidade
    {
        MemoryStream GerarRelatorio(Aluguel aluguel);
    }
}
