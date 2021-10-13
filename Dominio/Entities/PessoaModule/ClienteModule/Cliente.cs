using Dominio.PessoaModule.ClienteModule;

namespace Dominio.Entities.PessoaModule.ClienteModule
{
    public class Cliente : ICliente
    {
        public ICliente _Cliente;

        public Cliente(ICliente cliente)
        {
            _Cliente = cliente;
        }
        protected Cliente() { }

        public string Email { get { return _Cliente.Email; } set { _Cliente.Email = value; } }
        public string Nome { get { return _Cliente.Nome; } set { _Cliente.Nome = value; } }
        public string Telefone { get { return _Cliente.Telefone; } set { _Cliente.Telefone = value; } }
        public string Endereco { get { return _Cliente.Endereco; } set { _Cliente.Endereco = value; } }
        public string Documento { get { return _Cliente.Documento; } set { _Cliente.Documento = value; } }
        public int Id { get { return _Cliente.Id; } set { _Cliente.Id = value; } }

        public string Validar()
        {
            return _Cliente.Validar();
        }
    }
}