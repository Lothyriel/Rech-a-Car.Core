using Dominio.AluguelModule;
using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DAO.ORM.Repositories
{
    class RelatorioORM : BaseRepository<RelatorioAluguel>, IRelatorioRepository
    {
        public RelatorioAluguel GetProxEnvio()
        {
                if (Context.Set<RelatorioAluguel>().Where(x => x.DataEnvio == null).Count() != 0)
                    return Context.Set<RelatorioAluguel>().Where(x => x.DataEnvio == null).FirstOrDefault();
                else
                    return null;
        }

        public void MarcarEnviado(int id)
        {
            var relatorioEnviado = GetById(id);
            relatorioEnviado.DataEnvio = DateTime.Now;

            Context.Set<RelatorioAluguel>().Update(relatorioEnviado);
            Context.SaveChanges();
        }

        public void SalvarRelatorio(RelatorioAluguel envio)
        {
            Context.Set<RelatorioAluguel>().Add(envio);
            Context.SaveChanges();
        }
    }
}
