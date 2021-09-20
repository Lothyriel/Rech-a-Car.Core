using Dominio.Entities.PessoaModule;
using Dominio.Repositories;
using Infra.DAO.Shared;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;

namespace Infra.DAO.PessoaModule
{
    public class SenhaDAO : ISenhaRepository
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

        public Senha GetDadosSenha(int id_funcionario)
        {
            return Db.Get(sqlRecuperarSenha, ConverterEmSenha, new Dictionary<string, object>() { { "ID_FUNCIONARIO", id_funcionario } });
        }
        public bool SenhaCorreta(int id_funcionario, string senha)
        {
            var dadosSenha = GetDadosSenha(id_funcionario);
            var hash = ISenhaRepository.GerarHash(senha, dadosSenha.Salt);

            return hash == dadosSenha.Hash;
        }
        public void Inserir(int id_funcionario, string senha)
        {
            var salt = ISenhaRepository.GerarSalt();
            var hash = ISenhaRepository.GerarHash(senha, salt);
            Db.Insert(sqlInsereSenha, new Dictionary<string, object>() { { "HASH_SENHA", hash }, { "SALT", salt }, { "ID_FUNCIONARIO", id_funcionario } });
        }
        public void Editar(int id_funcionario, string senha)
        {
            var salt = ISenhaRepository.GerarSalt();
            var hash = ISenhaRepository.GerarHash(senha, salt);
            Db.Update(sqlEditarSenha, new Dictionary<string, object>() { { "HASH_SENHA", hash }, { "SALT", salt }, { "ID_FUNCIONARIO", id_funcionario } });
        }
        public Senha ConverterEmSenha(IDataReader reader)
        {
            var salt = (byte[])reader["SALT"];
            var hash = Convert.ToString(reader["HASH_SENHA"]);

            return new Senha(salt, hash);
        }

    }
}
