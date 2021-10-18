using Dominio.AluguelModule;
using System;
using System.Linq;

namespace Infra.DAO.ORM.Repositories
{
    public class RelatorioORM : BaseORM<RelatorioAluguel>, IRelatorioRepository
    {
        public RelatorioORM(Rech_a_carDbContext context) : base(context)
        {
        }

        public RelatorioAluguel GetProxEnvio()
        {
            if (Context.Set<RelatorioAluguel>().Where(x => x.DataEnvio == null).Any())
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
