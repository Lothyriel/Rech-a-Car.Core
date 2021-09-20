using Dominio.PessoaModule;
using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositories
{
    public interface ICnhRepository
    {
        void Inserir(CNH cnh);
        void Editar(int id, CNH cnh);
        CNH GetByIdCondutor(int id_condutor);

    }
}
