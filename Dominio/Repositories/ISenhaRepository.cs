using Dominio.Entities.PessoaModule;
using Dominio.Shared;
using System.Collections.Generic;

namespace Dominio.Repositories
{
    public interface ISenhaRepository : IRepository<Senha>
    {
        void Inserir();

        void Excluir();
    }
}
