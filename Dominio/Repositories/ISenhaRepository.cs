using Dominio.Entities.PessoaModule;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace Dominio.Repositories
{
    public interface ISenhaRepository
    {
        Senha GetDadosSenha(int id_funcionario);
        bool SenhaCorreta(int id_funcionario, string senha);
        void Inserir(int id_funcionario, string senha);
        void Editar(int id_funcionario, string senha);

        static byte[] GerarSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }

            return salt;
        }
        static string GerarHash(string senha, byte[] salt)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                        password: senha,
                                        salt: salt,
                                        prf: KeyDerivationPrf.HMACSHA256,
                                        iterationCount: 100000,
                                        numBytesRequested: 256 / 8));
        }
    }
}
