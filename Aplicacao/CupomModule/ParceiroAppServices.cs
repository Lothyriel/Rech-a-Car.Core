using Aplicacao.Shared;
using Dominio.ParceiroModule;
using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.CupomModule
{
    public class ParceiroAppServices : EntidadeAppServices<Parceiro>
    {
        public override IEntidadeRepository<Parceiro> Repositorio { get; }

        public ParceiroAppServices(IEntidadeRepository<Parceiro> repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
