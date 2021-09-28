using Dominio.CupomModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.ServicoModule;
using Dominio.Shared;
using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;

namespace Dominio.AluguelModule
{
    public class Aluguel : Entidade
    {
        public Aluguel(Veiculo veiculo, List<Servico> servicos, Plano tipoPlano, DateTime dataAluguel, ICliente cliente, Funcionario funcionario, DateTime dataDevolucao, Condutor condutor = null, Cupom cupom = null)
        {
            Funcionario = funcionario;
            Veiculo = veiculo;
            Servicos = servicos;
            TipoPlano = tipoPlano;
            DataAluguel = dataAluguel;
            Cliente = cliente;
            Condutor = condutor;
            DataDevolucao = dataDevolucao;
            Cupom = cupom;
            if (condutor == null)
                Condutor = (Condutor)cliente;
        }
        public Aluguel(Aluguel aluguel)
        {
            Funcionario = aluguel.Funcionario;
            Veiculo = aluguel.Veiculo;
            Servicos = aluguel.Servicos;
            TipoPlano = aluguel.TipoPlano;
            DataAluguel = aluguel.DataAluguel;
            Cliente = aluguel.Cliente;
            Condutor = aluguel.Condutor;
            if (aluguel.Condutor == null)
                Condutor = (Condutor)aluguel.Cliente;
        }
        public Aluguel() { }
        public Funcionario Funcionario { get; set; }
        public Veiculo Veiculo { get; set; }
        public ICliente Cliente { get; set; }
        public List<Servico> Servicos { get; set; } = new List<Servico>();
        public Condutor Condutor { get; set; }
        public Plano TipoPlano { get; set; }
        public DateTime DataAluguel { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Cupom Cupom { get; set; }

        public virtual double CalcularTotal(Configuracoes configs = null)
        {
            double PrecoParcial = 0;

            if (Servicos.Count != 0)
                Servicos.ForEach(x => PrecoParcial += x.Taxa);

            if (!DatasValidas())
                return PrecoParcial;

            if (Veiculo == null)
                return PrecoParcial;

            var Categoria = Veiculo.Categoria;
            switch (TipoPlano)
            {
                case Plano.Diário: CalculaPlanoDiario(); break;
                case Plano.Controlado: CalculaPlanoControlado(); break;
                case Plano.Livre: CalculaPlanoLivre(); break;
                default: break;
            }

            return PrecoParcial;

            void CalculaPlanoControlado()
            {
                PrecoParcial += (Categoria.PrecoDiaria * GetQtdDiasAluguel()) +
                    (Categoria.QuilometragemFranquia * Categoria.PrecoKm);
            }
            void CalculaPlanoDiario()
            {
                PrecoParcial += Categoria.PrecoDiaria * GetQtdDiasAluguel();
            }
            void CalculaPlanoLivre()
            {
                PrecoParcial += Categoria.PrecoLivre * GetQtdDiasAluguel();
            }
            int GetQtdDiasAluguel()
            {
                return (DataDevolucao - DataAluguel).Days;
            }
        }
        public AluguelFechado Fechar(int kmRodados, double tanqueUtilizado, List<Servico> servicos)
        {
            return new AluguelFechado(this, kmRodados, tanqueUtilizado, servicos, DateTime.Today);
        }
        public override string Validar()
        {
            string validacao = string.Empty;

            if (Veiculo == null)
                validacao += "O aluguel necessita de um veículo\n";
            if (Condutor == null)
                validacao += "O aluguel necessita de um condutor\n";

            if (validacao != string.Empty)
                return validacao;


            if (Condutor.Cnh.TipoCnh < Veiculo.Categoria.TipoDeCnh)
                validacao += "Condutor não tem a carteira necessária para dirigir o veículo selecionado\n";

            if (DataAluguel < DateTime.Today)
                validacao += "Data de aluguel não pode ser no passado\n";

            if (!DatasValidas())
                validacao += "Data de devolução deve ser após data de aluguel";



            return validacao;
        }
        private bool DatasValidas()
        {
            return DataAluguel < DataDevolucao;
        }
        public override string ToString()
        {
            return $"{Veiculo} {Funcionario} {Cliente} {Condutor} {TipoPlano}";
        }
    }
    public enum Plano
    {
        Diário,
        Controlado,
        Livre
    }
}