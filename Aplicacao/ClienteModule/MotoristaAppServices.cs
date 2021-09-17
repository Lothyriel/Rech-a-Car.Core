using Aplicacao.Shared;
using Dominio.PessoaModule;
using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.ClienteModule
{
    public class MotoristaAppServices : EntidadeAppServices<Motorista>
    {
        public override IRepository<Motorista> Repositorio { get; }

        public MotoristaAppServices(IRepository<Motorista> repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
