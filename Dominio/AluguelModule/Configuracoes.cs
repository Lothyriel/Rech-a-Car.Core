namespace Dominio.AluguelModule
{
    public class Configuracoes
    {
        public Configuracoes(double valorEtanol, double valorDiesel, double valorGasolina, double valorCaucao)
        {
            ValorEtanol = valorEtanol;
            ValorDiesel = valorDiesel;
            ValorGasolina = valorGasolina;
            ValorCaucao = valorCaucao;
        }

        public double ValorEtanol { get; internal set; }
        public double ValorDiesel { get; internal set; }
        public double ValorGasolina { get; internal set; }
        public double ValorCaucao { get; internal set; }
    }
}
