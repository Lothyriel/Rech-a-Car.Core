using Dominio.PessoaModule;
using FluentAssertions;
using Infra.DAO.PessoaModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            var cnhnova = new CNH("1212120", TipoCNH.C);
            CnhDAO.Editar(cnhAnterior.Id, cnhnova);

            CnhDAO.GetByIdCondutor(cnhAnterior.Id).TipoCnh.Should().Be(cnhnova.TipoCnh);
        }

        [TestMethod]
        public void Deve_Inserir_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            CnhDAO.Inserir(cnhAnterior);
        }

        [TestMethod]
        public void Deve_Excluir_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            CnhDAO.Excluir()
        }
    }
}
