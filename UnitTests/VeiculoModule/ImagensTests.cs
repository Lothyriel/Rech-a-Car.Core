using Dominio.PessoaModule;
using Dominio.PessoaModule.Condutor;
using Dominio.VeiculoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using UnitTests.Properties;

namespace UnitTests.ImagensModule
{
    [TestClass]
    public class ImagensTests
    {
        Categoria categoria = new Categoria("Economico", 100, 10, 400, 800, TipoCNH.B);

        [TestMethod]
        public void Deve_retornar_carro_valido_Imagem_JPG()
        {
            var imagemJPG = Resources.ford_ka_gay;
            var veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 50000, 4, 4, "ASDFGHJKLQWERTYUI", 0, 50, imagemJPG, true, categoria, TipoCombustivel.Gasolina);
            veiculo1.Validar().Should().Be(string.Empty);
        }

        [TestMethod]
        public void Deve_retornar_carro_valido_Imagem_GIF()
        {
            Image imagemgif = Resources.homer;
            var veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 50000, 4, 4, "ASDFGHJKLQWERTYUI", 0, 50, imagemgif, true, categoria, TipoCombustivel.Gasolina);
            veiculo1.Validar().Should().Be(string.Empty);
        }

        [TestMethod]
        public void Deve_retornar_carro_valido_Imagem_PNG()
        {
            Image imagemPNG = Resources.among;
            var veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 50000, 4, 4, "ASDFGHJKLQWERTYUI", 0, 50, imagemPNG, true, categoria, TipoCombustivel.Gasolina);
            veiculo1.Validar().Should().Be(string.Empty);
        }
    }
}
