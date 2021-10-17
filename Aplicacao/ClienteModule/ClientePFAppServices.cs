using Aplicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using Dominio.Shared;
using System;

namespace Aplicacao.ClienteModule
{
    public class ClientePFAppServices : EntidadeAppServices<ClientePF>
    {
        public ClientePFAppServices()
        {
            var dependencyResolver = DependencyInjection.Container;
            Repositorio = dependencyResolver.Resolve<IClientePFRepository>();
        }
        protected override IClientePFRepository Repositorio { get; }

        public override ResultadoOperacao Inserir(ClientePF clientePF)
        {
            if (Repositorio.ExisteDocumento(clientePF.TipoPessoa.Documento, clientePF.GetType()))
                return new ResultadoOperacao("Já existe um cliente com este Documento", EnumResultado.Falha);

            return base.Inserir(clientePF);
        }
        public override ResultadoOperacao Editar(int id, ClientePF entidade)
        {
            var edicao = base.Editar(id, entidade);
            if (edicao.Resultado == EnumResultado.Falha)
                return edicao;

            return edicao;
        }
    }
}
