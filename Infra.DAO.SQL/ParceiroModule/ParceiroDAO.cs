using Dominio.ParceiroModule;
using Infra.DAO.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infra.DAO.ParceiroModule
{
    public class ParceiroDAO : EntidadeDAO<Parceiro>
    {
        #region

        private const string sqlInserirParceiro =
        @"INSERT INTO TBPARCEIRO
	                (	
		                [PARCEIRO]
	                )
	                VALUES
	                (
                        @PARCEIRO
	                )";

        private const string sqlEditarParceiro =
        @"UPDATE TBPARCEIRO
                    SET
                        [PARCEIRO] = @PARCEIRO
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirParceiro =
         @"DELETE 
	                FROM
                        TBPARCEIRO
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarParceiroPorId =
         @"SELECT
                        [ID],
                        [PARCEIRO]
	                FROM
                        TBPARCEIRO
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarTodosParceiros =
        @"SELECT
                        [ID],
                        [PARCEIRO]

                        FROM TBPARCEIRO";


        private const string sqlExisteParceiros =
         @"SELECT 
                COUNT(*) 
            FROM 
                [TBPARCEIRO]
            WHERE 
                [ID] = @ID";

        #endregion
        public override string sqlSelecionarPorId => sqlSelecionarParceiroPorId;

        public override string sqlSelecionarTodos => sqlSelecionarTodosParceiros;

        public override string sqlInserir => sqlInserirParceiro;

        public override string sqlEditar => sqlEditarParceiro;

        public override string sqlExcluir => sqlExcluirParceiro;

        public override string sqlExists => sqlExisteParceiros;


        public override Parceiro ConverterEmEntidade(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string descricao = Convert.ToString(reader["PARCEIRO"]);

            return new Parceiro(descricao) { Id = id };
        }

        public override Dictionary<string, object> ObterParametrosRegistro(Parceiro parceiro)
        {
            return new Dictionary<string, object>
            {
                { "ID", parceiro.Id },
                { "PARCEIRO", parceiro.nome }
            };
        }
    }
}
