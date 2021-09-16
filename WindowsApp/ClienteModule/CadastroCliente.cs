using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule.ClienteModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class CadastroCliente : CadastroEntidade<ICliente>
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        public override Controlador<ICliente> Services => new ControladorCliente();

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