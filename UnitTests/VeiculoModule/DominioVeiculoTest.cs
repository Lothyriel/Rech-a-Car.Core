using Dominio.PessoaModule;
using Dominio.VeiculoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using UnitTests.Properties;

namespace Tests.VeiculoModule
{
    [TestClass]
    public class DominioVeiculoTest
    {
        Image imagem = Resources.focus_gay;
        Categoria categoria = new Categoria("Economico", 100, 10, 400, 800, TipoCNH.B);

        [TestMethod]
        public void Deve_retornar_tds_portamalas()
        {
            var veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 50000, 4, 4, "ASDFGHJKLQWERTYUI", 0, 50, imagem, true, categoria, TipoCombustivel.Gasolina);
            var veiculo2 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 50000, 4, 4, "ASDFGHJKLQWERTYUI", 1, 50, imagem, true, categoria, TipoCombustivel.Gasolina);
            var veiculo3 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 50000, 4, 4, "ASDFGHJKLQWERTYUI", 2, 50, imagem, true, categoria, TipoCombustivel.Gasolina);

            veiculo1.PortaMalaToString().Should().Be("Pequeno");
            veiculo2.PortaMalaToString().Should().Be("Médio");
            veiculo3.PortaMalaToString().Should().Be("Grande");
        }

        [TestMethod]
        public void Deve_retornar_tipos_de_cambio()
        {
            var veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 50000, 4, 4, "ASDFGHJKLQWERTYUI", 0, 50, imagem, false, categoria, TipoCombustivel.Gasolina);
            var veiculo2 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 50000, 4, 4, "ASDFGHJKLQWERTYUI", 1, 50, imagem, true, categoria, TipoCombustivel.Gasolina);

            veiculo1.CambioToString().Should().Be("Manual");
            veiculo2.CambioToString().Should().Be("Automático");
        }

        [TestMethod]
        public void Deve_retornar_carro_valido()
        {
            var veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 50000, 4, 4, "ASDFGHJKLQWERTYUI", 0, 50, imagem, true, categoria, TipoCombustivel.Gasolina);
            veiculo1.Validar().Should().Be(string.Empty);
        }

        [TestMethod]
        public void Deve_retornar_carro_invalido()
        {
            var veiculo1 = new Veiculo(string.Empty, string.Empty, DateTime.Now.Year + 2, "PLACA", -1, 0, 0, "CHASSI", -1, 0, null, true, null, TipoCombustivel.Etanol);
            veiculo1.Validar().Should().NotBe(string.Empty);
        }
    }
}
