namespace Dominio.AluguelModule
{
    public interface IRelatorio
    {
        RelatorioAluguel GerarRelatorio(Aluguel aluguel);
    }
}
