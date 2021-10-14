using Dominio.Shared;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace Dominio.Entities.PessoaModule
{
    public class SenhaHashed : Entidade
    {
        public SenhaHashed(byte[] salt, string hash)
        {
            Salt = salt;
            Hash = hash;
        }
        public byte[] Salt { get; }
        public string Hash { get; }

        public override string Validar()
        {
            return "";
        }

        private static byte[] GerarSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }

            return salt;
        }
        private static string GerarHash(string senha, byte[] salt)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                        password: senha,
                                        salt: salt,
                                        prf: KeyDerivationPrf.HMACSHA256,
                                        iterationCount: 100000,
                                        numBytesRequested: 256 / 8));
        }
        public static bool SenhaCorreta(string senha, SenhaHashed hashed) 
        {
            return GerarHash(senha, hashed.Salt) == hashed.Hash;
        }
        public static SenhaHashed GerarNovaSenhaHashed(string senha) 
        {
            var salt = GerarSalt();
            var hashed = GerarHash(senha, salt);
            return new SenhaHashed(salt, hashed);
        }
    }
}
