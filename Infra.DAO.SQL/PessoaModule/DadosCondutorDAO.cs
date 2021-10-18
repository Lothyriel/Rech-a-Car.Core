using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule.Condutor;
using Infra.DAO.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infra.DAO.PessoaModule
{
    public class DadosCondutorDAO
    {
        #region Queries
        private const string sqlSelecionarDadosCondutorPorIdCondutor =
            @"SELECT *
                    FROM
                    [TBCNH]
                    WHERE 
                    [ID] = @ID";

        private const string sqlInserirDadosCondutor =
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

        private const string sqlEditarDadosCondutor =
            @" UPDATE [TBCNH]
                    SET     
                    [TIPO] = @TIPO,             
                    [NUMERO] = @NUMERO
                    WHERE [ID] = @ID";

        private const string sqlExcluirDadosCondutor =
                @"DELETE FROM [TBCNH]
                    WHERE [ID] = @ID";

        #endregion
        public void Inserir(DadosCondutor dadosCondutor)
        {
            dadosCondutor.Id = Db.Insert(sqlInserirDadosCondutor, ObterParametrosRegistro(dadosCondutor));
        }
        public void Editar(int id, DadosCondutor dadosCondutor)
        {
            dadosCondutor.Id = id;
            Db.Update(sqlEditarDadosCondutor, ObterParametrosRegistro(dadosCondutor));
        }
        public bool Excluir(int id) 
        {
            try
            {
                Db.Delete(sqlExcluirDadosCondutor, Db.AdicionarParametro("ID", id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DadosCondutor GetById(int id_condutor)
        {
            return Db.Get(sqlSelecionarDadosCondutorPorIdCondutor, ConverterEmEntidade, new Dictionary<string, object> { { "ID", id_condutor } });
        }
        public Dictionary<string, object> ObterParametrosRegistro(DadosCondutor dadosCondutor)
        {
            var parametros = new Dictionary<string, object>
                    {
                    { "ID",dadosCondutor.Id },
                    { "NUMERO", dadosCondutor.Cnh.NumeroCnh },
                    { "TIPO", dadosCondutor.Cnh.TipoCnh }
                    };
            return parametros;
        }
        public DadosCondutor ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var tipo = Convert.ToInt32(reader["TIPO"]);
            var numero = Convert.ToString(reader["NUMERO"]);

            return new DadosCondutor(new CNH(numero, (TipoCNH)tipo))
            {
                Id = id
            };
        }
    }
}