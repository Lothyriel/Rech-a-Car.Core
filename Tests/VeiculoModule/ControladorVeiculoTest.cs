using Controladores.Shared;
using Controladores.VeiculoModule;
using Dominio.PessoaModule;
using Dominio.VeiculoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Tests.Shared;

namespace Tests.VeiculoModule
{
    [TestClass]
    public class ControladorVeiculoTest
    {
        Veiculo veiculo1;
        ControladorVeiculo controladorVeiculo = new ControladorVeiculo();

        [TestInitialize]
        public void Inserir_Veiculo()
        {
            Image imagem = Image.FromFile(@"..\..\Resources\ford_ka_gay.jpg");
            Categoria categoria = new Categoria("Economico", 100, 10, 400, 800, TipoCNH.B);
            veiculo1 = new Veiculo("Ka", "Ford", 2001, "ABC1024", 50000, 4, 4, "ASDFGHJKLQWERTYUI", 0, 50,imagem, false, categoria, TipoCombustivel.Gasolina);
            new ControladorCategoria().Inserir(categoria);
            controladorVeiculo.Inserir(veiculo1);
        }

        [TestMethod]
        public void Deve_inserir_veiculo()
        {
            veiculo1.Id.Should().NotBe(0);
        }

        [TestMethod]
        public void Deve_editar_marca_veiculo()
        {
            string marcaOriginal = veiculo1.Marca;

            veiculo1.Marca = "Marca diferente";
            controladorVeiculo.Editar(veiculo1.Id, veiculo1);

            controladorVeiculo.GetById(veiculo1.Id).Marca.Should().NotBe(marcaOriginal);
        }

        [TestMethod]
        public void Deve_editar_ano_veiculo()
        {
            int anoOriginal = veiculo1.Ano;

            veiculo1.Ano = 2017;

            controladorVeiculo.Editar(veiculo1.Id, veiculo1);

            controladorVeiculo.GetById(veiculo1.Id).Ano.Should().NotBe(anoOriginal);
        }

        [TestMethod]
        public void Deve_remover_veiculo()
        {
            controladorVeiculo.Excluir(veiculo1.Id);
            controladorVeiculo.Exists(veiculo1.Id).Should().BeFalse();
        }

        [TestMethod]
        public void Deve_retornar_todos_os_veiculos()
        {
            controladorVeiculo.Registros.Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBVeiculo"));
        }
    }
}
