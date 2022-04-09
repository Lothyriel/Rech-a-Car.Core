﻿using Dominio.Shared;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Drawing;

namespace Dominio.VeiculoModule
{
    public class Veiculo : Entidade
    {
        public Veiculo(string modelo, string marca, int ano, string placa, int quilometragem, int capacidade, int portas, string chassi, int porta_malas, int capacidadeTanque, Image foto, bool automatico, Categoria categoria, TipoCombustivel tipoCombustivel)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            Placa = placa.ToUpper();
            Capacidade = capacidade;
            Portas = portas;
            Chassi = chassi;
            PortaMalas = porta_malas;
            Foto = foto;
            Automatico = automatico;
            Categoria = categoria;
            TipoDeCombustivel = tipoCombustivel;
            Quilometragem = quilometragem;
            CapacidadeTanque = capacidadeTanque;
        }

        public Veiculo()
        {
        }

        public string Modelo { get; set; }
        public string Marca { get; set; }
        public virtual Categoria Categoria { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public int Capacidade { get; set; }
        public int CapacidadeTanque { get; set; }
        public int Portas { get; set; }
        public int PortaMalas { get; set; }
        public int Ano { get; set; }
        public Image Foto { get; set; }
        public TipoCombustivel TipoDeCombustivel { get; set; }
        public bool Automatico { get; set; }
        public int Quilometragem { get; set; }

        public string PortaMalaToString()
        {
            if (PortaMalas == 0)
                return "Pequeno";
            if (PortaMalas == 1)
                return "Médio";
            else
                return "Grande";
        }
        public string CambioToString()
        {
            return Automatico ? "Automático" : "Manual";
        }
        public override ValidationResult Validar => new VeiculoValidator().Validate(this);
        public override string ToString()
        {
            return $"{Marca} {Modelo} {Ano} {Categoria}";
        }
    }

    public class VeiculoValidator : AbstractValidator<Veiculo>
    {
        public VeiculoValidator()
        {
            throw new NotImplementedException();

            //Regex templatePlacaMercoSul = new Regex(@"\b[A-Z]{3}[0-9][A-Z][0-9]{2}\b", RegexOptions.IgnoreCase);
            //Regex templatePlacaAntiga = new Regex(@"\b[A-Z]{3}[0-9]{4}\b", RegexOptions.IgnoreCase);

            //string validacao = "";

            //if (String.IsNullOrEmpty(Modelo))
            //    validacao += "Modelo do veículo é obrigatório\n";

            //if (String.IsNullOrEmpty(Marca))
            //    validacao += "Marca do veículo é obrigatória\n";

            //if (!templatePlacaAntiga.IsMatch(Placa) && !templatePlacaMercoSul.IsMatch(Placa))
            //    validacao += "Placa do veículo inválida\n";

            //if (Chassi.Length != 17)
            //    validacao += "Chassi do veículo inválido\n";

            //if (Capacidade < 0)
            //    validacao += "Selecione a capacidade\n";

            //if (Portas < 1)
            //    validacao += "Deve ter pelo menos duas Portas\n";

            //if (Porta_malas < 0)
            //    validacao += "Volume do Porta-malas inválido\n";

            //if (Ano > DateTime.Now.Year + 1)
            //    validacao += "Ano do carro inválido\n";

            //if (CapacidadeTanque < 0)
            //    validacao += "Capacidade do tanque tem que ser maior que 0\n";
        }
    }
    public enum TipoCombustivel { Diesel, Etanol, Gasolina }
}
