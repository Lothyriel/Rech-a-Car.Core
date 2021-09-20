using Dominio.Entities.PessoaModule;
using Infra.DAO.Shared;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;

namespace Infra.DAO.PessoaModule
{
    public static class SenhaDAO
    {
        private const string sqlInsereSenha =
            @"INSERT INTO [TBSenha]
             (   
                [HASH_SENHA],            
                [SALT],
                [ID_FUNCIONARIO]
             )
          VALUES
             (            
                @HASH_SENHA,            
                @SALT,
                @ID_FUNCIONARIO
             )";

        private const string sqlEditarSenha =
            @" UPDATE [TBSENHA]
                SET 
                    [HASH_SENHA] = @HASH_SENHA,       
                    [SALT] = @SALT          
                WHERE [ID_FUNCIONARIO] = @ID_FUNCIONARIO";

        private const string sqlRecuperarSenha =
            @"SELECT 
                *
            FROM 
                [TBSENHA]
            WHERE 
                [ID_FUNCIONARIO] = @ID_FUNCIONARIO";

        public static Senha GetDadosSenha(int id_funcionario)
        {
            return Db.Get(sqlRecuperarSenha, ConverterEmSenha, new Dictionary<string, object>() { { "ID_FUNCIONARIO", id_funcionario } });
        }
        public static bool SenhaCorreta(int id_funcionario, string senha)
        {
            var dadosSenha = GetDadosSenha(id_funcionario);
            var hash = GerarHash(senha, dadosSenha.Salt);

            return hash == dadosSenha.Hash;
        }
        public static void Inserir(int id_funcionario, string senha)
        {
            var salt = GerarSalt();
            var hash = GerarHash(senha, salt);
            Db.Insert(sqlInsereSenha, new Dictionary<string, object>() { { "HASH_SENHA", hash }, { "SALT", salt }, { "ID_FUNCIONARIO", id_funcionario } });
        }
        public static void Editar(int id_funcionario, string senha)
        {
            var salt = GerarSalt();
            var hash = GerarHash(senha, salt);
            Db.Update(sqlEditarSenha, new Dictionary<string, object>() { { "HASH_SENHA", hash }, { "SALT", salt }, { "ID_FUNCIONARIO", id_funcionario } });
        }
        public static Senha ConverterEmSenha(IDataReader reader)
        {
            var salt = (byte[])reader["SALT"];
            var hash = Convert.ToString(reader["HASH_SENHA"]);

            return new Senha(salt, hash);
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

    }
}
