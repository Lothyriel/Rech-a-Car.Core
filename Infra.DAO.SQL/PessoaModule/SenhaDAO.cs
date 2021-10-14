using Dominio.Entities.PessoaModule;
using Dominio.Repositories;
using Infra.DAO.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infra.DAO.PessoaModule
{
    public class SenhaDAO : ISenhaRepository
    {
        #region Queries

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

        #endregion
        public SenhaHashed GetSenhaHashed(int id_funcionario)
        {
            return Db.Get(sqlRecuperarSenha, ConverterEmSenha, new Dictionary<string, object>() { { "ID_FUNCIONARIO", id_funcionario } });
        }
        public bool SenhaCorreta(int id_funcionario, string senha)
        {
            var hashed = GetSenhaHashed(id_funcionario);

            return SenhaHashed.SenhaCorreta(senha, hashed);
        }
        public void Inserir(int id_funcionario, string senha)
        {
            var hashed = SenhaHashed.GerarNovaSenhaHashed(senha);

            Db.Insert(sqlInsereSenha, new Dictionary<string, object>() { { "HASH_SENHA", hashed.Hash }, { "SALT", hashed.Salt }, { "ID_FUNCIONARIO", id_funcionario } });
        }
        public void Editar(int id_funcionario, string senha)
        {
            var hashed = SenhaHashed.GerarNovaSenhaHashed(senha);
            Db.Update(sqlEditarSenha, new Dictionary<string, object>() { { "HASH_SENHA", hashed.Hash }, { "SALT", hashed.Salt }, { "ID_FUNCIONARIO", id_funcionario } });
        }
        public SenhaHashed ConverterEmSenha(IDataReader reader)
        {
            var salt = (byte[])reader["SALT"];
            var hash = Convert.ToString(reader["HASH_SENHA"]);

            return new SenhaHashed(salt, hash);
        }
    }
}
