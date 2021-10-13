using Dominio.CupomModule;
using Dominio.ParceiroModule;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests.CupomModule
{
    [TestClass]
    public class CupomORMTest
    {
        CupomORM cupomORM = new();
        [TestCleanup]
        public void Limpar()
        {
            Db.Delete(TestExtensions.ResetId("TBCupons"));
        }
        [TestMethod]
        public void Deve_Inserir_Novo_Cupom()
        {

        }
    }
}
