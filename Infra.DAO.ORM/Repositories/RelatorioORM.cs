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
                if (Set<EnvioEmail>().Where(x => x.DataEnvio == null).Count() != 0)
                    return Db.Get(sqlGetProxEnvio, ConverterEmEntidade);
                else
                    return null;
        }

        public void MarcarEnviado(int id)
        {
            throw new NotImplementedException();
        }

        public void SalvarRelatorio(RelatorioAluguel envio)
        {
            throw new NotImplementedException();
        }
    }
}
