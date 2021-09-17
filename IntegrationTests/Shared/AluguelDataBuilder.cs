using Dominio.AluguelModule;
using Dominio.CupomModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.ServicoModule;
using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests.Shared
{
    class AluguelDataBuilder
    {
        Aluguel aluguel = null;

        public AluguelDataBuilder DeVeiculo(Veiculo veiculo)
        {
            aluguel = new Aluguel();

            aluguel.Veiculo = veiculo;

            return this;
        }

        public AluguelDataBuilder ParaCliente(ICliente cliente)
        {
            aluguel.Cliente = cliente;

            return this;
        }

        public AluguelDataBuilder PorFuncionario(Funcionario funcionario)
        {
            aluguel.Funcionario = funcionario;

            return this;
        }

        public AluguelDataBuilder NaData(DateTime dataAluguel)
        {
            aluguel.DataAluguel = dataAluguel;

            return this;
        }

        public AluguelDataBuilder ParaDevolver(DateTime dataDevolucao)
        {
            aluguel.DataDevolucao = dataDevolucao;

            return this;
        }

        public AluguelDataBuilder NoPlano(Plano tipoPlano)
        {
            aluguel.TipoPlano = tipoPlano;

            return this;
        }

        public AluguelDataBuilder ParaCondutor(Condutor condutor)
        {
            aluguel.Condutor = condutor;

            return this;
        }

        public AluguelDataBuilder ComServicos(List<Servico> servicos)
        {
            aluguel.Servicos = servicos;

            return this;
        }

        public AluguelDataBuilder ComCupom(Cupom cupom)
        {
            aluguel.Cupom = cupom;

            return this;
        }

        public Aluguel Build()
        {
            return aluguel;
        }
    }
}