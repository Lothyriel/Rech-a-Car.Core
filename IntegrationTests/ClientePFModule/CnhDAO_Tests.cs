using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule;
using Dominio.PessoaModule.Condutor;
using FluentAssertions;
using Infra.DAO.PessoaModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests.ClientePFModule
{
    [TestClass]
    public class CnhDAO_Tests
    {
        DadosCondutorDAO dd = new();

        [TestMethod]
        public void Deve_editar_cnh_cliente()
        {
            var dadosAnterior = new DadosCondutor(new CNH("1212120", TipoCNH.A));
            dd.Inserir(dadosAnterior);

            var cnhnova = new CNH("1212120", TipoCNH.C);
            dadosAnterior = new DadosCondutor(cnhnova);
            dd.Editar(dadosAnterior.Id, dadosAnterior);

            dd.GetById(dadosAnterior.Id).Cnh.TipoCnh.Should().Be(cnhnova.TipoCnh);
        }

        [TestMethod]
        public void Deve_Inserir_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            dd.Inserir(cnhAnterior);
        }

        [TestMethod]
        public void Deve_Excluir_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            dd.Excluir(cnhAnterior.Id);
        }
    }
}
