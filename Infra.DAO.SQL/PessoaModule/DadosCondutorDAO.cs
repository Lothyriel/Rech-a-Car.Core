using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule.Condutor;
using Dominio.Repositories;
using Infra.DAO.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infra.DAO.PessoaModule
{
    public class DadosCondutorDAO : EntidadeDAO<DadosCondutor>, IDadosCondutorRepository
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
        public override string sqlSelecionarPorId => sqlSelecionarDadosCondutorPorIdCondutor;
        public override string sqlSelecionarTodos => throw new NotImplementedException();
        public override string sqlInserir => sqlInserirDadosCondutor;
        public override string sqlEditar => sqlEditarDadosCondutor;
        public override string sqlExcluir => sqlExcluirDadosCondutor;
        public override string sqlExists => throw new NotImplementedException();
        public DadosCondutor GetById(int id_condutor)
        {
            return Db.Get(sqlSelecionarDadosCondutorPorIdCondutor, ConverterEmEntidade, new Dictionary<string, object> { { "ID", id_condutor } });
        }
        public override Dictionary<string, object> ObterParametrosRegistro(DadosCondutor dadosCondutor)
        {
            var parametros = new Dictionary<string, object>
                    {
                    { "ID",dadosCondutor.Id },
                    { "NUMERO", dadosCondutor.Cnh.NumeroCnh },
                    { "TIPO", dadosCondutor.Cnh.TipoCnh }
                    };
            return parametros;
        }
        public override DadosCondutor ConverterEmEntidade(IDataReader reader)
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