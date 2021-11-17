using Aplicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.AluguelModule;
using Dominio.CupomModule;
using Dominio.ServicoModule;
using Infra.ES.WorkerEnvioEmail;
using Infra.NLogger;
using System;
using System.Threading.Tasks;

namespace Aplicacao.AluguelModule
{
    public class AluguelAppServices : EntidadeAppServices<Aluguel>
    {
        protected override IAluguelRepository Repositorio { get; }
        public IRelatorioRepository RelatorioRepositorio { get; }
        public IRelatorio Relatorio { get; }
        public IServicoRepository ServicoRepositorio { get; }
        public ICupomRepository CupomRepositorio { get; }

        public AluguelAppServices()
        {
            var dependencyResolver = DependencyInjection.Container;

            Repositorio = dependencyResolver.Resolve<IAluguelRepository>();
            Relatorio = dependencyResolver.Resolve<IRelatorio>();
            RelatorioRepositorio = dependencyResolver.Resolve<IRelatorioRepository>();
            ServicoRepositorio = dependencyResolver.Resolve<IServicoRepository>();
            CupomRepositorio = dependencyResolver.Resolve<ICupomRepository>();
        }
        public override ResultadoOperacao Inserir(Aluguel aluguel)
        {
            using (var ctx = DependencyInjection.Container.BeginLifetimeScope())
            {
                var validacaoCupom = ValidarCupom(aluguel);
                if (validacaoCupom.Resultado == EnumResultado.Falha)
                    return validacaoCupom;

                var insercao = base.Inserir(aluguel);
                if (insercao.Resultado == EnumResultado.Falha)
                    return insercao;

                if (aluguel.Cupom != null)
                {
                    aluguel.Cupom.Usos++;
                    CupomRepositorio.Editar(aluguel.Cupom.Id, aluguel.Cupom);
                }
                ServicoRepositorio.AlugarServicos(aluguel.Id, aluguel.Servicos);

                GerarRelatorio(aluguel);

                return insercao;
            }
        }

        private void GerarRelatorio(Aluguel aluguel)
        {
            NLogger.Logger.Aqui().Debug("Gerando relatório de {aluguel} | ID: {idAluguel}", aluguel, aluguel.Id);
            var relatorio = Task.Run(() => Relatorio.GerarRelatorio(aluguel));
            RelatorioRepositorio.SalvarRelatorio(relatorio.Result);
            NLogger.Logger.Aqui().Info("Relatório gerado {aluguel} | ID: {idAluguel}", aluguel, aluguel.Id);
        }

        public override ResultadoOperacao Editar(int id, Aluguel entidade)
        {
            var edicao = base.Editar(id, entidade);
            if (edicao.Resultado == EnumResultado.Falha)
                return edicao;

            ServicoRepositorio.DesalugarServicosAlugados(id);
            ServicoRepositorio.AlugarServicos(entidade.Id, entidade.Servicos);
            return edicao;
        }
        public ResultadoOperacao ValidarCupom(Aluguel aluguel)
        {
            if (aluguel.Cupom == null)
                return new ResultadoOperacao("", EnumResultado.Sucesso);

            if (aluguel.Cupom == Cupom.Invalido)
                return new ResultadoOperacao("Cupom não existe", EnumResultado.Falha);

            var validacao = aluguel.ValidarCupom();

            if (validacao != string.Empty)
                return new ResultadoOperacao(validacao, EnumResultado.Falha);

            return new ResultadoOperacao("Cupom aplicado com sucesso", EnumResultado.Sucesso);
        }
    }
}
