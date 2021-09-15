using Controladores.ParceiroModule;
using Controladores.Shared;
using Dominio.CupomModule;
using Dominio.ParceiroModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores.CupomModule
{
    public class ControladorCupom : ControladorEntidade<Cupom>
    {
        #region 
        private const string sqlInserirCupom =
       @"INSERT INTO TBCUPONS
	                (	
		                [NOME], 
		                [VALOR_PERCENTUAL], 
		                [VALOR_FIXO],
                        [DATA_VALIDADE],
                        [IDPARCEIRO],
                        [VALOR_MINIMO]
	                )
	                VALUES
	                (
                        @NOME, 
		                @VALOR_PERCENTUAL, 
		                @VALOR_FIXO,
                        @DATA_VALIDADE,
                        @IDPARCEIRO,
                        @VALOR_MINIMO
	                )";

        private const string sqlEditarCupom =
        @"UPDATE TBCUPONS
                    SET
                        [NOME] = @NOME, 
		                [VALOR_PERCENTUAL] = @VALOR_PERCENTUAL, 
		                [VALOR_FIXO] = @VALOR_FIXO,
                        [DATA_VALIDADE] = @DATA_VALIDADE,
                        [IDPARCEIRO] = @IDPARCEIRO,
                        [VALOR_MINIMO] = @VALOR_MINIMO
                     
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirCupom =
        @"DELETE 
	                FROM
                        TBCUPONS
                    WHERE 
                        ID = @ID";

        private const string sqlExisteCupom =
         @"SELECT 
                    COUNT(*) 
                FROM 
                    [TBCUPONS]
                WHERE 
                    [ID] = @ID";

        private const string sqlSelecionarTodosCupons =
        @"SELECT
                        [ID],
                        [NOME], 
		                [VALOR_PERCENTUAL], 
		                [VALOR_FIXO],
                        [DATA_VALIDADE],
                        [IDPARCEIRO],
                        [VALOR_MINIMO]

                        FROM TBCUPONS";

        private const string sqlSelecionarCupomPorId =
         @"SELECT
                        [ID],
                        [NOME], 
		                [VALOR_PERCENTUAL], 
		                [VALOR_FIXO],
                        [DATA_VALIDADE],
                        [IDPARCEIRO],
                        [VALOR_MINIMO]

	                FROM
                        TBCUPONS
                    WHERE 
                        ID = @ID";


        #endregion

        public override string sqlSelecionarPorId => sqlSelecionarCupomPorId;

        public override string sqlSelecionarTodos => sqlSelecionarTodosCupons;

        public override string sqlInserir => sqlInserirCupom;

        public override string sqlEditar => sqlEditarCupom;

        public override string sqlExcluir => sqlExcluirCupom;

        public override string sqlExists => sqlExisteCupom;

        public override Cupom ConverterEmEntidade(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            int valor_Percentual = Convert.ToInt32(reader["VALOR_PERCENTUAL"]);
            double valor_Fixo = Convert.ToDouble(reader["VALOR_FIXO"]);
            DateTime data = Convert.ToDateTime(reader["DATA_VALIDADE"]);
            int idParceiro = Convert.ToInt32(reader["IDPARCEIRO"]);
            double valorMinimo = Convert.ToDouble(reader["VALOR_MINIMO"]);

            var parceiro = new ControladorParceiro().GetById(idParceiro);

            return new Cupom(nome, valor_Percentual, valor_Fixo, data, parceiro, valorMinimo)
            {
                Id = id
            };
        }

        public override Dictionary<string, object> ObterParametrosRegistro(Cupom entidade)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", entidade.Id },
                { "NOME", entidade.Nome },
                { "VALOR_PERCENTUAL", entidade.ValorPercentual },
                { "VALOR_FIXO", entidade.ValorFixo },
                { "DATA_VALIDADE", entidade.DataValidade },
                { "IDPARCEIRO", entidade.Parceiro.Id },
                { "VALOR_MINIMO", entidade.ValorMinimo }
            };
            return parametros;
        }
    }
}
