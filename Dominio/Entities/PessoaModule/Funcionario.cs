﻿using System.Drawing;

namespace Dominio.PessoaModule
{
    public class Funcionario : Pessoa, IUser
    {
        public Funcionario(string nome, string telefone, string endereco, string documento, Cargo cargo, Image foto, string usuario, string senha = null) : base(nome, telefone, endereco, documento)
        {
            Cargo = cargo;
            Foto = foto;
            Usuario = usuario;
            Senha = senha;
        }
        public Funcionario()
        {

        }
        public Image Foto { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public Cargo Cargo { get; set; }
        public override ETipoPessoa ETipoPessoa { get; init; } = ETipoPessoa.CPF;

        public override string Validar()
        {
            var validacao = base.Validar();

            if (Usuario.Length < 5)
                validacao += "Nome de usuário inválido\n";
            if (Senha?.Length < 8)
                validacao += "Senha precisa ter no mínimo 8 caracteres";

            return validacao;
        }
    }
    public enum Cargo { SysAdmin, Vendedor }
}
