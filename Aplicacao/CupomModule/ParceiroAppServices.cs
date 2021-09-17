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
        public override IRepository<Parceiro> Repositorio { get; }

        public ParceiroAppServices(IRepository<Parceiro> repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
