using Dominio.ServicoModule;
using System;
using System.Collections.Generic;

namespace Dominio.AluguelModule
{
    public class AluguelFechado : Aluguel
    {
        public AluguelFechado(Aluguel aluguel, int kmRodados, double tanqueUtilizado, List<Servico> servicosNecessarios, DateTime dataDevolvida) : base(aluguel)
        {
            Veiculo = aluguel.Veiculo;
            Servicos = aluguel.Servicos;
            Cliente = aluguel.Cliente;
            Condutor = aluguel.Condutor;
            TipoPlano = aluguel.TipoPlano;
            DataAluguel = aluguel.DataAluguel;
            Cupom = aluguel.Cupom;
            KmRodados = kmRodados;
            TanqueUtilizado = tanqueUtilizado;
            ServicosNecessarios = servicosNecessarios;
            DataDevolvida = dataDevolvida;
            DataDevolucao = aluguel.DataDevolucao;
        }
        public int KmRodados { get; set; }
        public double TanqueUtilizado { get; set; }
        public List<Servico> ServicosNecessarios { get; set; }
        public DateTime DataDevolvida { get; set; }
        public override double CalcularTotal(Configuracoes configs)
        {
            double PrecoFinal = base.CalcularTotal();

            if (DateTime.Today > DataDevolucao)
                PrecoFinal += (DateTime.Today - DataDevolucao).Days;

            PrecoFinal += CalcularCombustivel(configs);
            PrecoFinal += CalcularKmRodados();

            ServicosNecessarios.ForEach(x => PrecoFinal += x.Taxa);

            return PrecoFinal;
        }
        private double CalcularKmRodados()
        {
            double PrecoKmRodado = 0;

            if (TipoPlano == Plano.Controlado && KmRodados > Veiculo.Categoria.QuilometragemFranquia)
            {
                PrecoKmRodado = (KmRodados - Veiculo.Categoria.QuilometragemFranquia) * Veiculo.Categoria.PrecoKm;
                PrecoKmRodado += PrecoKmRodado * 0.15;
            }

            if (TipoPlano == Plano.Controlado && KmRodados < Veiculo.Categoria.QuilometragemFranquia && KmRodados != 0)
            {
                PrecoKmRodado = (KmRodados - Veiculo.Categoria.QuilometragemFranquia) * Veiculo.Categoria.PrecoKm;
                PrecoKmRodado -= PrecoKmRodado * 0.15;
            }

            if (TipoPlano == Plano.Diário)
                PrecoKmRodado = KmRodados * Veiculo.Categoria.PrecoKm;


            return PrecoKmRodado;
        }
        private double CalcularCombustivel(Configuracoes configs)
        {
            return Veiculo.TipoDeCombustivel switch
            {
                VeiculoModule.TipoCombustivel.Diesel => TanqueUtilizado * configs.ValorDiesel,
                VeiculoModule.TipoCombustivel.Etanol => TanqueUtilizado * configs.ValorEtanol,
                VeiculoModule.TipoCombustivel.Gasolina => TanqueUtilizado * configs.ValorGasolina,
                _ => 0,
            };
        }
        public override string Validar()
        {
            string validacao = base.Validar();

            if (KmRodados < 0)
                validacao += "Quilometros rodados necessita ser pelo menos 0\n";

            if (TanqueUtilizado < 0)
                validacao += "Tanque utilizado tem que ser pelo menos 0\n";

            return validacao;
        }
    }
}
