using Dominio.PessoaModule;
using Dominio.Repositories;
using Infra.DAO.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infra.DAO.PessoaModule
{
    public class CnhDAO : ICnhRepository
    {
        #region Queries
        private const string sqlSelecionarCnhPorIdCondutor =
            @"SELECT *
                    FROM
                    [TBCNH]
                    WHERE 
                    [ID] = @ID";

        private const string sqlInserirCnh =
            @"INSERT INTO [TBCNH]
                    (
                    [TIPO],
                    [NUMERO]
                    )
                    VALUES
                    (
                    @TIPO,
                    @NUMERO
                    )";

        private const string sqlEditarCnh =
            @" UPDATE [TBCNH]
                    SET     
                    [TIPO] = @TIPO,             
                    [NUMERO] = @NUMERO
                    WHERE [ID] = @ID";

        private const string sqlExcluirCnh =
            @" DELETE FROM [TBCNH]
                            WHERE [ID] = @ID";

        #endregion
        public void Inserir(CNH cnh)
        {
            cnh.Id = Db.Insert(sqlInserirCnh, ObterParametrosRegistro(cnh));
        }
        public void Editar(int id, CNH cnh)
        {
            cnh.Id = id;
            Db.Update(sqlEditarCnh, ObterParametrosRegistro(cnh));
        }
        public CNH GetById(int idCnh)
        {
            return Db.Get(sqlSelecionarCnhPorIdCondutor, ConverterEmEntidade, new Dictionary<string, object> { { "ID", idCnh } });
        }
        public void Excluir(int idCnh)
        {
            Db.Delete(sqlExcluirCnh, new Dictionary<string, object> { { "ID", idCnh } });
        }
        public Dictionary<string, object> ObterParametrosRegistro(CNH cnh)
        {
            var parametros = new Dictionary<string, object>
                    {
                    { "ID",cnh.Id },
                    { "NUMERO", cnh.NumeroCnh },
                    { "TIPO", cnh.TipoCnh }
                    };
            return parametros;
        }
        public CNH ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var tipo = Convert.ToInt32(reader["TIPO"]);
            var numero = Convert.ToString(reader["NUMERO"]);

            return new CNH(numero, (TipoCNH)tipo)
            {
                Id = id
            };
        }


    }
}
