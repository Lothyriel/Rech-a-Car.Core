﻿using Aplicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.PessoaModule;
using Dominio.Repositories;

namespace Aplicacao.ClienteModule
{
    public class MotoristaAppServices : EntidadeAppServices<Motorista>
    {
        protected override IMotoristaRepository Repositorio { get; }
        public MotoristaAppServices()
        {
            var dependencyResolver = DependencyInjection.Container;
            Repositorio = dependencyResolver.Resolve<IMotoristaRepository>();
        }
    }
}
