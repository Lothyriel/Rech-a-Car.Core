namespace Dominio.AluguelModule
{
    public interface IRelatorioRepository
    {
        void SalvarRelatorio(RelatorioAluguel envio);
        void MarcarEnviado(int id);
        RelatorioAluguel GetProxEnvio();
    }
}
