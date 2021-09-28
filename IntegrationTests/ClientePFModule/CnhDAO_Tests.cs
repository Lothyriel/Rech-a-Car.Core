using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using FluentAssertions;
using Infra.DAO.PessoaModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests.ClientePFModule
{
    [TestClass]
    public class CnhDAO_Tests
    {
        CnhDAO CnhDAO = new();

        [TestMethod]
        public void Deve_editar_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            CnhDAO.Inserir(cnhAnterior);
            var cnhnova = new CNH("36510896881", TipoCNH.C);
            CnhDAO.Editar(cnhAnterior.Id, cnhnova);

            ((int)CnhDAO.GetByIdCondutor(cnhAnterior.Id).TipoCnh).Should().NotBe(((int)cnhnova.TipoCnh));
        }
    }
}
