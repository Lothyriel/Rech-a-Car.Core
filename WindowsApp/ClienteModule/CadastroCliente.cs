using Aplicacao.ClienteModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;
using System;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class CadastroCliente : CadastroEntidade<ICliente>
    {
        public override ClienteAppServices Services { get; }
        public CadastroCliente(IEntidadeRepository<ICliente> repositorio)
        {
            Services = new ClienteAppServices(repositorio);
            InitializeComponent();
        }


        protected override IEditavel Editar()
        {
            if (entidade is ClientePF)
                return new CadastroClientePF().ConfigurarEditar((ClientePF)entidade);
            if (entidade is ClientePJ)
                return new CadastroClientePJ().ConfigurarEditar((ClientePJ)entidade);
            else
                throw new ArgumentException();
        }

        public override ICliente GetNovaEntidade()
        {
            throw new NotSupportedException();
        }
    }
}