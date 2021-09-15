using Controladores.Shared;
using Dominio.ParceiroModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.ParceiroModule
{
    public class ControladorParceiro : ControladorEntidade<Parceiro>
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


            Parceiro parceiros = new Parceiro(descricao);

            parceiros.Id = id;

            return parceiros;
        }

        public override Dictionary<string, object> ObterParametrosRegistro(Parceiro parceiro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", parceiro.Id);
            parametros.Add("PARCEIRO", parceiro.nome);
            ;

            return parametros;
        }
    }
}
