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
        public override IEntidadeRepository<Motorista> Repositorio { get; }

        public MotoristaAppServices(IEntidadeRepository<Motorista> repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
