using Dominio.PessoaModule;
using FluentAssertions;
using Infra.DAO.ORM.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests.ClientePFModule
{
    [TestClass]
    public class CnhORM_Test
    {
        CnhORM CnhORM = new();

        [TestMethod]
        public void Deve_editar_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            CnhORM.Inserir(cnhAnterior);
            var cnhnova = new CNH("1212120", TipoCNH.C);
            CnhORM.Editar(cnhAnterior.Id, cnhnova);

            CnhORM.GetById(cnhAnterior.Id).TipoCnh.Should().Be(cnhnova.TipoCnh);
        }

        [TestMethod]
        public void Deve_Inserir_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            CnhORM.Inserir(cnhAnterior);
        }

        [TestMethod]
        public void Deve_Excluir_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            CnhORM.Excluir(cnhAnterior.Id);
        }
    }
}
