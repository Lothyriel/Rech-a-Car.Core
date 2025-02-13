﻿using Aplicacao.ClienteModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class CadastroCliente : CadastroEntidade<Cliente>
    {
        public override ClienteAppServices Services { get; }
        public CadastroCliente()
        {
            Services = new ClienteAppServices();
            InitializeComponent();
        }

        protected override IEditavel Editar()
        {
            if (entidade is ClientePF pF)
                return new CadastroClientePF().ConfigurarEditar(pF);
            if (entidade is ClientePJ pJ)
                return new CadastroClientePJ().ConfigurarEditar(pJ);
            else
                throw new ArgumentException();
        }

        public override Cliente GetNovaEntidade()
        {
            throw new NotSupportedException();
        }
    }
}