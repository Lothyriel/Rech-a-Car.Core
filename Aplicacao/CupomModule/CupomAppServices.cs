using Aplicacao.Shared;
using Dominio.CupomModule;
using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.CupomModule
{
    public class CupomAppServices : EntidadeAppServices<Cupom>
    {
        public override IEntidadeRepository<Cupom> Repositorio { get; }

        public CupomAppServices(IEntidadeRepository<Cupom> repositorio)
        {
            Repositorio = repositorio;
        }
    }
}

