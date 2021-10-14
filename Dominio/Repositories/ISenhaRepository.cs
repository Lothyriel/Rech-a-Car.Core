using Dominio.Entities.PessoaModule;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace Dominio.Repositories
{
    public interface ISenhaRepository
    {
        SenhaHashed GetSenhaHashed(int id_funcionario);
        bool SenhaCorreta(int id_funcionario, string senha);
        void Inserir(int id_funcionario, string senha);
        void Editar(int id_funcionario, string senha);
    }
}
