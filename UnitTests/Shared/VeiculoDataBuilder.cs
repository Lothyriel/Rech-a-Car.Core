using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class VeiculoDataBuilder
    {
        Veiculo veiculo = null;

        public VeiculoDataBuilder DeModelo(string modelo)
        {
            veiculo = new Veiculo();

            veiculo.Modelo = modelo;

            return this;
        }

        public VeiculoDataBuilder DaMarca(string marca)
        {
            veiculo.Marca = marca;

            return this;
        }

        public VeiculoDataBuilder DoAno(int ano)
        {
            veiculo.Ano = ano;

            return this;
        }

        public VeiculoDataBuilder DePlaca(string placa)
        {
            veiculo.Placa = placa;

            return this;
        }

        public VeiculoDataBuilder ComCapacidadeDe(int capacidade)
        {
            veiculo.Capacidade = capacidade;

            return this;
        }

        public VeiculoDataBuilder ComQuilometragem(int quilometragem)
        {
            veiculo.Quilometragem = quilometragem;

            return this;
        }

        public VeiculoDataBuilder ComPortas(int portas)
        {
            veiculo.Portas = portas;

            return this;
        }

        public VeiculoDataBuilder DeChassi(string chassi)
        {
            veiculo.Chassi = chassi;

            return this;
        }

        public VeiculoDataBuilder ComPortaMalas(int porta_malas)
        {
            veiculo.Porta_malas = porta_malas;

            return this;
        }

        public VeiculoDataBuilder ComCapacidadeDoTanque(int capacidadeTanque)
        {
            veiculo.CapacidadeTanque = capacidadeTanque;

            return this;
        }

        public VeiculoDataBuilder Foto(Image foto)
        {
            veiculo.Foto = foto;

            return this;
        }

        public VeiculoDataBuilder ComCambio(bool automatico)
        {
            veiculo.Automatico = automatico;

            return this;
        }

        public VeiculoDataBuilder DaCategoria(Categoria categoria)
        {
            veiculo.Categoria = categoria;

            return this;
        }

        public VeiculoDataBuilder ComTipoCombustivel(TipoCombustivel tipoCombustivel)
        {
            veiculo.TipoDeCombustivel = tipoCombustivel;

            return this;
        }

        public Veiculo Build()
        {
            return veiculo;
        }
    }
}
