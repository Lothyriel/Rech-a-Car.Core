using Applicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using Dominio.Shared;
using System;

namespace Applicacao.ClienteModule
{
    public class MotoristaAppServices : EntidadeAppServices<Motorista>
    {
        protected override IMotoristaRepository Repositorio { get; }

        public ICnhRepository CnhRepository { get; }
        public IClientePJRepository ClientePJRepository { get; }


        public MotoristaAppServices()
        {
            var dependencyResolver = DependencyInjection.Container;
            Repositorio = dependencyResolver.Resolve<IMotoristaRepository>();
            CnhRepository = dependencyResolver.Resolve<ICnhRepository>();
            ClientePJRepository = dependencyResolver.Resolve<IClientePJRepository>();
        }

        public override ResultadoOperacao Inserir(Motorista motorista)
        {
            var inserir = base.Inserir(motorista);

            if (inserir.Resultado == EnumResultado.Falha)
                CnhRepository.Excluir(motorista.Cnh.Id);

            return inserir;
        }

        public override ResultadoOperacao Editar(int id, Motorista entidade)
        {
            var edicao = base.Editar(id, entidade);
            if (edicao.Resultado == EnumResultado.Falha)
                return edicao;

            CnhRepository.Editar(id, entidade.Cnh);

            return edicao;
        }

        public override void Excluir(int id, Type tipo = null)
        {
            base.Excluir(id, tipo);
            CnhRepository.Excluir(id);
        }
    }
}
